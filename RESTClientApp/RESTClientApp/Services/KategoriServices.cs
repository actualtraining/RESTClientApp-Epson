using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RestSharp.Portable;
using RestSharp.Portable.HttpClient;
using RESTClientApp.Model;

namespace RESTClientApp.Services
{
    public class KategoriServices
    {
        private RestClient _client;
        public KategoriServices()
        {
            _client = new RestClient(Helpers.GetUrl());
        }

        public async Task<IEnumerable<Kategori>> GetAllKategori()
        {
            RestRequest request = new RestRequest("api/Kategori", Method.GET);
            var res = await _client.Execute<List<Kategori>>(request);
            if (res.Data == null)
                throw new Exception("Error : " + res.StatusCode.ToString() + " " + res.StatusDescription);
            return res.Data;  
        }

        public async Task InsertKategori(Kategori kategori)
        {
            var request = new RestRequest("api/Kategori", Method.POST);
            request.AddBody(kategori);
            try
            {
                await _client.Execute(request);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task UpdateKategori(Kategori kategori)
        {
            var request = new RestRequest("api/Kategori", Method.PUT);
            request.AddBody(kategori);
            try
            {
                await _client.Execute(request);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task DeleteKategori(int kategoriID)
        {
            var request = new RestRequest(string.Format("api/Kategori/{0}", kategoriID),Method.DELETE);
            try
            {
                await _client.Execute(request);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
