using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace r12
{
        public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string email { get; set; }
        public string number { get; set; }
        public string password { get; set; }
        public List<Tovari> Tovaris { get; set; }
        public User()
        {
            Tovaris = new List<Tovari>();
        }
    }
   
}
