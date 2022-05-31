using System;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_ValidaCPF2 : Form
    {
        public Frm_ValidaCPF2()
        {
            InitializeComponent();
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja realmente validar o CPF?", "Mensagem de Validação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

            Msk_CPF.Text = "";
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Msk_CPF.Text = "";
        }
    }
}
