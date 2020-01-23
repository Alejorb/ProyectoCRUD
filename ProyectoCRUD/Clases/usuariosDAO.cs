using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academico
{
    public static class usuariosDAO
    {
        private static string cadenaConexion = @"server=DESKTOP-A6URQU3\SQLEXPRESS2016; database=TI2019; user id=sa; password=Lab123456";
        public static bool validaUsuario(string usuario, string clave)/*objeto de la clase*/ 
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);
            string sql = "select idLogin,nombreCompleto " +
                " from usuarios1 " +
                "where login=@login and clave=@clave ";

            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            ad.SelectCommand.Parameters.AddWithValue("@login", usuario);
            ad.SelectCommand.Parameters.AddWithValue("@clave", clave);
            DataTable dt = new DataTable();
            ad.Fill(dt);//llena el dataTable dt
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
