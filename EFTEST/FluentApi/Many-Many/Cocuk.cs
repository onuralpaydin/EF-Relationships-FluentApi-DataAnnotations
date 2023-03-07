using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTEST.FluentApi.Many_Many
{
    internal class Cocuk
    {
        public int CocukId { get; set; }
        
        public string CocukName { get; set; }

        public virtual ICollection<Sinifi> Sinifi { get; set; }
    }
}
