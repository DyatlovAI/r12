using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace r12
{
        public class Tovari
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Klient { get; set; }
        public string Tovar { get; set; }
        public string kolichestvo { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
