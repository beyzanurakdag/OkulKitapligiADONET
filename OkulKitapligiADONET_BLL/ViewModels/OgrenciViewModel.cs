using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulKitapligiADONET_BLL.ViewModels
{
    public class OgrenciViewModel
    {

        public int OgrId { get; set; }
        public DateTime KayitTarihi { get; set; }
        public string OgrAd { get; set; }
        public string OgrSoyad { get; set; }
        public byte Cinsiyet { get; set; }
        public int MyProperty { get; set; }

        public string Sinif { get; set; }
        public DateTime DogumTarihi { get; set; }
        public bool SilindiMi { get; set; }

        public override string ToString()
        {
            return this.OgrAd + " " + OgrSoyad;
        }

    }
}
