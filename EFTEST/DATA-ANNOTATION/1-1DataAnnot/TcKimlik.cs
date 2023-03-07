using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTEST
{
    public class TcKimlik
    {
        //Bunu böyle yapmazsak tabloları dolduramıyoruz kısır döngü.
        [Key,ForeignKey("Kisi")]
        public int TcKimlikId { get; set; }
        public string TcKimlikNo { get; set; }

        public virtual Kisi Kisi { get; set; }
    }
}
