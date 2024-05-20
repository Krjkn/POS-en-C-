namespace SAI_MOBIL_ESHOP
{
    partial class login
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
            this.textBoxContrasena = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxContrasena
            // 
            this.textBoxContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContrasena.Location = new System.Drawing.Point(49, 487);
            this.textBoxContrasena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxContrasena.Name = "textBoxContrasena";
            this.textBoxContrasena.Size = new System.Drawing.Size(380, 30);
            this.textBoxContrasena.TabIndex = 10;
            this.textBoxContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxContrasena.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxContrasena_KeyDown);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(49, 352);
            this.textBoxUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(380, 30);
            this.textBoxUsuario.TabIndex = 9;
            this.textBoxUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUsuario_KeyDown);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox1.Location = new System.Drawing.Point(237, 529);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.BackgroundImage = global::SAI_MOBIL_ESHOP.Properties.Resources.Frame_1;
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Location = new System.Drawing.Point(156, 641);
            this.loginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(168, 42);
            this.loginButton.TabIndex = 6;
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAI_MOBIL_ESHOP.Properties.Resources.Android_Small___1__1_;
            this.ClientSize = new System.Drawing.Size(481, 786);
            this.Controls.Add(this.textBoxContrasena);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.loginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - SAI Mobile Shop";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxContrasena;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button loginButton;
    }
}