using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Refaccionaria.Models;

namespace Refaccionaria.DAO
{
    public class CamionDAO
    {
        private string connectionString = @"Data Source=DESKTOP-VIF6PSC;Initial Catalog=refaccionaria;Integrated Security=True";

        // Método para obtener todos los camiones
        public Camion[] ObtenerCamiones()
        {
            List<Camion> listaCamiones = new List<Camion>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Camion";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Camion camion = new Camion
                    {
                        IdCamion = (int)reader["Idcamion"],
                        Nombre = reader["Nombre"].ToString(),
                        TotalAlmacenaje = (decimal)reader["Totalmacenaje"], // Cambiado a 'Totalmacenaje'
                        Placas = reader["Placas"].ToString(),
                        Marca = reader["Marca"].ToString()
                    };

                    listaCamiones.Add(camion);
                }

                reader.Close();
            }

            return listaCamiones.ToArray();
        }

        // Método para agregar un nuevo camión
        public void AgregarCamion(Camion camion)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Camion (Nombre, Totalmacenaje, Placas, Marca) VALUES (@Nombre, @TotalAlmacenaje, @Placas, @Marca)";
                SqlCommand command = new SqlCommand(query, connection);

                // Asegúrate de que los nombres coincidan con las columnas de la base de datos
                command.Parameters.AddWithValue("@Nombre", camion.Nombre);
                command.Parameters.AddWithValue("@TotalAlmacenaje", camion.TotalAlmacenaje); // Cambiado a 'Totalmacenaje'
                command.Parameters.AddWithValue("@Placas", camion.Placas);
                command.Parameters.AddWithValue("@Marca", camion.Marca);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
