using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cp2_Eercicio_5
{
    class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }

        public Livro(string titulo, string autor, int anoPublicacao)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"{Titulo} – {Autor} ({AnoPublicacao})");
        }
    }

}
