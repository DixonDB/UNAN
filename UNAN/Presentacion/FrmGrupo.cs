﻿using System;
using System.Windows.Forms;
using UNAN.Datos;
using UNAN.FrmPlanDidactico;
using UNAN.Logica;

namespace UNAN.Presentacion
{
    public partial class frmGrupo : Form
    {
        DModalidades mod=new DModalidades();
        DCarreras cr=new DCarreras();
        public frmGrupo()
        {
            InitializeComponent();
        }

        private void frmGrupo_Load(object sender, EventArgs e)
        {
            UCPlanDidactico up=new UCPlanDidactico();
            mod.MostrarModalidades(cbModalidad);
            cr.MostrarCarrera(cbCarrera, cbModalidad.Text);
            cbCarrera.Text = up.cbCarrera.Text;
            cbModalidad.Text=up.cbModalidad.Text;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGrupo.Text))
            {
                InsertarGrupo();
            }
            else
            {
                MessageBox.Show("Ingresa el grupo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGrupo.Focus();
            }
        }

        private void InsertarGrupo()
        {
            UCPlanDidactico uc=new UCPlanDidactico();
            LModalidad parametros= new LModalidad();
            DModalidades funcion= new DModalidades();
            parametros.Grupo=txtGrupo.Text;
            parametros.IdCarrera = Convert.ToInt32(cbCarrera.SelectedValue);
            if (funcion.InsertarGrupo(parametros)==true)
            {
                MessageBox.Show("Grupo Insertado con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void cbModalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            cr.MostrarCarrera(cbCarrera, cbModalidad.Text);
        }
    }
}
