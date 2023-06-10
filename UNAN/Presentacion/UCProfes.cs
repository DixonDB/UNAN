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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            panelRegitroP.Visible = true;
            panelRegitroP.Dock = DockStyle.Fill;
            btnGuardar.Visible = true;
            btnActualizar.Visible = false;
            this.Limpiar();
            PanelPaginado.Visible = false;

        }
        private void Limpiar()
        {
            txtNombreApellidos.Clear();
            txtIdentificacion.Clear();
            txtCelular.Clear();
            txtCorreo.Clear();
        }
        private void DiseñarDtvProfes()
        {
            Bases.DiseñoDtv(ref dataPersonal);
            Bases.DiseñoDtvEliminar(ref dataPersonal);
            PanelPaginado.Visible = true;
            dataPersonal.Columns[2].Visible = false;
        }
        private void InsertarProfesores()
        {
            LProfesores parametros = new LProfesores();
            DProfesores funcion = new DProfesores();
            parametros.NombreApellido = txtNombreApellidos.Text;
            parametros.CorreoP = txtCorreo.Text;
            parametros.CelularP = int.Parse(txtCelular.Text);
            parametros.CarnetP = int.Parse(txtIdentificacion.Text);
            if (funcion.InsertarProfesores(parametros) == true)
            {
                MostrarProfessores();
                panelRegitroP.Visible = false;

            }
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
                            InsertarProfesores();
                            MostrarProfessores();
                        }
                    }
                }


            }
        }
        private void MostrarProfessores()
        {
            DataTable dt = new DataTable();
            DProfesores funcion = new DProfesores();
            funcion.MostrarProfesores(ref dt, desde, hasta);
            dataPersonal.DataSource = dt;
            DiseñarDtvProfes();
        }

        private void UCProfesores_Load(object sender, EventArgs e)
        {
            ReiniciarPaginado();
            MostrarProfessores();
        }

        private void dataPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataPersonal.Columns["Eliminar"].Index)
            {
                DialogResult result = MessageBox.Show("¿Solo se Cambiara el Estado para que no pueda acceder, Desea Continuar?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(result== DialogResult.OK)
                {
                    EliminarProfes();
                }
                
            }
            if (e.ColumnIndex == dataPersonal.Columns["Editar"].Index)
            {
                Obtenerdatos();
            }
        }
        private void EliminarProfes()
        {
            Idprofesor = Convert.ToInt32(dataPersonal.SelectedCells[2].Value);
            LProfesores parametros = new LProfesores();
            DProfesores funcion = new DProfesores();
            parametros.IdProfesores = Idprofesor;
            if (funcion.EliminarProfesores(parametros) == true)
            {
                MostrarProfessores();
            }
        }
        private void Obtenerdatos()
        {
            Idprofesor = Convert.ToInt32(dataPersonal.SelectedCells[2].Value);
            Estado = dataPersonal.SelectedCells[7].Value.ToString();
            if (Estado == "ELIMINADO")
            {
                RestaurarP();
            }
            else
            {
                txtNombreApellidos.Text = dataPersonal.SelectedCells[3].Value.ToString();
                txtCorreo.Text= dataPersonal.SelectedCells[4].Value.ToString();
                txtCelular.Text = dataPersonal.SelectedCells[5].Value.ToString();
                txtIdentificacion.Text= dataPersonal.SelectedCells[6].Value.ToString();
                PanelPaginado.Visible = false;
                panelRegitroP.Visible = true;
                panelRegitroP.Dock = DockStyle.Fill;
                btnGuardar.Visible = true;                
                btnGuardar.Visible = false;
                btnActualizar.Visible = true;
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
            parametros.CarnetP = Convert.ToInt32(txtIdentificacion.Text);
            if(funcion.EditarProfesores(parametros)==true)
            {
                MostrarProfessores();
                panelRegitroP.Visible = false;
            }
        }

        private void btnVolverPersonal_Click(object sender, EventArgs e)
        {
            panelRegitroP.Visible = false;
            PanelPaginado.Visible = true;
        }
    }
}
