using KatmanliMimari.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.DataAccess.Concrete.EntityFramework
{
    public class UrunContext:DbContext
    {
        public DbSet<urun> Uruns { get; set; }
        public DbSet<kategori> Kategoris { get; set; }


    }
}
