using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Programacion3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            cargar_cliente();
            cargar_articulo();
            dataGridView1.DataSource = llenar_grid();
        }
        public DataTable llenar_grid()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT Articulo, Precio FROM Factura";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        public void cargar_cliente()
        {
            SqlCommand cmd = new SqlCommand("SELECT ID,Nombre FROM Clientes", Conexion.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow fila = dt.NewRow();
            fila["Nombre"] = "Cliente";
            dt.Rows.InsertAt(fila, 0);

            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Nombre";
            comboBox1.DataSource = dt;
        }
        public void cargar_articulo()
        {
                SqlCommand cmd = new SqlCommand("SELECT ID,Nombre FROM Articulos ", Conexion.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow fila = dt.NewRow();
                fila["Nombre"] = "Articulos";
                dt.Rows.InsertAt(fila, 0);

                comboBox2.ValueMember = "ID";
                comboBox2.DisplayMember = "Nombre";
                
                comboBox2.DataSource = dt;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string insertar = "INSERT INTO Factura(Cliente,Articulo, Precio) VALUES(@Cliente, @Articulo, @Precio)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@Cliente", comboBox1.Text);
            cmd1.Parameters.AddWithValue("@Articulo", comboBox2.Text);
            cmd1.Parameters.AddWithValue("@Precio", textBox1.Text);
            cmd1.ExecuteNonQuery();        
            dataGridView1.DataSource = llenar_grid();
            string precio1 = "SELECT SUM(Precio) FROM Factura";
            SqlCommand comando1 = new SqlCommand(precio1, Conexion.Conectar());
            label2.Text = Convert.ToString(comando1.ExecuteScalar());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string precio = "SELECT SUM(Precio) FROM Factura";
            SqlCommand comando = new SqlCommand(precio, Conexion.Conectar());
            label2.Text = Convert.ToString(comando.ExecuteScalar());

            string facturar = "DELETE FROM Factura";           
            SqlCommand cmd1 = new SqlCommand(facturar, Conexion.Conectar());            
            cmd1.ExecuteNonQuery();
            dataGridView1.DataSource = llenar_grid();



            string fecha = "INSERT INTO D_factura(Fecha, Hora, Cliente, Pago) VALUES(@Fecha, @Hora, @Cliente, @Pago)";
            SqlCommand comando1 = new SqlCommand(fecha, Conexion.Conectar());
            comando1.Parameters.AddWithValue("@Fecha", hoy);
            comando1.Parameters.AddWithValue("@Hora", hoy);
            comando1.Parameters.AddWithValue("@Cliente", comboBox1.Text);
            comando1.Parameters.AddWithValue("@Pago", "$"+label2.Text);
            comando1.ExecuteNonQuery();
            label2.Text = "0.0";

        }

        private void label2_Click(object sender, EventArgs e)
        {
            string precio = "SELECT SUM(Precio) FROM Factura";
            SqlCommand comando = new SqlCommand(precio, Conexion.Conectar());
            label2.Text = Convert.ToString(comando.ExecuteScalar());

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string precio = "SELECT Precio FROM Articulos WHERE ID = " + comboBox2.SelectedValue.ToString();
                SqlCommand comando = new SqlCommand(precio, Conexion.Conectar());
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    textBox1.Text = Convert.ToString(reader["Precio"]);


                }
            }
            catch { }

        }
        DateTime hoy = DateTime.Now;

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox2.Text = hoy.ToShortTimeString();

        }
    }
}
