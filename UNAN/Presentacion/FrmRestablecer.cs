using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UNAN.Datos;

namespace UNAN.Presentacion
{
    public partial class FrmRestablecer : Form
    {
        public FrmRestablecer()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            Dispose();
        }

        public string RecuperarPass(string pass)
        {
            return new DRecuperacion().recoverPassword(pass);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var result=RecuperarPass(txtUser.Text);
            lblMsj.Text = result;
        }
    }
}
