using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EfPersonelOtomasyonu
{
   public class PersonelDal
    {
        public List<Personeller> personelList()
        {
            using (EFPersonellerContext eFPersonellerContext = new EFPersonellerContext())
            {
                return eFPersonellerContext.Personeller.ToList();
            }
        }

        public void personelEkle(Personeller P)
        {
            using (EFPersonellerContext eFPersonellerContext = new EFPersonellerContext())
            {
                eFPersonellerContext.Personeller.Add(P);
                eFPersonellerContext.SaveChanges();
            }
        }
        public void personelGuncelle(Personeller P)
        {
            using (EFPersonellerContext eFPersonellerContext = new EFPersonellerContext())
            {
                var guncelle = eFPersonellerContext.Entry(P);
                guncelle.State = EntityState.Modified;
                eFPersonellerContext.SaveChanges();
            }
        }

        public void personelSil(Personeller P)
        {
            using (EFPersonellerContext eFPersonellerContext = new EFPersonellerContext())
            {
                var sil = eFPersonellerContext.Entry(P);
                sil.State = EntityState.Deleted;
                eFPersonellerContext.SaveChanges();
            }
        }
    }
}
