
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MovimientoBackend.Models
{
    using Movimiento.Domain.Models;
    public class LocalDataContext : DataContext

    {
        public System.Data.Entity.DbSet<Movimiento.Common.Models.Product> Products { get; set; }
    }
}