using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SAI_MOBIL_ESHOP
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            textBoxContrasena.PasswordChar = '*';
        }
        

        private void loginButton_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = textBoxUsuario.Text;
            string contraseñaIngresada = textBoxContrasena.Text;

            // Hash de la contraseña ingresada para comparación con la base de datos
            string hashedPassword = GetMd5Hash(contraseñaIngresada);

            // Verificar si el usuario existe y la contraseña es correcta
            if (VerificarCredenciales(usuarioIngresado, contraseñaIngresada, hashedPassword))
            {
                // Guardar el usuario en loggerManager
                loggerManager.setLogger(usuarioIngresado);

                this.Hide(); // Oculta el formulario de inicio de sesión
                home form2 = new home(); // Crea una nueva instancia del Form2
                form2.ShowDialog(); // Muestra el Form2 como un cuadro de diálogo
                this.Close();
            }
            else
            {
                // Si no son válidos, mostrar un mensaje de error
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private bool VerificarCredenciales(string username, string password, string hashedPassword)
        {
            try
            {
                // string connectionString = "Data Source=LAPTOP-97C2SFPH\\MSSQLSERVER02,50991;Initial Catalog=sai-pos;User ID=sa;Password=123;";
                
                string connectionString = "Data Source=LAPTOP-97C2SFPH\\MSSQLSERVER02,50991;Initial Catalog=sai-pos;User ID=sa;Password=123;";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // Comprobar primero con la contraseña hasheada
                    string query = "SELECT COUNT(*) FROM vendedores WHERE Nombre = @username AND (Password = @hashedPassword OR Password = @password)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@hashedPassword", hashedPassword);
                        cmd.Parameters.AddWithValue("@password", password);  // Contraseña en texto plano
                        con.Open();
                        int userCount = (int)cmd.ExecuteScalar();
                        return userCount > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar las credenciales: " + ex.Message);
                return false;
            }
        }

        private string GetMd5Hash(string contraseñaIngresada)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(contraseñaIngresada));
                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
                return sBuilder.ToString();
            }
        }

        private void textBoxUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Cambiar el foco al campo de texto de la contraseña
                textBoxContrasena.Focus();
            }
        }

        private void textBoxContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Cambiar el foco al campo de texto de la contraseña
                loginButton.PerformClick();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBoxContrasena.PasswordChar = '\0'; // Carácter nulo para mostrar la contraseña.
            else
                textBoxContrasena.PasswordChar = '*';
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
