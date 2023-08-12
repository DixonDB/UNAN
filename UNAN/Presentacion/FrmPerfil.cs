using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UNAN.Datos;
using UNAN.Logica;

namespace UNAN.Presentacion
{
    public partial class FrmPerfil : Form
    {
        private bool labelsVerdes = false;
        int id;
        private int conteo;
        string correo = Login.correo;
        public FrmPerfil()
        {
            InitializeComponent();
            MostrarDatos();
            conteo = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            Dispose();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = true;
            btnActualizar.Visible = true;
            btnEditar.Visible = false;
        }
        private void MostrarDatos()
        {
            id = Login.idprofesor;
            DProfesores profe = new DProfesores();
            DataTable dt = new DataTable();
            profe.MostrarDatos(id, dt);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtNombreApellidos.Text = row["NombreApellido"].ToString();
                txtCelular.Text = row["CelularP"].ToString();
                txtCorreo.Text = row["CorreoP"].ToString();
                txtIdentificacion.Text = row["CarnetP"].ToString();
                txtUsuario.Text = row["Usuario"].ToString();
                txtContraseña.Text = Encrip.DesEncriptar(Encrip.DesEncriptar(row["Password"].ToString()));
                Icono.BackgroundImage = null;
                byte[] b = (byte[])(row["Icono"]);
                MemoryStream ms = new MemoryStream(b);
                Icono.Image = Image.FromStream(ms);
                lblTUsuario.Text = row["TUsuario"].ToString();
            }
        }
        //Metodos de validación
        private bool validar()
        {
            double entero;
            if (!double.TryParse(txtCelular.Text, out entero))
            {
                return false;
            }
            return !(txtNombreApellidos.Text == "" || txtCorreo.Text == "" || txtIdentificacion.Text == "" ||
             txtCelular.Text == "" || txtUsuario.Text == "" || txtContraseña.Text == "");

        }
        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            string contra = txtContraseña.Text;
            
           Validaciones.ActualizarVisibilidadEtiquetas(contra, lblMayu, lblMin, lblNum, lblCarEsp);

            //// Verificar si la contraseña cumple con los criterios
            bool cumpleCriterios = Validaciones.ContraseñaCumpleCriterios(contra) && contra.Length >= 8;

            //// Cambiar el color del Label según si cumple los criterios
           label15.ForeColor = cumpleCriterios ? Color.Green : Color.Red;
            //// Actualizar los colores de los labels y validar si todos están en verde
            labelsVerdes = Validaciones.ValidarLabelsVerdes(lblNombreApellidos, lblIdentificacion, lblCelular, lblCorreo, lblUsuario);

            // Habilitar o deshabilitar el botón btnActualizar
          btnActualizar.Enabled = cumpleCriterios && labelsVerdes;
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;

            if (textBox == txtIdentificacion)
            {
                lblIdentificacion.ForeColor = string.IsNullOrEmpty(txtIdentificacion.Text) ? Color.Red : Color.Green;

                // Actualizar los colores de los labels y validar si todos están en verde
             labelsVerdes = Validaciones.ValidarLabelsVerdes(lblNombreApellidos, lblIdentificacion, lblCelular, lblCorreo, lblUsuario);

                // Habilitar o deshabilitar el botón actualizar según el estado de los labels
               
                btnActualizar.Enabled = labelsVerdes;
            }

            if (textBox == txtNombreApellidos)
            {
                lblNombreApellidos.ForeColor = string.IsNullOrEmpty(txtNombreApellidos.Text) ? Color.Red : Color.Green;
                txtUsuario.Text = Validaciones.GenerarUsuario(txtNombreApellidos.Text);

                // Actualizar los colores de los labels y validar si todos están en verde
             labelsVerdes = Validaciones.ValidarLabelsVerdes(lblNombreApellidos, lblIdentificacion, lblCelular, lblCorreo, lblUsuario);

                // Habilitar o deshabilitar el botón actualiar según el estado de los labels
                btnActualizar.Enabled = labelsVerdes;
            }

