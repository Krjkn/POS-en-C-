using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAI_MOBIL_ESHOP
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
            conexionToolStripMenuItem.Visible = false; //No borrar, oculta la conexion del menú
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            agregar form3 = new agregar();
            form3.ShowDialog();
            this.Close();
        }

        private void conexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form3 = new Form1();
            form3.ShowDialog();
            this.Close();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventas form3 = new ventas();
            form3.ShowDialog();
            this.Close();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loggerManager.resetLogger();
            this.Hide(); // Oculta el formulario de inicio de sesión
            login form3 = new login(); // Crea una nueva instancia del Form2
            form3.ShowDialog(); // Muestra el Form2 como un cuadro de diálogo
            this.Close();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios form3 = new Usuarios();
            form3.ShowDialog();
            this.Close();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }
    }
}
