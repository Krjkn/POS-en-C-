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

namespace SAI_MOBIL_ESHOP
{
    public partial class Usuarios : Form
    {
        string usuarioIniciado = loggerManager.getLogger();
        public Usuarios()
        {
            InitializeComponent();
            string usuarioIniciado = loggerManager.getLogger();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int wrong = 0;

            try
            {
                // Suponiendo que existen TextBoxes con estos nombres para capturar la información del usuario
                string nombre = nombretextBox.Text;
                string email = emailtextBox.Text;
                string password = passwordtextBox.Text;
                string confirmPassword = passwordtextBox2.Text;

                if (password != confirmPassword)
                {
                    MessageBox.Show("Las contraseñas no coinciden.");
                    return; // Salir del método si las contraseñas no coinciden
                }
                string hashedPassword = GetMd5Hash(password);
                // Llamada a la función que inserta en la base de datos de vendedores
                productDB.InsertIntoVendedoresDB(nombre, email, hashedPassword);

                // Limpiar los TextBoxes después de la inserción
                nombretextBox.Text = "";
                emailtextBox.Text = "";
                passwordtextBox.Text = "";
                passwordtextBox2.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ocurrido: " + ex.Message);
                wrong++;
                if (wrong >= 3)
                {
                    nombretextBox.Text = "";
                    emailtextBox.Text = "";
                    passwordtextBox.Text = "";
                    passwordtextBox2.Text = "";
                    wrong = 0;
                }
            }
        }
        public static string GetMd5Hash(string input)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                
                StringBuilder sBuilder = new StringBuilder();

                
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                // Devolver el string hexadecimal.
                return sBuilder.ToString();
            }
        }

        private void ActualizarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Recuperar las contraseñas de los TextBoxes
            string newPassword = resetTextBox.Text;
            string confirmNewPassword = resetTextBox2.Text;

            // Verificar que las contraseñas coincidan
            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            // Hash de la nueva contraseña
            string hashedPassword = GetMd5Hash(newPassword);

            // Obtener el nombre de usuario desde loggerManager
            string username = loggerManager.getLogger();
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("No se ha especificado un usuario para actualizar.");
                return;
            }

            // Actualizar la contraseña en la base de datos
            if (UpdateUserPassword(username, hashedPassword))
            {
                MessageBox.Show("Contraseña actualizada con éxito.");
            }
            else
            {
                MessageBox.Show("Error al actualizar la contraseña.");
            }
            resetTextBox.Text = "";
            resetTextBox2.Text = "";
        }

        private bool UpdateUserPassword(string username, string hashedPassword)
        {
            try
            {
                string connectionString = "server=DESKTOP-8828HBH  ; database=sai-pos ; integrated security = true";
                SqlConnection con = new SqlConnection(connectionString);
                {
                    string query = "UPDATE vendedores SET Password = @password WHERE Nombre = @username";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                        cmd.Parameters.AddWithValue("@username", username);
                        con.Open();
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la contraseña: " + ex.Message);
                return false;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == ActualizarUsuario)
            {

                string username = loggerManager.getLogger();
                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("No hay un usuario especificado para actualizar.");
                    return;
                }

                // Comprobar si el usuario existe en la base de datos
                if (productDB.UserExists(username))
                {
                    // Usuario encontrado, permitir actualizar contraseña
                    MessageBox.Show("Hola " + usuarioIniciado + ". Proceda a cambiar la contraseña.");
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado.");
                }
            }
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            home form3 = new home();
            form3.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
