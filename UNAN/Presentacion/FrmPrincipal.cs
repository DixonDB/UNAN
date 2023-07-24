using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using UNAN.Datos;
using UNAN.FrmPlanDidactico;
using UNAN.Presentacion;

namespace UNAN
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        public int Idusuario;
        public string LoginV;
        string Base_De_datos = "UNAN";
        string Servidor = @".\";
        string ruta;


        private void reloj_Tick(object sender, EventArgs e)
        {
           lblReloj.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            reloj.Enabled = true;
            lblUser.Text = Login.nombreprofe;
            pbUser.BackgroundImage = null;
            byte[] b = (byte[])(Login.Icono);
            MemoryStream ms = new MemoryStream(b);
            pbUser.Image = Image.FromStream(ms);
            lbltUsuario.Text = Login.Tusuario;
            Permisos();
        }


        private void Permisos()
        {
            if (lbltUsuario.Text == "Administrativo")
            {
                btnAsistencia.Enabled = true;
            }
            if (lbltUsuario.Text == "Profesor")
            {
                btnAsistencia.Visible = true;
                btnProfesores.Visible= false;
                btnRestaurarBD.Visible = false;
            }
        }

        private void btnRestaurarBD_Click(object sender, EventArgs e)
        {
            RestaurarBd();
        }
        private void RestaurarBd()
        {
            dlg.InitialDirectory = "";
            dlg.Filter = "Backup " + Base_De_datos + "|*.bak";
            dlg.FilterIndex = 2;
            dlg.Title = "Cargador de Backup";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ruta = Path.GetFullPath(dlg.FileName);
                DialogResult pregunta = MessageBox.Show("Usted está a punto de restaurar la base de datos," + "asegurese de que el archivo .bak sea reciente, de" + "lo contrario podría perder información y no podrá" + "recuperarla, ¿desea continuar?", "Restauración de base de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (pregunta == DialogResult.Yes)
                {
                    Conexion.abrir();
                    try
                    {
                        string useMaster = "USE master";
                        SqlCommand UseMasterCommand = new SqlCommand(useMaster, Conexion.conectar);
                        UseMasterCommand.ExecuteNonQuery();

                        string Alter1 = string.Format("ALTER DATABASE [{0}] SET Single_User WITH Rollback Immediate", Base_De_datos);
                        SqlCommand AlterCmd = new SqlCommand(Alter1, Conexion.conectar);
                        AlterCmd.ExecuteNonQuery();

                        string Restore = string.Format("RESTORE DATABASE {0} FROM DISK='{1}'", Base_De_datos, ruta);
                        SqlCommand RestoreCmd = new SqlCommand(Restore, Conexion.conectar);
                        RestoreCmd.ExecuteNonQuery();

                        string Alter2 = string.Format("ALTER DATABASE [{0}] SET Multi_User", Base_De_datos);
                        SqlCommand Alter2Cmd = new SqlCommand(Alter2, Conexion.conectar);
                        Alter2Cmd.ExecuteNonQuery();
                        MessageBox.Show("La base de datos ha sido restaurada satisfactoriamente! Vuelve a Iniciar El Aplicativo", "Restauración de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        Conexion.cerrar();
                    }
                }
            }

        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            pn12.Controls.Clear();
            UCControlAsistencia P = new UCControlAsistencia();
            P.Dock = DockStyle.Fill;
            pn12.Controls.Add(P);
            btnTitulo.Text = "Asistencia";
            //Control de botones
            btnAsistencia.Enabled = false;
            btnProfesores.Enabled = true;
            btnReportes.Enabled = true;
            btnPlanEst.Enabled = true;
            btnAvanceProg.Enabled = true;
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        { 
            #region funcionactual
            pn12.Controls.Clear();
            UCProfes P = new UCProfes();
            P.Dock = DockStyle.Fill;
            pn12.Controls.Add(P);
            btnTitulo.Text = "Personal";
            //Control de botones
            btnAsistencia.Enabled = true;
            btnProfesores.Enabled = false;
            btnReportes.Enabled = true;
            btnPlanEst.Enabled = true;
            btnAvanceProg.Enabled = true;
            #endregion
        }

        private void btnPlanEst_Click(object sender, EventArgs e)
        {
            pn12.Controls.Clear();
            UCPlanDidactico plan = new UCPlanDidactico();
            plan.Dock = DockStyle.Fill;
            pn12.Controls.Add(plan);
            btnTitulo.Text = "Plan Didáctico Semestral";
            //Control de botones
            btnAsistencia.Enabled = true;
            btnProfesores.Enabled = true;
            btnReportes.Enabled = true;
            btnPlanEst.Enabled = false;
            btnAvanceProg.Enabled = true;
        }

        private void btnAvanceProg_Click(object sender, EventArgs e)
        {
            pn12.Controls.Clear();
            UCAvanceP avance = new UCAvanceP();
            avance.Dock = DockStyle.Fill;
            pn12.Controls.Add(avance);
            btnTitulo.Text = "Avance Programático";
            //Control de botones
            btnAsistencia.Enabled = true;
            btnProfesores.Enabled = true;
            btnReportes.Enabled = true;
            btnPlanEst.Enabled = true;
            btnAvanceProg.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            pn12.Controls.Clear();
            UCGraficos plan = new UCGraficos();
            plan.Dock = DockStyle.Fill;
            pn12.Controls.Add(plan);
            btnTitulo.Text = "Reportes";
            //Control de botones
            btnAsistencia.Enabled = true;
            btnProfesores.Enabled = true;
            btnReportes.Enabled = false;
            btnPlanEst.Enabled = true;
            btnAvanceProg.Enabled = true;
        }


        private void pbUser_Click(object sender, EventArgs e)
        {
            FrmPerfil perfil = new FrmPerfil();
            perfil.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmPerfil perfil = new FrmPerfil();
            perfil.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
            Login fr =new Login();
            fr.Show();
        }
    }
}
