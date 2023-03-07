using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace EFTEST.FluentApi._1_1
{
    internal class StudentAdress
    {
        //[Key] bunu yazmazsan onmodel creating doldursan bile patlıyor.
//        One or more validation errors were detected during model generation:

//EFTEST.StudentAdress: : EntityType 'StudentAdress' has no key defined.Define the key for this EntityType.
//StudentAdress: EntityType: EntitySet 'StudentAdress' is based on type 'StudentAdress' that has no keys defined.
        public int StudentAddressId { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int Zipcode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public virtual Student Student { get; set; }
    }
}
