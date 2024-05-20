namespace SAI_MOBIL_ESHOP
{
    partial class TicketNotificacion
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
            this.cambioLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cambioLabel
            // 
            this.cambioLabel.AutoSize = true;
            this.cambioLabel.Location = new System.Drawing.Point(285, 152);
            this.cambioLabel.Name = "cambioLabel";
            this.cambioLabel.Size = new System.Drawing.Size(10, 64);
            this.cambioLabel.TabIndex = 5;
            this.cambioLabel.Text = ".\r\n\r\n\r\n.\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cambio: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Venta Realizada Con Exito ";
            // 
            // TicketNotificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 260);
            this.Controls.Add(this.cambioLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TicketNotificacion";
            this.Text = "TicketNotificacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cambioLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}