using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADDRESS_DAL.Models
{
    internal class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? PhoneNumber { get; set; }

        public List<SocialNetwork>? SocialNetworks { get; set; }

        public Contact(int id, string name, string address, DateTime? birthDate, string? phoneNumber, List<SocialNetwork>? socialNetworks)
        {
            Id = id;
            Name = name;
            Address = address;
            BirthDate = birthDate;
            PhoneNumber = phoneNumber;
            SocialNetworks = socialNetworks;
        }

        public Contact(int id, string name, string address)
        {
            Id= id;
            Name = name;
            Address = address;
        }
    }
}
