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

    }
}
