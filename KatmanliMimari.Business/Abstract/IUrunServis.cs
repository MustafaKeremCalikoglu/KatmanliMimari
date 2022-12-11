using KatmanliMimari.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.Business.Abstract
{
    public interface IUrunServis
    {
        void Add(urun urun);
        void Delete(urun urun);
        List<urun> GetAll();
        List<urun> GetByKategoriId(int v);
        List<urun> GetByUrunAdi(string UrunAdi);
        void Update(urun urun);
    }
}
