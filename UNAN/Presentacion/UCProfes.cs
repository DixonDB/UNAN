using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UNAN.Logica;
using UNAN.Datos;
using System.IO;
using System.Xml.Linq;

namespace UNAN.Presentacion
{
    public partial class UCProfes : UserControl
    {
        public UCProfes()
        {
            InitializeComponent();
        }
        int desde = 1;
        int hasta = 10;
        int Contador;
        int Idprofesor;
        private int items_por_pagina = 10;
        string Estado;
        int totalPaginas;
        string usuario;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            panelRegitroP.Visible = true;
            panelRegitroP.Dock = DockStyle.Fill;
            btnGuardar.Visible = true;
            btnActualizar.Visible = false;
            this.Limpiar();
            PanelPaginado.Visible = false;
            MostrarModulos();

        }
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
        private void DiseñarDtvProfes()
        {
            Bases.DiseñoDtv(ref dataProfesores);
            Bases.DiseñoDtvEliminar(ref dataProfesores);
            PanelPaginado.Visible = true;
            dataProfesores.Columns[2].Visible = false;
            dataProfesores.Columns[9].Visible = false;
        }
        private void InsertarProfesores()
        {
            LProfesores parametros = new LProfesores();
            DProfesores funcion = new DProfesores();
            parametros.NombreApellido = txtNombreApellidos.Text;
            parametros.CorreoP = txtCorreo.Text;
            parametros.CelularP = int.Parse(txtCelular.Text);
            parametros.CarnetP = txtIdentificacion.Text;
            parametros.Usuario= txtUsuario.Text;
            parametros.Password = txtContraseña.Text;
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
            DPermisos funcion= new DPermisos();
            Lpermisos parametros= new Lpermisos();
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
            if (!string.IsNullOrEmpty(txtNombreApellidos.Text))
            {
                if (!string.IsNullOrEmpty(txtCorreo.Text))
                {
                    if (!string.IsNullOrEmpty(txtCelular.Text))
                    {
                        if (!string.IsNullOrEmpty(txtIdentificacion.Text))
                        {
                            if (!string.IsNullOrEmpty(txtUsuario.Text))
                            {
                                if (!string.IsNullOrEmpty(txtContraseña.Text))
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
                               
                            }                          
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Completa todos los campos");
                }

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
                if(result== DialogResult.OK)
                {
                    EliminarProfes();
                }
                
            }
            if (e.ColumnIndex == dataProfesores.Columns["Editar"].Index)
            {
                ObtenerEstado();
                if (Estado == "ELIMINADO")
                {
                    DialogResult resultado = MessageBox.Show("Este Usuario se Elimino. ¿Desea Volver a Habilitarlo?", "Restauracion de registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (resultado == DialogResult.OK)
                    {
                        RestaurarP();
                    }
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
                txtCorreo.Text= dataProfesores.SelectedCells[4].Value.ToString();
                txtCelular.Text = dataProfesores.SelectedCells[5].Value.ToString();
                txtIdentificacion.Text= dataProfesores.SelectedCells[6].Value.ToString();
                txtUsuario.Text = dataProfesores.SelectedCells[7].Value.ToString();
                txtContraseña.Text= dataProfesores.SelectedCells[8].Value.ToString();
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
            EditarProfesores();
        }
        private void EditarProfesores()
        {
            LProfesores parametros= new LProfesores();
            DProfesores funcion= new DProfesores();
            parametros.IdProfesores= Idprofesor;
            parametros.NombreApellido = txtNombreApellidos.Text;
            parametros.CorreoP = txtCorreo.Text;
            parametros.CelularP =Convert.ToInt32( txtCelular.Text);
            parametros.CarnetP = txtIdentificacion.Text;
            parametros.Usuario= txtUsuario.Text;
            parametros.Password = txtContraseña.Text;
            MemoryStream ms = new MemoryStream();
            Icono.Image.Save(ms, Icono.Image.RawFormat);
            parametros.Icono = ms.GetBuffer();
            if (funcion.EditarProfesores(parametros)==true)
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
                int Idmodulo= Convert.ToInt32(row.Cells["IdModulo"].Value);
                bool marcado = Convert.ToBoolean(row.Cells["Marcar"].Value);
                if (marcado== true)
                {
                    Lpermisos parametros= new Lpermisos();
                    DPermisos funcion= new DPermisos();
                    parametros.IdModulo = Idmodulo;
                    parametros.IdProfesor = Idprofesor;
                    funcion.Insertar_Permisos(parametros);
                }
            }
            MostrarProfessores();
            panelRegitroP.Visible = false;
        }
    }
}
