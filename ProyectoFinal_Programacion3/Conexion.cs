using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinal_Programacion3
{
    class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection(@"server=JOSE2021\SQLEXPRESS; database=Aplicacion; Integrated security=true;");
            cn.Open();
            return cn;
        }
        public DataTable login(string nomusu, string clausu, SqlConnection con)
        {
            DataTable tb = new DataTable();
            string strSql = "SELECT * FROM usuarios WHERE nomusu = @nomusu AND clausu = @clausu";
            SqlDataAdapter da = new SqlDataAdapter(strSql, con);
            da.SelectCommand.CommandType = CommandType.Text;
            da.SelectCommand.Parameters.Add("@nomusu", SqlDbType.VarChar, 15).Value = nomusu;
            da.SelectCommand.Parameters.Add("@clausu", SqlDbType.VarChar, 50).Value = clausu;
            da.Fill(tb);
            return tb;
        }
    }
}
