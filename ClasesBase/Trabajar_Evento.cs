using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class Trabajar_Evento
    {
        public static void agregar_evento(Evento inscripcion)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdep);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Evento( Atl_ID, Com_ID, Eve_Estado) values (@atleta,@competencia,@estado)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@atleta", inscripcion.Atl_ID);
            cmd.Parameters.AddWithValue("@competencia", inscripcion.Com_ID);
            cmd.Parameters.AddWithValue("@estado", inscripcion.Eve_Estado);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public static DataTable listar_evento()
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdep);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = " SELECT ";

            cmd.CommandText += " Eve_ID as 'ID', ";
            cmd.CommandText += " Eve_Estado as 'Estado', ";
            cmd.CommandText += " E.Com_ID as 'Nro Competencia', ";
            cmd.CommandText += " C.Com_Nombre as 'Nombre de Competencia',";
            cmd.CommandText += " E.Atl_ID as 'Nro Atleta', ";
            cmd.CommandText += " A.Atl_DNI as 'Atleta', ";
            cmd.CommandText += " Eve_HoraInicio as 'Hora_Inicio', ";
            cmd.CommandText += " Eve_HoraFin as 'Hora_Fin' ";

            cmd.CommandText += " FROM Evento as E";
            cmd.CommandText += " LEFT JOIN Atleta as A ON (E.Atl_ID=A.Atl_ID)";
            cmd.CommandText += " LEFT JOIN Competencia as C ON (E.Com_ID=C.Com_ID)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Completa las datos de la consualta en el DataTable 
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable buscar_inscripcion_atleta(int id_atl, int id_com)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdep);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = " SELECT *";
            cmd.CommandText += " FROM Evento ";

            cmd.CommandText += " WHERE";//realiza la busqueda 
            cmd.CommandText += " Atl_ID LIKE @id_atl AND  Com_ID LIKE @id_com";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@id_atl", id_atl);
            cmd.Parameters.AddWithValue("@id_com", id_com);
            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Completa las datos de la consualta en el DataTable 
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

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

        /*public string ObtenerNombreAtleta(int atletaID)
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
        }*/

        public static DataTable buscar_atletas(int sPattern, string sEstado)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdep);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText  = "SELECT DISTINCT ";
            cmd.CommandText += " a.Atl_ID as IDAtleta, ";
            cmd.CommandText += " (a.Atl_Apellido + ' ' + a.Atl_Nombre) as Nombre, ";
            cmd.CommandText += " ISNULL(e.eve_HoraFin, '00:00') as HoraFin, ";
            cmd.CommandText += " e.eve_Estado as Estado, ";
            cmd.CommandText += " e.eve_ID as IDEvento ";
            cmd.CommandText += " FROM Atleta a";
            cmd.CommandText += " JOIN Evento e ON a.Atl_ID = e.Atl_ID";
            cmd.CommandText += " WHERE ";
            cmd.CommandText += " e.com_ID = @pattern and ";
            cmd.CommandText += " e.eve_Estado = @estado";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@pattern", sPattern);//expresion regular para el motor de sql
            cmd.Parameters.AddWithValue("@estado", sEstado  );//expresion regular para el motor de sql

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Completa las datos de la consualta en el DataTable 
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void modificarEvento(Evento eventoModificado)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdep);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.CommandText = " UPDATE Evento";
            cmd.CommandText += " SET  eve_HoraInicio = @eve_HoraInicio, eve_HoraFin = @eve_HoraFin, atl_ID = @atl_ID, com_ID = @com_ID ,eve_Estado = @eve_Estado" ;
            cmd.CommandText += " WHERE eve_ID LIKE @modificarId";

            cmd.Parameters.AddWithValue("@eve_HoraInicio", eventoModificado.Eve_HoraInicio);
            cmd.Parameters.AddWithValue("@eve_HoraFin", eventoModificado.Eve_HoraFin);
            cmd.Parameters.AddWithValue("@atl_ID", eventoModificado.Atl_ID);
            cmd.Parameters.AddWithValue("@com_ID", eventoModificado.Com_ID);
            cmd.Parameters.AddWithValue("@eve_Estado", eventoModificado.Eve_Estado);

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@modificarId", eventoModificado.Eve_ID);
            //
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
