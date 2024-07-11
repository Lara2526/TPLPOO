using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarCompetencias
    {
        public static DataTable listarCompetencias()
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdep);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ListarCompetencias";

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;



            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Completa las datos de la consualta en el DataTable 
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void agregar_Competencia_SP(Competencia ocom)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdep);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "AgregarCompetencia";

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;
            cmd.Parameters.AddWithValue("@nombre", ocom.Com_Nombre);
            cmd.Parameters.AddWithValue("@descripcion", ocom.Com_Descripcion);
            cmd.Parameters.AddWithValue("@fechaInicio", ocom.Com_FechaInicio);
            cmd.Parameters.AddWithValue("@fechaFin", ocom.Com_FechaFin);
            cmd.Parameters.AddWithValue("@estado", ocom.Com_Estado);
            cmd.Parameters.AddWithValue("@organizador", ocom.Com_Organizador);
            cmd.Parameters.AddWithValue("@ubicacion", ocom.Com_Ubicacion);
            cmd.Parameters.AddWithValue("@sponsors", ocom.Com_Sponsors);
            cmd.Parameters.AddWithValue("@catid", ocom.Cat_ID);
            cmd.Parameters.AddWithValue("@disid", ocom.Dis_ID);
            
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static void mosdificar_competencias_SP(Competencia ocom)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdep);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ModificarCompetencia";

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@nombre", ocom.Com_Nombre);
            cmd.Parameters.AddWithValue("@descripcion", ocom.Com_Descripcion);
            cmd.Parameters.AddWithValue("@fechaInicio", ocom.Com_FechaInicio);
            cmd.Parameters.AddWithValue("@fechaFin", ocom.Com_FechaFin);
            cmd.Parameters.AddWithValue("@estado", ocom.Com_Estado);
            cmd.Parameters.AddWithValue("@organizador", ocom.Com_Organizador);
            cmd.Parameters.AddWithValue("@ubicacion", ocom.Com_Ubicacion);
            cmd.Parameters.AddWithValue("@sponsors", ocom.Com_Sponsors);
            cmd.Parameters.AddWithValue("@catid", ocom.Cat_ID);
            cmd.Parameters.AddWithValue("@disid", ocom.Dis_ID);
            cmd.Parameters.AddWithValue("@id", ocom.Com_ID);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static void eliminar_competencia(string comEliminado)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdep);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "EliminarCompetencia";

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@eliminado", comEliminado);


            SqlDataAdapter da = new SqlDataAdapter(cmd);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
