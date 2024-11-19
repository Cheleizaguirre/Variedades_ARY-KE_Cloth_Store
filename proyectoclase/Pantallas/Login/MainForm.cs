using CorteCajaApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuProyectoPOS;

namespace proyectoclase.Pantallas.Login
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        private string usuario;
        private string rol;

        public MainForm(string usuario, string rol)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.rol = rol;
            ConfigurarInterfaz();
        }
        
        private void ConfigurarInterfaz()
        {
            lblBienvenida1.Text = $"Bienvenido, {usuario}";

            if (rol == "Usuario")
            {
                // Restringir acceso a ciertas funciones para usuarios regulares
                tileCorteCaja.Enabled = false;
            }
        }

        // Evento para gestionar proveedores
        private void tileProveedores_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gestionar Proveedores", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Evento para gestionar clientes
        private void tileClientes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gestionar Clientes", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Evento para gestionar inventario
        private void tileInventario_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gestionar Inventario", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Evento para registrar una venta
        private void tileVentas_Click(object sender, EventArgs e)
        {
            VentasForm ventasForm = new VentasForm();
            ventasForm.Show(); // O utiliza ventasForm.ShowDialog(); si prefieres que sea modal
        }


        private void tileCorteCaja_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia del formulario `CorteCajaForm`
                CorteCajaForm corteCajaForm = new CorteCajaForm();

                // Mostrar el formulario
                corteCajaForm.ShowDialog(); // Abre el formulario de forma modal
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario Corte de Caja: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
