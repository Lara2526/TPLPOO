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
