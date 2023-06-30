using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UNAN.Logica;
using UNAN.Datos;
using UNAN.Presentacion;
using System.IO;

namespace UNAN.Presentacion
{
    public partial class Login : Form
    {
        NProfes nprofes = new NProfes();
        LProfesores lprofes= new LProfesores();
        public static string nombreprofe;
        public static byte[] Icono;
        public static int idprofesor;
        frmMenu f = new frmMenu();

        public Login()
        {
            InitializeComponent();
        }
        private void Logueo()
        {
            DataTable dt = new DataTable();
            lprofes.Usuario= txtusuario.Text;
            lprofes.Password= Encrip.Encriptar(Encrip.Encriptar(txtpassword.Text));

            dt = nprofes.Nprofes(lprofes);
            if(dt.Rows.Count > 0 )
            {
                //MessageBox.Show("Bienvenido al sistema " + dt.Rows[0][1].ToString(), "Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information );
                idprofesor = Convert.ToInt32(dt.Rows[0][0]);
                nombreprofe = dt.Rows[0][1].ToString();
                Icono = (byte[])dt.Rows[0][2];
                f.Show();
                this.Hide();
                txtusuario.Clear();
                txtpassword.Clear();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btnIniciarsesion_Click(object sender, EventArgs e)
        {
            Logueo();
            //frmMenu fr = new frmMenu();
            //fr.Show();
            //this.Hide();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            FrmRestablecer res = new FrmRestablecer();
            res.Show();
            this.Hide();
        }
     
     
    }
}
