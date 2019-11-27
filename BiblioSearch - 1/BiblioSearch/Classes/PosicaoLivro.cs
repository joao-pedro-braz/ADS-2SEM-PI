using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Classes
{
    public class PosicaoLivro : IDisposable
    {
        public int? IdPosicaoLivro { get; set; }
        public Posicao Posicao { get; set; }

        public void Dispose()
        {
        }
    }
}
