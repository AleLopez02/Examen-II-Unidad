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
    public partial class DetallesView : Form
    {
        public DetallesView()
        {
            InitializeComponent();
            DetallesController contralador = new DetallesController(this);
        }

    }
}
