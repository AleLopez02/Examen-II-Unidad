using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Modelo.DAO;
using WindowsFormsApp1.Modelo.Entidades;
using WindowsFormsApp1.Vista;

namespace WindowsFormsApp1.Controlador
{
    public class ClienteController
    {
        ClienteView clienteVista;
        
        ClienteDAO clientDAO = new ClienteDAO();
        Cliente client = new Cliente();

        string opcion = string.Empty;

        public ClienteController(ClienteView view)
        {
            clienteVista = view;
            clienteVista.NuevoButton.Click += new EventHandler(Nuevo);
            clienteVista.RegistrarButton.Click += new EventHandler(InsertarUsuario);
            clienteVista.CancelarButton.Click += new EventHandler(LimpiarControles);
            clienteVista.Load += new EventHandler(Load);
        }

        private void Nuevo(object sender, EventArgs e)
        {
            LimpiarControles();
            HabilitarControles();
            opcion = "Nuevo";
        }

        private void Load(object sender, EventArgs e)
        {
            DeshabilitarControles();
        }

        private void InsertarUsuario(object sender, EventArgs e)
        {
            if (clienteVista.NombreTextBox.Text == "")
            {
                MessageBox.Show("Ingrese un nombre");
                return;
            }
            if (clienteVista.CorreoTextBox.Text == "")
            {
                MessageBox.Show("Ingrese un correo");
                return;
            }
            if (clienteVista.ServicioComboBox.Text == "")
            {
                MessageBox.Show("Ingrese un servicio");
                return;
            }

            client.Nombre = clienteVista.NombreTextBox.Text;
            client.Correo = clienteVista.CorreoTextBox.Text;
            client.Servicio = clienteVista.ServicioComboBox.Text;
            client.TipoTicket = "En Espera";

            if (opcion == "Nuevo")
            {
                bool inserto = clientDAO.InsertarCliente(client);

                if (inserto)
                {
                    LimpiarControles();
                    DeshabilitarControles();
                    MessageBox.Show("Cliente registrado con éxito");
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el cliente");
                }
            }
            
        }
   
        private void LimpiarControles()
        {
            clienteVista.NombreTextBox.Clear();
            clienteVista.CorreoTextBox.Clear();
            clienteVista.ServicioComboBox.Text = string.Empty;
        }
        private void HabilitarControles()
        {
            clienteVista.NombreTextBox.Enabled = true;
            clienteVista.CorreoTextBox.Enabled = true;
            clienteVista.ServicioComboBox.Enabled = true;
        }
        private void DeshabilitarControles()
        {
            clienteVista.NombreTextBox.Enabled = false;
            clienteVista.CorreoTextBox.Enabled = false;
            clienteVista.ServicioComboBox.Enabled = false;
        }
        private void LimpiarControles(object sender, EventArgs e)
        {
            clienteVista.NombreTextBox.Clear();
            clienteVista.CorreoTextBox.Clear();
            clienteVista.ServicioComboBox.Text = string.Empty;
        }

    }
}
