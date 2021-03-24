using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.model;

namespace WpfApp1.context
{
    class RealtorContext : DbContext
    {
 
        public DbSet<Realtor> Realtors { get; set; }

        public RealtorContext() : base("test")
        {
        }
    }
}
