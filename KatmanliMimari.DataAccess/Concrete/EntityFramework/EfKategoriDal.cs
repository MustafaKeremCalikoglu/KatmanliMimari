using KatmanliMimari.DataAccess.Abstract;
using KatmanliMimari.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.DataAccess.Concrete.EntityFramework
{
    public class EfKategoriDal:EfEntityRepositoryBase<kategori,UrunContext>,IKategori
    {
    }
}
