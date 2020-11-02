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
    public partial class central_user : Form
    {
        public central_user()
        {
            InitializeComponent();
        }

        private void btn_hi_Click(object sender, EventArgs e)
        {
            Registro_Inventario v1 = new Registro_Inventario();
            v1.Show();
        }

        private void btn_cd_Click(object sender, EventArgs e)
        {
            Corte v2 = new Corte();
            v2.Show();
        }

        private void btn_hc_Click(object sender, EventArgs e)
        {
            Historial_corte v3 = new Historial_corte();
            v3.Show();
        }

        private void btn_cs_Click(object sender, EventArgs e)
        {
            login v0 = new login();
            this.Hide();
            v0.Show();
        }
    }
}
