using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADDRESS_DAL.Models
{
    internal class SocialNetwork
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }

        public SocialNetwork(int id, string name, string link) {
            Id= id;
            Name= name;
            Link= link;
        }
    }
}
