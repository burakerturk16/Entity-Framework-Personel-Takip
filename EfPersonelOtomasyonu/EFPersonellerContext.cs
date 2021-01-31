using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EfPersonelOtomasyonu
{
    public class EFPersonellerContext:DbContext
    {
        public DbSet<Personeller> Personeller { get; set; }
    }
}
