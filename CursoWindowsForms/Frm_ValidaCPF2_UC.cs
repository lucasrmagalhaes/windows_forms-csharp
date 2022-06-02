using CursoWindowsFormsBiblioteca;
using System;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_ValidaCPF2_UC : UserControl
    {
        public Frm_ValidaCPF2_UC()
        {
            InitializeComponent();
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            string vConteudo = Msk_CPF.Text;

            vConteudo = vConteudo.Replace(".", "").Replace("-", "").Trim();

            if (vConteudo == "")
            {
                MessageBox.Show("Informe um CPF", "Mensagem de Validação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (vConteudo.Length != 11)
                {
                    MessageBox.Show("CPF deve ter 11 dígitos", "Mensagem de Validação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Frm_Questao Db = new Frm_Questao();
                    Db.ShowDialog();

                    // if (MessageBox.Show("Você deseja realmente validar o CPF?", "Mensagem de Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    if (Db.DialogResult == DialogResult.Yes)
                    {
                        bool validaCPF = false;

                        validaCPF = Cls_Uteis.ValidaCPF(Msk_CPF.Text);

                        if (validaCPF == true)
                        {
                            MessageBox.Show("CPF Válido!", "Mensagem de Validação",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("CPF Inválido!", "Mensagem de Validação",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            Msk_CPF.Text = "";
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Msk_CPF.Text = "";
        }
    }
}
