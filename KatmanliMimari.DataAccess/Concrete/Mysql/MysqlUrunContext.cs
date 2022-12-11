using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KatmanliMimari.Entities.Concrete;

namespace KatmanliMimari.DataAccess.Concrete.Mysql
{
    public class MysqlUrunContext:DbContext
    {

        public MysqlUrunContext()
        {
            //Veritabanının kod tarafından oluşturulmasını engeller.
            Database.SetInitializer<MysqlUrunContext>(null);
        }

        public DbSet<urun> urun { get; set; }
        public DbSet<kategori> kategori { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
