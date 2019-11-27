using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace ConsoleApplication.Classes
{
    public class Db_Utils
    {
        private SQLiteConnection ConnectionLite(char status)
        {
            var pathRoot = Application.StartupPath;
         
            SQLiteConnection conn = new SQLiteConnection($"Data Source={pathRoot}\\FATEC.sdb;Version=3;");
            if (status == 'o')
            {
                conn.Open();
            }
            else if (status == 'c')
            {
                conn.Close();
            }
            return conn;
        }

        private string Sqlstatement(string selectedcolumns, string from,string where, string qtd)
        {
            StringBuilder sqlstatement = new StringBuilder();

            sqlstatement.Append($"SELECT DISTINCT {qtd} {selectedcolumns} ");
            sqlstatement.Append($"FROM {from} ");
            sqlstatement.Append($"INNER JOIN B_PosicaoLivro ON B_PosicaoLivro.IdLivro = B_Livros.IdLivro ");
            sqlstatement.Append($"INNER JOIN B_Posicao ON B_Posicao.IdPosicao = B_PosicaoLivro.IdPosicao ");
            sqlstatement.Append($"WHERE {where} ");
            
            return sqlstatement.ToString();
        }

        public List<Livros> FindBook(string mensagem, int origem)
        {
            var lstLivro = new List<Livros>();
            var lstposicao = new List<PosicaoLivro>();
            Classes.Livros livros = new Classes.Livros();
            Classes.PosicaoLivro posicaoLivro = new Classes.PosicaoLivro();
            Classes.Posicao posicao = new Classes.Posicao();
            TipoConsulta tipoConsulta = new TipoConsulta();

            var qtd = "";
            switch (origem)
            {
                //Telegram
                case 1:
                    {
                        tipoConsulta = TipoConsultaTelegram(mensagem);
                        qtd = "TOP 15";
                        break;
                    }
                // APP
                case 2:
                    {
                        tipoConsulta = TipoConsultaTelegram(mensagem);
                        qtd = "TOP 1";
                        break;
                    }
                // Window Form
                case 3:
                    {
                        tipoConsulta = TipoConsultaTelegram(mensagem);
                        qtd = "";
                        break;
                    }

            }

            
            //Busca Livro Pelo ID
            if (tipoConsulta.idconsulta == 1)
            {
                Classes.Db_Utils db = new Classes.Db_Utils();

                livros = db.FindBook(Convert.ToInt32(tipoConsulta.consulta));

                lstLivro.Add(livros);
            }

            //Consulta Titulo ou Autor ou Geral
            else if (tipoConsulta.idconsulta == 2 || tipoConsulta.idconsulta == 3 || tipoConsulta.idconsulta == 4)
            {
                var conn = ConnectionLite('o');
                var sql = Sqlstatement("B_Livros.IdLivro, Titulo, Autores, Cutter, Imagem, Descricao", "B_Livros", $"{tipoConsulta.tabela}{tipoConsulta.operador}{tipoConsulta.consulta}", qtd);

                SQLiteCommand command = new SQLiteCommand(sql, conn);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        using (var tempLivros = new Classes.Livros())
                        {
                            tempLivros.IdLivro = Convert.ToInt32(reader["IdLivro"]);
                            tempLivros.Titulo = reader["Titulo"].ToString();
                            tempLivros.Autores = reader["Autores"].ToString();
                            tempLivros.Cutter = reader["Cutter"].ToString();
                            tempLivros.Imagem = reader["Imagem"].ToString();
                            tempLivros.Descricao = reader["Descricao"].ToString();

                            lstLivro.Add(tempLivros);
                        }
                    }

                }

                //BUSCA POSICAO EM CASO DE SOMENTE UM LIVRO
                if (lstLivro.Count == 1) {

                    Classes.Db_Utils db = new Classes.Db_Utils();

                    int idlivro = lstLivro.First().IdLivro;

                    lstLivro.Clear();

                    lstLivro.Add(db.FindBook(idlivro));

                }

                ConnectionLite('c');
            }

            //Erro no Tipo
            else if (tipoConsulta.idconsulta == -1)
            {
                using (var tempLivros = new Classes.Livros())
                {
                    tempLivros.IdLivro = -1;

                    lstLivro.Add(tempLivros);
                }
            }

            return lstLivro;

        }

        public Livros FindBook(int idlivro)
        {
            var conn = ConnectionLite('o');
            var sql = Sqlstatement("B_Livros.IdLivro, Titulo, Autores, Cutter, Imagem, Descricao", "B_Livros", $"B_Livros.IdLivro = {idlivro}", "");
            var sql2 = Sqlstatement("IdPosicaoLivro, B_Posicao.IdPosicao, Coluna, Estante, Lado, Bandeja", "B_Livros", $"B_Livros.IdLivro = {idlivro}", "");

            using (Classes.Livros livros = new Classes.Livros())
            {
                using (Classes.PosicaoLivro posicaoLivro = new Classes.PosicaoLivro())
                {
                    using (Classes.Posicao posicao = new Classes.Posicao())
                    {
                        SQLiteCommand command = new SQLiteCommand(sql, conn);
                        SQLiteCommand command2 = new SQLiteCommand(sql2, conn);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                livros.IdLivro = Convert.ToInt32(reader["IdLivro"]);
                                livros.Titulo = reader["Titulo"].ToString();
                                livros.Autores = reader["Autores"].ToString();
                                livros.Cutter = reader["Cutter"].ToString();
                                livros.Imagem = reader["Imagem"].ToString();
                                livros.Descricao = reader["Descricao"].ToString();
                            }
                        }
                        if (livros != null)
                        {
                            using (SQLiteDataReader reader = command2.ExecuteReader())
                            {
                                livros.PosicoesLivro = new List<Classes.PosicaoLivro>();

                                while (reader.Read())
                                {
                                    using (var tempPosicaoLivro = new Classes.PosicaoLivro())
                                    {
                                        using (var tempPosicao = new Classes.Posicao())
                                        {
                                            tempPosicaoLivro.IdPosicaoLivro = Convert.ToInt32(reader["IdPosicaoLivro"]);
                                            tempPosicao.IdPosicao = Convert.ToInt32(reader["IdPosicao"]);
                                            tempPosicao.Bandeja = reader["Bandeja"].ToString();
                                            tempPosicao.Coluna = reader["Coluna"].ToString();
                                            tempPosicao.Lado = reader["Lado"].ToString();
                                            tempPosicao.Estante = reader["Estante"].ToString();
                                            tempPosicaoLivro.Posicao = tempPosicao;

                                            livros.PosicoesLivro.Add(tempPosicaoLivro);
                                        }
                                    }
                                }
                            }

                        }

                        ConnectionLite('c');

                        return livros;
                    }
                }
            }
        }

        //Telegram
        public TipoConsulta TipoConsultaTelegram(string mensagem)
        {
            Classes.TipoConsulta tipoConsulta = new Classes.TipoConsulta();
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

                tipoConsulta.tabela = " B_Livros.Titulo ";
                tipoConsulta.consulta = $" '%{titulo}%' ";
                tipoConsulta.operador = " like ";
                tipoConsulta.idconsulta = 2;

            }

            else if (matchAutor.Success)
            {
                string autor = matchAutor.Groups[1].Value;
                autor = autor.Trim();


                tipoConsulta.tabela = " B_Livros.Autores ";
                tipoConsulta.consulta = $" '%{autor}%' ";
                tipoConsulta.operador = " like ";
                tipoConsulta.idconsulta = 3;

            }

            else if (matchLivro.Success)
            {
                try
                {
                    string id = matchLivro.Groups[1].Value;
                    int idlivro = Convert.ToInt32(id);
                    tipoConsulta.tabela = " B_Livros.IdLivro ";
                    tipoConsulta.consulta = $" {idlivro} ";
                    tipoConsulta.operador = " = ";
                    tipoConsulta.idconsulta = 1;

                }
                catch
                {
                    tipoConsulta.tabela = " B_Livros.IdLivro ";
                    tipoConsulta.consulta = $" {0} ";
                    tipoConsulta.operador = " = ";
                    tipoConsulta.idconsulta = -1;
                }
            }

            else if (matchComandoDesc.Success)
            {
                tipoConsulta.tabela = " B_Livros.IdLivro ";
                tipoConsulta.consulta = $" {0} ";
                tipoConsulta.operador = " = ";
                tipoConsulta.idconsulta = -1;
            }

            else
            {
                mensagem = Program.RemoverAcentos(mensagem);

                tipoConsulta.tabela = " B_Livros.DadosPesquisa ";
                tipoConsulta.consulta = $" '%{mensagem}%' ";
                tipoConsulta.operador = " Like ";
                tipoConsulta.idconsulta = 4;
            }

            return tipoConsulta;

        }

    }
}

