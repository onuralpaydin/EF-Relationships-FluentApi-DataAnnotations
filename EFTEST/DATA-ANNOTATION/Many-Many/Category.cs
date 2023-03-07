using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTEST.DATA_ANNOTATION.Many_Many
{
    internal class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public int CategoryAdi { get; set; }
        public List<Product> Product { get; set; }
    }
}
