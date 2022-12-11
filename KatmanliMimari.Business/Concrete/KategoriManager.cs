using KatmanliMimari.Business.Abstract;
using KatmanliMimari.DataAccess.Abstract;
using KatmanliMimari.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.Business.Concrete
{
    public class KategoriManager:IKatalogServis
    {   
        private IKategori _kategoriDal;
        public KategoriManager(IKategori kategori)
        {
            _kategoriDal = kategori;
        }

        public List<kategori> GetAll()
        {
            return _kategoriDal.GetAll();
        }
    }
}
