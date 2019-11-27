using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication.Classes
{
    public partial class Livros : IDisposable
    {
        public Livros()
        {

        }

        public IEnumerable<Livros>GetAll()
        {
            Db_Utils db = new Db_Utils();
            return db.FindBook("", 1);
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
