using KatmanliMimari.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.Entities.Concrete
{
    public class kategori:IEntity
    {

        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; }



    }
}
