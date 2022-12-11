using KatmanliMimari.Business.Abstract;
using KatmanliMimari.Business.FluentValidation;
using KatmanliMimari.Business.Utilities;
using KatmanliMimari.DataAccess.Abstract;
using KatmanliMimari.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.Business.Concrete
{
    public class UrunManager:IUrunServis
    {
        private IUrunDal _urunDal;
        public UrunManager(IUrunDal urunServis)
        {
            _urunDal = urunServis;  
        }

        public void Add(urun urun)
        {
            ValidationTool.Validate(new UrunValidator(), urun);
            _urunDal.Add(urun);
        }

        public void Delete(urun urun)
        {
            try
            {
                _urunDal.Delete(urun);

            }
            catch (Exception e)
            {

                throw new Exception("silinemedi");
            }
        }

        public List<urun> GetAll()
        {
            return _urunDal.GetAll();
        }

        public List<urun> GetByKategoriId(int v)
        {
            return _urunDal.GetAll(p => p.KategoriId == v);
        }

        public List<urun> GetByUrunAdi(string UrunAdi)
        {
            return _urunDal.GetAll(p => p.UrunIsmi.Contains(UrunAdi));
        }

        public void Update(urun urun)
        {
            ValidationTool.Validate(new UrunValidator(), urun);
            _urunDal.Update(urun);
        }
    }
}
