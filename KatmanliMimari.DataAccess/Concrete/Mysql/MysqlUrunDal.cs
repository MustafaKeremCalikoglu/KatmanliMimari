using KatmanliMimari.DataAccess.Abstract;
using KatmanliMimari.Entities.Concrete;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.DataAccess.Concrete.Mysql
{
    public class MysqlUrunDal:MysqlBase<urun,MysqlUrunContext>,IUrunDal
    {
    }
}
