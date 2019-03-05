using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Concrete
    {
        public int Id { get; set; }

        public string Mark { get; set; }

        public virtual Producer Producer { get; set; }
    }
}
