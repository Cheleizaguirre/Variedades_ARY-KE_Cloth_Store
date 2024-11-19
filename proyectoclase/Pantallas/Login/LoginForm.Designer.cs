namespace proyectoclase.Pantallas
{
    partial class LoginForm
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
            this.lblUsuario1 = new MetroFramework.Controls.MetroLabel();
            this.txtUsuario1 = new MetroFramework.Controls.MetroTextBox();
            this.lblContrasena1 = new MetroFramework.Controls.MetroLabel();
            this.txtContrasena1 = new MetroFramework.Controls.MetroTextBox();
            this.btnLogin1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblUsuario1
            // 
            this.lblUsuario1.AutoSize = true;
            this.lblUsuario1.Location = new System.Drawing.Point(390, 299);
            this.lblUsuario1.Name = "lblUsuario1";
            this.lblUsuario1.Size = new System.Drawing.Size(56, 19);
            this.lblUsuario1.TabIndex = 0;
            this.lblUsuario1.Text = "Usuario:";
            // 
            // txtUsuario1
            // 
            this.txtUsuario1.Location = new System.Drawing.Point(469, 295);
            this.txtUsuario1.Name = "txtUsuario1";
            this.txtUsuario1.Size = new System.Drawing.Size(126, 23);
            this.txtUsuario1.TabIndex = 1;
            this.txtUsuario1.Text = "Ingresa tu usuario";
            this.txtUsuario1.Click += new System.EventHandler(this.metroTextBox1_Click);
            this.txtUsuario1.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario1.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // lblContrasena1
            // 
            this.lblContrasena1.AutoSize = true;
            this.lblContrasena1.Location = new System.Drawing.Point(368, 340);
            this.lblContrasena1.Name = "lblContrasena1";
            this.lblContrasena1.Size = new System.Drawing.Size(78, 19);
            this.lblContrasena1.TabIndex = 2;
            this.lblContrasena1.Text = "Contraseña:";
            // 
            // txtContrasena1
            // 
            this.txtContrasena1.Location = new System.Drawing.Point(469, 336);
            this.txtContrasena1.Name = "txtContrasena1";
            this.txtContrasena1.PasswordChar = '*';
            this.txtContrasena1.Size = new System.Drawing.Size(126, 23);
            this.txtContrasena1.TabIndex = 3;
            this.txtContrasena1.Click += new System.EventHandler(this.metroTextBox2_Click);
            this.txtContrasena1.Enter += new System.EventHandler(this.txtContrasena_Enter);
            this.txtContrasena1.Leave += new System.EventHandler(this.txtContrasena_Leave);
            // 
            // btnLogin1
            // 
            this.btnLogin1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogin1.Location = new System.Drawing.Point(238, 409);
            this.btnLogin1.Name = "btnLogin1";
            this.btnLogin1.Size = new System.Drawing.Size(187, 39);
            this.btnLogin1.TabIndex = 4;
            this.btnLogin1.Text = "Iniciar Sesión";
            this.btnLogin1.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginForm
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 471);
            this.Controls.Add(this.btnLogin1);
            this.Controls.Add(this.txtContrasena1);
            this.Controls.Add(this.lblContrasena1);
            this.Controls.Add(this.txtUsuario1);
            this.Controls.Add(this.lblUsuario1);
            this.Name = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblUsuario;
        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroLabel lblContrasena;
        private MetroFramework.Controls.MetroTextBox txtContrasena;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroLabel lblUsuario1;
        private MetroFramework.Controls.MetroTextBox txtUsuario1;
        private MetroFramework.Controls.MetroLabel lblContrasena1;
        private MetroFramework.Controls.MetroTextBox txtContrasena1;
        private MetroFramework.Controls.MetroButton btnLogin1;
    }
}
