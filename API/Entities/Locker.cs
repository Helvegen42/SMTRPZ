using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Locker : BaseIdEntity<int>
    {
        public Locker() => Bookses = new List<Books>();
      
        public int Capacity { get; set; }
        public string  Theme { get; set; }
        public virtual ICollection<Books> Bookses { get; set; }
    }
}
