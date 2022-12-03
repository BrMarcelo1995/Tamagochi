using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi.Modelo
{
    public static class MascoteService
    {
        public static Mascote PegarMascotes()
        {
            RestClient client = new RestClient("https://pokeapi.co/api/v2");

            RestRequest rq = new RestRequest("pokemon/", Method.Get);

            RestResponse resp = client.Get(rq);


            string json = resp.Content;

            Mascote mascote = new Mascote();


            return mascote
        }
    }
}
