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
            myServices = new KategoriServices();
            btnEdit.Clicked += BtnEdit_Clicked;

            btnDelete.Clicked += BtnDelete_Clicked;
        }

        private async void BtnDelete_Clicked(object sender, EventArgs e)
        {
            try
            {
                var result = await DisplayAlert("Konfirmasi", "Apakah anda ingin delete data " + txtNamaKategori.Text,
                    "Yes","No");
                if (result)
                {
                    await myServices.DeleteKategori(Convert.ToInt32(txtKategoriID.Text));
                    await Navigation.PopAsync();
                }   
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
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
