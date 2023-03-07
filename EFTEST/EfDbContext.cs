using EFTEST.DATA_ANNOTATION._1_Many;
using EFTEST.DATA_ANNOTATION.Many_Many;
using EFTEST.FluentApi._1_1;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Windows.Forms;
using EFTEST.FluentApi._1_Many;
using System.Diagnostics;
using EFTEST.FluentApi.Many_Many;

namespace EFTEST
{
    internal class EfDbContext:DbContext
    {
        public EfDbContext():base("conn")
        {

        }
        public DbSet<TcKimlik> Tbl_TcKimlik { get; set; }
        public DbSet<Kisi> Tbl_Kisi { get; set; }
        public DbSet<Ayakkabi> Tbl_Ayakkabi { get; set; }
        public DbSet<Insan> Insan { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<StudentAdress> StudentAdress { get; set; }
        public DbSet<Ogrenci> Ogrenci { get; set; }
        public DbSet<Notu> Notu { get; set; }
        public DbSet<Cocuk> Cocuk { get; set; }
        public DbSet<Sinifi> Sinifi { get; set; }

        //override onmodelcreating
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //            One or more validation errors were detected during model generation:

            //EFTEST.StudentAdress: : EntityType 'StudentAdress' has no key defined. Define the key for this EntityType.
            //StudentAdress: EntityType: EntitySet 'StudentAdress' is based on type 'StudentAdress' that has no keys defined.

            modelBuilder.Entity<Student>()
                .HasOptional(s => s.Address) // Mark Address property optional in Student entity
                .WithRequired(ad => ad.Student); // mark Student property as required in StudentAddress entity. Cannot save StudentAddress without Student
            modelBuilder.Entity<StudentAdress>().HasKey(s => s.StudentAddressId);
            // configures one-to-many relationship
            modelBuilder.Entity<Ogrenci>()
                .HasRequired<Notu>(s => s.Notu)//navigation
                .WithMany(n=>n.Ogrenci)//navigation
                .HasForeignKey<int>(s => s.OgrenciNotuId);//sütun


            modelBuilder.Entity<Cocuk>()
                .HasMany<Sinifi>(c=>c.Sinifi)//navigation
                .WithMany(s=>s.Cocuk)//navigation
                .Map(cs =>
                {
                    cs.MapLeftKey("StudentRefId");//ilk tablonun ara tablo pksi
                    cs.MapRightKey("CourseRefId");//ikinci tablonun ara tablo pksi
                    cs.ToTable("CocugunSinifi");//AraTabloAdi
                });
            base.OnModelCreating(modelBuilder);


        }
    }
}
