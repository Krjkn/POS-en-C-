namespace SAI_MOBIL_ESHOP
{
    partial class modificar
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
            this.label1 = new System.Windows.Forms.Label();
            this.loteLabel = new System.Windows.Forms.TextBox();
            this.precioCLabel = new System.Windows.Forms.TextBox();
            this.precioPLabel = new System.Windows.Forms.TextBox();
            this.stockLabel = new System.Windows.Forms.TextBox();
            this.descrLabel = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.Actualizar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // loteLabel
            // 
            this.loteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loteLabel.Location = new System.Drawing.Point(26, 105);
            this.loteLabel.Margin = new System.Windows.Forms.Padding(2);
            this.loteLabel.Name = "loteLabel";
            this.loteLabel.Size = new System.Drawing.Size(244, 24);
            this.loteLabel.TabIndex = 6;
            this.loteLabel.TextChanged += new System.EventHandler(this.loteLabel_TextChanged);
            // 
            // precioCLabel
            // 
            this.precioCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioCLabel.Location = new System.Drawing.Point(26, 172);
            this.precioCLabel.Margin = new System.Windows.Forms.Padding(2);
            this.precioCLabel.Name = "precioCLabel";
            this.precioCLabel.Size = new System.Drawing.Size(244, 24);
            this.precioCLabel.TabIndex = 7;
            this.precioCLabel.TextChanged += new System.EventHandler(this.precioCLabel_TextChanged);
            // 
            // precioPLabel
            // 
            this.precioPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioPLabel.Location = new System.Drawing.Point(26, 235);
            this.precioPLabel.Margin = new System.Windows.Forms.Padding(2);
            this.precioPLabel.Name = "precioPLabel";
            this.precioPLabel.Size = new System.Drawing.Size(244, 24);
            this.precioPLabel.TabIndex = 8;
            this.precioPLabel.TextChanged += new System.EventHandler(this.precioPLabel_TextChanged);
            // 
            // stockLabel
            // 
            this.stockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockLabel.Location = new System.Drawing.Point(26, 300);
            this.stockLabel.Margin = new System.Windows.Forms.Padding(2);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(244, 24);
            this.stockLabel.TabIndex = 9;
            this.stockLabel.TextChanged += new System.EventHandler(this.stockLabel_TextChanged);
            // 
            // descrLabel
            // 
            this.descrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descrLabel.Location = new System.Drawing.Point(342, 106);
            this.descrLabel.Margin = new System.Windows.Forms.Padding(2);
            this.descrLabel.Multiline = true;
            this.descrLabel.Name = "descrLabel";
            this.descrLabel.Size = new System.Drawing.Size(241, 111);
            this.descrLabel.TabIndex = 10;
            this.descrLabel.TextChanged += new System.EventHandler(this.descrLabel_TextChanged);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(92, 54);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(35, 13);
            this.idLabel.TabIndex = 11;
            this.idLabel.Text = "label7";
            this.idLabel.Click += new System.EventHandler(this.textID_Click);
            // 
            // Actualizar
            // 
            this.Actualizar.BackColor = System.Drawing.Color.Transparent;
            this.Actualizar.BackgroundImage = global::SAI_MOBIL_ESHOP.Properties.Resources.btnactualizar;
            this.Actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Actualizar.FlatAppearance.BorderSize = 0;
            this.Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Actualizar.Location = new System.Drawing.Point(405, 235);
            this.Actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(127, 34);
            this.Actualizar.TabIndex = 13;
            this.Actualizar.UseVisualStyleBackColor = false;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.Color.Transparent;
            this.Eliminar.BackgroundImage = global::SAI_MOBIL_ESHOP.Properties.Resources.btneliminar;
            this.Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Eliminar.FlatAppearance.BorderSize = 0;
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminar.Location = new System.Drawing.Point(405, 300);
            this.Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(127, 34);
            this.Eliminar.TabIndex = 14;
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAI_MOBIL_ESHOP.Properties.Resources.Modficar_Productsbkg;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.descrLabel);
            this.Controls.Add(this.stockLabel);
            this.Controls.Add(this.precioPLabel);
            this.Controls.Add(this.precioCLabel);
            this.Controls.Add(this.loteLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "modificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Producto - SAI Mobile Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loteLabel;
        private System.Windows.Forms.TextBox precioCLabel;
        private System.Windows.Forms.TextBox precioPLabel;
        private System.Windows.Forms.TextBox stockLabel;
        private System.Windows.Forms.TextBox descrLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.Button Eliminar;
    }
}