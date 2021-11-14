using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controlador;

namespace WindowsFormsApp1.Vista
{
    public partial class LoginView : Form
    {
        internal object errorProvider1;

        public LoginView()
        {
            InitializeComponent();
            LoginController controlador = new LoginController(this);
        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }

        private void BienvenidoLabel_Click(object sender, EventArgs e)
        {

        }

        private void CorreoLabel_Click(object sender, EventArgs e)
        {

        }

        private void ClaveLabel_Click(object sender, EventArgs e)
        {

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {

        }

        private void IngresarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
