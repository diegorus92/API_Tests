using ADDRESS_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADDRESS_DAL.Data
{
    public class AddressAppContext:DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<SocialNetwork> SocialNetworks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=DESKTOP-D5A7JAP\\SQLEXPRESS; Initial Catalog=AddressDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
            );
        }
    }
}
