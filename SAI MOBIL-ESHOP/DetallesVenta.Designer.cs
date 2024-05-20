namespace SAI_MOBIL_ESHOP
{
    partial class DetallesVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.detallesTabla = new System.Windows.Forms.DataGridView();
            this.Id_DetalleVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.detallesTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::SAI_MOBIL_ESHOP.Properties.Resources.btncancelar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(73, 333);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 30);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.Transparent;
            this.printButton.BackgroundImage = global::SAI_MOBIL_ESHOP.Properties.Resources.btnimprimir;
            this.printButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.printButton.FlatAppearance.BorderSize = 0;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Location = new System.Drawing.Point(432, 333);
            this.printButton.Margin = new System.Windows.Forms.Padding(2);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(105, 30);
            this.printButton.TabIndex = 6;
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // detallesTabla
            // 
            this.detallesTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detallesTabla.BackgroundColor = System.Drawing.SystemColors.Control;
            this.detallesTabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detallesTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.detallesTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detallesTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_DetalleVenta,
            this.ID_Prod,
            this.Descripcion,
            this.Cantidad,
            this.PrecioUnitario,
            this.SubTotal,
            this.Vendedor});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.detallesTabla.DefaultCellStyle = dataGridViewCellStyle8;
            this.detallesTabla.Location = new System.Drawing.Point(73, 79);
            this.detallesTabla.Margin = new System.Windows.Forms.Padding(2);
            this.detallesTabla.Name = "detallesTabla";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detallesTabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.detallesTabla.RowHeadersWidth = 51;
            this.detallesTabla.RowTemplate.Height = 24;
            this.detallesTabla.Size = new System.Drawing.Size(464, 247);
            this.detallesTabla.TabIndex = 4;
            this.detallesTabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.detallesTabla_CellContentClick);
            // 
            // Id_DetalleVenta
            // 
            this.Id_DetalleVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id_DetalleVenta.HeaderText = "ID Venta";
            this.Id_DetalleVenta.MinimumWidth = 6;
            this.Id_DetalleVenta.Name = "Id_DetalleVenta";
            this.Id_DetalleVenta.Width = 125;
            // 
            // ID_Prod
            // 
            this.ID_Prod.HeaderText = "ID Prod";
            this.ID_Prod.MinimumWidth = 6;
            this.ID_Prod.Name = "ID_Prod";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.MinimumWidth = 6;
            this.PrecioUnitario.Name = "PrecioUnitario";
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Subtotal";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            // 
            // Vendedor
            // 
            this.Vendedor.HeaderText = "Vendedor";
            this.Vendedor.MinimumWidth = 6;
            this.Vendedor.Name = "Vendedor";
            // 
            // DetallesVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAI_MOBIL_ESHOP.Properties.Resources.HistorialVentasBkg__1_;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.detallesTabla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DetallesVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetallesVenta -SAI Mobile Shop ";
            ((System.ComponentModel.ISupportInitialize)(this.detallesTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.DataGridView detallesTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_DetalleVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendedor;
    }
}