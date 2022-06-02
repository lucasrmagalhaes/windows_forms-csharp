using System;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();

            Lbl_Login.Text = "Usuário";
            Lbl_Password.Text = "Senha";

            Btn_OK.Text = "OK";
            Btn_Cancel.Text = "Cancel"; 
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
