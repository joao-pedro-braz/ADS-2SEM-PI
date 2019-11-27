using System;
using System.Linq;
using System.Text;
using System.Threading;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ConsoleApplication.Windows_Form;
using System.Diagnostics;

namespace ConsoleApplication
{
    public class Program
    {
        private static Process processTaskMgr;

        static void Main()
        {
            Thread t = new Thread(NovaThread);
            t.Start();
        }
        static void NovaThread()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Load());
        }


        public static string RemoverAcentos(string input)
        {
            string stFormD = input.Normalize(NormalizationForm.FormD);
            int len = stFormD.Length;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < len; i++)
            {
                System.Globalization.UnicodeCategory uc = System.Globalization.CharUnicodeInfo.GetUnicodeCategory(stFormD[i]);
                if (uc != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(stFormD[i]);
                }
            }
            return (sb.ToString().Normalize(NormalizationForm.FormC));
        }

        public static string TipoConsulta(string mensagem)
        {
            Regex regexTitulo = new Regex("(?i)@T[í|i]tulo(.*)");
            Match matchTitulo = regexTitulo.Match(mensagem);
            Regex regexAutor = new Regex("(?i)@(?:Autores|Autor)(.*)");
            Match matchAutor = regexAutor.Match(mensagem);
            Regex regexLivro = new Regex("(?i)@Livro(.*)");
            Match matchLivro = regexLivro.Match(mensagem);


            Regex regexComandoDesc = new Regex("@[^ ]+(.*)");
            Match matchComandoDesc = regexComandoDesc.Match(mensagem);

            if (matchTitulo.Success)
            {
                string titulo = matchTitulo.Groups[1].Value;
                titulo = titulo.Trim();
                Console.WriteLine($"where B_Livros.Titulo Like '%{titulo}%'");
                return $"where B_Livros.Titulo Like '%{titulo}%'";
            }

            else if (matchAutor.Success)
            {
                string autor = matchAutor.Groups[1].Value;
                autor = autor.Trim();
                Console.WriteLine($"where B_Livros.Autor Like '%{autor}%'");
                return $"where B_Livros.Autores Like '%{autor}%'";
            }

            else if (matchLivro.Success)
            {
                try
                {
                    string id = matchLivro.Groups[1].Value;
                    //Console.WriteLine($"where B_Livros.IdLivro = {Convert.ToInt32(id)}");
                    return $"where B_Livros.IdLivro = {Convert.ToInt32(id)}";
                }
                catch
                {
                    return "Número do Livro Inválido";
                }
            }

            else if (matchComandoDesc.Success)
            {
                Console.WriteLine("desc");
                return $"desc";
            }

            else
            {
                mensagem = RemoverAcentos(mensagem);
                Console.WriteLine($"where B_Livros.DadosPesquisa Like '%{mensagem}%'");
                return $"where B_Livros.DadosPesquisa Like '%{mensagem}%'"; ;
            }

        }

    }


}
