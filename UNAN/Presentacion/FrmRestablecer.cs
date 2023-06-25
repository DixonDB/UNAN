﻿using System;
using System.Drawing;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using UNAN.Datos;

namespace UNAN.Presentacion
{
    public partial class FrmRestablecer : Form
    {
        private int conteo;
        public FrmRestablecer()
        {
            InitializeComponent();
            conteo = 0;
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
            pbrInicio.Visible = true;
            lblProgress.Visible = true;
            timer1.Enabled = true;
            pbrInicio.Value = 0;
            conteo = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            conteo += 10;
            lblProgress.Text = conteo.ToString() + " %";

            if (conteo >= 50)
            {
                lblProgress.BackColor = Color.FromArgb(6, 176, 37);
            }

            if (pbrInicio.Value < 100)
            {
                pbrInicio.Value += 10;
            }

            if (pbrInicio.Value == 100)
            {
                timer1.Enabled = false;
                var result = RecuperarPass(txtUser.Text);
                lblMsj.Text = result;
            }

        }
    }
}
