using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Trabajar_Evento
    {
        private static string connectionString = ClasesBase.Properties.Settings.Default.comdep;

        public List<Evento> ObtenerResultados(int competenciaID)
        {
            List<Evento> eventos = new List<Evento>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "ObtenerResultados";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@CompetenciaID", competenciaID);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Evento evento = new Evento
                    {
                        Eve_ID = reader.GetInt32(0),
                        Com_ID = reader.GetInt32(1),
                        Atl_ID = reader.GetInt32(2),
                        Eve_Estado = reader.GetString(3),
                        Eve_HoraInicio = reader.IsDBNull(4) ? DateTime.MinValue : reader.GetDateTime(4),
                        Eve_HoraFin = reader.IsDBNull(5) ? DateTime.MinValue : reader.GetDateTime(5)
                    };
                    eventos.Add(evento);
                }
                reader.Close();
            }

            return eventos;
        }

        public List<Evento> CalcularOrden(List<Evento> eventos)
        {
            return eventos.OrderBy(e => e.Eve_HoraFin - e.Eve_HoraInicio).ToList();
        }

        public string ObtenerNombreAtleta(int atletaID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "ObtenerNombreAtleta";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@AtletaID", atletaID);

                connection.Open();
                return command.ExecuteScalar()?.ToString() ?? string.Empty;
            }
        }

        public string ObtenerCategoria(int atletaID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "ObtenerCategoria";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@AtletaID", atletaID);

                connection.Open();
                return command.ExecuteScalar()?.ToString() ?? string.Empty;
            }
        }

        public string ObtenerDisciplina(int competenciaID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "ObtenerDisciplina";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@CompetenciaID", competenciaID);

                connection.Open();
                return command.ExecuteScalar()?.ToString() ?? string.Empty;
            }
        }
    }
}
