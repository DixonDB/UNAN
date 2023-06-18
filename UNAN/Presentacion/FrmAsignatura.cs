using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UNAN.Datos;
using UNAN.Logica;

namespace UNAN.Presentacion
{
    public partial class FrmAsignatura : Form
    {
        DCarreras carreras = new DCarreras();
        DModalidades modalidades = new DModalidades();
        public FrmAsignatura()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FrmAsignatura_Load(object sender, EventArgs e)
        {
            modalidades.MostrarModalidades(cbModalidad);
            modalidades.MostrarSemestre(cbSemestre);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodAsig.Text))
            {
                if (!string.IsNullOrEmpty(txtAsignatura.Text))
                {
                    if (!string.IsNullOrEmpty(cbModalidad.Text))
                    {
                        if (!string.IsNullOrEmpty(cbCarrera.Text))
                        {
                            if (!string.IsNullOrEmpty(cbSemestre.Text))
                            {
                                insertarAsignatura();
                            }
                            else
                            {
                                MessageBox.Show("Ingrese el Semestre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese la Carrera", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese la modalidad", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese la Asignatura", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese el codigo de la Asignatura", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insertarAsignatura()
        {
            LAsignatura parametros = new LAsignatura();
            DAsignatura funcion = new DAsignatura();
            parametros.NombreA = txtAsignatura.Text;
            parametros.CodigoA = txtCodAsig.Text;
            parametros.IdCarrera = Convert.ToInt32(cbCarrera.SelectedValue);
            parametros.IdSemestre = Convert.ToInt32(cbSemestre.SelectedValue);
            parametros.IdGrupo=Convert.ToInt32(cbGrupo.SelectedValue);
            if (funcion.InsertarAsignatura(parametros) == true)
            {

                MessageBox.Show("Asignatura Insertada con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void cbModalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            carreras.MostrarCarrera(cbCarrera, cbModalidad.Text);
        }

        private void cbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            modalidades.MostrarGrupos(cbGrupo, cbCarrera.Text);
        }
    }
}
