using System;
using System.Drawing;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Menu_Flutuante : Form
    {
        public Frm_Menu_Flutuante()
        {
            InitializeComponent();
        }

        private void Frm_Menu_Flutuante_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right) 
            {
                /*
                var PosicaoX = e.X;
                var PosicaoY = e.Y;


                MessageBox.Show(
                    "Cliquei com o botão direito do mouse.\n" +
                    "A posição relativa foi (" + 
                    PosicaoX.ToString() + ", " + PosicaoY.ToString() + ")"
                );
                */

                var ContextMenu = new ContextMenuStrip();

                var vToolTip001 = DesenhaItemMenu("Item do Menu 01", "key");
                var vToolTip002 = DesenhaItemMenu("Item do Menu 02", "Frm_ValidaSenha");

                ContextMenu.Items.Add(vToolTip001);
                ContextMenu.Items.Add(vToolTip002);

                ContextMenu.Show(this, new System.Drawing.Point(e.X, e.Y));

                vToolTip001.Click += new System.EventHandler(vToolTip001_Click);
                vToolTip002.Click += new System.EventHandler(vToolTip002_Click);
            }

            void vToolTip001_Click(object sender1, EventArgs e1)
            {
                MessageBox.Show("Selecionei a opção do menu 001.");
            }

            void vToolTip002_Click(object sender2, EventArgs e2)
            {
                MessageBox.Show("Selecionei a opção do menu 002.");
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
}
