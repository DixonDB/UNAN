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
        int Idpersonal;
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
            txtCorreo.Clear();
            txtCorreo.Clear();
        }
        private void DiseñarDtvProfes()
        {
            Bases.DiseñoDtv(ref dataPersonal);
            //Bases.DiseñoDtvEliminar(ref dataPersonal);
            PanelPaginado.Visible = true;
            dataPersonal.Columns[0].Visible = false;
        }
        private void InsertarProfesores()
        {
            LProfesores parametros = new LProfesores();
            DProfesores funcion = new DProfesores();
            parametros.NombreApellido = txtNombreApellidos.Text;
            parametros.CorreoP= txtCorreo.Text; 
            parametros.CelularP=int.Parse( txtCelular.Text);
            parametros.CarnetP= int.Parse(txtIdentificacion.Text);
            if (funcion.InsertarProfesores(parametros) == true)
            {
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
            funcion.ContarPersonal(ref Contador);
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
    }
}
