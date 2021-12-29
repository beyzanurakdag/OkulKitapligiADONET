using OkulKitapligiADONET_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulKitapligiADONET
{
    public partial class FormOduncIslemleri_Sonra : Form
    {
        public FormOduncIslemleri_Sonra()
        {
            InitializeComponent();
        }

        //Global alan
        OgrenciManager ogrenciManager = new OgrenciManager();
        private void FormOduncIslemleri_Load(object sender, EventArgs e)
        {
            // sayfa load olduğunda kitaplar listboxa gelecek
            TumKitaplariUC_MyListBoxKitaplaraGetir();
            TumKitaplariUC_MyListBoxOgrencilereGetir();

            // sayfa load olduğunda öğrenciler listboxa gelecek
        }
        private void TumKitaplariUC_MyListBoxKitaplaraGetir()
        {
           
        }

        private void TumKitaplariUC_MyListBoxOgrencilereGetir()
        {
            //TumOgrencileriGetir
           
            UC_MyListBoxOgrenciler.myListBox.DataSource = ogrenciManager.TumOgrencileriViewModelleGetir();
        }
    }
}
