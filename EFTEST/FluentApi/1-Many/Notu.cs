using EFTEST.FluentApi._1_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTEST.FluentApi._1_Many
{
    internal class Notu
    {
        public int NotuId { get; set; }
        public string NotuName { get; set; }
        public string Section { get; set; }
        public ICollection<Ogrenci> Ogrenci { get; set; }

    }
}
