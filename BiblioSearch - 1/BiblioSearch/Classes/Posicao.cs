using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Classes
{
    public class Posicao : IDisposable
    {
        public int? IdPosicao { get; set; }
        public string Bandeja { get; set; }
        public string Coluna { get; set; }
        public string Estante { get; set; }
        public string Lado { get; set; }

        public void Dispose()
        {
        }
    }
}
