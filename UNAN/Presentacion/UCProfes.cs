using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNAN.Datos;
using UNAN.Logica;

namespace UNAN.Presentacion
{
    public partial class UCProfes : UserControl
    {
        /// <summary>
        /// Método que genera c# para inicializar los componentes que estén dentro de él
        /// En este caso se agregan SetToolTip para mostrar msj de ayuda sobre los campos
        /// </summary>
        private int conteo;
        string contraseñaGenerada;
        public UCProfes()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.txtContraseña, "La contraseña debe ser segura, debe contener al menos 8 caracteres, 1 mayúscula, 1 minúscula y un carácter especial");
            this.toolTip1.SetToolTip(this.txtCorreo, "El correo debe ser institucional ejemplo: nombre@estu.unan.edu.ni");
            //Incribiendo todos los eventos  TextChanged de los textbox para ser utilizados en un solo metodo
            txtIdentificacion.TextChanged += TextBox_TextChanged;
            txtNombreApellidos.TextChanged += TextBox_TextChanged;
            txtCelular.TextChanged += TextBox_TextChanged;
            txtCorreo.TextChanged += TextBox_TextChanged;
            txtUsuario.TextChanged += TextBox_TextChanged;
            conteo = 0;
        }
        /// <summary>
        /// Variables globales utilizadas para la paginación de los datos en el DataGrid view
        /// </summary>
        int desde = 1;
        int hasta = 10;
        int Contador;
        int Idprofesor;
        private int items_por_pagina = 10;
        string Estado;
        int totalPaginas;
        string usuario;
        // Declarar variable para realizar seguimiento de los labels en verde
        private bool labelsVerdes = false;
        /// <summary>
        /// Evento click del btnAgregar en el cual se muestra el panelRegistroP el cual contiene los campos necesarios para crear un registro de un profesor
        /// Tambien se llama al método contraseñaGenerada el cual genera una contraseña segura en el txtcontraseña y valida que la contraseña generada sea segura y cumpla
        /// con ciertos requisitos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            btnVolverPersonal.Visible = true;
            panelRegitroP.Visible = true;
            panelRegitroP.Dock = DockStyle.Fill;
            btnGuardar.Visible = true;
            btnActualizar.Visible = false;
            this.Limpiar();
            PanelPaginado.Visible = false;
            contraseñaGenerada = Validaciones.GenerarContraseñaAleatoria();
            txtContraseña.Text = contraseñaGenerada;
            Validaciones.ActualizarVisibilidadEtiquetas(contraseñaGenerada, lblMayu, lblMin, lblNum, lblCarEsp);
            txtContraseña.Visible = true;
            label6.Visible = true;
            label7.Visible=true;
            label15.Visible=true;
            lblMayu.Visible=true;
            lblMin.Visible=true;
            lblNum.Visible=true;
            lblCarEsp.Visible=true;
            panel10.Visible = true;
            txtbuscador.Visible = false;
            pictureBox1.Visible = false;
            btnMostrarTodos.Visible = false;
            panel3.Visible = false;
            cbTUsuario.Enabled = true;
            panel1.Visible = false;
        }
        /// <summary>
        /// Método para limpiar el contenido de los textbox que se utilizarán para crear un nuevo registro.
        /// </summary>
        private void Limpiar()
        {
            txtNombreApellidos.Clear();
            txtIdentificacion.Clear();
            txtCelular.Clear();
            txtCorreo.Clear();
            txtUsuario.Clear();
            Icono.Controls.Clear();
            lblanuncioIcono.Visible = true;
            txtContraseña.Clear();

        }
        /// <summary>
        /// Método que sirve para cambiar el diseño al DataGrid view
        /// </summary>
        private void DiseñarDtvProfes()
        {
            Bases.DiseñoDtv(ref dataProfesores);
            Bases.DiseñoDtvEliminar(ref dataProfesores);
            PanelPaginado.Visible = true;
            dataProfesores.Columns[6].Visible = false;
            dataProfesores.Columns[12].Visible = false;
            dataProfesores.Columns[14].Visible = false;
            dataProfesores.Columns[15].Visible = false;

        }
        /// <summary>
        /// Método para insertar los registros a la base de datos.
        /// </summary>
        private void InsertarProfesores()
        {
            LProfesores parametros = new LProfesores();
            DProfesores funcion = new DProfesores();
            parametros.NombreApellido = txtNombreApellidos.Text;
            parametros.CorreoP = txtCorreo.Text;
            parametros.CelularP = int.Parse(txtCelular.Text);
            parametros.CarnetP = txtIdentificacion.Text;
            parametros.Usuario = txtUsuario.Text;
            parametros.Password = Encrip.Encriptar(Encrip.Encriptar(txtContraseña.Text));
            parametros.TUsuario= cbTUsuario.Text;
            MemoryStream ms = new MemoryStream();
            Icono.Image.Save(ms, Icono.Image.RawFormat);
            parametros.Icono = ms.GetBuffer();
            if (funcion.InsertarProfesores(parametros) == true)
            {
                ObtenerIdProfesor();
                MostrarProfessores();
                panelRegitroP.Visible = false;
                ReiniciarPaginado();
                txtbuscador.Visible = true;
                pictureBox1.Visible = true;
                btnMostrarTodos.Visible = true;
                panel3.Visible = true;

            }
        }
        private void ObtenerIdProfesor()
        {
            DProfesores funcion = new DProfesores();
            funcion.ObtenerIdProfesor(ref Idprofesor, txtUsuario.Text);
        }
        private void ReiniciarPaginado()
        {
            desde = 1;
            hasta = 10;
            Contar();

            if (Contador > hasta)
            {

                btn_Sig.Visible = true;
                btn_atras.Visible = false;
                btn_Ultima.Visible = true;
                btn_Primera.Visible = true;
            }
            else
            {

                btn_Sig.Visible = false;
                btn_atras.Visible = false;
                btn_Ultima.Visible = false;
                btn_Primera.Visible = false;
            }
            Paginar();
        }
        private void Contar()
        {
            DProfesores funcion = new DProfesores();
            funcion.ContarProfesores(ref Contador);
        }
        private void Paginar()
        {
            try
            {
                lbl_Pagina.Text = (hasta / items_por_pagina).ToString();
                lbl_totalPaginas.Text = Math.Ceiling(Convert.ToSingle(Contador) / items_por_pagina).ToString();
                totalPaginas = Convert.ToInt32(lbl_totalPaginas.Text);
            }
            catch (Exception)
            {

            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    if (lblanuncioIcono.Visible == false)
                    {
                        InsertarProfesores();
                    }
                    else
                    {
                        MessageBox.Show("Ingresa un Icono Para agregar este Profesor");
                    }
                }
                else
                {
                    MessageBox.Show("Completa todos los campos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void MostrarProfessores()
        {
            DataTable dt = new DataTable();
            DProfesores funcion = new DProfesores();
            funcion.MostrarProfesores(ref dt, desde, hasta);
            dataProfesores.DataSource = dt;
            DiseñarDtvProfes();
        }
        private async void UCProfesores_Load(object sender, EventArgs e)
        {
            pncarga.Dock = DockStyle.Fill;
            timer1.Enabled = true;
            await CargarDatos();
            pncarga.Visible = false;
            panel1.Visible = true;
        }
        public async Task CargarDatos()
        {
            await Task.Delay(1500);
            MostrarProfessores();
            ReiniciarPaginado();
            await Task.Delay(1000);
        }
        private void dataPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ObtenerEstado();
            if (e.ColumnIndex == dataProfesores.Columns["Eliminar"].Index)
            {
                DialogResult result = MessageBox.Show("¿Solo se Cambiara el Estado para que no pueda acceder, Desea Continuar?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    EliminarProfes();
                }

            }
            if (e.ColumnIndex == dataProfesores.Columns["Editar"].Index)
            {
                ObtenerEstado();
                if (Estado == "ELIMINADO")
                {
                    RestaurarP();
                }
                else
                {
                    btnVolverPersonal.Visible = true;
                    Obtenerdatos();
                    txtbuscador.Visible = false;
                    pictureBox1.Visible = false;
                    btnMostrarTodos.Visible = false;
                    panel3.Visible = false;
                    btnAgregar.Enabled = false;
                }

            }
            if (e.ColumnIndex == dataProfesores.Columns["Enviar"].Index)
            {
                contraseñaGenerada = Validaciones.GenerarContraseñaAleatoria();
                var result = RecuperarPass(dataProfesores.SelectedCells[11].Value.ToString());
                MessageBox.Show(result, "Recuperacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void EliminarProfes()
        {
            Idprofesor = Convert.ToInt32(dataProfesores.SelectedCells[6].Value);
            LProfesores parametros = new LProfesores();
            DProfesores funcion = new DProfesores();
            parametros.IdProfesores = Idprofesor;
            if (funcion.EliminarProfesores(parametros) == true)
            {
                MostrarProfessores();
            }
        }
        private void capturaridprofesor()
        {
            Idprofesor = Convert.ToInt32(dataProfesores.SelectedCells[6].Value);
            usuario = dataProfesores.SelectedCells[14].Value.ToString();

        }
        private void ObtenerEstado()
        {
            Idprofesor = Convert.ToInt32(dataProfesores.SelectedCells[6].Value);
            Estado = dataProfesores.SelectedCells[15].Value.ToString();
        }
        private void Obtenerdatos()
        {
            capturaridprofesor();
            Idprofesor = Convert.ToInt32(dataProfesores.SelectedCells[6].Value);
            Estado = dataProfesores.SelectedCells[15].Value.ToString();
            if (Estado == "ELIMINADO")
            {
                RestaurarP();
            }
            else
            {
                txtNombreApellidos.Text = dataProfesores.SelectedCells[7].Value.ToString();
                txtCorreo.Text = dataProfesores.SelectedCells[8].Value.ToString();
                txtCelular.Text = dataProfesores.SelectedCells[9].Value.ToString();
                txtIdentificacion.Text = dataProfesores.SelectedCells[10].Value.ToString();
                txtUsuario.Text = dataProfesores.SelectedCells[11].Value.ToString();
                txtContraseña.Text = Encrip.DesEncriptar(Encrip.DesEncriptar(dataProfesores.SelectedCells[12].Value.ToString()));
                cbTUsuario.Text= dataProfesores.SelectedCells[13].Value.ToString();
                if (cbTUsuario.Text == "Administrador")
                {
                    cbTUsuario.Enabled = false;
                }
                else
                {
                    cbTUsuario .Enabled = true;
                }
                Icono.BackgroundImage = null;
                byte[] b = (byte[])(dataProfesores.SelectedCells[14].Value);
                MemoryStream ms = new MemoryStream(b);
                Icono.Image = Image.FromStream(ms);
                PanelPaginado.Visible = false;
                panelRegitroP.Visible = true;
                panelRegitroP.Dock = DockStyle.Fill;
                btnGuardar.Visible = true;
                btnGuardar.Visible = false;
                btnActualizar.Visible = true;
                lblanuncioIcono.Visible = false;
                label6.Visible = false;
                panel10.Visible = false;
                txtContraseña.Visible = false;
                Icono.Enabled = false;
                label15.Visible = false;
                label7.Visible = false;
            }

        }
        private void RestaurarP()
        {
            DialogResult result = MessageBox.Show("Este Personal se Elimino. ¿Desea Volver a Habilitarlo?", "Restauracion de registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                HabilitarPersonal();
            }
        }
        private void HabilitarPersonal()
        {
            LProfesores parametros = new LProfesores();
            DProfesores funcion = new DProfesores();
            parametros.IdProfesores = Idprofesor;
            if (funcion.restaurarProfesores(parametros) == true)
            {
                MostrarProfessores();
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            conteo += 10;
            lblCarga.Text = conteo.ToString() + " %";
            if (pbrCarga.Value < 100)
            {
                pbrCarga.Value += 10;
            }
            if (pbrCarga.Value == 100)
            {
                timer1.Enabled = false;
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                EditarProfesores();
                txtbuscador.Visible = true;
                pictureBox1.Visible = true;
                btnMostrarTodos.Visible = true;
                panel3.Visible = true;
                btnAgregar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Existen campos vacios o datos incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EditarProfesores()
        {
            LProfesores parametros = new LProfesores();
            DProfesores funcion = new DProfesores();
            parametros.IdProfesores = Idprofesor;
            parametros.NombreApellido = txtNombreApellidos.Text;
            parametros.CorreoP = txtCorreo.Text;
            parametros.CelularP = Convert.ToInt32(txtCelular.Text);
            parametros.CarnetP = txtIdentificacion.Text;
            parametros.Usuario = txtUsuario.Text;
            parametros.Password = Encrip.Encriptar(Encrip.Encriptar(txtContraseña.Text));            
            parametros.TUsuario = cbTUsuario.Text;
            MemoryStream ms = new MemoryStream();
            Icono.Image.Save(ms, Icono.Image.RawFormat);
            parametros.Icono = ms.GetBuffer();
            if (funcion.EditarProfesores(parametros) == true)
            {
                MessageBox.Show("Se Edito correctamente");
                MostrarProfessores();
                panelRegitroP.Visible = false;
            }
        }
        private void btnVolverPersonal_Click(object sender, EventArgs e)
        {
            btnVolverPersonal.Visible = false;
            panelRegitroP.Visible = false;
            PanelPaginado.Visible = true;
            txtbuscador.Visible = true;
            pictureBox1.Visible = true;
            btnMostrarTodos.Visible = true;
            panel3.Visible = true;
            btnAgregar.Enabled = true;
            panel1.Visible = true;
        }
        private void btn_atras_Click(object sender, EventArgs e)
        {
            desde -= 10;
            hasta -= 10;
            MostrarProfessores();
            Contar();
            if (Contador > hasta)
            {
                btn_Sig.Visible = true;
                btn_atras.Visible = true;
            }
            else
            {
                btn_Sig.Visible = false;
                btn_atras.Visible = true;
            }
            if (desde == 1)
            {
                ReiniciarPaginado();
            }
            Paginar();
        }
        private void btn_Sig_Click(object sender, EventArgs e)
        {

            desde += 10;
            hasta += 10;
            MostrarProfessores();
            Contar();
            if (Contador > hasta)
            {
                btn_Sig.Visible = true;
                btn_atras.Visible = true;
            }
            else
            {
                btn_Sig.Visible = false;
                btn_atras.Visible = true;
            }
            Paginar();
        }
        private void btn_Ultima_Click(object sender, EventArgs e)
        {
            hasta = totalPaginas * items_por_pagina;
            desde = hasta - 9;
            MostrarProfessores();
            Contar();
            if (Contador > hasta)
            {
                btn_Sig.Visible = true;
                btn_atras.Visible = true;
            }
            else
            {
                btn_Sig.Visible = false;
                btn_atras.Visible = true;
            }
            Paginar();
        }
        private void btn_Primera_Click(object sender, EventArgs e)
        {
            ReiniciarPaginado();
            MostrarProfessores();
        }
        private void lblanuncioIcono_Click(object sender, EventArgs e)
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
                    lblanuncioIcono.Visible = false;
                }
                else
                {
                    MessageBox.Show("El tamaño de la imagen seleccionada debe ser menor o igual a 4 MB.", "Tamaño de imagen excedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                    lblanuncioIcono.Visible = false;
                }
                else
                {
                    MessageBox.Show("El tamaño de la imagen seleccionada debe ser menor o igual a 4 MB.", "Tamaño de imagen excedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
             txtCelular.Text == ""||txtUsuario.Text==""||txtContraseña.Text=="");

        }        
        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            string contra = txtContraseña.Text;
             Validaciones.ActualizarVisibilidadEtiquetas(contra, lblMayu, lblMin, lblNum, lblCarEsp);

            //// Verificar si la contraseña cumple con los criterios
             bool cumpleCriterios = Validaciones.ContraseñaCumpleCriterios(contra) && contra.Length >= 8;

            // Cambiar el color del Label según si cumple los criterios
            label15.ForeColor = cumpleCriterios ? Color.Green : Color.Red;
            // Actualizar los colores de los labels y validar si todos están en verde
            labelsVerdes = Validaciones.ValidarLabelsVerdes(lblNombreApellidos, lblIdentificacion, lblCelular, lblCorreo, lblUsuario);

            // Habilitar o deshabilitar el botón btnGuardar
            btnGuardar.Enabled = cumpleCriterios && labelsVerdes;
            btnActualizar.Enabled = cumpleCriterios && labelsVerdes;
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = (System.Windows.Forms.TextBox)sender;

            if (textBox == txtIdentificacion)
            {
                lblIdentificacion.ForeColor = string.IsNullOrEmpty(txtIdentificacion.Text) ? Color.Red : Color.Green;

                // Actualizar los colores de los labels y validar si todos están en verde
                labelsVerdes = Validaciones.ValidarLabelsVerdes(lblNombreApellidos, lblIdentificacion, lblCelular, lblCorreo, lblUsuario);

                // Habilitar o deshabilitar el botón guardar según el estado de los labels
                btnGuardar.Enabled = labelsVerdes;
                btnActualizar.Enabled = labelsVerdes;
            }

            if (textBox == txtNombreApellidos)
            {
                lblNombreApellidos.ForeColor = string.IsNullOrEmpty(txtNombreApellidos.Text) ? Color.Red : Color.Green;
                txtUsuario.Text = Validaciones.GenerarUsuario(txtNombreApellidos.Text);

                // Actualizar los colores de los labels y validar si todos están en verde
                labelsVerdes = Validaciones.ValidarLabelsVerdes(lblNombreApellidos, lblIdentificacion, lblCelular, lblCorreo, lblUsuario);

                // Habilitar o deshabilitar el botón guardar según el estado de los labels
                btnGuardar.Enabled = labelsVerdes;
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

                // Habilitar o deshabilitar el botón guardar según el estado de los labels
                btnGuardar.Enabled = labelsVerdes;
                btnActualizar.Enabled = labelsVerdes;
            }

            if (textBox == txtCorreo)
            {
                lblCorreo.ForeColor = Validaciones.EsCorreoValido(txtCorreo.Text) ? Color.Green : Color.Red;
                // Actualizar los colores de los labels y validar si todos están en verde
                labelsVerdes = Validaciones.ValidarLabelsVerdes(lblNombreApellidos, lblIdentificacion, lblCelular, lblCorreo, lblUsuario);

                // Habilitar o deshabilitar el botón guardar según el estado de los labels
                btnGuardar.Enabled = labelsVerdes;
                btnActualizar.Enabled = labelsVerdes;
            }

            if (textBox == txtUsuario)
            {
                lblUsuario.ForeColor = string.IsNullOrEmpty(txtUsuario.Text) ? Color.Red : Color.Green;
                // Actualizar los colores de los labels y validar si todos están en verde
              labelsVerdes = Validaciones.ValidarLabelsVerdes(lblNombreApellidos, lblIdentificacion, lblCelular, lblCorreo, lblUsuario);

                // Habilitar o deshabilitar el botón guardar según el estado de los labels
                btnGuardar.Enabled = labelsVerdes;
                btnActualizar.Enabled = labelsVerdes;
            }
        }

        //Enviar Correo de recuperacion
        public string RecuperarPass(string pass)
        {
            return new DRecuperacion().RecoverPassword2(pass,contraseñaGenerada);
        }

        private void txtbuscador_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscador.Text=="")
            {
                ReiniciarPaginado();
                MostrarProfessores();
            }
            else
            {
                Buscador();
            }
        }
        private void Buscador()
        {
            DataTable dt = new DataTable();
            DProfesores funcion = new DProfesores();
            funcion.BuscarProfesores(ref dt, desde, hasta, txtbuscador.Text);
            dataProfesores.DataSource= dt;
            DiseñarDtvProfes();
            
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            ReiniciarPaginado();
            MostrarProfessores();
        }
    }
}
