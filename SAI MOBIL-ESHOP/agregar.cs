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
    public partial class agregar : Form
    {
        public agregar()
        {
            InitializeComponent();
            mostrarDatos();
            tabControl1.TabPages.RemoveByKey("Consultar");
        }

        public void MostrarDatos()
        {
            dataGridView1.Rows.Clear();

            List<ProductList> list = productDB.CheckStock();

            foreach (ProductList product in list)
            {
                dataGridView1.Rows.Add(
                    product.ID_producto,
                    product.Lote,
                    product.Descripcion,
                    product.Precio_Compra,
                    product.Precio_Venta,
                    product.Stock
                );
            }

            list.Clear();
        }
        private void mostrarDatos()
        {
            DataTable datos = productDB.ObtenerTodosLosProductos();
            dataGridView1.DataSource = datos;
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario de inicio de sesión
            home form3 = new home(); // Crea una nueva instancia del Form2
            form3.ShowDialog(); // Muestra el Form2 como un cuadro de diálogo
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int wrong = 0;

            try
            {
                productDB.InsertIntoProductDB(loteTextBox.Text, descripcionTB.Text,
                        double.Parse(precio_ventaTB.Text), double.Parse(precio_compraTB.Text), int.Parse(stockTb.Text));

                loteTextBox.Text = "";
                stockTb.Text = "";
                precio_ventaTB.Text = "";
                precio_compraTB.Text = "";
                descripcionTB.Text = "";


            }
            catch (Exception ex)
            {
                wrong++;
                MessageBox.Show("Error ocurrido al agregar, compruebe los campos"+ex);

                if (wrong >= 3)
                {
                    loteTextBox.Text = "";
                    stockTb.Text = "";
                    precio_ventaTB.Text = "";
                    descripcionTB.Text = "";

                    wrong = 0;
                }

            }
            mostrarDatos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            int Id = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value);
            string Lote = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            string Descripcion = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            string Stock = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();  
            string Precio_pub = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            string Precio_Compra = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            

            modificar pi = new modificar(Id, Lote, Descripcion, Stock, Precio_pub, Precio_Compra);
            pi.Show();
            mostrarDatos();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == checkStockPanel)
            {
                mostrarDatos();

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buscar_Click(object sender, EventArgs e)
        {
            string consulta = txtBusqueda.Text; // Suponiendo que txtBusqueda es tu TextBox de búsqueda
            DataTable datos = productDB.ObtenerProductosPorConsulta(consulta);
            dataGridView1.DataSource = datos;
            txtBusqueda.Text = "";
        }

        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Simular clic en el botón de búsqueda
                buscar.PerformClick();
            }
        }

        private void agregar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                // Establecer el foco en el TextBox de búsqueda
                txtBusqueda.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-97C2SFPH\\MSSQLSERVER02,50991;Initial Catalog=sai-pos;User ID=sa;Password=123;";
            string lote = idBusqueda.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ID_Prod, Lote, Descripcion, Stock, Precio_Venta, Precio_Compra FROM productos WHERE Lote = @Lote";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Lote", lote);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        idLabel.Text = reader["ID_Prod"].ToString();
                        loteLabel.Text = reader["Lote"].ToString();
                        descrLabel.Text = reader["Descripcion"].ToString();
                        stockLabel.Text = reader["Stock"].ToString();
                        precioPLabel.Text = reader["Precio_Venta"].ToString();
                        precioCLabel.Text = reader["Precio_Compra"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un producto con el lote especificado.");
                        // Limpiar los textBox si no se encuentra el lote
                        idLabel.Text = "";
                        loteLabel.Text = "";
                        descrLabel.Text = "";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }

        private void agregar_Load(object sender, EventArgs e)
        {

        }
    }
    
}
