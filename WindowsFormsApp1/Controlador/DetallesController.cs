using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Modelo.DAO;
using WindowsFormsApp1.Vista;

namespace WindowsFormsApp1.Controlador
{
    public class DetallesController
    {
        DetallesView detallesVista;
        ClienteDAO clientDAO = new ClienteDAO();

        public DetallesController(DetallesView view)
        {
            detallesVista = view;
            detallesVista.Load += new EventHandler(CargarClientes);

            if (detallesVista.ClienteDataGridView != null)
            {
                detallesVista.ActualizarButton.Click += new EventHandler(CargarClientes);
            }
            
        }

        public void CargarClientes(object sender, EventArgs e)
        {
            ListarClientes(clientDAO);
        }

        public void ListarClientes(ClienteDAO client)
        {
            detallesVista.ClienteDataGridView.DataSource = client.GetClientes();
        }

    }
}
