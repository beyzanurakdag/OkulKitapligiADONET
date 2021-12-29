using OkulKitapligiADONET_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using OkulKitapligiADONET_BLL.ViewModels;

namespace OkulKitapligiADONET_BLL
{
    public class KitapOduncIslemManager
    {

        MyPocketDAL myPocketDAL = new MyPocketDAL("DESKTOP-TUMHS1A", "OKULKITAPLIGI", "", "");

        public DataTable TumKitaplariGetir()
        {
            try
            {
                DataTable data = new DataTable();
                data = myPocketDAL.GetTheData("Kitaplar", "*", "SilindiMi=0");
                return data;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable TumOgrencileriGetir()
        {
            try
            {
                DataTable data = new DataTable();
                data = myPocketDAL.GetTheData("Ogrenciler", "OgrId, CONCAT(OgrAd, ' ' , OgrSoyad) as OgrenciAdSoyad, Cinsiyet, Sinif, DogumTarihi, SilindiMi", "SilindiMi=0");
                return data;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable GrideVerileriGetir()
        {
            try
            {
                DataTable data = new DataTable();
                data = myPocketDAL.GetTheData("select i.IslemId, i.KitapId,  CONCAT(o.OgrAd, ' ', o.OgrSoyad) as OgrenciAdSoyad, k.KitapAdi, i.OduncAldigiTarih, i.OduncBitisTarihi from  Islemler i inner join Kitaplar k on k.KitapId = i.KitapId inner join Ogrenciler o on o.OgrId = i.OgrId ");


                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<IslemViewModel> GrideVerileriViewModelleGetir()
        {
            List<IslemViewModel> data = new List<IslemViewModel>();

            try
            {
                DataTable theData = new DataTable();
                theData = myPocketDAL.GetTheData("select i.IslemId, k.KitapId, o.OgrId, CONCAT(o.OgrAd, ' ', o.OgrSoyad) as OgrenciAdSoyad, k.KitapAdi, i.OduncAldigiTarih, i.OduncBitisTarihi, i.TeslimEdildiMi from  Islemler i inner join Kitaplar k on k.KitapId = i.KitapId inner join Ogrenciler o on o.OgrId = i.OgrId");

                // veriler dataTable ile geldi. Ama ben o verileri tek tek döngü ile dönerken içindeki verileri viewmodelime aktaracağım.

                for (int i = 0; i < theData.Rows.Count; i++)
                {
                    DataRow satir = theData.Rows[i];

                    IslemViewModel veri = new IslemViewModel()
                    {
                        IslemId = (int)theData.Rows[i].ItemArray[0],
                        KitapId = (int)theData.Rows[i].ItemArray[1],
                        OgrId = (int)theData.Rows[i].ItemArray[2],
                        OgrenciAdSoyad = theData.Rows[i].ItemArray[3].ToString(),
                        KitapAdi = theData.Rows[i].ItemArray[4].ToString(),
                        OduncAldigiTarih = Convert.ToDateTime(theData.Rows[i].ItemArray[5]),
                        OduncBitisTarihi= Convert.ToDateTime(theData.Rows[i].ItemArray[6]),
                        TeslimEdildiMi=(bool)theData.Rows[i].ItemArray[7]

                    };

                    //IslemViewModel tipindeki veri isimli nesne IslemViewModel tipine sahip listeye eklenecek
                    data.Add(veri); // ekledik
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }


            return data;
        }

        public int KitabinStogunuGetir(int kitapId)
        {
            try
            {
                int stokAdeti = 0;
                object data = myPocketDAL
                    .GetTheDataByExecuteScalar($"select Stok from Kitaplar where KitapId={kitapId}");

                if (data != null)
                {
                    stokAdeti = Convert.ToInt32(data);
                }

                return stokAdeti;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public bool OduncKitapKaydiniYap(string tableName, Hashtable htVeri)
        {
            bool sonuc = false;
            try
            {
                //stok adet
                object stokAdeti = myPocketDAL.GetTheDataByExecuteScalar("select Stok from Kitaplar where KitapId=" + htVeri["KitapId"].ToString());

                if (stokAdeti != null)
                {
                    //stoğu azaltacağız

                    stokAdeti = (int)stokAdeti - 1;
                    string updateCumlesi = "Update Kitaplar set Stok=" + stokAdeti + " where KitapId=" + htVeri["KitapId"];

                    //ödünç 
                    string insertCumlesi = myPocketDAL.CreateInsertQueryAsString(tableName, htVeri);

                    sonuc = myPocketDAL.ExecuteTheQueriesWithTransaction(insertCumlesi, updateCumlesi);

                }
                else
                {
                    throw new Exception("HATA: Stok adet bilgisi alınamadığı için hata oluştu!");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return sonuc;
        }


        public bool OduncKitapTeslimEt(string tableName, int islemId, int kitapId)
        {

            bool sonuc = false;
            try
            {
                //stok
                object stokAdet = myPocketDAL.GetTheDataByExecuteScalar("select Stok from Kitaplar where KitapId=" + kitapId);
                if (stokAdet != null)
                {
                    stokAdet = (int)stokAdet + 1;
                    string[] komutcumleleri = new string[2];
                    komutcumleleri[0] = "update Kitaplar Set Stok=" + stokAdet + "  where KitapId=" + kitapId;

                    //CreateUpdateAsString isimli metodunu kullanmak amacıyla hastable oluşturacağız
                    // Eğer o metodu kullanmak istemezseniz yani hastable oluşturmaya erindiniz diyelim ozaman 2. komut cümlesini aşağıdaki gibi oluşturabilirsiniz.
                    //komutcumleleri[1] = "update Islemler Set TeslimEdildiMi=1, OduncBitisTarihi='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'  where IslemId=" + islemId;

                    Hashtable htVeri = new Hashtable();

                    string bitisTarih = "'"
                        + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                        + "'";

                    htVeri.Add("TeslimEdildiMi", "1");
                    htVeri.Add("OduncBitisTarihi", bitisTarih);
                    string kosulum = "IslemId=" + islemId;
                    komutcumleleri[1] = myPocketDAL.CreateUpdateQueryAsString("Islemler", htVeri, kosulum);

                    sonuc = myPocketDAL.ExecuteTheQueriesWithTransaction(komutcumleleri);
                }
                else
                {
                    throw new Exception("HATA: Stok adeti çekilemediği için hata oluştu!");
                }

                return sonuc;

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

    }
}
