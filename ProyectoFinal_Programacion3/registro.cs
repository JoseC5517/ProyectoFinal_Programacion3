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
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtuser.Text != "" && txtpass.Text != "" && txtconfirm.Text != "")
                {
                    if(txtpass.Text == txtconfirm.Text)
                    {
                        string validacion = "SELECT COUNT(*) FROM usuarios where nomusu = '" + txtuser.Text + "'";
                        SqlCommand comm = new SqlCommand(validacion, Conexion.Conectar());
                        Int32 count = Convert.ToInt32(comm.ExecuteScalar());

                        if (count == 0)
                        {
                            string insertar = "INSERT INTO usuarios(nomusu,clausu) VALUES(@user, @pass)";
                            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
                            cmd1.Parameters.AddWithValue("@user", txtuser.Text);
                            cmd1.Parameters.AddWithValue("@pass", txtpass.Text);
                            cmd1.ExecuteNonQuery();
                            MessageBox.Show("✅ Usuario Registrado con éxito.");
                            this.Visible = false;
                            Form1 form1 = new Form1();
                            form1.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("🚫 Error. ¡Usuario ya existente!");
                            txtuser.Clear();
                            txtpass.Clear();
                            txtconfirm.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("⚠️ Las contraseñas no coinciden.");
                    }

                }
            }
            catch { }

        }

        private void checkBoxcontra_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxcontra.Checked == true)
            {
                txtpass.PasswordChar = '\0';
            }
            else
            {
                txtpass.PasswordChar = '#';
            }
        }

        private void checkBoxconf_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxconf.Checked == true)
            {
                txtconfirm.PasswordChar = '\0';
            }
            else
            {
                txtconfirm.PasswordChar = '#';
            }
        }


        private void sALIRToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 form1 = new Form1();
            form1.Visible = true;
        }
    }
}
