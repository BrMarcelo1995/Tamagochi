using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi.Visao
{
    public static class View
    {
        public static string nome { get; set; }
        public static string opcao { get; set; }
        public static void Apresentacao()
        {
            Console.WriteLine("Seja bem-vindo \n");
            Console.Write("Infome seu nome: ");
            nome = Console.ReadLine();

        }

        public static void menu()
        {
            Console.WriteLine("1 = Adoção de Mascotes");
            Console.WriteLine("2 = Ver mascotes");
            Console.WriteLine("3 = Sair do Jogo");
        }
    }
}
