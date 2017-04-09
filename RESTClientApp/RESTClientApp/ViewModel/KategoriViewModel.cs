using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using RESTClientApp.Model;
using System.Collections.ObjectModel;
using RESTClientApp.Services;

namespace RESTClientApp.ViewModel
{
    public class KategoriViewModel : BindableObject
    {
        private ObservableCollection<Kategori> listKategori;

        public ObservableCollection<Kategori> ListKategori
        {
            get { return listKategori; }
            set { listKategori = value; OnPropertyChanged("ListKategori"); }
        }

        private async void FillListKategori()
        {
            KategoriServices kategoriService = new KategoriServices();
            ListKategori = await kategoriService.GetAllKategori();
        }

        public KategoriViewModel()
        {
            FillListKategori();
        }

    }
}
