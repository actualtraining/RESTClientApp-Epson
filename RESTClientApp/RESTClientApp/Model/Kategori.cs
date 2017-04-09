using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RESTClientApp.Model
{
    public class Kategori : BindableObject
    {
        private int kategoriId;
        public int KategoriID
        {
            get { return kategoriId; }
            set { kategoriId = value; OnPropertyChanged("KategoriID"); }
        }
        //public string NamaKategori { get; set; }
        private string namaKategori;
        public string NamaKategori
        {
            get { return namaKategori; }
            set { namaKategori = value; OnPropertyChanged("NamaKategori"); }
        }

    }
}
