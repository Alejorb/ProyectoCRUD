using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCRUD.Clases
{
    class usuariosDAO
    {
        private static string cadenaConexion = @"server=L-PCT-151\SQLEXPRESS2016; database=TI2019; user id=sa; password=Lab123456";
        public static int guardar(usuarios usuario/*objeto de la clase*/ )
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
    }
}
