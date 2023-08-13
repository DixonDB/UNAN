using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNAN.Datos;

namespace UNAN.Presentacion
{
    public partial class FrmRestablecer : Form
    {
        private int conteo;
        string contraseñaGenerada;
        public FrmRestablecer()
        {
            InitializeComponent();
            conteo = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Dispose();
        }
        private void GenerarPass()
        {
            contraseñaGenerada = Validaciones.GenerarContraseñaAleatoria();
        }
        public string RecuperarPass(string pass)
        {
            return new DRecuperacion().RecoverPassword2(pass, contraseñaGenerada);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            lblMsj.Text = "";
            GenerarPass();
            pbrInicio.Visible = true;
            lblProgress.Visible = true;
            lblProgress.BringToFront();
            timer1.Enabled = true;
            pbrInicio.Value = 0;
            conteo = 0;
        }

        private async Task Enviar()
        {
            await Task.Delay(1500);
            var result = RecuperarPass(txtUser.Text);
            lblMsj.Text = result;
            await Task.Delay(1000);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            conteo += 10;
            lblProgress.Text = conteo.ToString() + " %";
            if (conteo >= 50)
            {
                lblProgress.BackColor = Color.FromArgb(6, 176, 37);
            }
            else
            {
                lblProgress.BackColor = Color.White;
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
