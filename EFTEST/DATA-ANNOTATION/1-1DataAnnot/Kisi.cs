using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTEST
{
    public class Kisi
    {
        public int KisiId { get; set; }
        public string KisiAdi { get; set; }

        public virtual TcKimlik TcKimlik { get; set; }
        //entity ile aynı ismi vermezsen hata veriyor.
        //The ForeignKeyAttribute on property 'TcKimlikId' on type 'EFTEST.TcKimlik' is not valid.The navigation property 'Kisi' was not found on the dependent type 'EFTEST.TcKimlik'. The Name value should be a valid navigation property name.

        


    }
}
