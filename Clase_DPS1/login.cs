using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_DPS1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if(User.Text == "1")
            {
                if(Pass.Text == "1")
                {
                    central_admin v1 = new central_admin();
                    this.Hide();
                    v1.Show();
                }
                else
                {
                    MessageBox.Show("Clave incorrecta intente de nuevo");
                    User.Clear();
                    Pass.Clear();
                }
            }
            if (User.Text == "2")
            {
                if (Pass.Text == "2")
                {
                    central_user v1 = new central_user();
                    this.Hide();
                    v1.Show();
                }
                else
                {
                    MessageBox.Show("Clave incorrecta intente de nuevo");
                    User.Clear();
                    Pass.Clear();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
