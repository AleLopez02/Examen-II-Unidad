using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Modelo.DAO;
using WindowsFormsApp1.Modelo.Entidades;
using WindowsFormsApp1.Vista;

namespace WindowsFormsApp1.Controlador
{
    public class EstadosController
    {
        EstadosView estadosVista;
        ClienteDAO clientDAO = new ClienteDAO();
        Cliente client = new Cliente();
        int pos;

        public EstadosController(EstadosView vista)
        {
            estadosVista = vista;
            estadosVista.EstadosdataGridView1.DataSource = clientDAO.GetClientes();
            estadosVista.Load += new EventHandler(Load);
            estadosVista.ModificarButton.Click += new EventHandler(Modificar);
            estadosVista.GuardarButton.Click += new EventHandler(Guardar);
        }

        private void Load(object sender, EventArgs e)
        {
            DeshabilitarControl();
        }

        private void Modificar(object sender, EventArgs e)
        {
            if (estadosVista.EstadosdataGridView1.SelectedRows.Count > 0)
            {
                estadosVista.EstadosComboBox.Text = estadosVista.EstadosdataGridView1.CurrentRow.Cells["TIPOTICKET"].Value.ToString();
                pos = estadosVista.EstadosdataGridView1.CurrentRow.Index;
            }
            HabilitarControl();
        }


        private void Guardar(object sender, EventArgs e)
        {
            estadosVista.EstadosdataGridView1[3, pos].Value = estadosVista.EstadosComboBox.Text;
            client.TipoTicket = estadosVista.EstadosComboBox.Text;

            bool modifico = clientDAO.ActualizarTicket(client);

            if (modifico)
            {
                MessageBox.Show("Modificación exitosa");
            }
            else
            {
                MessageBox.Show("No se pudo modificar el estado del ticket");
            }
            DeshabilitarControl();
            LimpiarControl();
        }

        private void HabilitarControl()
        {
            estadosVista.EstadosComboBox.Enabled = true;
        }
        private void DeshabilitarControl()
        {
            estadosVista.EstadosComboBox.Enabled = false;
        }
        private void LimpiarControl()
        {
            estadosVista.EstadosComboBox.Text = string.Empty;
        }
    }
}
