using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTEST.FluentApi._1_Many
{
    internal class Ogrenci
    {
        public int OgrenciId { get; set; }
        public string OgrenciName { get; set; }

        //Bu ikisi olmazsa fluentApi olmuyor Data annot. daha kolay
        public int OgrenciNotuId { get; set; }
        public Notu Notu { get; set; }


    }
}
