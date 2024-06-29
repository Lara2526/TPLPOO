using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarCategoria
    {

        public static DataTable listarCategoria()
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdep);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ListarCategoria";

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;



            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Completa las datos de la consualta en el DataTable 
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void agregar_categoria_SP(Categoria ocat)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdep);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "AgregarCategoria";

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;
            cmd.Parameters.AddWithValue("@descripcion", ocat.Cat_Descripcion);
            cmd.Parameters.AddWithValue("@nombre", ocat.Cat_Nombre);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static void mosdificar_disciplina_SP(Categoria ocat)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdep);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ModificarCategoria";

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@descripcion", ocat.Cat_Descripcion);
            cmd.Parameters.AddWithValue("@nombre", ocat.Cat_Nombre);
            cmd.Parameters.AddWithValue("@id", ocat.Cat_ID);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static void eliminar_categoria(string catEliminado)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdep);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "EliminarCategoria";

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@eliminado", catEliminado);


            SqlDataAdapter da = new SqlDataAdapter(cmd);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
