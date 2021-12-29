using OkulKitapligiADONET_BLL.ViewModels;
using OkulKitapligiADONET_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulKitapligiADONET_BLL
{
   public class OgrenciManager
    {
        MyPocketDAL myPocketDAL = new MyPocketDAL("DESKTOP-TUMHS1A", "OKULKITAPLIGI", "", "");

        public DataTable TumOgrencileriGetir()
        {
            try
            {
                DataTable data = new DataTable();
                data = myPocketDAL.GetTheData("Ogrenciler", "*", "SilindiMi=0");
                return data;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<OgrenciViewModel> TumOgrencileriViewModelleGetir()
        {
            List<OgrenciViewModel> data = new List<OgrenciViewModel>();
            try
            {
                DataTable theData = new DataTable();
                theData = myPocketDAL.GetTheData("Ogrenciler", "*", "SilindiMi=0");


                for (int i = 0; i < theData.Rows.Count; i++)
                {
                    OgrenciViewModel ogrenci = new OgrenciViewModel()
                    {


                        OgrId = (int)theData.Rows[i].ItemArray[0],
                        KayitTarihi = Convert.ToDateTime(theData.Rows[i].ItemArray[1]),
                        OgrAd = theData.Rows[i].ItemArray[2].ToString(),
                        OgrSoyad = theData.Rows[i].ItemArray[3].ToString()
                    };

                    data.Add(ogrenci);

                }
                return data;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
