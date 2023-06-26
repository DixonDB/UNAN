using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
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
            panelRegitroP.Visible = true;
            panelRegitroP.Dock = DockStyle.Fill;
            btnGuardar.Visible = true;
            btnActualizar.Visible = false;
            this.Limpiar();
            PanelPaginado.Visible = false;
            MostrarModulos();
            string contraseñaGenerada = GenerarContraseñaAleatoria();
            txtContraseña.Text = contraseñaGenerada;
            ActualizarVisibilidadEtiquetas(contraseñaGenerada); ;
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
            dataProfesores.Columns[2].Visible = false;
            dataProfesores.Columns[8].Visible = false;
            dataProfesores.Columns[9].Visible = false;
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
            MemoryStream ms = new MemoryStream();
            Icono.Image.Save(ms, Icono.Image.RawFormat);
            parametros.Icono = ms.GetBuffer();
            if (funcion.InsertarProfesores(parametros) == true)
            {
                InsertarPermisos();
                ObtenerIdProfesor();
                MostrarProfessores();
                panelRegitroP.Visible = false;

            }
        }
        private void MostrarModulos()
        {
            DModulos funcion = new DModulos();
            DataTable dt = new DataTable();
            funcion.mostrar_Modulos(ref dt);
            datalistadoModulos.DataSource = dt;
            datalistadoModulos.Columns[1].Visible = false;
        }
        private void MostrarPermisos()
        {
            DataTable dt = new DataTable();
            DPermisos funcion = new DPermisos();
            Lpermisos parametros = new Lpermisos();
            foreach (DataRow rowPermisos in dt.Rows)
            {
                int idmoduloPermisos = Convert.ToInt32(rowPermisos["IdModulo"]);
                foreach (DataGridViewRow rowModulos in datalistadoModulos.Rows)
                {
                    int Idmodulo = Convert.ToInt32(rowModulos.Cells["IdModulo"].Value);
                    if (idmoduloPermisos == Idmodulo)
                    {
                        rowModulos.Cells[0].Value = true;
                    }
                }
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
            if (validar())
            {
                if (lblanuncioIcono.Visible == false)
                {
                    InsertarProfesores();
                    MostrarProfessores();
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
        private void MostrarProfessores()
        {
            DataTable dt = new DataTable();
            DProfesores funcion = new DProfesores();
            funcion.MostrarProfesores(ref dt, desde, hasta);
            dataProfesores.DataSource = dt;
            DiseñarDtvProfes();
        }

        private void UCProfesores_Load(object sender, EventArgs e)
        {
            ReiniciarPaginado();
            MostrarProfessores();
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
                    Obtenerdatos();
                }

            }
        }
        private void EliminarProfes()
        {
            Idprofesor = Convert.ToInt32(dataProfesores.SelectedCells[2].Value);
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
            Idprofesor = Convert.ToInt32(dataProfesores.SelectedCells[2].Value);
            usuario = dataProfesores.SelectedCells[10].Value.ToString();

        }
        private void ObtenerEstado()
        {
            Estado = dataProfesores.SelectedCells[10].Value.ToString();
        }
        private void Obtenerdatos()
        {
            capturaridprofesor();
            Idprofesor = Convert.ToInt32(dataProfesores.SelectedCells[2].Value);
            Estado = dataProfesores.SelectedCells[7].Value.ToString();
            if (Estado == "ELIMINADO")
            {
                RestaurarP();
            }
            else
            {
                txtNombreApellidos.Text = dataProfesores.SelectedCells[3].Value.ToString();
                txtCorreo.Text = dataProfesores.SelectedCells[4].Value.ToString();
                txtCelular.Text = dataProfesores.SelectedCells[5].Value.ToString();
                txtIdentificacion.Text = dataProfesores.SelectedCells[6].Value.ToString();
                txtUsuario.Text = dataProfesores.SelectedCells[7].Value.ToString();
                txtContraseña.Text = Encrip.DesEncriptar(Encrip.DesEncriptar(dataProfesores.SelectedCells[8].Value.ToString()));
                Icono.BackgroundImage = null;
                byte[] b = (byte[])(dataProfesores.SelectedCells[9].Value);
                MemoryStream ms = new MemoryStream(b);
                Icono.Image = Image.FromStream(ms);
                PanelPaginado.Visible = false;
                panelRegitroP.Visible = true;
                panelRegitroP.Dock = DockStyle.Fill;
                btnGuardar.Visible = true;
                btnGuardar.Visible = false;
                btnActualizar.Visible = true;
                lblanuncioIcono.Visible = false;
                MostrarModulos();
                MostrarPermisos();
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
            DiseñarDtvProfes();
            timer1.Stop();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                EditarProfesores();
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
            MemoryStream ms = new MemoryStream();
            Icono.Image.Save(ms, Icono.Image.RawFormat);
            parametros.Icono = ms.GetBuffer();
            if (funcion.EditarProfesores(parametros) == true)
            {
                MostrarProfessores();
                panelRegitroP.Visible = false;
            }
            MessageBox.Show("Se Edito correctamente");
        }

        private void btnVolverPersonal_Click(object sender, EventArgs e)
        {
            panelRegitroP.Visible = false;
            PanelPaginado.Visible = true;
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
            dlg.Title = "Cargador de imagenes";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Icono.BackgroundImage = null;
                Icono.Image = new Bitmap(dlg.FileName);
                lblanuncioIcono.Visible = false;
            }
        }
        private void Icono_Click(object sender, EventArgs e)
        {
            dlg.InitialDirectory = "";
            dlg.Filter = "Imagenes|*.jpg;*.png";
            dlg.FilterIndex = 2;
            dlg.Title = "Cargador de imagenes";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Icono.BackgroundImage = null;
                Icono.Image = new Bitmap(dlg.FileName);
                lblanuncioIcono.Visible = false;
            }
        }
        private void InsertarPermisos()
        {
            foreach (DataGridViewRow row in datalistadoModulos.Rows)
            {
                int Idmodulo = Convert.ToInt32(row.Cells["IdModulo"].Value);
                bool marcado = Convert.ToBoolean(row.Cells["Marcar"].Value);
                if (marcado == true)
                {
                    Lpermisos parametros = new Lpermisos();
                    DPermisos funcion = new DPermisos();
                    parametros.IdModulo = Idmodulo;
                    parametros.IdProfesor = Idprofesor;
                    funcion.Insertar_Permisos(parametros);
                }
            }
            MostrarProfessores();
            panelRegitroP.Visible = false;
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
            ActualizarVisibilidadEtiquetas(contra);

            // Verificar si la contraseña cumple con los criterios
            bool cumpleCriterios = ContraseñaCumpleCriterios(contra) && contra.Length >= 8;

            // Cambiar el color del Label según si cumple los criterios
            label15.ForeColor = cumpleCriterios ? Color.Green : Color.Red;
            // Actualizar los colores de los labels y validar si todos están en verde
            labelsVerdes = ValidarLabelsVerdes();

            // Habilitar o deshabilitar el botón btnGuardar
            btnGuardar.Enabled = cumpleCriterios && labelsVerdes;
            btnActualizar.Enabled = cumpleCriterios && labelsVerdes;
        }

        private void ActualizarVisibilidadEtiquetas(string contra)
        {
            bool mayuscula = false, minuscula = false, numero = false, caracespecial = false;

            foreach (char c in contra)
            {
                if (char.IsUpper(c))
                {
                    mayuscula = true;
                }
                else if (char.IsLower(c))
                {
                    minuscula = true;
                }
                else if (char.IsDigit(c))
                {
                    numero = true;
                }
                else if (SpecialCharacters.Contains(c))
                {
                    caracespecial = true;
                }
            }

            lblMayu.Visible = !mayuscula;
            lblMin.Visible = !minuscula;
            lblNum.Visible = !numero;
            lblCarEsp.Visible = !caracespecial;
        }

        private static readonly Random random = new Random();
        private const string UpperCaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string LowerCaseLetters = "abcdefghijklmnopqrstuvwxyz";
        private const string Numbers = "0123456789";
        private const string SpecialCharacters = "!@#$%^&*()";

        private string GenerarContraseñaAleatoria()
        {
            int longitud = 8; // Longitud mínima de la contraseña
            string caracteres = UpperCaseLetters + LowerCaseLetters + Numbers + SpecialCharacters;

            // Asegurarse de que la contraseña cumpla con los criterios mínimos
            while (true)
            {
                StringBuilder contraseña = new StringBuilder();
                contraseña.Append(RandomCharacter(UpperCaseLetters));
                contraseña.Append(RandomCharacter(LowerCaseLetters));
                contraseña.Append(RandomCharacter(Numbers));
                contraseña.Append(RandomCharacter(SpecialCharacters));

                // Generar caracteres aleatorios adicionales
                for (int i = 4; i < longitud; i++)
                {
                    contraseña.Append(RandomCharacter(caracteres));
                }

                // Mezclar los caracteres aleatoriamente
                contraseña = new StringBuilder(new string(contraseña.ToString().ToCharArray().OrderBy(c => random.Next()).ToArray()));

                // Comprobar si la contraseña cumple con los criterios
                if (ContraseñaCumpleCriterios(contraseña.ToString()))
                {
                    return contraseña.ToString();
                }
            }
        }

        private char RandomCharacter(string caracteres)
        {
            int indice = random.Next(0, caracteres.Length);
            return caracteres[indice];
        }

        private bool ContraseñaCumpleCriterios(string contraseña)
        {
            bool mayuscula = false, minuscula = false, numero = false, caracespecial = false;

            foreach (char c in contraseña)
            {
                if (char.IsUpper(c))
                {
                    mayuscula = true;
                }
                else if (char.IsLower(c))
                {
                    minuscula = true;
                }
                else if (char.IsDigit(c))
                {
                    numero = true;
                }
                else if (SpecialCharacters.Contains(c))
                {
                    caracespecial = true;
                }
            }
            return mayuscula && minuscula && numero && caracespecial;
        }
        //-------------------otros metodos--------------

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;

            if (textBox == txtIdentificacion)
            {
                lblIdentificacion.ForeColor = string.IsNullOrEmpty(txtIdentificacion.Text) ? Color.Red : Color.Green;

                // Actualizar los colores de los labels y validar si todos están en verde
                labelsVerdes = ValidarLabelsVerdes();

                // Habilitar o deshabilitar el botón guardar según el estado de los labels
                btnGuardar.Enabled = labelsVerdes;
                btnActualizar.Enabled = labelsVerdes;
            }

            if (textBox == txtNombreApellidos)
            {
                lblNombreApellidos.ForeColor = string.IsNullOrEmpty(txtNombreApellidos.Text) ? Color.Red : Color.Green;
                txtUsuario.Text = GenerarUsuario(txtNombreApellidos.Text);

                // Actualizar los colores de los labels y validar si todos están en verde
                labelsVerdes = ValidarLabelsVerdes();

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
                labelsVerdes = ValidarLabelsVerdes();

                // Habilitar o deshabilitar el botón guardar según el estado de los labels
                btnGuardar.Enabled = labelsVerdes;
                btnActualizar.Enabled= labelsVerdes;
            }

            if (textBox == txtCorreo)
            {
                lblCorreo.ForeColor = EsCorreoValido(txtCorreo.Text) ? Color.Green : Color.Red;
                // Actualizar los colores de los labels y validar si todos están en verde
                labelsVerdes = ValidarLabelsVerdes();

                // Habilitar o deshabilitar el botón guardar según el estado de los labels
                btnGuardar.Enabled = labelsVerdes;
                btnActualizar.Enabled = labelsVerdes;
            }

            if (textBox == txtUsuario)
            {
                lblUsuario.ForeColor = string.IsNullOrEmpty(txtUsuario.Text) ? Color.Red : Color.Green;
                // Actualizar los colores de los labels y validar si todos están en verde
                labelsVerdes = ValidarLabelsVerdes();

                // Habilitar o deshabilitar el botón guardar según el estado de los labels
                btnGuardar.Enabled = labelsVerdes;
                btnActualizar.Enabled = labelsVerdes;
            }
        }

        // Función para validar si un correo es válido
        private bool EsCorreoValido(string correo)
        {
            // Expresión regular para validar el formato del correo
            string patronCorreo = @"^[a-zA-Z0-9_.+-]+@(gmail\.com|yahoo\.com|hotmail\.com|estu\.unan\.edu\.ni|\w+\.(com|es|net|org))$";

            // Realizar la validación del formato utilizando la expresión regular
            bool formatoValido = System.Text.RegularExpressions.Regex.IsMatch(correo, patronCorreo);

            // Retorna el resultado de la validación de formato
            return formatoValido;
        }

        private string GenerarUsuario(string nombreApellidos)
        {
            // Obtener los nombres y apellidos separados
            var partes = nombreApellidos.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Validar que exista al menos un nombre y un apellido
            if (partes.Length < 2)
            {
                return string.Empty;
            }

            // Generar el usuario con el primer nombre, un punto y las iniciales del segundo nombre y los apellidos
            string usuario = partes[0] + ".";

            for (int i = 1; i < partes.Length; i++)
            {
                usuario += partes[i][0];
            }

            return usuario;
        }
        // Función para validar si todos los labels están en verde
        private bool ValidarLabelsVerdes()
        {
            return lblNombreApellidos.ForeColor == Color.Green
                && lblIdentificacion.ForeColor == Color.Green
                && lblCelular.ForeColor == Color.Green
                && lblCorreo.ForeColor == Color.Green
                && lblUsuario.ForeColor == Color.Green;
        }
    }
}
