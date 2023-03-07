using EFTEST.FluentApi._1_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTEST.FluentApi.Many_Many
{
    internal class Sinifi
    {
        public int SinifiId { get; set; }
        public string SinifiName { get; set; }

        public virtual ICollection<Cocuk> Cocuk { get; set; }
    }
}
