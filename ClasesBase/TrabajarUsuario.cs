using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace ClasesBase
{
    public class TrabajarUsuario
    {
        public static DataTable VerificarUsu(string nombre, string password)
        {
            //Realizar la conexión a la Base de Datos
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdep);

            //Crear el Comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Usu_NombreUsuario, Usu_Contraseña, Usu_ApellidoNombre, Rol_Codigo";
            cmd.CommandText += " FROM Usuario";
            cmd.CommandText += " WHERE";
            cmd.CommandText += "(Usu_NombreUsuario LIKE @name) AND (Usu_Contraseña LIKE @password)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@name", nombre );
            cmd.Parameters.AddWithValue("@password", password);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            //Crear el DataAdapter y le pasamos el Comando SQLCommand que acabamos de crear
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            

            DataTable dt = new DataTable();
           
            //Cargar el tabla con el contenido del DataAdapter
            da.Fill(dt);
            return dt;
        }
        public static void agregar_usuario(Usuario user)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdep);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Usuario(Usu_NombreUsuario, Usu_Contraseña, Usu_ApellidoNombre, Rol_Codigo) values (@nom,@contra,@ayn,@rolco)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@nom", user.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@contra", user.Usu_Contraseña);
            cmd.Parameters.AddWithValue("@ayn", user.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@rolco", user.Rol_Codigo);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }


        public static DataTable eliminar_usuario(string iEliminado)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdep);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.CommandText = "DELETE FROM Usuario";
            cmd.CommandText += " WHERE";
            cmd.CommandText += "(Usu_ID  LIKE @eliminado)";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@eliminado", "%" + iEliminado + "%");

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;

        }

        public static void modificar_usuario(Usuario modificadoUsr)//
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdep);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.CommandText = " UPDATE Usuario";
            cmd.CommandText += " SET  Usu_NombreUsuario = @usu_nombreusuario, Usu_Contraseña = @usu_contraseña, Usu_ApellidoNombre = @usu_apellidonombre, Rol_Codigo = @rol_codigo";
            cmd.CommandText += " WHERE Usu_ID LIKE @modificarId";

            cmd.Parameters.AddWithValue("@usu_nombreusuario", modificadoUsr.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@usu_contraseña", modificadoUsr.Usu_Contraseña);
            cmd.Parameters.AddWithValue("@usu_apellidonombre", modificadoUsr.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@rol_codigo", modificadoUsr.Rol_Codigo);
          
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@modificarId", "%" + modificadoUsr.Usu_ID + "%");
             //
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public static DataTable lista_usuarios()
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdep);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = " SELECT ";
            cmd.CommandText += " Rol_Descripcion as 'Rol', ";
            cmd.CommandText += " Usu_ID as 'ID', ";
            cmd.CommandText += " Usu_ApellidoNombre as 'Nombre Completo', ";
            cmd.CommandText += " Usu_NombreUsuario as 'Usuario', ";
            cmd.CommandText += " Usu_Contraseña as 'Contraseña',  ";
            cmd.CommandText += " U.Rol_Codigo as 'Rol_id' ";
            cmd.CommandText += " FROM Usuario as U";
            cmd.CommandText += " LEFT JOIN Roles as R ON (R.Rol_Codigo=U.Rol_Codigo)"; //condicion de relacion
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Completa las datos de la consualta en el DataTable 
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable list_roles()
        {
            //Realizar la conexion con la base de datos
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdep);

            //Crear comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Roles";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;

            //Ejecutar la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //LLenar los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public static DataTable buscar_usuarios(string sPattern)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdep);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = " SELECT ";
            cmd.CommandText += " Rol_Descripcion as 'Rol', ";
            cmd.CommandText += " Usu_ID as 'ID', ";
            cmd.CommandText += " Usu_ApellidoNombre as 'Nombre Completo', ";
            cmd.CommandText += " Usu_NombreUsuario as 'Usuario', ";
            cmd.CommandText += " Usu_Contraseña as 'Contraseña',  ";
            cmd.CommandText += " U.Rol_Codigo as 'Rol_id' ";
            cmd.CommandText += " FROM Usuario as U ";
            cmd.CommandText += " LEFT JOIN Roles as R ON (R.Rol_Codigo=U.Rol_Codigo)";
            cmd.CommandText += " WHERE";//realiza la busqueda 
            cmd.CommandText += " Usu_NombreUsuario LIKE @pattern";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");//expresion regular para el motor de sql

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Completa las datos de la consualta en el DataTable 
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public static DataTable buscar_usuarios_SP(string sPattern)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdep);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ListaUsuarioporNombre";
           
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@nombre",sPattern );//expresion regular para el motor de sql

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Completa las datos de la consualta en el DataTable 
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

    }
}
