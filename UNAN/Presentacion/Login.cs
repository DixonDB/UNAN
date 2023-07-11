using System;
using System.Data;
using System.Windows.Forms;
using UNAN.Datos;
using UNAN.Logica;

namespace UNAN.Presentacion
{
    public partial class Login : Form
    {
        NProfes nprofes = new NProfes();
        LProfesores lprofes= new LProfesores();
        public static string nombreprofe;
        public static byte[] Icono;
        public static int idprofesor;
        public static string correo;
        public static string Tusuario;
        frmMenu f = new frmMenu();

        public Login()
        {
            InitializeComponent();
        }
        private void Logueo()
        {
            DataTable dt = new DataTable();
            lprofes.Usuario = txtusuario.Text;
            lprofes.Password = Encrip.Encriptar(Encrip.Encriptar(txtpassword.Text));
            
            try
            {
                dt = nprofes.Nprofes(lprofes);

                if (dt.Rows.Count > 0)
                {
                    idprofesor = Convert.ToInt32(dt.Rows[0][0]);
                    nombreprofe = dt.Rows[0][1].ToString();
                    Icono = (byte[])dt.Rows[0][2];
                    correo = dt.Rows[0][5].ToString();
                    Tusuario= dt.Rows[0][6].ToString();
                    f.Show();
                    this.Hide();
                    txtusuario.Clear();
                    txtpassword.Clear();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexion.cerrar();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btnIniciarsesion_Click(object sender, EventArgs e)
        {
            Logueo();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            FrmRestablecer res = new FrmRestablecer();
            res.Show();
            this.Hide();
        }
    }
}
