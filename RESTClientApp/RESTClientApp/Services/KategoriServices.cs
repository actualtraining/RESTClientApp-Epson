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
             
        }

    }
}
