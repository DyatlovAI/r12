using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace r12
{
        public class User
    {
        
        public string Name { get; set; }
        public string email { get; set; }
        public string number { get; set; }
    }
    public class Tovari
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Klient { get; set; }
        public string Tovar { get; set; }
        public string kolichestvo { get; set; }
    }
}
