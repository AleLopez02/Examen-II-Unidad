using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Modelo;
using WindowsFormsApp1.Modelo.DAO;
using WindowsFormsApp1.Vista;

namespace WindowsFormsApp1.Controlador
{
    public class LoginController
    {
        LoginView vista;
        
        public LoginController(LoginView view)
        {
            vista = view;
            vista.IngresarButton.Click += new EventHandler(ValidarUsuario);
        } 

        private void ValidarUsuario(object sender, EventArgs e)
        {
            bool esValido = false;

            if (vista.CorreoTextBox.Text == "")
            {
                MessageBox.Show("Ingrese un correo");
                return;
            }

            if (vista.ClaveTextBox.Text == "")
            {
                MessageBox.Show("Ingrese una clave");
                return;
            }

            UsuarioDAO userDao = new UsuarioDAO();
            Usuario user = new Usuario();

            user.Correo = vista.CorreoTextBox.Text;
            user.Clave = EncriptarClave(vista.ClaveTextBox.Text);

            esValido = userDao.ValidarUsuario(user);

            if (esValido)
            {
                MenuView menu = new MenuView();
                vista.Hide();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto");
            }

        }

        public static string EncriptarClave(string clave)
        {
            string cadena = clave + "MiClavePersonal";
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding enconding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(enconding.GetBytes(cadena));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();

        }

    }
}
