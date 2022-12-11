using KatmanliMimari.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.Entities.Concrete
{
    public class urun:IEntity
    {

        public int UrunId { get; set; }
        public int KategoriId { get; set; }
        public string UrunIsmi { get; set; }
        public int Fiyat { get; set; }
    }
}
