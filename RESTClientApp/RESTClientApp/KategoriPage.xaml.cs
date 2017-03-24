using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RESTClientApp.Model;
using RESTClientApp.Services;

namespace RESTClientApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KategoriPage : ContentPage
    {
        private KategoriServices myServices;
        public KategoriPage()
        {
            InitializeComponent();
            myServices = new KategoriServices();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await myServices.GetAllKategori();
        }
    }
}
