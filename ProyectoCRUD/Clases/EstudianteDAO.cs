using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Academico
{
    public static class EstudianteDAO
    {
        private static string cadenaConexion = @"server=DESKTOP-A6URQU3\SQLEXPRESS2016; database=TI2019; user id=sa; password=Lab123456";
        public static int guardar(Estudiante estudiante/*objeto de la clase*/ )
        {
            //definimos una objeto conexión
            SqlConnection conn = new SqlConnection(cadenaConexion/*llamada de clase*/);//creando conexión

            string sql = "insert into estudiantes(matricula,apellidos,nombres,genero," +
                "fechaNacimiento,email) values(@matricula,@apellidos,@nombres,@genero," +
                "@fechaNacimiento,@email)";

            //definimos un comando
            SqlCommand comando = new SqlCommand(sql, conn);
            //configuramos los parametros
            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.AddWithValue("@matricula", estudiante.Matricula);
            comando.Parameters.AddWithValue("@apellidos", estudiante.Apellidos);
            comando.Parameters.AddWithValue("@nombres", estudiante.Nombres);
            comando.Parameters.AddWithValue("@genero", estudiante.Genero);
            comando.Parameters.AddWithValue("@fechaNacimiento", estudiante.FechaNAcimiento);
            comando.Parameters.AddWithValue("@email", estudiante.Correo);
            conn.Open();//abrir la conexión
            int x = comando.ExecuteNonQuery();//ejecutamos el comando
            conn.Close();//cerrar la conexión
            return x;//retornar

        } 

        /// <summary>
        /// Devuelve todas las filas de las tabla estudiante
        /// </summary>
        /// <returns></returns>
    public static DataTable getDatos()
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);
            string sql = "select matricula,apellidos,nombres,genero," +
                "fechaNacimiento,email from estudiantes order by apellidos";

            SqlDataAdapter ad = new SqlDataAdapter(sql,conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;
        }

        /// <summary>
        /// validar correo electrónico
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool validarEmail(string email)
        {
           
            String expresion;
            expresion = @"^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9 -]+)*(\.[a-z]{2,4})$";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    
                    return true;
                }
                else
                {
                   
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Llenar el cmbMatricula
        /// </summary>
        /// <returns></returns>
        public static DataTable getNombresCompletos()
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);
            string sql = "select matricula, upper(apellidos + ' ' + nombres) as Estudiante " +
                " from estudiantes order by apellidos,nombres";

            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;
        }

        /// <summary>
        /// Obtiene un estudiante por su numero de matricula
        /// </summary>
        /// <param name="matricula"></param>
        /// <returns></returns>
        public static DataTable getDatos(String matricula)
        { 
            SqlConnection conn = new SqlConnection(cadenaConexion);
            string sql = "select matricula,apellidos,nombres,genero," +
                "fechaNacimiento,email from estudiantes " +
                "where matricula=@matricula " +
                "order by apellidos, nombres";

            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            ad.SelectCommand.Parameters.AddWithValue("@matricula", matricula);
            DataTable dt = new DataTable();
            ad.Fill(dt);//llena el dataTable dt

            return dt;
        }

        /// <summary>
        /// Borrar a un estudiante de la base de datos
        /// </summary>
        /// <param name="matricula"></param>
        /// <returns></returns>
        public static int borrar(String matricula)
        {
            //definimos una objeto conexión
            SqlConnection conn = new SqlConnection(cadenaConexion);
            
            string sql = "delete from estudiantes "+
                "where matricula=@matricula";

            //definimos un comando
            SqlCommand comando = new SqlCommand(sql, conn);
            //configuramos los parametros
            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.AddWithValue("@matricula",matricula);
            conn.Open();
            int x = comando.ExecuteNonQuery();//ejecutamos el comando
            conn.Close();
            return x;

        }

        public static int actualizar(Estudiante estudiante/*objeto de la clase*/ )
        {
            //definimos una objeto conexión
            SqlConnection conn = new SqlConnection(cadenaConexion/*llamada de clase*/);//creando conexión

            string sql = "update estudiantes set apellidos=@apellidos,nombres=@nombres, genero=@genero, " +
                "fechaNacimiento=@fechaNacimiento, email=@email where matricula=@matricula ";

            //definimos un comando
            SqlCommand comando = new SqlCommand(sql, conn);
            //configuramos los parametros
            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.AddWithValue("@matricula", estudiante.Matricula);
            comando.Parameters.AddWithValue("@apellidos", estudiante.Apellidos);
            comando.Parameters.AddWithValue("@nombres", estudiante.Nombres);
            comando.Parameters.AddWithValue("@genero", estudiante.Genero);
            comando.Parameters.AddWithValue("@fechaNacimiento", estudiante.FechaNAcimiento.Date);
            comando.Parameters.AddWithValue("@email", estudiante.Correo);
            conn.Open();//abrir la conexión
            int x = comando.ExecuteNonQuery();//ejecutamos el comando
            conn.Close();//cerrar la conexión
            return x;//retornar

        }



    }
}
