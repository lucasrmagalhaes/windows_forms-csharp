using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class btn : Form
    {
        public btn()
        {
            InitializeComponent();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            string mouseEvent = e.Button.ToString();

            MessageBox.Show("Foi pressionado o botão da(o) " + mouseEvent);
        }
    }
}
