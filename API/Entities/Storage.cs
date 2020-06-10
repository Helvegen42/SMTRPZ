using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Storage : BaseIdEntity<int>
    {
        public Storage()
        {
            ContainRooms = new List<Locker>();
        }
        public virtual ICollection<Locker> ContainRooms { get; set; }
    }
}
