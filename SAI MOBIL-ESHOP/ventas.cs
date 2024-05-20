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
    public partial class ventas : Form
    {
        public ventas()
        {
            InitializeComponent();
            mostrarDatos();
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Efectivo.Text))
            {
                MessageBox.Show("Ingresa el Efectivo");
            }
            else
            {
                RegistrarVenta();
                RegistrarDetVenta();
                DisminuirExistencias();

                string totalStr = billLabel.Text;
                double total = double.Parse(totalStr);

                LimpiarTablaCarrito();
                mostrarDatos();
                TicketNotificacion ticket = new TicketNotificacion();
                ticket.Show();
                ticket.MostrarCambio(total, double.Parse(Efectivo.Text));
                //sellButon.Enabled = !string.IsNullOrWhiteSpace(Efectivo.Text);
                Efectivo.Text = "";
                billLabel.Text = "";
            }
        }

        private void LimpiarTablaCarrito()
        {
            cartItemTable.Rows.Clear();
        }

        private void DisminuirExistencias()
        {
            int rowCount = cartItemTable.RowCount;

            // Iterar sobre todas las filas
            for (int rowIndex = 0; rowIndex < rowCount; rowIndex++)
            {
                // Obtener los valores de las columnas 4 y 7 de la fila actual
                int qty = int.Parse(cartItemTable.Rows[rowIndex].Cells[3].Value.ToString());
                int stock = int.Parse(cartItemTable.Rows[rowIndex].Cells[5].Value.ToString());

                // Realizar operaciones con los valores obtenidos
                int qtyTester = stock - qty;
                productDB.SellProductDB(int.Parse(cartItemTable.Rows[rowIndex].Cells[0].Value.ToString()), qtyTester);
            }
        }

        private void RegistrarDetVenta()
        {
            int rowCount = cartItemTable.RowCount;

            // Iterar sobre todas las filas
            for (int rowIndex = 0; rowIndex < rowCount; rowIndex++)
            {
                // Obtener los valores de las columnas de la fila actual
                int idVenta = VentaDB.ObtenerNumeroVentaActual() - 1;
                int idProducto = int.Parse(cartItemTable.Rows[rowIndex].Cells[0].Value.ToString());
                int cantidad = int.Parse(cartItemTable.Rows[rowIndex].Cells[3].Value.ToString());
                double precioUnitario = double.Parse(cartItemTable.Rows[rowIndex].Cells[2].Value.ToString());
                double subTotal = precioUnitario * cantidad;

                // Registrar los detalles de venta para el producto actual
                VentaDB.RegistrarDetallesVenta(idVenta, idProducto, cantidad, precioUnitario, subTotal);
            }
        }

        private void RegistrarVenta()
        {
            string totalString = billLabel.Text;
            double total = double.Parse(totalString);
            //VentaDB.insertIntoVentaDB(total, LoggerManager.getLogger());  
            VentaDB.InsertIntoVentaDB(total, loggerManager.getLogger(), Efectivo.Text);
        }

        private void mostrarDatos()
        {
            DataTable datos = productDB.ObtenerTodosLosProductos();
            tablaProductos.DataSource = datos;
        }

        private void tablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = tablaProductos.SelectedCells[0].RowIndex;

            string ID = tablaProductos.Rows[rowIndex].Cells[0].Value.ToString();
            string descripcion = tablaProductos.Rows[rowIndex].Cells[2].Value.ToString();
            string Stock = tablaProductos.Rows[rowIndex].Cells[5].Value.ToString();
            double precio = double.Parse(tablaProductos.Rows[rowIndex].Cells[3].Value.ToString());
            int numeroVentaActual = VentaDB.ObtenerNumeroVentaActual();
            //int numeroVentaActual =1;

            object cantidad = 1;

            // Obtener la cantidad disponible del producto seleccionado
            int existencia = int.Parse(tablaProductos.Rows[rowIndex].Cells[3].Value.ToString());

            // Verificar si el producto ya existe en el carrito
            int existingRowIndex = -1;
            foreach (DataGridViewRow row in cartItemTable.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == ID)
                {
                    existingRowIndex = row.Index;
                    break;
                }
            }

            if (existingRowIndex != -1)
            {
                // El producto ya existe en el carrito, actualizar la cantidad
                int existingCantidad = int.Parse(cartItemTable.Rows[existingRowIndex].Cells[3].Value.ToString());
                int newCantidad = existingCantidad + 1;
                if (newCantidad >= 3)
                {
                    // Mostrar un cuadro de diálogo para solicitar la cantidad deseada
                    //string input = Microsoft.VisualBasic.Interaction.InputBox("¿Cuántos productos deseas agregar?", "Agregar productos", "1");
                    try
                    {
                        //newCantidad = int.Parse(input);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Cantidad inválida. Se mantendrá la cantidad actual.");
                        cantidad = existingCantidad; // Mantener la cantidad actual
                        return;
                    }
                }
                // Verificar si la nueva cantidad supera la existencia
                if (newCantidad > existencia)
                {
                    MessageBox.Show("No hay suficientes existencia!");
                    cantidad = existingCantidad;
                    return; // Detener la ejecución del código
                }
                cartItemTable.Rows[existingRowIndex].Cells[3].Value = newCantidad;
                // Actualizar el subtotal
                double subtotal = precio * newCantidad;
                cartItemTable.Rows[existingRowIndex].Cells[4].Value = subtotal;
            }
            else
            {
                // El producto no existe en el carrito, agregar nueva fila
                // Verificar si la cantidad supera la existencia
                if (1 > existencia)
                {
                    MessageBox.Show("No hay más en existencia xd!");
                    return; // Detener la ejecución del código
                }
                double Cant = 1;
                double subtotal = precio * Cant;
                cartItemTable.Rows.Add(ID, descripcion, precio, cantidad, subtotal, Stock, numeroVentaActual);
            }

            // Actualizar el total del precio
            TotalPagar();
            MessageBox.Show("Producto añadido a carrito!");
            mostrarDatos();
        }

        private void TotalPagar()
        {
            double total = 0.0;
            foreach (DataGridViewRow row in cartItemTable.Rows)
            {
                if (row.Cells[2].Value != null && row.Cells[3].Value != null && row.Cells[5].Value != null)
                {
                    double precioProducto = double.Parse(row.Cells[2].Value.ToString());
                    int cantidadProducto = int.Parse(row.Cells[3].Value.ToString());
                    total += precioProducto * cantidadProducto;
                }
            }
            billLabel.Text = total.ToString();
        }

        private void delEntry_Click(object sender, EventArgs e)
        {
            cartItemTable.Rows.Clear();
            billLabel.Text = "";
            Efectivo.Text = "";
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica si la pestaña seleccionada es la pestaña de facturación
            if (tabControl1.SelectedTab == billingPanel)
            {
                MostrarVentas();

            }
        }

        private void MostrarVentas()
        {
            DataTable datos = VentaDB.ObtenerTodasLasVentas(); //Solo solicitar todo alv
            billingTable.DataSource = datos; 
        }

        private void billingTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = billingTable.SelectedCells[0].RowIndex;

            int ID_Venta = Convert.ToInt32(billingTable.Rows[rowIndex].Cells[0].Value);
            int Total = Convert.ToInt32(billingTable.Rows[rowIndex].Cells[2].Value);
            string Fecha = billingTable.Rows[rowIndex].Cells[1].Value.ToString();
            string Vendedor = billingTable.Rows[rowIndex].Cells[4].Value.ToString();
            string Efectivo = billingTable.Rows[rowIndex].Cells[3].Value.ToString();

            DetallesVenta dtv = new DetallesVenta(ID_Venta, Total, Fecha, Vendedor, Efectivo);
            dtv.Show();
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            home form3 = new home();
            form3.ShowDialog();
            this.Close();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            string consulta = textBox1.Text; // Suponiendo que txtBusqueda es tu TextBox de búsqueda
            DataTable datos = productDB.ObtenerProductosPorConsulta(consulta);
            tablaProductos.DataSource = datos;
            textBox1.Text = "";
        }
    }
}
