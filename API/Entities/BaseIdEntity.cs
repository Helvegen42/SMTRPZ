using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class BaseIdEntity<T>
    {
        public T Id { get; set; }
    }
}
