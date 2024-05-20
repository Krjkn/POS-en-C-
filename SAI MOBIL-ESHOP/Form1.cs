using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAI_MOBIL_ESHOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static SqlConnection GetSqlConnection()
        {
            string connectionString = "Data Source=LAPTOP-97C2SFPH\\MSSQLSERVER02,50991;Initial Catalog=sai-pos;User ID=sa;Password=123;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = GetSqlConnection();

            if (connection.State == ConnectionState.Open)
            {
                MessageBox.Show("Conexión establecida correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al establecer la conexión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
