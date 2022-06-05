using System;
using System.Drawing;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Principal_Menu_UC : Form
    {
        int ControleDemonstracaoKey = 0;
        int ControleHelloWorld = 0;
        int ControleValidaCPF2 = 0;
        int ControleArquivoImagem = 0;

        public Frm_Principal_Menu_UC()
        {
            InitializeComponent();

            novoToolStripMenuItem1.Enabled = false;
            apagarAbaToolStripMenuItem.Enabled = false;
            sairToolStripMenuItem1.Enabled = false;
            açõesToolStripMenuItem.Enabled = false;
            abrirImagemToolStripMenuItem.Enabled = false;
            windowsToolStripMenuItem.Enabled = false;
            desconectarToolStripMenuItem.Enabled = false;
        }

        private void deToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleDemonstracaoKey += 1;

            Frm_DemonstracaoKey_UC U = new Frm_DemonstracaoKey_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Demonstração Key " + ControleDemonstracaoKey;
            TB.Text = "Demonstração Key " + ControleDemonstracaoKey;
            TB.ImageIndex = 0;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleHelloWorld += 1;

            Frm_HelloWorld_UC U = new Frm_HelloWorld_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Hello World " + ControleHelloWorld;
            TB.Text = "Hello World " + ControleHelloWorld;
            TB.ImageIndex = 1;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void máscaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mascara frm_Mascara = new Frm_Mascara();
            frm_Mascara.ShowDialog();
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF frm_ValidaCPF = new Frm_ValidaCPF();
            frm_ValidaCPF.ShowDialog();
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCPF2 += 1;

            Frm_ValidaCPF2_UC U = new Frm_ValidaCPF2_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Valida CPF 2 " + ControleValidaCPF2;
            TB.Text = "Valida CPF 2 " + ControleValidaCPF2;
            TB.ImageIndex = 0;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaSenha frm_ValidaSenha = new Frm_ValidaSenha();
            frm_ValidaSenha.ShowDialog();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void apagarAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);
            }
        }

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Db = new OpenFileDialog();

            Db.InitialDirectory = "C:\\Users\\Lucas\\Desktop\\windows_forms-csharp\\CursoWindowsForms\\Imagens";
            Db.Filter = "PNG|*.PNG";
            Db.Title = "Escolha a Imagem";

            if (Db.ShowDialog() == DialogResult.OK)
            {
                string nomeArquivoImagem = Db.FileName;

                ControleArquivoImagem += 1;

                Frm_ArquivoImagem_UC U = new Frm_ArquivoImagem_UC(nomeArquivoImagem);
                
                U.Dock = DockStyle.Fill;
                
                TabPage TB = new TabPage();

                TB.Name = "Arquivo Imagem " + ControleArquivoImagem;
                TB.Text = "Arquivo Imagem " + ControleArquivoImagem;
                TB.ImageIndex = 6;
                TB.Controls.Add(U);
                
                Tbc_Aplicacoes.TabPages.Add(TB);
            }
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login F = new Frm_Login();
            
            F.ShowDialog();

            if (F.DialogResult == DialogResult.OK)
            {
                string login = F.login;
                string senha = F.senha;

                if (CursoWindowsFormsBiblioteca.Cls_Uteis.validaSenhaLogin(senha) == true)
                {
                    novoToolStripMenuItem1.Enabled = true;
                    apagarAbaToolStripMenuItem.Enabled = true;
                    sairToolStripMenuItem1.Enabled = true;
                    açõesToolStripMenuItem.Enabled = true;
                    abrirImagemToolStripMenuItem.Enabled = true;
                    windowsToolStripMenuItem.Enabled = true;
                    desconectarToolStripMenuItem.Enabled = true;

                    conectarToolStripMenuItem.Enabled = false;

                    MessageBox.Show("Bem-vindo " + login + " !", "Mensagem",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Senha inválida!", "Mensagem",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Questao Db = new Frm_Questao("icons8_question_mark_96", "Você deseja se desconectar?");
            
            Db.ShowDialog();

            if (Db.DialogResult == DialogResult.Yes)
            {
                for (int i = Tbc_Aplicacoes.TabPages.Count - 1; i >= 0; i += -1)
                {
                    Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.TabPages[i]);
                }

                novoToolStripMenuItem1.Enabled = false;
                apagarAbaToolStripMenuItem.Enabled = false;
                sairToolStripMenuItem1.Enabled = false;
                açõesToolStripMenuItem.Enabled = false;
                abrirImagemToolStripMenuItem.Enabled = false;
                windowsToolStripMenuItem.Enabled = false;
                desconectarToolStripMenuItem.Enabled = false;

                conectarToolStripMenuItem.Enabled = true;
            }
        }

        private void Tbc_Aplicacoes_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var ContextMenu = new ContextMenuStrip();

                var vToolTip001 = DesenhaItemMenu("Apagar a aba", "DeleteTab");
                var vToolTip002 = DesenhaItemMenu("Apagar todas a esquerda", "DeleteLeft");
                var vToolTip003 = DesenhaItemMenu("Apagar todas a direita", "DeleteRight");
                var vToolTip004 = DesenhaItemMenu("Apagar todas menos esta", "DeleteAll");

                ContextMenu.Items.Add(vToolTip001);
                ContextMenu.Items.Add(vToolTip002);
                ContextMenu.Items.Add(vToolTip003);
                ContextMenu.Items.Add(vToolTip004);

                ContextMenu.Show(this, new System.Drawing.Point(e.X, e.Y));

                vToolTip001.Click += new System.EventHandler(vToolTip001_Click);
                vToolTip002.Click += new System.EventHandler(vToolTip002_Click);
                vToolTip003.Click += new System.EventHandler(vToolTip003_Click);
                vToolTip004.Click += new System.EventHandler(vToolTip004_Click);
            }
        }

        void vToolTip001_Click(object sender1, EventArgs e1)
        {

        }

        void vToolTip002_Click(object sender2, EventArgs e2)
        {
            
        }

        void vToolTip003_Click(object sender3, EventArgs e3)
        {

        }

        void vToolTip004_Click(object sender4, EventArgs e4)
        {

        }

        ToolStripMenuItem DesenhaItemMenu(string texto, string nomeImagem)
        {
            var vToolTip = new ToolStripMenuItem();

            vToolTip.Text = texto;

            Image MinhaImagem = (Image)global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(nomeImagem);

            vToolTip.Image = MinhaImagem;

            return vToolTip;
        }
    }
}
