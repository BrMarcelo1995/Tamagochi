
using RestSharp;
using System.Text.Json;
using Tamagochi.Modelo;
using Tamagochi.Visao;

View.Apresentacao();

do
{
    View.menu();
    View.opcao = Console.ReadLine();

    switch (View.opcao) {
        case "1":
            Console.WriteLine("Ainda não implementado");
            break;

        case "2":

            break;
    }
} 
while (View.opcao != "3");


//Console.WriteLine("*******************");






//HttpClient cli = new HttpClient();

//HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, "https://pokeapi.co/api/v2/pokemon/");

//HttpResponseMessage res = cli.Send(req);

////Console.WriteLine(res.Headers); 