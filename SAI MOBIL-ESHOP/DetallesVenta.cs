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
    public partial class DetallesVenta : Form
    {
        int tktidventa;
        int tkttotal;
        string tktfecha;
        string tktvendedor;
        string tktEfectivo;


        private string ticketContent;
        private VariablesParaImprimirTicket variablesTicket;

        VariablesParaImprimirTicket instanciaTicket = VariablesParaImprimirTicket.getInstancia();
        public DetallesVenta(int idVenta, int Total, string Fecha, string Vendedor, string Efectivo)
        {
            this.tktidventa = idVenta;
            this.tktfecha = Fecha;
            this.tkttotal = Total;
            this.tktvendedor = Vendedor;
            this.tktEfectivo = Efectivo;

            variablesTicket = VariablesParaImprimirTicket.getInstancia();
            InitializeComponent();

            detallesTabla.Rows.Clear();
            List<string> productos = new List<string>();
            List<detVentaObject> list = new List<detVentaObject>();
            list = VentaDB.obtenerDetallesVenta(idVenta);

            foreach (detVentaObject item in list)
            {
                object[] data = new object[]
                {
            item.idVenta,
            item.idProducto,
            item.descripcion,
            item.cantidad,
            item.precioUnitario,
            item.subtotal,
            item.vendedor // Agrega el campo "vendedor"
                };

                int cantidadProductos = detallesTabla.Rows.Count;
                variablesTicket.setCantidadProductos(cantidadProductos.ToString());
                variablesTicket.setVendedor(Vendedor);



                detallesTabla.Rows.Add(data);

                string productoData = item.descripcion + ", " +
                                      item.cantidad + " pz, $" +
                                      item.subtotal;

                productos.Add(productoData);
            }
            variablesTicket.setFechaVenta(Fecha);
            variablesTicket.setTotalVenta(Total.ToString());
            variablesTicket.setCodigoVenta(idVenta.ToString());
            variablesTicket.setImporte(Efectivo);

            string productosLista = string.Join("\n", productos);
            variablesTicket.setProductosLista(productosLista);

            Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void detallesTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printButton_Click(object sender, EventArgs e)
        {
            TicketPrinter ticketPrinter = new TicketPrinter(ticketContent);
            ticketPrinter.PrintTicket();
        }
    }
}
