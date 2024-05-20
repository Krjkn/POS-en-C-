using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SAI_MOBIL_ESHOP
{
    public partial class modificar : Form
    {
        private int id;
        private string lote;
        private string descripcion;
        private string stock;
        private string precio_pub;
        private string precio_Compra;

        public modificar(int id, string lote, string descripcion, string stock, string precio_pub, string precio_Compra)
        {
            InitializeComponent();
            label1.Visible = false;
            idLabel.Visible = false;
            this.id = id;
            this.lote = lote;
            this.descripcion = descripcion;
            this.stock = stock;
            this.precio_pub = precio_pub;
            this.precio_Compra = precio_Compra;
            try
            {
                idLabel.Text = id.ToString();
                loteLabel.Text = lote;
                descrLabel.Text = descripcion;
                stockLabel.Text = stock;
                precioPLabel.Text = precio_pub;
                precioCLabel.Text = precio_Compra;
            }
            catch (FormatException ex)
            {
                // Manejo de error si la fecha no está en el formato esperado
                MessageBox.Show("Error al convertir la fecha: " + ex.Message);
            }
            // Establecer otras configuraciones si es necesario
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textID_Click(object sender, EventArgs e)
        {

        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            productDB.actualizarProducto(loteLabel.Text, descrLabel.Text,
                                    double.Parse(precioPLabel.Text), double.Parse(precioCLabel.Text),
                                    int.Parse(stockLabel.Text),
                                    int.Parse(idLabel.Text));
            this.Close();
            
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int del = int.Parse(idLabel.Text);
                productDB.Delete(del);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void descrLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void stockLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void precioPLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void precioCLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void loteLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
