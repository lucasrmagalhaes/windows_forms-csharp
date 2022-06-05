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

                ContextMenu.Items.Add(DesenhaItemMenu("Item do Menu 01"));
                ContextMenu.Items.Add(DesenhaItemMenu("Item do Menu 02"));

                ContextMenu.Show(this, new System.Drawing.Point(e.X, e.Y));
            }

            ToolStripMenuItem DesenhaItemMenu(string text)
            {
                var vToolTip = new ToolStripMenuItem();
               
                vToolTip.Text = text;

                return vToolTip;
            }
        }
    }
}
