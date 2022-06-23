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
    class CRUD
    {
        public DataTable buscar(string txt, SqlConnection con)
        {
            string str = "SELECT * FROM Clientes WHERE Nombre LIKE ('%" + txt + "%') OR ID LIKE ('%" + txt + "%')";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            return tb;
        }
        public DataTable llenargrid(SqlConnection con)
        {
            DataTable tb = new DataTable();
            string strSql = "SELECT * FROM Clientes";
            SqlCommand cmd = new SqlCommand(strSql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            return tb;
        }
        public DataTable llenargrid2(SqlConnection con)
        {
            DataTable tb = new DataTable();
            string strSql = "SELECT * FROM Articulos";
            SqlCommand cmd = new SqlCommand(strSql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            return tb;
        }
        public DataTable llenargrid3(SqlConnection con)
        {
            DataTable tb = new DataTable();
            string strSql = "SELECT * FROM D_factura";
            SqlCommand cmd = new SqlCommand(strSql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            return tb;
        }
        public DataTable llenargrid4(SqlConnection con)
        {
            DataTable tb = new DataTable();
            string strSql = "SELECT * FROM proveedores";
            SqlCommand cmd = new SqlCommand(strSql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            return tb;
        }
    }
}
