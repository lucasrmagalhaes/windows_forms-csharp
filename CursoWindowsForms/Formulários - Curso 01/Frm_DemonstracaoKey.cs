using System;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_DemonstracaoKey : Form
    {
        public Frm_DemonstracaoKey()
        {
            InitializeComponent();
        }

        private void Txt_Input_KeyDown(object sender, KeyEventArgs e)
        {
            Txt_Msg.AppendText("\r\n" + "Pressionei uma tecla: " + e.KeyCode + "\r\n");
            Txt_Msg.AppendText("\t" + "Código da tecla: " + ((int)e.KeyCode) + "\r\n");
            Txt_Msg.AppendText("\t" + "Nome da tecla: " + e.KeyData + "\r\n");
            Lbl_Lower.Text = e.KeyCode.ToString().ToLower();
            Lbl_Upper.Text = e.KeyCode.ToString().ToUpper();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Txt_Msg.Text = "";
            Txt_Input.Text = "";
            Lbl_Lower.Text = "";
            Lbl_Upper.Text = "";
        }
    }
}
