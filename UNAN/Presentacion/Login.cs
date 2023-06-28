using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UNAN.Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btnIniciarsesion_Click(object sender, EventArgs e)
        {
            frmMenu fr = new frmMenu();
            fr.Show();
            this.Hide();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            FrmRestablecer res = new FrmRestablecer();
            res.Show();
            this.Hide();
        }
    }
}
