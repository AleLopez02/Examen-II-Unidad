using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1.Vista
{
    public partial class MenuView : Syncfusion.Windows.Forms.Office2010Form
    {
        public MenuView()
        {
            InitializeComponent();
        }

        private void MenuView_Load(object sender, EventArgs e)
        {

        }

        ClienteView clienteVista;
        DetallesView detallesVista;
        EstadosView estadosVista;

        private void TicketstoolStripTabItem3_Click(object sender, EventArgs e)
        {
            if (clienteVista == null)
            {
                clienteVista = new ClienteView();
                clienteVista.MdiParent = this;
                clienteVista.FormClosed += ClienteVista_FormClosed;
                clienteVista.Show();
            }
            else
            {
                clienteVista.Activate();
            }
            
        }

        private void ClienteVista_FormClosed(object sender, FormClosedEventArgs e)
        {
           clienteVista = null;
        }

        private void DetallestoolStripTabItem4_Click(object sender, EventArgs e)
        {
            if (detallesVista == null)
            {
                detallesVista = new DetallesView();
                detallesVista.MdiParent = this;
                detallesVista.FormClosed += DetallesVista_FormClosed;
                detallesVista.Show();
                
            }
            else
            {
                detallesVista.Activate();
            }
        }

        private void DetallesVista_FormClosed(object sender, FormClosedEventArgs e)
        {
            detallesVista = null;
        }

        private void EstadostoolStripTabItem2_Click(object sender, EventArgs e)
        {
            if (estadosVista == null)
            {
                estadosVista = new EstadosView();
                estadosVista.MdiParent = this;
                estadosVista.FormClosed += EstadosVista_FormClosed;
                estadosVista.Show();

            }
            else
            {
                estadosVista.Activate();
            }
        }

        private void EstadosVista_FormClosed(object sender, FormClosedEventArgs e)
        {
            estadosVista = null;
        }
    }
}
