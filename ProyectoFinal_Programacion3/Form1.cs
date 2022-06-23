using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoFinal_Programacion3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnloggin_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion conexion = new Conexion();
                string nomusu = txtnom.Text;
                string clausu = txtcon.Text;
                DataTable tb = conexion.login(nomusu, clausu, Conexion.Conectar());

                if (tb.Rows.Count > 0)
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario incorrecto");
                    if (nomusu == "")
                    {
                        txtnom.Focus();
                    }
                    else
                    {
                        txtcon.Focus();
                    }
                }
            }
            catch { }
        }

        private void checkBoxlg_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxlg.Checked == true)
            {
                txtcon.PasswordChar = '\0';
            }
            else
            {
                txtcon.PasswordChar = '#';
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registro registro = new registro();
            registro.Show();
            this.Hide();
        }
    }
}
