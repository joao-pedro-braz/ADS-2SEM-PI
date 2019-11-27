using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ConsoleApplication.Windows_Form
{
    public partial class BiblioSearch : MaterialSkin.Controls.MaterialForm
    {
        public BiblioSearch()
        {
            InitializeComponent();
        }

        int contador = 0;
        int lastindex = -1;

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            var pesquisa = "";

            LimparPesquisa();

            if (cbCategoria.SelectedIndex <= 0)
            {
                pesquisa = tbPesquisa.Text;
            }
            else if (cbCategoria.SelectedIndex == 1)
            {
                pesquisa = $"@Autor {tbPesquisa.Text}";
            }
            else if (cbCategoria.SelectedIndex == 2)
            {
                pesquisa = $"@Titulo {tbPesquisa.Text}";
            }
            
            ConsoleApplication.Classes.Db_Utils db = new ConsoleApplication.Classes.Db_Utils();
            StringBuilder mensagem = new StringBuilder();

            var livros = db.FindBook(pesquisa, 3);
            

            if (livros.Count == 1 && livros.FirstOrDefault().IdLivro == -1)
            {
                mensagem.Append($"Comando não reconhecido!\n");
                mensagem.Append($"Você pode usar @Título , @Autor ou fazer uma pesquisa geral\n");
                LimparPesquisa();
                MessageBox.Show("Nenhum Livro Encontrado", "Resultado da Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (livros.Count == 0)
            {
                LimparPesquisa();
                MessageBox.Show("Nenhum Livro Encontrado", "Resultado da Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (livros.Count == 1)
            {
                Mostrarlivro(livros);
            }

            else
            {
                for (int i = 0; i < livros.Count; i++)
                {
                    lbResultados.Items.Add($"\nTítulo (nº.{livros.ElementAt(i).IdLivro}): {livros.ElementAt(i).Titulo}\n");
                }
            }
            tbPesquisa.Focus();
            timer1.Stop();
            timer1.Start();
        }

        public void Mostrarlivro(List<ConsoleApplication.Classes.Livros> livros)
        {
            string imagem = "";

            pnLivro.Visible = true;

            pbFundo.Visible = false;

            tbDescricao.Visible = false;

            pnOutrasLoc.Visible = false;

            lbOutrasPos.Items.Clear();

            if (lbResultados.SelectedIndex < 0)
            {
                lbResultados.Items.Insert(0, $"\nTítulo (nº.{livros.FirstOrDefault().IdLivro}): {livros.FirstOrDefault().Titulo}");
            }

            tbTitulo.Text = livros.FirstOrDefault().Titulo;
            tbAutores.Text = livros.FirstOrDefault().Autores;
            tbDescricao.Text = livros.FirstOrDefault().Descricao;
            tbCutter.Text = livros.FirstOrDefault().Cutter;

            imagem = $"{livros.FirstOrDefault().Imagem}";

            if (imagem != "")
            {
                try
                {
                    pbLivro.Load(imagem);
                    pbLivro.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch
                {

                }

            }

            if (livros.FirstOrDefault().PosicoesLivro.Count > 1)
            {
                pnOutrasLoc.Visible = true;

                // lbOutrasPos.Items.Add($"Outras possíveis localizações do Livro:");
                // lbOutrasPos.Items.Add($"");
            }
            for (int i = 0; i < livros.FirstOrDefault().PosicoesLivro.Count; i++)
            {

                if (i == 0)
                {
                    lbBandeja.Text = livros.FirstOrDefault().PosicoesLivro[i].Posicao.Bandeja;
                    lbEstante.Text = livros.FirstOrDefault().PosicoesLivro[i].Posicao.Estante;
                    lbLado.Text = livros.FirstOrDefault().PosicoesLivro[i].Posicao.Lado == "A" ? "Esquerdo" : "Direito";
                    lbColuna.Text = livros.FirstOrDefault().PosicoesLivro[i].Posicao.Coluna;
                    lbOutrasPos.Items.Add($"");
                }
                else
                {
                    var lado = livros.FirstOrDefault().PosicoesLivro[i].Posicao.Lado == "A" ? "Esquerdo" : "Direito";
                    lbOutrasPos.Items.Add($"Estante: {livros.FirstOrDefault().PosicoesLivro[i].Posicao.Estante}");
                    lbOutrasPos.Items.Add($"Lado: {lado}");
                    lbOutrasPos.Items.Add($"Coluna: {livros.FirstOrDefault().PosicoesLivro[i].Posicao.Coluna}");
                    lbOutrasPos.Items.Add($"Bandeja: {livros.FirstOrDefault().PosicoesLivro[i].Posicao.Bandeja}\n");
                    lbOutrasPos.Items.Add($"");
                }
            }

            if (tbDescricao.Text != "")
            {
                tbDescricao.Visible = true;
            }

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            LimparPesquisa();
            tbPesquisa.Text = "";
            lbCategoria.Visible = true;
            cbCategoria.SelectedIndex = -1;
            tbPesquisa.Focus();
        }

        public void LimparPesquisa()
        {
            this.pbLivro.Image = global::BiblioSearch.Properties.Resources.ImagemFundo;
            pbLivro.SizeMode = PictureBoxSizeMode.StretchImage;
            lbResultados.Items.Clear();
            tbTitulo.Text = "";
            tbDescricao.Text = "";
            tbCutter.Text = "";
            tbAutores.Text = "";
            lbBandeja.Text = "";
            lbEstante.Text = "";
            lbLado.Text = "";
            lbColuna.Text = "";
            lbOutrasPos.Items.Clear();
            pnLivro.Visible = false;
            pbFundo.Visible = true;
            lastindex = -1;
            contador = 0;
            timer1.Stop();
        }

        private void tbPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btPesquisar_Click(sender, e);
            }
        }

        private void lbResultados_SelectedIndexChanged(object sender, EventArgs e)
        {
            contador = 0;
            int idlivro = 0;
            if (lastindex == -1 || lbResultados.SelectedIndex != lastindex)
            {

                try
                {
                    lastindex = lbResultados.SelectedIndex;
                    var livro = lbResultados.SelectedItem.ToString();

                    Regex regexLivro = new Regex("Título [(]nº[.](\\d+)[)]");
                    Match matchLivro = regexLivro.Match(livro);

                    if (matchLivro.Success)
                    {
                        idlivro = Convert.ToInt32(matchLivro.Groups[1].Value);
                    }

                    ConsoleApplication.Classes.Db_Utils db = new ConsoleApplication.Classes.Db_Utils();
                    StringBuilder mensagem = new StringBuilder();

                    var livros = db.FindBook($"@Livro {idlivro}", 3);

                    Mostrarlivro(livros);
                }
                catch { }
            }

        }

        private void BiblioSearch_Load(object sender, EventArgs e)
        {
            pbLivro.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPesquisa.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFundo.SizeMode = PictureBoxSizeMode.CenterImage;
            tbPesquisa.BorderStyle = 0;
            lbResultados.BorderStyle = 0;
            lbOutrasPos.BorderStyle = 0;
            tbTitulo.BorderStyle = 0;
            tbCutter.BorderStyle = 0;
            tbDescricao.BorderStyle = 0;
            tbAutores.BorderStyle = 0;

            pbFundo.Location = new Point(
            this.ClientSize.Width / 2 - pbFundo.Size.Width / 2,
            220);
            pbFundo.Anchor = AnchorStyles.None;

            ctPesquisa.Location = new Point(
            this.ClientSize.Width / 2 - ctPesquisa.Size.Width / 2,
            100);
            ctPesquisa.Anchor = AnchorStyles.None;

            pnLivro.Location = new Point(
            this.ClientSize.Width / 2 - pnLivro.Size.Width / 2,
            345);
            pnLivro.Anchor = AnchorStyles.None;

            pnLivro.Visible = false;

            ProcessModule objCurrentModule = Process.GetCurrentProcess().MainModule;
            objKeyboardProcess = new LowLevelKeyboardProc(captureKey);
            ptrHook = SetWindowsHookEx(13, objKeyboardProcess, GetModuleHandle(objCurrentModule.ModuleName), 0);
            EnterFullScreenMode(this);
            MinimizeBox = false;
            MaximizeBox = false;
            
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbCategoria.Visible = false;
        }

        /* Code to Disable WinKey, Alt+Tab, Ctrl+Esc Starts Here */

       //Structure contain information about low-level keyboard input event

       [StructLayout(LayoutKind.Sequential)]
        private struct KBDLLHOOKSTRUCT
        {
            public Keys key;
            public int scanCode;
            public int flags;
            public int time;
            public IntPtr extra;
        }
        //System level functions to be used for hook and unhook keyboard input  
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int id, LowLevelKeyboardProc callback, IntPtr hMod, uint dwThreadId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hook);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hook, int nCode, IntPtr wp, IntPtr lp);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string name);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern short GetAsyncKeyState(Keys key);
        //Declaring Global objects     
        private IntPtr ptrHook;
        private LowLevelKeyboardProc objKeyboardProcess;

        private IntPtr captureKey(int nCode, IntPtr wp, IntPtr lp)
        {
            if (nCode >= 0)
            {
                KBDLLHOOKSTRUCT objKeyInfo = (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lp, typeof(KBDLLHOOKSTRUCT));

                // Disabling Windows keys 

                if (objKeyInfo.key == Keys.RWin || objKeyInfo.key == Keys.LWin || objKeyInfo.key == Keys.Tab && HasAltModifier(objKeyInfo.flags) || objKeyInfo.key == Keys.Escape && (ModifierKeys & Keys.Control) == Keys.Control)
                {
                    return (IntPtr)1; // if 0 is returned then All the above keys will be enabled
                }
            }
            return CallNextHookEx(ptrHook, nCode, wp, lp);
        }

        bool HasAltModifier(int flags)
        {
            return (flags & 0x20) == 0x20;
        }

        private void BiblioSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing || e.CloseReason == CloseReason.FormOwnerClosing)
            {
                MessageBox.Show("Computador dedicado para o Biblio Search","Ação inválida",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                e.Cancel = true;
                return;
            }
            base.OnFormClosing(e);
        }
        
        public void EnterFullScreenMode(Form targetForm)
        {
            targetForm.WindowState = FormWindowState.Normal;
            targetForm.FormBorderStyle = FormBorderStyle.None;
            targetForm.WindowState = FormWindowState.Maximized;
        }

        public void LeaveFullScreenMode(Form targetForm)
        {
            targetForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            targetForm.WindowState = FormWindowState.Normal;
        }

        private void BiblioSearch_ResizeBegin(object sender, EventArgs e)
        {
            EnterFullScreenMode(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (contador != 600)
            {
                contador++;
            }
            else
            {
                timer1.Stop();
                LimparPesquisa();
                tbPesquisa.Text = "";
                lbCategoria.Visible = true;
                cbCategoria.SelectedIndex = -1;
                tbPesquisa.Focus();
            }

        }
    }
}
