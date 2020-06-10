using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.RequestModels
{
    public class AddBooksRequest
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string TypeOfCover { get; set; }
        public string Annotation { get; set; }
        public string Theme { get; set; }
        public string Price { get; set; }
    }
}
