using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ConsoleApplication.Classes;
using Newtonsoft.Json;

namespace WebAPI.Controllers
{
    public class TitulosController : ApiController
    {
        // GET: api/Titulos
        public IEnumerable<Livros> Get()
        {
            Db_Utils db = new Db_Utils();
            var listLivros = db.FindBook("", 1);
            return listLivros;
        }

        // GET: api/Titulos/5
        public Livros Get(int id)
        {
            Db_Utils db = new Db_Utils();
            var livro = db.FindBook(id);
            return livro;
        }
        // GET: api/Titulos/
        public IEnumerable<Livros> Get(string pesquisa)
        {
            Db_Utils db = new Db_Utils();
            var listLivros = db.FindBook(pesquisa, 2);
            if (listLivros.FirstOrDefault().IdLivro == -1)
            {
                listLivros.Clear();
            }
            return listLivros;
        }
        public IEnumerable<Livros> GetAutor(string autor)
        {
            Db_Utils db = new Db_Utils();
            var listLivros = db.FindBook($"@Autor {autor}", 2);
            return listLivros;
        }
        public IEnumerable<Livros> GetTitulo(string titulo)
        {
            Db_Utils db = new Db_Utils();
            var listLivros = db.FindBook($"@Titulo {titulo}", 2);
            return listLivros;
        }

        // POST: api/Titulos
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Titulos/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Titulos/5
        public void Delete(int id)
        {
        }
    }
}
