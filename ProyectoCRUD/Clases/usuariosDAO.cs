using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Academico
{
    public static class usuariosDAO
    {
        private static string cadenaConexion = @"server=L-PCT-117\SQLEXPRESS2016; database=TI2019; user id=sa; password=Lab123456";
        public static bool validaUsuario(string usuario, string clave)/*objeto de la clase*/ 
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);
            string sql = "select idLogin,nombreCompleto " +
                " from usuarios " +
                "where login=@login and clave=@clave ";
            String strclave = GetMD5(clave);

            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            ad.SelectCommand.Parameters.AddWithValue("@login", usuario);
            ad.SelectCommand.Parameters.AddWithValue("@clave", strclave);
            DataTable dt = new DataTable();
            ad.Fill(dt);//llena el dataTable dt
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public static int guardar(usuarios usuario/*objeto de la clase*/ )
        {
            //definimos una objeto conexión
            SqlConnection conn = new SqlConnection(cadenaConexion/*llamada de clase*/);//creando conexión

            string sql = "insert into " +
                "usuarios(nombreCompleto,login,clave,tipoUsuario) " +
                " values(@nombreCompleto,@login,@clave,@tipoUsuario)";

            String strclave = GetMD5(usuario.clave);//encipta clave

            //definimos un comando
            SqlCommand comando = new SqlCommand(sql, conn);
            //configuramos los parametros
            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.AddWithValue("@nombreCompleto", usuario.nombreCompleto);
            comando.Parameters.AddWithValue("@login", usuario.login);
            comando.Parameters.AddWithValue("@clave", strclave);
            comando.Parameters.AddWithValue("@tipoUsuario", usuario.tipoUsuario);
            conn.Open();//abrir la conexión
            int x = comando.ExecuteNonQuery();//ejecutamos el comando
            conn.Close();//cerrar la conexión
            return x;//retornar

        }
        public static DataTable getDatos()
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);
            string sql = "select idLogin,nombreCompleto,login,clave,tipoUsuario " +
                "from usuarios order by nombreCompleto";

            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;
        }
        public static DataTable getDatos(int idLogin)
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);
            string sql = "select idLogin,nombreCompleto,login,clave,tipoUsuario " +
                "from usuarios " +
                "where idLogin=@idLogin " +
                "order by nombreCompleto ";
            
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            ad.SelectCommand.Parameters.AddWithValue("@idLogin", idLogin);

            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;                                                      
        }

        public static int borrar(String id)
        {
            //definimos una objeto conexión
            SqlConnection conn = new SqlConnection(cadenaConexion);

            string sql = "delete from usuarios " +
                "where idLogin=@idLogin";

            //definimos un comando
            SqlCommand comando = new SqlCommand(sql, conn);
            //configuramos los parametros
            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.AddWithValue("@idLogin", id);
            conn.Open();
            int x = comando.ExecuteNonQuery();//ejecutamos el comando
            conn.Close();
            return x;

        }

        public static int actualizar(usuarios usuario/*objeto de la clase*/ )
        {
            //definimos una objeto conexión
            SqlConnection conn = new SqlConnection(cadenaConexion/*llamada de clase*/);//creando conexión

            string sql = "update usuarios set " +
                "nombreCompleto=@nombreCompleto, login=@login, " +
                "clave=@clave, tipoUsuario=@tipoUsuario " +
                "where idLogin=@idLogin ";

            String strclave = GetMD5(usuario.clave);//encipta clave

            //definimos un comando
            SqlCommand comando = new SqlCommand(sql, conn);
            //configuramos los parametros
            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.AddWithValue("@idLogin", usuario.idLogin);
            comando.Parameters.AddWithValue("@nombreCompleto", usuario.nombreCompleto);
            comando.Parameters.AddWithValue("@login", usuario.login);
            comando.Parameters.AddWithValue("@clave", usuario.clave);
            comando.Parameters.AddWithValue("@tipoUsuario", usuario.tipoUsuario);         
            conn.Open();//abrir la conexión
            int x = comando.ExecuteNonQuery();//ejecutamos el comando
            conn.Close();//cerrar la conexión
            return x;//retornar

        }

        public static string GetMD5(string str)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }
}
