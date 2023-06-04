using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UNAN.Datos;
using UNAN.FrmPlanDidactico;
using UNAN.Logica;

namespace UNAN.Presentacion
{
    public partial class FrmCarrera : Form
    {
        DModalidades cmd=new DModalidades();
        int IdModa = 0; 
        public FrmCarrera()
        {
            InitializeComponent();
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCarrera.Text))
            {
                if (!string.IsNullOrEmpty(txtCodCarrera.Text))
                {
                    if (!string.IsNullOrEmpty(cbModalidad.Text))
                    {
                        InsertarCarrera();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese la modalidad","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el codigo de la Carrera", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese la Carrera", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCarrera_Load(object sender, EventArgs e)
        {
            cmd.MostrarModalidades(cbModalidad);
        }

        private void InsertarCarrera()
        {
            LCarreras parametros= new LCarreras();
            DCarreras funcion= new DCarreras();
            parametros.NombreC=txtCarrera.Text;
            parametros.CodigoC=txtCodCarrera.Text;
            parametros.IdModalidad = Convert.ToInt32(cbModalidad.SelectedValue);
            if (funcion.InsertarCarrera(parametros)==true)
            {

                MessageBox.Show("Carrera Insertada con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
