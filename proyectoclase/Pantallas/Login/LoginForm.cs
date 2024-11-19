using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using proyectoclase.Pantallas.Login;

namespace proyectoclase.Pantallas
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        private DatabaseConnection db = new DatabaseConnection();

        public LoginForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.UpdateStyles();
        }




        private void btnLogin_Click(object sender, EventArgs e)
        {



            // Obtener usuario y contraseña de los campos de texto
            string usuario = txtUsuario1.Text;
            string contraseña = txtContrasena1.Text;

            // Validar el login y obtener el rol del usuario
            string rol = ObtenerRolUsuario(usuario, contraseña);

            if (!string.IsNullOrEmpty(rol))
            {
                MessageBox.Show("Inicio de sesión exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                // Pasar usuario y rol al MainForm
                MainForm mainForm = new MainForm(usuario, rol);
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ObtenerRolUsuario(string usuario, string contraseña)
        {
            string query = "SELECT rol FROM Usuarios WHERE nombreUsuario = @usuario AND contraseña = @contraseña";

            try
            {
                db.OpenConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contraseña", contraseña);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retornar el rol del usuario
                            return reader["rol"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de conexión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }

            // Retornar cadena vacía si no se encontró el usuario
            return string.Empty;
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

      
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario1.Text == "Ingresa tu usuario")
            {
                txtUsuario1.Text = "";
                txtUsuario1.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario1.Text))
            {
                txtUsuario1.Text = "Ingresa tu usuario";
                txtUsuario1.ForeColor = Color.Gray;
            }
        }

        
        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena1.Text == "Ingresa tu contraseña")
            {
                txtContrasena1.Text = "";
                txtContrasena1.ForeColor = Color.Black;
                txtContrasena1.PasswordChar = '*'; 
            }
        }

        
        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContrasena1.Text))
            {
                txtContrasena1.Text = "Ingresa tu contraseña";
                txtContrasena1.ForeColor = Color.Gray;
                txtContrasena1.PasswordChar = '\0'; 
            }
        }


    }
}
   