            if (textBox == txtCelular)
            {
                if (int.TryParse(txtCelular.Text, out int celular) && celular.ToString().Length >= 8)
                {
                    lblCelular.ForeColor = Color.Green;
                }
                else
                {
                    lblCelular.ForeColor = Color.Red;
                }
                // Actualizar los colores de los labels y validar si todos están en verde
               labelsVerdes = Validaciones.ValidarLabelsVerdes(lblNombreApellidos, lblIdentificacion, lblCelular, lblCorreo, lblUsuario);

                // Habilitar o deshabilitar el botón actualizar según el estado de los labels
                btnActualizar.Enabled = labelsVerdes;
            }

            if (textBox == txtCorreo)
            {
                lblCorreo.ForeColor = Validaciones.EsCorreoValido(txtCorreo.Text) ? Color.Green : Color.Red;
                // Actualizar los colores de los labels y validar si todos están en verde
               labelsVerdes = Validaciones.ValidarLabelsVerdes(lblNombreApellidos, lblIdentificacion, lblCelular, lblCorreo, lblUsuario);

                // Habilitar o deshabilitar el botón actualizar según el estado de los labels
                btnActualizar.Enabled = labelsVerdes;
            }

            if (textBox == txtUsuario)
            {
                lblUsuario.ForeColor = string.IsNullOrEmpty(txtUsuario.Text) ? Color.Red : Color.Green;
                // Actualizar los colores de los labels y validar si todos están en verde
               labelsVerdes = Validaciones.ValidarLabelsVerdes(lblNombreApellidos, lblIdentificacion, lblCelular, lblCorreo, lblUsuario);

                // Habilitar o deshabilitar el botón actualizar según el estado de los labels
                btnActualizar.Enabled = labelsVerdes;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                lblProgress.Visible = true;
                pbrInicio.Visible = true;
                lblProgress.BringToFront();
                timer1.Enabled = true;
                pbrInicio.Value = 0;
                conteo = 0;
            }
            else
            {
                MessageBox.Show("Existen campos vacios o datos incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editarProfes()
        {
            LProfesores parametros = new LProfesores();
            DProfesores funcion = new DProfesores();
            parametros.IdProfesores = id;
            parametros.NombreApellido = txtNombreApellidos.Text;
            parametros.CorreoP = txtCorreo.Text;
            parametros.CelularP = Convert.ToInt32(txtCelular.Text);
            parametros.CarnetP = txtIdentificacion.Text;
            parametros.Usuario = txtUsuario.Text;
            parametros.Password = Encrip.Encriptar(Encrip.Encriptar(txtContraseña.Text));
            MemoryStream ms = new MemoryStream();
            Icono.Image.Save(ms, Icono.Image.RawFormat);
            parametros.Icono = ms.GetBuffer();
            parametros.TUsuario = lblTUsuario.Text;
            Login.Icono = parametros.Icono;
            Login.nombreprofe = parametros.NombreApellido;
            if (funcion.EditarProfesores(parametros) == true)
            {
                MessageBox.Show("Se Edito correctamente");
                btnEditar.Visible = true;
                btnActualizar.Visible = false;
                gbDatos.Enabled = false;
            }
        }

        private void Icono_Click(object sender, EventArgs e)
        {
            dlg.InitialDirectory = "";
            dlg.Filter = "Imagenes|*.jpg;*.png";
            dlg.FilterIndex = 2;
            dlg.Title = "Seleccionar una imagen";
            dlg.CheckFileExists = true; // Verifica si el archivo seleccionado existe
            dlg.CheckPathExists = true; // Verifica si la ruta del archivo seleccionado existe

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Obtener información del archivo seleccionado
                FileInfo fileInfo = new FileInfo(dlg.FileName);

                // Verificar el tamaño del archivo (en bytes)
                if (fileInfo.Length <= 4 * 1024 * 1024) // 4 MB (4 * 1024 * 1024 bytes)
                {
                    Icono.BackgroundImage = null;
                    Icono.Image = new Bitmap(dlg.FileName);
                }
                else
                {
                    MessageBox.Show("El tamaño de la imagen seleccionada debe ser menor o igual a 4 MB.", "Tamaño de imagen excedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public string CorreoCambio(string correo)
        {
            return new DRecuperacion().NotificacionCambio(correo);
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
                var result = CorreoCambio(correo.ToString());
                editarProfes();
            }
        }
    }
}
