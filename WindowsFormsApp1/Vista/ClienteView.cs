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
    public partial class ClienteView : Form
    {
        public ClienteView()
        {
            InitializeComponent();
            ClienteController controlador = new ClienteController(this);
        }

        private void ClienteView_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {

        }

        private void CorreoLabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
