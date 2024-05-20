using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace SAI_MOBIL_ESHOP
{
    public class TicketPrinter : PrintDocument
    {
        private string ticketContent;
        private VariablesParaImprimirTicket instanciaTicket = VariablesParaImprimirTicket.getInstancia();
        private int currentPageIndex = 0;

        public TicketPrinter(string ticketContent)
        {
            this.ticketContent = ticketContent;
        }

        public void PrintTicket()
        {
            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = this;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Print();
            }
        }

        protected override void OnPrintPage(PrintPageEventArgs e)
        {
            base.OnPrintPage(e);

            Graphics g = e.Graphics;
            Font font = new Font("Arial", 7);
            float lineHeight = font.GetHeight(g) + 1;
            float startX = 5;
            float startY = e.MarginBounds.Top;

            // Dibujar imagen del logo (comentado)


            // Dibujar el título "Ticket de venta" en el centro del ticket
            string title = "Ticket de venta";
            SizeF titleSize = g.MeasureString(title, font);
            g.DrawString(title, font, Brushes.Black, (e.PageBounds.Width - titleSize.Width) / 2, startY);
            startY += titleSize.Height + 10;

            // Dibujar detalles de la venta
            g.DrawString(instanciaTicket.getLinea1(), font, Brushes.Black, startX, startY);
            startY += 15;
            g.DrawString(instanciaTicket.getCalle(), font, Brushes.Black, startX, startY);
            startY += 15;
            g.DrawString(instanciaTicket.getTelefono(), font, Brushes.Black, startX, startY);
            startY += 15;
            g.DrawString("Numero de Factura: " + instanciaTicket.getCodigoVenta(), font, Brushes.Black, startX, startY);
            startY += 15;
            g.DrawString("Fecha y Hora: " + instanciaTicket.getFechaVenta(), font, Brushes.Black, startX, startY);
            startY += 15;
            g.DrawString("Atendido por: " + instanciaTicket.getVendedor(), font, Brushes.Black, startX, startY);
            startY += 5;
            g.DrawString(instanciaTicket.getLinea3(), font, Brushes.Black, startX, startY);
            startY += 10;
            g.DrawString("|Descripcion|Cantidad|Subtotal", font, Brushes.Black, startX, startY);
            startY += 10;
            //g.DrawString("Precio Unitario|Subtotal", font, Brushes.Black, startX, startY);
            //startY += 3;
            g.DrawString("_____________________________", font, Brushes.Black, startX, startY);
            startY += 15;

            // Imprimir cada línea del texto
            string[] lines = instanciaTicket.getProductosLista().Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            for (int i = 0; i < lines.Length; i++)
            {
                g.DrawString(lines[i], font, Brushes.Black, startX, startY);
                startY += lineHeight; // Incrementar la posición Y para la próxima línea
            }

            string ImporteCambio = instanciaTicket.getImporte() + instanciaTicket.getTotalVenta();

            startY += 3;
            g.DrawString("_____________________________", font, Brushes.Black, startX, startY);
            startY += 20;
            g.DrawString("Total a Pagar: $" + instanciaTicket.getTotalVenta(), font, Brushes.Black, startX, startY);
            startY += 10;
            g.DrawString("Efectivo: $" + instanciaTicket.getImporte(), font, Brushes.Black, startX, startY);
            startY += 10;
            double total = Double.Parse(instanciaTicket.getTotalVenta());
            double efectivo = Double.Parse(instanciaTicket.getImporte());
            double cambio = efectivo - total;
            g.DrawString("Cambio: $" + cambio, font, Brushes.Black, startX, startY);
            startY += 15;
            g.DrawString("Gracias Por Su Preferencia", font, Brushes.Black, startX, startY);
            startY += 10;
        }


    }
}