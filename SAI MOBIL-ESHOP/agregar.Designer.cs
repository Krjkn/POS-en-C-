namespace SAI_MOBIL_ESHOP
{
    partial class agregar
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.loteTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.descripcionTB = new System.Windows.Forms.TextBox();
            this.stockTb = new System.Windows.Forms.TextBox();
            this.precio_ventaTB = new System.Windows.Forms.TextBox();
            this.precio_compraTB = new System.Windows.Forms.TextBox();
            this.checkStockPanel = new System.Windows.Forms.TabPage();
            this.buscar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Consultar = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.idBusqueda = new System.Windows.Forms.TextBox();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Actualizar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.descrLabel = new System.Windows.Forms.TextBox();
            this.stockLabel = new System.Windows.Forms.TextBox();
            this.precioPLabel = new System.Windows.Forms.TextBox();
            this.precioCLabel = new System.Windows.Forms.TextBox();
            this.loteLabel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.checkStockPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Consultar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.CausesValidation = false;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.checkStockPanel);
            this.tabControl1.Controls.Add(this.Consultar);
            this.tabControl1.Location = new System.Drawing.Point(1, 22);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(849, 505);
            this.tabControl1.TabIndex = 16;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::SAI_MOBIL_ESHOP.Properties.Resources.AddProductsbkg__1_;
            this.tabPage1.Controls.Add(this.loteTextBox);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.descripcionTB);
            this.tabPage1.Controls.Add(this.stockTb);
            this.tabPage1.Controls.Add(this.precio_ventaTB);
            this.tabPage1.Controls.Add(this.precio_compraTB);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(841, 476);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar Productos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // loteTextBox
            // 
            this.loteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loteTextBox.Location = new System.Drawing.Point(82, 114);
            this.loteTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.loteTextBox.Name = "loteTextBox";
            this.loteTextBox.Size = new System.Drawing.Size(285, 26);
            this.loteTextBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::SAI_MOBIL_ESHOP.Properties.Resources.btn_agregar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(580, 265);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 34);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // descripcionTB
            // 
            this.descripcionTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionTB.Location = new System.Drawing.Point(484, 115);
            this.descripcionTB.Margin = new System.Windows.Forms.Padding(2);
            this.descripcionTB.Multiline = true;
            this.descripcionTB.Name = "descripcionTB";
            this.descripcionTB.Size = new System.Drawing.Size(298, 131);
            this.descripcionTB.TabIndex = 8;
            // 
            // stockTb
            // 
            this.stockTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockTb.Location = new System.Drawing.Point(82, 397);
            this.stockTb.Margin = new System.Windows.Forms.Padding(2);
            this.stockTb.Name = "stockTb";
            this.stockTb.Size = new System.Drawing.Size(285, 26);
            this.stockTb.TabIndex = 9;
            // 
            // precio_ventaTB
            // 
            this.precio_ventaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio_ventaTB.Location = new System.Drawing.Point(82, 302);
            this.precio_ventaTB.Margin = new System.Windows.Forms.Padding(2);
            this.precio_ventaTB.Name = "precio_ventaTB";
            this.precio_ventaTB.Size = new System.Drawing.Size(285, 26);
            this.precio_ventaTB.TabIndex = 10;
            // 
            // precio_compraTB
            // 
            this.precio_compraTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio_compraTB.Location = new System.Drawing.Point(82, 208);
            this.precio_compraTB.Margin = new System.Windows.Forms.Padding(2);
            this.precio_compraTB.Name = "precio_compraTB";
            this.precio_compraTB.Size = new System.Drawing.Size(285, 26);
            this.precio_compraTB.TabIndex = 11;
            // 
            // checkStockPanel
            // 
            this.checkStockPanel.BackgroundImage = global::SAI_MOBIL_ESHOP.Properties.Resources.ConsultarProductsbkg__1_;
            this.checkStockPanel.Controls.Add(this.buscar);
            this.checkStockPanel.Controls.Add(this.txtBusqueda);
            this.checkStockPanel.Controls.Add(this.dataGridView1);
            this.checkStockPanel.Location = new System.Drawing.Point(4, 25);
            this.checkStockPanel.Margin = new System.Windows.Forms.Padding(2);
            this.checkStockPanel.Name = "checkStockPanel";
            this.checkStockPanel.Padding = new System.Windows.Forms.Padding(2);
            this.checkStockPanel.Size = new System.Drawing.Size(841, 476);
            this.checkStockPanel.TabIndex = 1;
            this.checkStockPanel.Text = "Comprobar Existencias";
            this.checkStockPanel.UseVisualStyleBackColor = true;
            // 
            // buscar
            // 
            this.buscar.BackColor = System.Drawing.Color.Transparent;
            this.buscar.BackgroundImage = global::SAI_MOBIL_ESHOP.Properties.Resources.btn_busar;
            this.buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buscar.FlatAppearance.BorderSize = 0;
            this.buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscar.Location = new System.Drawing.Point(393, 429);
            this.buscar.Margin = new System.Windows.Forms.Padding(2);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(127, 34);
            this.buscar.TabIndex = 19;
            this.buscar.UseVisualStyleBackColor = false;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(82, 432);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(283, 26);
            this.txtBusqueda.TabIndex = 18;
            this.txtBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusqueda_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(117, 97);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(611, 287);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Consultar
            // 
            this.Consultar.Controls.Add(this.button2);
            this.Consultar.Controls.Add(this.idBusqueda);
            this.Consultar.Controls.Add(this.Eliminar);
            this.Consultar.Controls.Add(this.Actualizar);
            this.Consultar.Controls.Add(this.label8);
            this.Consultar.Controls.Add(this.idLabel);
            this.Consultar.Controls.Add(this.descrLabel);
            this.Consultar.Controls.Add(this.stockLabel);
            this.Consultar.Controls.Add(this.precioPLabel);
            this.Consultar.Controls.Add(this.precioCLabel);
            this.Consultar.Controls.Add(this.loteLabel);
            this.Consultar.Controls.Add(this.label9);
            this.Consultar.Controls.Add(this.label10);
            this.Consultar.Controls.Add(this.label11);
            this.Consultar.Controls.Add(this.label12);
            this.Consultar.Controls.Add(this.label13);
            this.Consultar.Location = new System.Drawing.Point(4, 25);
            this.Consultar.Margin = new System.Windows.Forms.Padding(2);
            this.Consultar.Name = "Consultar";
            this.Consultar.Padding = new System.Windows.Forms.Padding(2);
            this.Consultar.Size = new System.Drawing.Size(841, 476);
            this.Consultar.TabIndex = 2;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(167, 39);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 30;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // idBusqueda
            // 
            this.idBusqueda.Location = new System.Drawing.Point(55, 39);
            this.idBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.idBusqueda.Name = "idBusqueda";
            this.idBusqueda.Size = new System.Drawing.Size(76, 20);
            this.idBusqueda.TabIndex = 29;
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(236, 329);
            this.Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(95, 41);
            this.Eliminar.TabIndex = 28;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(513, 329);
            this.Actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(95, 41);
            this.Actualizar.TabIndex = 27;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 243);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Descripcion:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(233, 110);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(35, 13);
            this.idLabel.TabIndex = 25;
            this.idLabel.Text = "label7";
            // 
            // descrLabel
            // 
            this.descrLabel.Location = new System.Drawing.Point(204, 272);
            this.descrLabel.Margin = new System.Windows.Forms.Padding(2);
            this.descrLabel.Name = "descrLabel";
            this.descrLabel.Size = new System.Drawing.Size(161, 20);
            this.descrLabel.TabIndex = 24;
            // 
            // stockLabel
            // 
            this.stockLabel.Location = new System.Drawing.Point(482, 134);
            this.stockLabel.Margin = new System.Windows.Forms.Padding(2);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(161, 20);
            this.stockLabel.TabIndex = 23;
            // 
            // precioPLabel
            // 
            this.precioPLabel.Location = new System.Drawing.Point(482, 201);
            this.precioPLabel.Margin = new System.Windows.Forms.Padding(2);
            this.precioPLabel.Name = "precioPLabel";
            this.precioPLabel.Size = new System.Drawing.Size(161, 20);
            this.precioPLabel.TabIndex = 22;
            // 
            // precioCLabel
            // 
            this.precioCLabel.Location = new System.Drawing.Point(482, 272);
            this.precioCLabel.Margin = new System.Windows.Forms.Padding(2);
            this.precioCLabel.Name = "precioCLabel";
            this.precioCLabel.Size = new System.Drawing.Size(161, 20);
            this.precioCLabel.TabIndex = 21;
            // 
            // loteLabel
            // 
            this.loteLabel.Location = new System.Drawing.Point(204, 201);
            this.loteLabel.Margin = new System.Windows.Forms.Padding(2);
            this.loteLabel.Name = "loteLabel";
            this.loteLabel.Size = new System.Drawing.Size(161, 20);
            this.loteLabel.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(480, 243);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Precio Venta:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(480, 110);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Stock:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(480, 171);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Precio Público:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(202, 171);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Codigo de Barras:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(202, 110);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "ID:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 30);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regresarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(848, 26);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // regresarToolStripMenuItem
            // 
            this.regresarToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresarToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.regresarToolStripMenuItem.Name = "regresarToolStripMenuItem";
            this.regresarToolStripMenuItem.Size = new System.Drawing.Size(81, 22);
            this.regresarToolStripMenuItem.Text = "Regresar";
            this.regresarToolStripMenuItem.Click += new System.EventHandler(this.regresarToolStripMenuItem_Click);
            // 
            // agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAI_MOBIL_ESHOP.Properties.Resources.Productosbkg;
            this.ClientSize = new System.Drawing.Size(848, 528);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "agregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos - SAI Mobile Shop";
            this.Load += new System.EventHandler(this.agregar_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.agregar_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.checkStockPanel.ResumeLayout(false);
            this.checkStockPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Consultar.ResumeLayout(false);
            this.Consultar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox loteTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox descripcionTB;
        private System.Windows.Forms.TextBox stockTb;
        private System.Windows.Forms.TextBox precio_ventaTB;
        private System.Windows.Forms.TextBox precio_compraTB;
        private System.Windows.Forms.TabPage checkStockPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.TabPage Consultar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox idBusqueda;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox descrLabel;
        private System.Windows.Forms.TextBox stockLabel;
        private System.Windows.Forms.TextBox precioPLabel;
        private System.Windows.Forms.TextBox precioCLabel;
        private System.Windows.Forms.TextBox loteLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}