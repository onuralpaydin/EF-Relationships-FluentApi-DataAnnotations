using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTEST.FluentApi._1_1
{
    internal class Student
    {

        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public virtual StudentAdress Address { get; set; }
    }
}
