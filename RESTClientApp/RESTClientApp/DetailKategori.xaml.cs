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
    public partial class DetailKategori : ContentPage
    {
        public DetailKategori()
        {
            InitializeComponent();
            btnEdit.Clicked += BtnEdit_Clicked;
        }

        private KategoriServices myServices;
        private async void BtnEdit_Clicked(object sender, EventArgs e)
        {
            var editKategori = new Kategori
            {
                KategoriID = Convert.ToInt32(txtKategoriID.Text),
                NamaKategori = txtNamaKategori.Text
            };
            try
            {
                await myServices.UpdateKategori(editKategori);
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
