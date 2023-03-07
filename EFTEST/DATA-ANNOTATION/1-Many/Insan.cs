using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTEST.DATA_ANNOTATION._1_Many
{
    [Table("tbl_Insan")]
    internal class Insan
    {
        [Key]
        public int InsanId { get; set; }
        public string InsanAdi { get; set; }

        [ForeignKey("Ayakkabi")]
        public int AyakkabiBaglantiId { get; set; }

        public List<Ayakkabi> Ayakkabi { get; set; }
        //böyle yazmazsan hata veriyor
        //The ForeignKeyAttribute on property 'AyakkabiBaglantiId' on type 'EFTEST.DATA_ANNOTATION._1_Many.Insan' is not valid.The navigation property 'Ayakkabi' was not found on the dependent type 'EFTEST.DATA_ANNOTATION._1_Many.Insan'. The Name value should be a valid navigation property name.

    }
}
