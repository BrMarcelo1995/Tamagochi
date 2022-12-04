using Tamagochi.Modelo;
using Tamagochi.Visao;

View.Apresentacao();

do
{
    View.menu();

    View.opcao = Console.ReadLine();

    var mascote = new Mascote();

    string MascoteEscolhido;

    switch (View.opcao) {
        case "1":

            Console.Clear();
            
            mascote = MascoteService.ListarMascotes();

            mascote.ListarMascotes();

            Console.WriteLine();
    
            break;

        case "2":

            string opcao;

            mascote = MascoteService.ListarMascotes();

            mascote.ListarMascotes();

            Console.WriteLine();

            Console.WriteLine("Escolha um mascote");

            MascoteEscolhido = Console.ReadLine();

 

            do
            {
                View.menuDetalhes(MascoteEscolhido);

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":

                        Console.WriteLine("Sobre : PENDENTE DE IMPLEMENTAÇÃO");
                        break;

                    case "2":
                        Console.WriteLine("Adotar : PENDENTE DE IMPLEMENTAÇÃO");
                        break;
                }

            } while (opcao != "3");




            //Console.WriteLine();

            //Console.WriteLine("Informe o nome do mascote que deseja adotar: ");

            //string nome = Console.ReadLine();
            
            //Console.Clear();
            
            //mascote = MascoteService.PegarMascote(nome);

            //Console.WriteLine($"nome: {mascote.name}");
            
            //Console.WriteLine($"peso: {mascote.weight}");

            //Console.WriteLine();
            
            break;
    }
} 
while (View.opcao != "3");

