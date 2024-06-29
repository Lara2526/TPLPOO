using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarDisciplina
    {
        public static void agregar_disciplina_SP(Disciplina odisc)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdep);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "AgregarDisciplina";

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;
            cmd.Parameters.AddWithValue("@descripcion", odisc.Dis_Descripcion);
            cmd.Parameters.AddWithValue("@nombre", odisc.Dis_Nombre);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static DataTable listarDisciplina()
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdep);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ListarDisciplina";

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;



            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Completa las datos de la consualta en el DataTable 
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void mosdificar_disciplina_SP(Disciplina odisc)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdep);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ModificarDisciplina";

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;
            
            cmd.Parameters.AddWithValue("@nombre", odisc.Dis_Nombre);
            cmd.Parameters.AddWithValue("@descripcion", odisc.Dis_Descripcion);
            cmd.Parameters.AddWithValue("@id", odisc.Dis_ID);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static void eliminar_disciplina(string iEliminado)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdep);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "EliminarDisciplina";

            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@eliminado", iEliminado);

           
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
