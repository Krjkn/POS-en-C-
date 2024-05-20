namespace SAI_MOBIL_ESHOP
{
    partial class Usuarios
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.nuevoUsuario = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.passwordtextBox2 = new System.Windows.Forms.TextBox();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.nombretextBox = new System.Windows.Forms.TextBox();
            this.ActualizarUsuario = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.resetTextBox2 = new System.Windows.Forms.TextBox();
            this.resetTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.nuevoUsuario.SuspendLayout();
            this.ActualizarUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regresarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(848, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // regresarToolStripMenuItem
            // 
            this.regresarToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresarToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.regresarToolStripMenuItem.Name = "regresarToolStripMenuItem";
            this.regresarToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.regresarToolStripMenuItem.Text = "Regresar";
            this.regresarToolStripMenuItem.Click += new System.EventHandler(this.regresarToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.nuevoUsuario);
            this.tabControl1.Controls.Add(this.ActualizarUsuario);
            this.tabControl1.Location = new System.Drawing.Point(0, 26);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(848, 505);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // nuevoUsuario
            // 
            this.nuevoUsuario.BackgroundImage = global::SAI_MOBIL_ESHOP.Properties.Resources.nvousuariobkg__1_;
            this.nuevoUsuario.Controls.Add(this.button1);
            this.nuevoUsuario.Controls.Add(this.passwordtextBox2);
            this.nuevoUsuario.Controls.Add(this.passwordtextBox);
            this.nuevoUsuario.Controls.Add(this.emailtextBox);
            this.nuevoUsuario.Controls.Add(this.nombretextBox);
            this.nuevoUsuario.Location = new System.Drawing.Point(4, 22);
            this.nuevoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.nuevoUsuario.Name = "nuevoUsuario";
            this.nuevoUsuario.Padding = new System.Windows.Forms.Padding(2);
            this.nuevoUsuario.Size = new System.Drawing.Size(840, 479);
            this.nuevoUsuario.TabIndex = 0;
            this.nuevoUsuario.Text = "Nuevo Usuario";
            this.nuevoUsuario.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SAI_MOBIL_ESHOP.Properties.Resources.btn_agregar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(518, 426);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 34);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // passwordtextBox2
            // 
            this.passwordtextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtextBox2.Location = new System.Drawing.Point(428, 382);
            this.passwordtextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.passwordtextBox2.Name = "passwordtextBox2";
            this.passwordtextBox2.Size = new System.Drawing.Size(289, 26);
            this.passwordtextBox2.TabIndex = 6;
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtextBox.Location = new System.Drawing.Point(428, 288);
            this.passwordtextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(289, 26);
            this.passwordtextBox.TabIndex = 5;
            // 
            // emailtextBox
            // 
            this.emailtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtextBox.Location = new System.Drawing.Point(428, 194);
            this.emailtextBox.Margin = new System.Windows.Forms.Padding(2);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(289, 26);
            this.emailtextBox.TabIndex = 4;
            // 
            // nombretextBox
            // 
            this.nombretextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombretextBox.Location = new System.Drawing.Point(428, 99);
            this.nombretextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nombretextBox.Name = "nombretextBox";
            this.nombretextBox.Size = new System.Drawing.Size(289, 26);
            this.nombretextBox.TabIndex = 1;
            // 
            // ActualizarUsuario
            // 
            this.ActualizarUsuario.BackgroundImage = global::SAI_MOBIL_ESHOP.Properties.Resources.changepassbkg;
            this.ActualizarUsuario.Controls.Add(this.button2);
            this.ActualizarUsuario.Controls.Add(this.resetTextBox2);
            this.ActualizarUsuario.Controls.Add(this.resetTextBox);
            this.ActualizarUsuario.Location = new System.Drawing.Point(4, 22);
            this.ActualizarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.ActualizarUsuario.Name = "ActualizarUsuario";
            this.ActualizarUsuario.Padding = new System.Windows.Forms.Padding(2);
            this.ActualizarUsuario.Size = new System.Drawing.Size(840, 479);
            this.ActualizarUsuario.TabIndex = 1;
            this.ActualizarUsuario.Text = "Restablecer Contraseña";
            this.ActualizarUsuario.UseVisualStyleBackColor = true;
            this.ActualizarUsuario.Click += new System.EventHandler(this.ActualizarUsuario_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::SAI_MOBIL_ESHOP.Properties.Resources.btnactualizar;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(537, 372);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 34);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // resetTextBox2
            // 
            this.resetTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetTextBox2.Location = new System.Drawing.Point(444, 297);
            this.resetTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.resetTextBox2.Name = "resetTextBox2";
            this.resetTextBox2.Size = new System.Drawing.Size(300, 26);
            this.resetTextBox2.TabIndex = 3;
            // 
            // resetTextBox
            // 
            this.resetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetTextBox.Location = new System.Drawing.Point(444, 203);
            this.resetTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.resetTextBox.Name = "resetTextBox";
            this.resetTextBox.Size = new System.Drawing.Size(300, 26);
            this.resetTextBox.TabIndex = 2;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAI_MOBIL_ESHOP.Properties.Resources.Productosbkg;
            this.ClientSize = new System.Drawing.Size(848, 528);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Usuarios";
            this.Text = "Usuarios - SAI Mobile Shop";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.nuevoUsuario.ResumeLayout(false);
            this.nuevoUsuario.PerformLayout();
            this.ActualizarUsuario.ResumeLayout(false);
            this.ActualizarUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage nuevoUsuario;
        private System.Windows.Forms.TabPage ActualizarUsuario;
        private System.Windows.Forms.TextBox nombretextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox passwordtextBox2;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.TextBox resetTextBox2;
        private System.Windows.Forms.TextBox resetTextBox;
        private System.Windows.Forms.Button button2;
    }
}