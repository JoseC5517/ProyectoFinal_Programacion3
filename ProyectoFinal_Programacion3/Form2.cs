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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Clientes");
            comboBox1.Items.Add("Proveedores");
            comboBox1.Items.Add("Articulos");
            comboBox1.Items.Add("Detalle-Factura");
            comboBox2.Items.Clear();
            comboBox2.Items.Add("M");
            comboBox2.Items.Add("F");
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                txtnom.Enabled = true;
                txtape.Enabled = true;
                txtcell.Enabled = true;
                txtema.Enabled = true;

                label1.Enabled = true;
                label2.Enabled = true;
                label3.Enabled = true;
                label4.Enabled = true;
                label5.Enabled = true;
                textBox1.Enabled = true;


                txtnom.Visible = true;
                txtape.Visible = true;
                txtcell.Visible = true;
                txtema.Visible = true;

                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;

                if (comboBox1.SelectedItem.ToString() == "Clientes")
                {
                    CRUD crud = new CRUD();
                    dataGridView1.DataSource = crud.llenargrid(Conexion.Conectar());
                    label2.Text = "Apellido";
                    label3.Text = "Sexo";
                    txtcell.Visible = true;
                    comboBox2.Enabled = true;
                    comboBox2.Visible = true;
                    txtsexo.Visible = false;
                    txtsexo.Enabled = false;
                    txtcell.Enabled = true;
                    txtema.Visible = true;
                    txtema.Enabled = true;
                    label4.Visible = true;
                    label4.Enabled = true;
                    label5.Visible = true;
                    button2.Visible = false;
                    button2.Enabled = false;
                    label5.Enabled = true;
                    btnagregar.Enabled = true;
                    btnagregar.Visible = true;
                    btneliminar.Enabled = true;
                    btneliminar.Visible = true;
                    btnmodificar.Enabled = true;
                    btnmodificar.Visible = true;
                    btnnuevo.Enabled = true;
                    btnnuevo.Visible = true;
                    eliminar1();
                }
                else if (comboBox1.SelectedItem.ToString() == "Proveedores")
                {
                    CRUD crud = new CRUD();
                    dataGridView1.DataSource = crud.llenargrid4(Conexion.Conectar());
                    label2.Text = "Apellido";
                    label3.Text = "Sexo";
                    txtcell.Visible = true;
                    comboBox2.Enabled = true;
                    comboBox2.Visible = true;
                    txtsexo.Visible = false;
                    txtsexo.Enabled = false;
                    txtcell.Enabled = true;
                    txtema.Visible = true;
                    txtema.Enabled = true;
                    label4.Visible = true;
                    label4.Enabled = true;
                    label5.Visible = true;
                    button2.Visible = false;
                    button2.Enabled = false;
                    label5.Enabled = true;
                    btnagregar.Enabled = true;
                    btnagregar.Visible = true;
                    btneliminar.Enabled = true;
                    btneliminar.Visible = true;
                    btnmodificar.Enabled = true;
                    btnmodificar.Visible = true;
                    btnnuevo.Enabled = true;
                    btnnuevo.Visible = true;
                    eliminar1();
                }
                else if(comboBox1.SelectedItem.ToString() == "Articulos")
                {
                    CRUD crud = new CRUD();
                    dataGridView1.DataSource = crud.llenargrid2(Conexion.Conectar());
                    label2.Text = "Precio";
                    label3.Text = "Stock";
                    txtcell.Visible = false;
                    txtcell.Enabled = false;
                    txtema.Visible = false;
                    txtema.Enabled = false;
                    comboBox2.Enabled = false;
                    comboBox2.Visible = false;
                    txtsexo.Visible = true;
                    txtsexo.Enabled = true;
                    label4.Visible = false;
                    label4.Enabled = false;
                    label5.Visible = false;
                    label5.Enabled = false;
                    button2.Visible = false;
                    button2.Enabled = false;
                    btnagregar.Enabled = true;
                    btnagregar.Visible = true;
                    btneliminar.Enabled = true;
                    btneliminar.Visible = true;
                    btnmodificar.Enabled = true;
                    btnmodificar.Visible = true;
                    btnnuevo.Enabled = true;
                    btnnuevo.Visible = true;
                    comboBox2.SelectedItem = null;
                    eliminar1();
                }
                else
                {
                    CRUD crud = new CRUD();
                    dataGridView1.DataSource = crud.llenargrid3(Conexion.Conectar());
                    button2.Visible = true;
                    button2.Enabled = true;
                    btnagregar.Enabled = false;
                    btnagregar.Visible = false;
                    btneliminar.Enabled = false;
                    btneliminar.Visible = false;
                    btnmodificar.Enabled = false;
                    btnmodificar.Visible = false;
                    btnnuevo.Enabled = false;
                    btnnuevo.Visible = false;
                    txtcell.Visible = false;
                    txtcell.Enabled = false;
                    txtema.Visible = false;
                    txtema.Enabled = false;
                    comboBox2.Enabled = false;
                    comboBox2.Visible = false;
                    label1.Visible = false;
                    label1.Enabled = false;
                    label2.Visible = false;
                    label2.Enabled = false;
                    label3.Enabled = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label4.Enabled = false;
                    label5.Visible = false;
                    label5.Enabled = false;
                    txtnom.Enabled = false;
                    txtnom.Visible = false;
                    txtape.Visible = false;
                    txtape.Enabled = false;
                    txtsexo.Visible = false;
                    txtsexo.Enabled = false;
                    

                    eliminar1();

                }
            }
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedItem.ToString() == "Clientes")
            {
                string codigo = textBox1.Text;
                string cadena = "SELECT * FROM Clientes WHERE Nombre LIKE ('" + textBox1.Text + "%') or ID LIKE ('" + textBox1.Text + "%')";
                SqlCommand comando = new SqlCommand(cadena, Conexion.Conectar());
                comando.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.SelectedItem.ToString() == "Proveedores")
            {
                string codigo = textBox1.Text;
                string cadena = "SELECT * FROM proveedores WHERE Nombre LIKE ('" + textBox1.Text + "%') or ID LIKE ('" + textBox1.Text + "%')";
                SqlCommand comando = new SqlCommand(cadena, Conexion.Conectar());
                comando.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if(comboBox1.SelectedItem.ToString() == "Articulos")
            {
                string codigo = textBox1.Text;
                string cadena = "SELECT * FROM Articulos WHERE Nombre LIKE ('" + textBox1.Text + "%') or ID LIKE ('" + textBox1.Text + "%')";
                SqlCommand comando = new SqlCommand(cadena, Conexion.Conectar());
                comando.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                string codigo = textBox1.Text;
                string cadena = "SELECT * FROM D_factura WHERE Cliente LIKE ('" + textBox1.Text + "%') or ID LIKE ('" + textBox1.Text + "%')";
                SqlCommand comando = new SqlCommand(cadena, Conexion.Conectar());
                comando.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            
            try
            {

                if (comboBox1.SelectedItem.ToString() == "Clientes")
                {
                    string insertar = "INSERT INTO Clientes(Nombre, Apellido, Sexo, Cell, Email) VALUES(@Nombre, @Apellido, @Sexo, @Cell, @Email)";
                    SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
                    cmd1.Parameters.AddWithValue("@Nombre", txtnom.Text);
                    cmd1.Parameters.AddWithValue("@Apellido", txtape.Text);
                    cmd1.Parameters.AddWithValue("@Sexo", comboBox2.SelectedItem.ToString());
                    cmd1.Parameters.AddWithValue("@Cell", txtcell.Text);
                    cmd1.Parameters.AddWithValue("@Email", txtema.Text);
                    cmd1.ExecuteNonQuery();
                    CRUD crud = new CRUD();
                    dataGridView1.DataSource = crud.llenargrid(Conexion.Conectar());

                }
                else if (comboBox1.SelectedItem.ToString() == "Proveedores")
                {
                    string insertar = "INSERT INTO proveedores(Nombre, Apellido, Sexo, Cell, Email) VALUES(@Nombre, @Apellido, @Sexo, @Cell, @Email)";
                    SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
                    cmd1.Parameters.AddWithValue("@Nombre", txtnom.Text);
                    cmd1.Parameters.AddWithValue("@Apellido", txtape.Text);
                    cmd1.Parameters.AddWithValue("@Sexo", comboBox2.SelectedItem.ToString());
                    cmd1.Parameters.AddWithValue("@Cell", txtcell.Text);
                    cmd1.Parameters.AddWithValue("@Email", txtema.Text);
                    cmd1.ExecuteNonQuery();
                    CRUD crud = new CRUD();
                    dataGridView1.DataSource = crud.llenargrid4(Conexion.Conectar());

                }
                else
                {
                    string insertar = "INSERT INTO Articulos(Nombre, Precio, Stock) VALUES(@Nombre, @Precio, @Stock)";
                    SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
                    cmd1.Parameters.AddWithValue("@Nombre", txtnom.Text);
                    cmd1.Parameters.AddWithValue("@Precio", txtape.Text);
                    cmd1.Parameters.AddWithValue("@Stock", txtsexo.Text);
                    cmd1.ExecuteNonQuery();
                    CRUD crud = new CRUD();
                    dataGridView1.DataSource = crud.llenargrid2(Conexion.Conectar());
                }

                eliminar1();
            }
            catch { }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem.ToString() == "Clientes")
                {
                    string actualizar = "UPDATE Clientes SET Nombre = @Nombre, Apellido = @Apellido, Sexo = @Sexo, Cell = @Cell, Email = @Email WHERE ID = @ID";
                    SqlCommand cmd1 = new SqlCommand(actualizar, Conexion.Conectar());
                    cmd1.Parameters.AddWithValue("@Nombre", txtnom.Text);
                    cmd1.Parameters.AddWithValue("@Apellido", txtape.Text);
                    cmd1.Parameters.AddWithValue("@Sexo", comboBox2.SelectedItem.ToString());
                    cmd1.Parameters.AddWithValue("@Cell", txtcell.Text);
                    cmd1.Parameters.AddWithValue("@Email", txtema.Text);
                    cmd1.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd1.ExecuteNonQuery();
                    CRUD crud = new CRUD();
                    dataGridView1.DataSource = crud.llenargrid(Conexion.Conectar());

                }
                else if (comboBox1.SelectedItem.ToString() == "Proveedores")
                {
                    string actualizar = "UPDATE proveedores SET Nombre = @Nombre, Apellido = @Apellido, Sexo = @Sexo, Cell = @Cell, Email = @Email WHERE ID = @ID";
                    SqlCommand cmd1 = new SqlCommand(actualizar, Conexion.Conectar());
                    cmd1.Parameters.AddWithValue("@Nombre", txtnom.Text);
                    cmd1.Parameters.AddWithValue("@Apellido", txtape.Text);
                    cmd1.Parameters.AddWithValue("@Sexo", comboBox2.SelectedItem.ToString());
                    cmd1.Parameters.AddWithValue("@Cell", txtcell.Text);
                    cmd1.Parameters.AddWithValue("@Email", txtema.Text);
                    cmd1.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd1.ExecuteNonQuery();
                    CRUD crud = new CRUD();
                    dataGridView1.DataSource = crud.llenargrid4(Conexion.Conectar());

                }
                else
                {
                    string actualizar = "UPDATE Articulos SET  Nombre = @Nombre, Precio = @Precio, Stock = @Stock WHERE ID = @ID";
                    SqlCommand cmd1 = new SqlCommand(actualizar, Conexion.Conectar());
                    cmd1.Parameters.AddWithValue("@Nombre", txtnom.Text);
                    cmd1.Parameters.AddWithValue("@Precio", txtape.Text);
                    cmd1.Parameters.AddWithValue("@Stock", txtsexo.Text);
                    cmd1.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd1.ExecuteNonQuery();
                    CRUD crud = new CRUD();
                    dataGridView1.DataSource = crud.llenargrid2(Conexion.Conectar());
                }

            }
            catch { }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Clientes")
            {
                txtnom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtape.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                comboBox2.SelectedItem = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtcell.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtema.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            else if (comboBox1.SelectedItem.ToString() == "Proveedores")
            {
                txtnom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtape.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                comboBox2.SelectedItem = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtcell.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtema.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            else
            {
                txtnom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtape.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtsexo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string eliminar;
                if (comboBox1.SelectedItem.ToString() == "Clientes")
                {
                    eliminar = "DELETE FROM Clientes WHERE ID=@ID";
                    SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
                    cmd3.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd3.ExecuteNonQuery();
                    CRUD crud = new CRUD();
                    dataGridView1.DataSource = crud.llenargrid(Conexion.Conectar());
                }
                else if (comboBox1.SelectedItem.ToString() == "Proveedores")
                {
                    eliminar = "DELETE FROM proveedores WHERE ID=@ID";
                    SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
                    cmd3.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd3.ExecuteNonQuery();
                    CRUD crud = new CRUD();
                    dataGridView1.DataSource = crud.llenargrid4(Conexion.Conectar());
                }
                else
                {

                    eliminar = "DELETE FROM Articulos WHERE ID=@ID";
                    SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
                    cmd3.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd3.ExecuteNonQuery();
                    CRUD crud = new CRUD();
                    dataGridView1.DataSource = crud.llenargrid2(Conexion.Conectar());
                }
                eliminar1();
            }
            catch { }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            eliminar1();
        }
        private void eliminar1()
        {
            txtape.Clear();
            txtnom.Clear();
            txtema.Clear();
            txtcell.Clear();
            txtsexo.Clear();
            comboBox2.SelectedItem = null;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string eliminar = "DELETE FROM D_factura WHERE ID=@ID";
            SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
            cmd3.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            cmd3.ExecuteNonQuery();
            CRUD crud = new CRUD();
            dataGridView1.DataSource = crud.llenargrid3(Conexion.Conectar());
        }

        private void txtape_TextChanged(object sender, EventArgs e)
        {

        }

        private void fACTURARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void cERRARSESIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 loggin = new Form1();
            loggin.Show();
            this.Hide();
        }

        private void aCTUALIZARUSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actualizar actualizar = new actualizar();
            actualizar.Show();
            this.Hide();
        }
    }
}
