using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTEST.DATA_ANNOTATION.Many_Many
{
    internal class Product
    {
        [Key]
        public int ProductId { get; set; }
        public int ProductAdı { get; set; }
        public List<Category> Category { get; set; }
    }
}
