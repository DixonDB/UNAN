using System;
using System.Drawing;
using System.Windows.Forms;

namespace UNAN.Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciarsesion_Click(object sender, EventArgs e)
        {
            frmMenu fr = new frmMenu();
            fr.ShowDialog();
            this.Dispose();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            FrmRestablecer res= new FrmRestablecer();
            res.Show();
            this.Hide();
        }
    }
}
