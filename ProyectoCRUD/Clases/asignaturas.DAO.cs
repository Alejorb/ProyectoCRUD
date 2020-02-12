using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academico
{
    public static class AsignaturasDAO
    {
        private static string cadenaConexion = @"server=DESKTOP-4UD5QDC\SQLEXPRESS2017; database=TI2019; user id=sa; password=Lab123456";

        public static int guardar(Asignaturas asignaturas/*objeto de la clase*/ )
        {
            //definimos una objeto conexión
            SqlConnection conn = new SqlConnection(cadenaConexion/*llamada de clase*/);//creando conexión

            string sql = "insert into asignaturas(codAsignatura,nombreAsignatura,nivel," +
                "creditos,carrera) values(@codAsignatura,@nombreAsignatura,@nivel," +
                "@creditos,@carrera)";

            //definimos un comando
            SqlCommand comando = new SqlCommand(sql, conn);
            //configuramos los parametros
            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.AddWithValue("@codAsignatura", asignaturas.CodAsignatura);
            comando.Parameters.AddWithValue("@nombreAsignatura", asignaturas.NombreAsignatura);
            comando.Parameters.AddWithValue("@nivel", asignaturas.Nivel);
            comando.Parameters.AddWithValue("@creditos", asignaturas.Creditos);
            comando.Parameters.AddWithValue("@carrera", asignaturas.Carrera);
            conn.Open();//abrir la conexión
            int x = comando.ExecuteNonQuery();//ejecutamos el comando
            conn.Close();//cerrar la conexión
            return x;//retornar

        }

        public static DataTable getNombresCompletos()
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);
            string sql = "select codAsignatura, upper(nombreAsignatura) as Asignatura " +
                " from asignaturas order by nombreAsignatura";

            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;
        }

        public static DataTable getDatos(String codigo)
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);
            string sql = "select codAsignatura,nombreAsignatura,nivel,creditos," +
                "carrera from asignaturas " +
                "where codAsignatura=@codAsignatura " +
                "order by nombreAsignatura";

            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            ad.SelectCommand.Parameters.AddWithValue("@codAsignatura", codigo);
            DataTable dt = new DataTable();
            ad.Fill(dt);//llena el dataTable dt

            return dt;
        }

        public static int actualizar(Asignaturas asignaturas/*objeto de la clase*/ )
        {
            //definimos una objeto conexión
            SqlConnection conn = new SqlConnection(cadenaConexion/*llamada de clase*/);//creando conexión

            string sql = "update asignaturas set " +
                "nombreAsignatura=@nombreAsignatura,nivel=@nivel, creditos=@creditos, " +
                "carrera=@carrera " +
                "where codAsignatura=@codAsignatura ";

            //definimos un comando
            SqlCommand comando = new SqlCommand(sql, conn);
            //configuramos los parametros
            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.AddWithValue("@codAsignatura", asignaturas.CodAsignatura);
            comando.Parameters.AddWithValue("@nombreAsignatura", asignaturas.NombreAsignatura);
            comando.Parameters.AddWithValue("@nivel", asignaturas.Nivel);
            comando.Parameters.AddWithValue("@creditos", asignaturas.Creditos);
            comando.Parameters.AddWithValue("@carrera", asignaturas.Carrera);
            conn.Open();//abrir la conexión
            int x = comando.ExecuteNonQuery();//ejecutamos el comando
            conn.Close();//cerrar la conexión
            return x;//retornar

        }

        public static int borrar(String codigo)
        {
            //definimos una objeto conexión
            SqlConnection conn = new SqlConnection(cadenaConexion);

            string sql = "delete from asignaturas " +
                "where codAsignatura=@codAsignatura";

            //definimos un comando
            SqlCommand comando = new SqlCommand(sql, conn);
            //configuramos los parametros
            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.AddWithValue("@codAsignatura", codigo);
            conn.Open();
            int x = comando.ExecuteNonQuery();//ejecutamos el comando
            conn.Close();
            return x;

        }
    }
}
