using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi.Modelo
{
    public class Mascote
    {
        public List<Results>? results { get; set; }
        public double height { get; set; }
        public double weight { get; set; }
        public string? name { get; set; }
        public int Alimentacao { get; set; }
        public int Humor { get; set; }
        public DateTime DataNascimento { get; set; }

        public void ListarMascotes()
        {
            foreach (var names in results)
            {
                Console.WriteLine(names.name);
            }
        }
    }
}
