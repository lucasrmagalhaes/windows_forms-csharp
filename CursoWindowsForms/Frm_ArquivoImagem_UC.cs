using System.Drawing;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_ArquivoImagem_UC : UserControl
    {
        public Frm_ArquivoImagem_UC(string nomeArquivoImagem)
        {
            InitializeComponent();

            Lbl_ArquivoImagem.Text = nomeArquivoImagem;
            Pic_ArquivoImagem.Image = Image.FromFile(nomeArquivoImagem);
        }

        private void Btn_Cor_Click(object sender, System.EventArgs e)
        {
            ColorDialog Cdb = new ColorDialog();

            if (Cdb.ShowDialog() == DialogResult.OK)
            {
                Lbl_ArquivoImagem.ForeColor = Cdb.Color;
            }
        }

        private void Btn_Fonte_Click(object sender, System.EventArgs e)
        {
            FontDialog Fdb = new FontDialog();

            if (Fdb.ShowDialog() == DialogResult.OK)
            {
                Lbl_ArquivoImagem.Font = Fdb.Font;
            }
        }
    }
}
