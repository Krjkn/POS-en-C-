namespace SAI_MOBIL_ESHOP
{
    partial class ventas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.cardPanel = new System.Windows.Forms.TabPage();
            this.Efectivo = new System.Windows.Forms.TextBox();
            this.billLabel = new System.Windows.Forms.Label();
            this.tablaProductos = new System.Windows.Forms.DataGridView();
            this.sellButton = new System.Windows.Forms.Button();
            this.delEntry = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cartItemTable = new System.Windows.Forms.DataGridView();
            this.ID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroVentaActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billingPanel = new System.Windows.Forms.TabPage();
            this.billingTable = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.cardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartItemTable)).BeginInit();
            this.billingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billingTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regresarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(924, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // regresarToolStripMenuItem
            // 
            this.regresarToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.regresarToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.regresarToolStripMenuItem.Name = "regresarToolStripMenuItem";
            this.regresarToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.regresarToolStripMenuItem.Text = "Regresar";
            this.regresarToolStripMenuItem.Click += new System.EventHandler(this.regresarToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.cardPanel);
            this.tabControl1.Controls.Add(this.billingPanel);
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(920, 470);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // cardPanel
            // 
            this.cardPanel.BackgroundImage = global::SAI_MOBIL_ESHOP.Properties.Resources.ventabkgxd;
            this.cardPanel.Controls.Add(this.Efectivo);
            this.cardPanel.Controls.Add(this.billLabel);
            this.cardPanel.Controls.Add(this.tablaProductos);
            this.cardPanel.Controls.Add(this.sellButton);
            this.cardPanel.Controls.Add(this.delEntry);
            this.cardPanel.Controls.Add(this.Buscar);
            this.cardPanel.Controls.Add(this.textBox1);
            this.cardPanel.Controls.Add(this.cartItemTable);
            this.cardPanel.Location = new System.Drawing.Point(4, 22);
            this.cardPanel.Margin = new System.Windows.Forms.Padding(2);
            this.cardPanel.Name = "cardPanel";
            this.cardPanel.Padding = new System.Windows.Forms.Padding(2);
            this.cardPanel.Size = new System.Drawing.Size(912, 444);
            this.cardPanel.TabIndex = 0;
            this.cardPanel.Text = "Ventas";
            this.cardPanel.UseVisualStyleBackColor = true;
            // 
            // Efectivo
            // 
            this.Efectivo.Location = new System.Drawing.Point(797, 369);
            this.Efectivo.Margin = new System.Windows.Forms.Padding(2);
            this.Efectivo.Name = "Efectivo";
            this.Efectivo.Size = new System.Drawing.Size(83, 20);
            this.Efectivo.TabIndex = 9;
            // 
            // billLabel
            // 
            this.billLabel.AutoSize = true;
            this.billLabel.Location = new System.Drawing.Point(294, 385);
            this.billLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.billLabel.Name = "billLabel";
            this.billLabel.Size = new System.Drawing.Size(10, 13);
            this.billLabel.TabIndex = 8;
            this.billLabel.Text = ".";
            // 
            // tablaProductos
            // 
            this.tablaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaProductos.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(234)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(234)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaProductos.GridColor = System.Drawing.SystemColors.Control;
            this.tablaProductos.Location = new System.Drawing.Point(551, 82);
            this.tablaProductos.Margin = new System.Windows.Forms.Padding(2);
            this.tablaProductos.Name = "tablaProductos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(234)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaProductos.RowHeadersWidth = 51;
            this.tablaProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tablaProductos.RowTemplate.Height = 24;
            this.tablaProductos.Size = new System.Drawing.Size(317, 200);
            this.tablaProductos.TabIndex = 7;
            this.tablaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaProductos_CellContentClick);
            // 
            // sellButton
            // 
            this.sellButton.BackgroundImage = global::SAI_MOBIL_ESHOP.Properties.Resources.btnreaizarvneta;
            this.sellButton.FlatAppearance.BorderSize = 0;
            this.sellButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellButton.Location = new System.Drawing.Point(718, 406);
            this.sellButton.Margin = new System.Windows.Forms.Padding(2);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(127, 34);
            this.sellButton.TabIndex = 6;
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // delEntry
            // 
            this.delEntry.BackColor = System.Drawing.Color.Transparent;
            this.delEntry.BackgroundImage = global::SAI_MOBIL_ESHOP.Properties.Resources.brnvaciarcarrito;
            this.delEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delEntry.FlatAppearance.BorderSize = 0;
            this.delEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delEntry.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.delEntry.Location = new System.Drawing.Point(140, 410);
            this.delEntry.Margin = new System.Windows.Forms.Padding(2);
            this.delEntry.Name = "delEntry";
            this.delEntry.Size = new System.Drawing.Size(112, 32);
            this.delEntry.TabIndex = 5;
            this.delEntry.UseVisualStyleBackColor = false;
            this.delEntry.Click += new System.EventHandler(this.delEntry_Click);
            // 
            // Buscar
            // 
            this.Buscar.BackgroundImage = global::SAI_MOBIL_ESHOP.Properties.Resources.btn_busar;
            this.Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Buscar.FlatAppearance.BorderSize = 0;
            this.Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscar.Location = new System.Drawing.Point(781, 312);
            this.Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(99, 28);
            this.Buscar.TabIndex = 3;
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(556, 317);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 2;
            // 
            // cartItemTable
            // 
            this.cartItemTable.AllowUserToAddRows = false;
            this.cartItemTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cartItemTable.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(234)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartItemTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.cartItemTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartItemTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID1,
            this.Descripcion1,
            this.Precio1,
            this.Cantidad,
            this.Subtotal,
            this.Stock1,
            this.numeroVentaActual});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(234)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cartItemTable.DefaultCellStyle = dataGridViewCellStyle5;
            this.cartItemTable.Location = new System.Drawing.Point(68, 82);
            this.cartItemTable.Margin = new System.Windows.Forms.Padding(2);
            this.cartItemTable.Name = "cartItemTable";
            this.cartItemTable.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(234)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartItemTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.cartItemTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.cartItemTable.RowTemplate.Height = 24;
            this.cartItemTable.Size = new System.Drawing.Size(316, 288);
            this.cartItemTable.TabIndex = 0;
            // 
            // ID1
            // 
            this.ID1.HeaderText = "ID";
            this.ID1.MaxInputLength = 1000;
            this.ID1.MinimumWidth = 6;
            this.ID1.Name = "ID1";
            this.ID1.ReadOnly = true;
            this.ID1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Descripcion1
            // 
            this.Descripcion1.HeaderText = "Descripcion";
            this.Descripcion1.MinimumWidth = 6;
            this.Descripcion1.Name = "Descripcion1";
            this.Descripcion1.ReadOnly = true;
            // 
            // Precio1
            // 
            this.Precio1.HeaderText = "Precio";
            this.Precio1.MinimumWidth = 6;
            this.Precio1.Name = "Precio1";
            this.Precio1.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.MinimumWidth = 6;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // Stock1
            // 
            this.Stock1.HeaderText = "Stock";
            this.Stock1.MinimumWidth = 6;
            this.Stock1.Name = "Stock1";
            this.Stock1.ReadOnly = true;
            // 
            // numeroVentaActual
            // 
            this.numeroVentaActual.HeaderText = "No de Venta";
            this.numeroVentaActual.MinimumWidth = 6;
            this.numeroVentaActual.Name = "numeroVentaActual";
            this.numeroVentaActual.ReadOnly = true;
            // 
            // billingPanel
            // 
            this.billingPanel.BackgroundImage = global::SAI_MOBIL_ESHOP.Properties.Resources.HistorialVentasBkg;
            this.billingPanel.Controls.Add(this.billingTable);
            this.billingPanel.Location = new System.Drawing.Point(4, 22);
            this.billingPanel.Margin = new System.Windows.Forms.Padding(2);
            this.billingPanel.Name = "billingPanel";
            this.billingPanel.Padding = new System.Windows.Forms.Padding(2);
            this.billingPanel.Size = new System.Drawing.Size(912, 444);
            this.billingPanel.TabIndex = 1;
            this.billingPanel.Text = "Historial";
            this.billingPanel.UseVisualStyleBackColor = true;
            // 
            // billingTable
            // 
            this.billingTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billingTable.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.billingTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.billingTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.billingTable.DefaultCellStyle = dataGridViewCellStyle8;
            this.billingTable.GridColor = System.Drawing.SystemColors.Control;
            this.billingTable.Location = new System.Drawing.Point(154, 93);
            this.billingTable.Margin = new System.Windows.Forms.Padding(2);
            this.billingTable.Name = "billingTable";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.billingTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.billingTable.RowHeadersWidth = 51;
            this.billingTable.RowTemplate.Height = 24;
            this.billingTable.Size = new System.Drawing.Size(612, 287);
            this.billingTable.TabIndex = 0;
            this.billingTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billingTable_CellContentClick);
            // 
            // ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAI_MOBIL_ESHOP.Properties.Resources.ventasbkg;
            this.ClientSize = new System.Drawing.Size(924, 512);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas - SAI Mobile Shop";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.cardPanel.ResumeLayout(false);
            this.cardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartItemTable)).EndInit();
            this.billingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.billingTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage cardPanel;
        private System.Windows.Forms.TextBox Efectivo;
        private System.Windows.Forms.Label billLabel;
        private System.Windows.Forms.DataGridView tablaProductos;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button delEntry;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView cartItemTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroVentaActual;
        private System.Windows.Forms.TabPage billingPanel;
        private System.Windows.Forms.DataGridView billingTable;
    }
}