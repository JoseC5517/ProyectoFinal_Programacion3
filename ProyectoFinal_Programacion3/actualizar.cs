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
    public partial class actualizar : Form
    {
        public actualizar()
        {
            InitializeComponent();
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            if(txtcon.Text != "" && txtconfirm.Text != "" && txtNN.Text != "" && txtnombre.Text != "")
            {
                string validacion = "SELECT COUNT(*) FROM usuarios where nomusu = '" + txtnombre.Text + "'";
                SqlCommand comm = new SqlCommand(validacion, Conexion.Conectar());
                Int32 count = Convert.ToInt32(comm.ExecuteScalar());

                if (count > 0)
                {
                    string vali = "SELECT COUNT(*) FROM usuarios where nomusu = '" + txtNN.Text + "'";
                    SqlCommand com = new SqlCommand(vali, Conexion.Conectar());
                    Int32 count1 = Convert.ToInt32(com.ExecuteScalar());
                    if (count1 == 0)
                    {
                        if(txtcon.Text == txtconfirm.Text)
                        {
                            string actualizar = "UPDATE usuarios SET nomusu = @user, clausu = @pass where nomusu = '" + txtnombre.Text + "'";
                            SqlCommand cmd1 = new SqlCommand(actualizar, Conexion.Conectar());
                            cmd1.Parameters.AddWithValue("@user", txtNN.Text);
                            cmd1.Parameters.AddWithValue("@pass", txtcon.Text);
                            cmd1.ExecuteNonQuery();
                            MessageBox.Show("✅ Usuario Actualizado Correctamente.");
                            Form1 loggin = new Form1();
                            loggin.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("⚠️ Las contraseñas no coinciden.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("🚫 Error. ¡Usuario ya existente!");
                    }

                }
                else
                {
                    MessageBox.Show("🚫 Error. ¡Este Usuario no existente!");
                }

            }
        }

        private void checkBoxcontra_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxcontra.Checked == true)
            {
                txtcon.PasswordChar = '\0';
            }
            else
            {
                txtcon.PasswordChar = '#';
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
    }
}
