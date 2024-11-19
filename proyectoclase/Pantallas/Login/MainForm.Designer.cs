namespace proyectoclase.Pantallas.Login
{
    partial class MainForm
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
            this.lblBienvenida1 = new MetroFramework.Controls.MetroLabel();
            this.tileProveedores1 = new MetroFramework.Controls.MetroTile();
            this.tileClientes1 = new MetroFramework.Controls.MetroTile();
            this.tileInventario1 = new MetroFramework.Controls.MetroTile();
            this.tileVentas1 = new MetroFramework.Controls.MetroTile();
            this.tileCorteCaja1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lblBienvenida1
            // 
            this.lblBienvenida1.AutoSize = true;
            this.lblBienvenida1.Location = new System.Drawing.Point(63, 21);
            this.lblBienvenida1.Name = "lblBienvenida1";
            this.lblBienvenida1.Size = new System.Drawing.Size(132, 19);
            this.lblBienvenida1.TabIndex = 0;
            this.lblBienvenida1.Text = "Bienvenido, [Usuario]";
            // 
            // tileProveedores1
            // 
            this.tileProveedores1.ActiveControl = null;
            this.tileProveedores1.Location = new System.Drawing.Point(63, 82);
            this.tileProveedores1.Name = "tileProveedores1";
            this.tileProveedores1.Size = new System.Drawing.Size(169, 37);
            this.tileProveedores1.TabIndex = 1;
            this.tileProveedores1.Text = "Gestionar Proveedores";
            this.tileProveedores1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tileProveedores1.UseSelectable = true;
            this.tileProveedores1.Click += new System.EventHandler(this.tileProveedores_Click);
            // 
            // tileClientes1
            // 
            this.tileClientes1.ActiveControl = null;
            this.tileClientes1.Location = new System.Drawing.Point(63, 144);
            this.tileClientes1.Name = "tileClientes1";
            this.tileClientes1.Size = new System.Drawing.Size(132, 36);
            this.tileClientes1.TabIndex = 2;
            this.tileClientes1.Text = "Gestionar Clientes";
            this.tileClientes1.UseSelectable = true;
            this.tileClientes1.Click += new System.EventHandler(this.tileClientes_Click);
            // 
            // tileInventario1
            // 
            this.tileInventario1.ActiveControl = null;
            this.tileInventario1.Location = new System.Drawing.Point(63, 217);
            this.tileInventario1.Name = "tileInventario1";
            this.tileInventario1.Size = new System.Drawing.Size(169, 38);
            this.tileInventario1.TabIndex = 3;
            this.tileInventario1.Text = "Gestionar Inventario";
            this.tileInventario1.UseSelectable = true;
            this.tileInventario1.Click += new System.EventHandler(this.tileInventario_Click);
            // 
            // tileVentas1
            // 
            this.tileVentas1.ActiveControl = null;
            this.tileVentas1.Location = new System.Drawing.Point(63, 293);
            this.tileVentas1.Name = "tileVentas1";
            this.tileVentas1.Size = new System.Drawing.Size(109, 40);
            this.tileVentas1.TabIndex = 4;
            this.tileVentas1.Text = "Registrar Venta";
            this.tileVentas1.UseSelectable = true;
            this.tileVentas1.Click += new System.EventHandler(this.tileVentas_Click);
            // 
            // tileCorteCaja1
            // 
            this.tileCorteCaja1.ActiveControl = null;
            this.tileCorteCaja1.Location = new System.Drawing.Point(63, 358);
            this.tileCorteCaja1.Name = "tileCorteCaja1";
            this.tileCorteCaja1.Size = new System.Drawing.Size(109, 48);
            this.tileCorteCaja1.TabIndex = 5;
            this.tileCorteCaja1.Text = "Corte de Caja";
            this.tileCorteCaja1.UseSelectable = true;
            this.tileCorteCaja1.Click += new System.EventHandler(this.tileCorteCaja_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(63, 333);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(0, 0);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(635, 429);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tileCorteCaja1);
            this.Controls.Add(this.tileVentas1);
            this.Controls.Add(this.tileInventario1);
            this.Controls.Add(this.tileClientes1);
            this.Controls.Add(this.tileProveedores1);
            this.Controls.Add(this.lblBienvenida1);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblBienvenida;
        private MetroFramework.Controls.MetroTile tileProveedores;
        private MetroFramework.Controls.MetroTile tileClientes;
        private MetroFramework.Controls.MetroTile tileInventario;
        private MetroFramework.Controls.MetroTile tileVentas;
        private MetroFramework.Controls.MetroTile tileCorteCaja;
        private MetroFramework.Controls.MetroLabel lblBienvenida1;
        private MetroFramework.Controls.MetroTile tileProveedores1;
        private MetroFramework.Controls.MetroTile tileClientes1;
        private MetroFramework.Controls.MetroTile tileInventario1;
        private MetroFramework.Controls.MetroTile tileVentas1;
        private MetroFramework.Controls.MetroTile tileCorteCaja1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}
