using System;
using System.Configuration;
using MySql.Data.MySqlClient;

public class DatabaseConnection
{
    private MySqlConnection connection;

    public DatabaseConnection()
    {
        // Obtener la cadena de conexión
        string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"]?.ConnectionString;

        if (connectionString == null)
        {
            throw new Exception("No se encontró la cadena de conexión 'MySqlConnection' en el archivo App.config.");
        }

        connection = new MySqlConnection(connectionString);
    }

    public MySqlConnection GetConnection()
    {
        return connection;
    }

    public void OpenConnection()
    {
        if (connection.State == System.Data.ConnectionState.Closed)
        {
            connection.Open();
        }
    }

    public void CloseConnection()
    {
        if (connection.State == System.Data.ConnectionState.Open)
        {
            connection.Close();
        }
    }


}
