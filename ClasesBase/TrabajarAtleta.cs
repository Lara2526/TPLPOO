using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarAtleta
    {
        public static void agregar_atleta(Atleta atleta)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdep);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Atleta(Atl_DNI, Atl_Apellido, Atl_Nombre, Atl_Nacionalidad, Atl_Entrenador, Atl_Genero, Atl_Altura, Atl_Peso, Atl_FechaNac, Atl_Direccion, Atl_email) values (@dni,@apellido,@name,@nacionalidad,@entrenador,@genero,@altura,@peso,@fecha,@direccion,@email)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", atleta.Atl_DNI);
            cmd.Parameters.AddWithValue("@apellido", atleta.Atl_Apellido);
            cmd.Parameters.AddWithValue("@name", atleta.Atl_Nombre);
            cmd.Parameters.AddWithValue("@nacionalidad", atleta.Atl_Nacionalidad);
            cmd.Parameters.AddWithValue("@entrenador",atleta.Atl_Entrenador );
            cmd.Parameters.AddWithValue("@genero",atleta.Atl_Genero);
            cmd.Parameters.AddWithValue("@altura",atleta.Atl_Altura);
            cmd.Parameters.AddWithValue("@peso",atleta.Atl_Peso);
            cmd.Parameters.AddWithValue("@fecha",atleta.Atl_FechaNac);
            cmd.Parameters.AddWithValue("@direccion",atleta.Atl_Direccion);
            cmd.Parameters.AddWithValue("@email",atleta.Atl_Email);
            
           

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public static DataTable lista_atletas()
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdep);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = " SELECT ";
            cmd.CommandText += " Atl_ID as 'ID', ";
            cmd.CommandText += " Atl_DNI as 'DNI', ";
            cmd.CommandText += " Atl_Apellido as 'Apellido', ";
            cmd.CommandText += " Atl_Nombre as 'Nombre Completo', ";
            cmd.CommandText += " Atl_Nacionalidad as 'Nacionalidad', ";
            cmd.CommandText += " Atl_Entrenador as 'Entrenador',  ";
            cmd.CommandText += " Atl_Genero as 'Genero',  ";
            cmd.CommandText += " Atl_Altura as 'Altura',  ";
            cmd.CommandText += " Atl_Peso as 'Peso',  ";
            cmd.CommandText += " Atl_FechaNac as 'Fecha de Nacimiento',  ";
            cmd.CommandText += " Atl_Direccion as 'Direccion',  ";
            cmd.CommandText += " Atl_email as 'Email'  ";


            cmd.CommandText += " FROM Atleta as A";
            
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Completa las datos de la consualta en el DataTable 
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable eliminar_atleta(string iEliminado)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdep);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.CommandText = "DELETE FROM Atleta";
            cmd.CommandText += " WHERE";
            cmd.CommandText += "(Atl_ID  LIKE @eliminado)";

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
        public static void modificar_atleta(Atleta modificadoAtl)//
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdep);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.CommandText = " UPDATE Atleta";
            cmd.CommandText += " SET   Atl_DNI =  @dni, Atl_Apellido = @apellido, Atl_Nombre = @name, Atl_Nacionalidad = @nacionalidad, Atl_Entrenador = @entrenador, Atl_Genero = @genero,Atl_Altura = @altura ,Atl_Peso = @peso,Atl_FechaNac = @fecha,Atl_Direccion = @direccion, Atl_email = @email";
            cmd.CommandText += " WHERE Atl_ID LIKE @modificarId";

            cmd.Parameters.AddWithValue("@dni", modificadoAtl.Atl_DNI);
            cmd.Parameters.AddWithValue("@apellido", modificadoAtl.Atl_Apellido);
            cmd.Parameters.AddWithValue("@name", modificadoAtl.Atl_Nombre);
            cmd.Parameters.AddWithValue("@nacionalidad", modificadoAtl.Atl_Nacionalidad);
            cmd.Parameters.AddWithValue("@entrenador", modificadoAtl.Atl_Entrenador);
            cmd.Parameters.AddWithValue("@genero", modificadoAtl.Atl_Genero);
            cmd.Parameters.AddWithValue("@altura", modificadoAtl.Atl_Altura);
            cmd.Parameters.AddWithValue("@peso", modificadoAtl.Atl_Peso);
            cmd.Parameters.AddWithValue("@fecha", modificadoAtl.Atl_FechaNac);
            cmd.Parameters.AddWithValue("@direccion", modificadoAtl.Atl_Direccion);
            cmd.Parameters.AddWithValue("@email", modificadoAtl.Atl_Email);
            

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@modificarId", "%" + modificadoAtl.Atl_ID + "%");
            //
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable buscar_atletas(string sPattern)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdep);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = " SELECT ";
            cmd.CommandText += " Atl_ID as 'ID', ";
            cmd.CommandText += " Atl_DNI as 'DNI', ";
            cmd.CommandText += " Atl_Apellido as 'Apellido', ";
            cmd.CommandText += " Atl_Nombre as 'Nombre Completo', ";
            cmd.CommandText += " Atl_Nacionalidad as 'Nacionalidad', ";
            cmd.CommandText += " Atl_Entrenador as 'Entrenador',  ";
            cmd.CommandText += " Atl_Genero as 'Genero',  ";
            cmd.CommandText += " Atl_Altura as 'Altura',  ";
            cmd.CommandText += " Atl_Peso as 'Peso',  ";
            cmd.CommandText += " Atl_FechaNac as 'Fecha de Nacimiento',  ";
            cmd.CommandText += " Atl_Direccion as 'Direccion',  ";
            cmd.CommandText += " Atl_email as 'Email'  ";
            cmd.CommandText += " FROM Atleta ";
           
            cmd.CommandText += " WHERE";//realiza la busqueda 
            cmd.CommandText += " Atl_Apellido LIKE @pattern";
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

        public static DataTable ordear_DNI_atletas__SP()
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdep);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ListaAtltasOrdenadosporDNI";

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Completa las datos de la consualta en el DataTable 
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public static DataTable ordear_Apellido_atletas__SP()
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdep);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ListaAtltasOrdenadosporApellido";

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;



            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Completa las datos de la consualta en el DataTable 
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
