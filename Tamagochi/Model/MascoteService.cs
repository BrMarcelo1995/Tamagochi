using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi.Modelo
{
    public static class MascoteService
    {
        public static Mascote PegarMascote(string nome)
        {
            var client = new RestClient("https://pokeapi.co/api/v2");

            RestRequest rq = new RestRequest($"pokemon/{nome}");

            return client.Get<Mascote>(rq);

        }

        public static Mascote ListarMascotes()
        {
            var client = new RestClient("https://pokeapi.co/api/v2");

            var rq = new RestRequest("/pokemon");

            return client.Get<Mascote>(rq);

        }
    }
}
