using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Classes
{
    public partial class Livros
    //IdLivro, Titulo, Autores, Cutter, Imagem, Bandeja, Coluna, Estante, Lado
    {
        public int IdLivro { get; set; }
        public string Titulo { get; set; }
        public string Autores { get; set; }
        public string Cutter { get; set; }
        public string Imagem { get; set; }
        public string Descricao { get; set; }
        public List<PosicaoLivro> PosicoesLivro { get; set; }

    }

}
