using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProjesi
{
    public class ogrenci:Genel
    { 
        public Guid Id { get; set; }

        public string SoruSayisi { get; set; }
        public string KullaniciAdi { get; set; }


        public override void BilgiGetir()
        {
            throw new NotImplementedException();
        }

        public override string Listele()
        {
            throw new NotImplementedException();
        }
    }
}
