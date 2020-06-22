using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movimiento.Domain.Models
{
    using System.Data.Entity;
    public class DataContext : DbContext
    {
        public DataContext() : base ("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Movimiento.Common.Models.Product> Products { get; set; }
    }
}
