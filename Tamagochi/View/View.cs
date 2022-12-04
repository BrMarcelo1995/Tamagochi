
namespace Tamagochi.Visao
{
    public static class View
    {
        public static string? nome { get; set; }
        public static string? opcao { get; set; }
        public static void Apresentacao()
        {
           
            Console.Write("Infome seu nome: ");
            
            nome = Console.ReadLine();
            
            Console.Clear();

            Console.WriteLine($"Seja bem-vindo, {nome}!\n");

        }

        public static void menu()
        {
            Console.WriteLine("1 = Ver Mascotes");
            
            Console.WriteLine("2 = Adotar um Mascote");
            
            Console.WriteLine("3 = Sair do Jogo \n");
            
            Console.WriteLine();
        }

        public static void menuDetalhes(string especie)
        {
            Console.WriteLine($"1 = Saber mais sobre {especie}?");
            Console.WriteLine($"2 = Adotar um(a) {especie}?");
            Console.WriteLine("3 = Retornar para menu anterior");
        }
    }
}
