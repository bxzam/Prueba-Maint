using PruebaMaintBZ.Data.DataObject;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaMaintBZ.Data.Models
{
    public class DemoContext : DbContext
    {
        public DbSet<Person> People { get; set; }
    }
}
