using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WpfApp1.model;

namespace WpfApp1
{
    class UserContext:DbContext
    {
        public DbSet<User> Users {get;set;}
        public UserContext() : base("test") { 
        }
    }
}

 