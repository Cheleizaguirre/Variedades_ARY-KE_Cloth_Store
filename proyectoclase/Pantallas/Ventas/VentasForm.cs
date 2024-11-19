using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework.Forms;

namespace TuProyectoPOS
{
    public partial class VentasForm : MetroForm
    {
        private DatabaseConnection dbConnection;
        private MySqlConnection conexion;
        private List<DetalleVenta> carrito = new List<DetalleVenta>();

        public VentasForm()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
            conexion = dbConnection.GetConnection();
        }

        private void VentasForm_Load(object sender, EventArgs e)
        {
            CargarProductos();
            CargarClientes();
        }

        private void CargarProductos()
        {
            string query = "SELECT idProducto, nombreProducto, precio FROM Productos";
            MySqlCommand comando = new MySqlCommand(query, conexion);

            try
            {
                dbConnection.OpenConnection();

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    cmbProductos.Items.Add(new Producto
                    {
                        idProducto = reader.GetInt32("idProducto"),
                        nombreProducto = reader.GetString("nombreProducto"),
                        precio = reader.GetDecimal("precio")
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

        private void CargarClientes()
        {
            string query = "SELECT idCliente, nombreCliente FROM Clientes";
            MySqlCommand comando = new MySqlCommand(query, conexion);

            try
            {
                dbConnection.OpenConnection();

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    cmbClientes.Items.Add(new Cliente
                    {
                        idCliente = reader.GetInt32("idCliente"),
                        nombreCliente = reader.GetString("nombreCliente")
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedItem == null || string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Seleccione un producto y especifique la cantidad.");
                return;
            }

            Producto productoSeleccionado = (Producto)cmbProductos.SelectedItem;
            int cantidad;

            if (!int.TryParse(txtCantidad.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            DetalleVenta detalle = new DetalleVenta
            {
                idProducto = productoSeleccionado.idProducto,
                nombreProducto = productoSeleccionado.nombreProducto,
                cantidad = cantidad,
                precioUnitario = productoSeleccionado.precio,
                subtotal = cantidad * productoSeleccionado.precio
            };

            carrito.Add(detalle);
            ActualizarCarrito();
        }

        private void ActualizarCarrito()
        {
            dgvCarrito.DataSource = null;
            dgvCarrito.DataSource = carrito;

            dgvCarrito.Columns["idDetalleVenta"].Visible = false;
            dgvCarrito.Columns["idVenta"].Visible = false;
            dgvCarrito.Columns["idProducto"].Visible = false;

            lblTotal.Text = "Total: $" + CalcularTotal().ToString("F2");
        }

        private decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (var item in carrito)
            {
                total += item.subtotal;
            }
            return total;
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.");
                return;
            }

            if (cmbClientes.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un cliente.");
                return;
            }

            try
            {
                dbConnection.OpenConnection();
                MySqlCommand comando = conexion.CreateCommand();
                MySqlTransaction transaccion = conexion.BeginTransaction();

                comando.Connection = conexion;
                comando.Transaction = transaccion;

                try
                {
                    // Insertar en la tabla Ventas
                    comando.CommandText = "INSERT INTO Ventas(fechaVenta, idUsuario, idCliente, totalVenta) VALUES(@fechaVenta, @idUsuario, @idCliente, @totalVenta)";
                    comando.Parameters.AddWithValue("@fechaVenta", DateTime.Now);
                    comando.Parameters.AddWithValue("@idUsuario", ObtenerIdUsuario()); // Implementa este método según tu lógica de autenticación
                    comando.Parameters.AddWithValue("@idCliente", ((Cliente)cmbClientes.SelectedItem).idCliente);
                    comando.Parameters.AddWithValue("@totalVenta", CalcularTotal());
                    comando.ExecuteNonQuery();

                    long idVenta = comando.LastInsertedId;

                    // Insertar detalles de la venta
                    foreach (var item in carrito)
                    {
                        comando.CommandText = "INSERT INTO DetalleVenta(idVenta, idProducto, cantidad, precioUnitario, subtotal) VALUES(@idVenta, @idProducto, @cantidad, @precioUnitario, @subtotal)";
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@idVenta", idVenta);
                        comando.Parameters.AddWithValue("@idProducto", item.idProducto);
                        comando.Parameters.AddWithValue("@cantidad", item.cantidad);
                        comando.Parameters.AddWithValue("@precioUnitario", item.precioUnitario);
                        comando.Parameters.AddWithValue("@subtotal", item.subtotal);
                        comando.ExecuteNonQuery();

                        // Actualizar stock en Inventario
                        comando.CommandText = "UPDATE Inventario SET stock = stock - @cantidad WHERE idProducto = @idProducto";
                        comando.ExecuteNonQuery();
                    }

                    transaccion.Commit();
                    MessageBox.Show("Venta realizada con éxito.");

                    carrito.Clear();
                    ActualizarCarrito();
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    MessageBox.Show("Error al realizar la venta: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

        private int ObtenerIdUsuario()
        {
            // Implementa este método para obtener el ID del usuario actualmente autenticado
            return 1; // Valor de ejemplo
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.CurrentRow != null)
            {
                carrito.RemoveAt(dgvCarrito.CurrentRow.Index);
                ActualizarCarrito();
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar.");
            }
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    // Clases auxiliares
    public class Producto
    {
        public int idProducto { get; set; }
        public string nombreProducto { get; set; }
        public decimal precio { get; set; }

        public override string ToString()
        {
            return nombreProducto + " - $" + precio.ToString("F2");
        }
    }

    public class Cliente
    {
        public int idCliente { get; set; }
        public string nombreCliente { get; set; }

        public override string ToString()
        {
            return nombreCliente;
        }
    }

    public class DetalleVenta
    {
        public int idDetalleVenta { get; set; }
        public int idVenta { get; set; }
        public int idProducto { get; set; }
        public string nombreProducto { get; set; }
        public int cantidad { get; set; }
        public decimal precioUnitario { get; set; }
        public decimal subtotal { get; set; }
    }
}
