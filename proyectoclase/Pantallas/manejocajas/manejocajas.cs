using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework.Forms;

namespace CorteCajaApp
{
    public partial class CorteCajaForm : MetroFramework.Forms.MetroForm
    {
        public CorteCajaForm()
        {
            InitializeComponent();
            // Configura el DataGridView
            dataGridViewCorteCaja.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CargarDatos();
        }

        private void CargarDatos()
        {
            // Asegúrate de que el connection string "MySqlConnection" esté configurado correctamente en tu archivo de configuración.
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            using (MySqlConnection connection = new MySqlConnection(connectionString)) // Usa la instancia correctamente
            {
                try
                {
                    connection.Open();
                    string query = "SELECT idCorteCaja, fechaCorte, totalIngresos, totalGastos, idUsuario FROM CorteCaja";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewCorteCaja.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
            }
        }


        // Botón para cargar datos
        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        // Botón para agregar datos
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Lógica para agregar un nuevo registro en la base de datos.
        }

        // Botón para actualizar datos
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Lógica para actualizar un registro seleccionado.
        }

        // Botón para eliminar datos
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Lógica para eliminar un registro seleccionado en el DataGridView.
        }

        private void CorteCajaForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewCorteCaja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
