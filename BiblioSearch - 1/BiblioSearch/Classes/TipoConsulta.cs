using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Classes
{
    public class TipoConsulta
    {
        public string tabela { get; set; }
        public string consulta { get; set; }
        public string operador { get; set; }
        public int idconsulta { get; set; }
    }
}
