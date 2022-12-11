using KatmanliMimari.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.Business.Abstract
{
    public interface IKatalogServis
    {
        List<kategori> GetAll();
    }
}
