using System;
using System.Collections.Generic;
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
    }
}
