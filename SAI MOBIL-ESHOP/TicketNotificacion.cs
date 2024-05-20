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
    public partial class TicketNotificacion : Form
    {
        public TicketNotificacion()
        {
            InitializeComponent();
        }

        internal void MostrarCambio(double totalPagar, double efectivo)
        {
            double cambio = efectivo - totalPagar;
            cambioLabel.Text = cambio.ToString();
        }
    }
}
