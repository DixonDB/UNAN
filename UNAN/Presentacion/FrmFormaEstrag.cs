using System;
using System.Windows.Forms;
using UNAN.Datos;
using UNAN.FrmPlanDidactico;
using UNAN.Logica;

namespace UNAN.Presentacion
{
    public partial class FrmFormaEstrag : Form
    {
        public FrmFormaEstrag()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEstrEva_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEstrEva.Text))
            {
                InsertarEstrategiadeEvaluacion();
            }
            else
            {
                MessageBox.Show("Ingrese la estretagía de evaluación ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InsertarEstrategiadeEvaluacion()
        {
            DAprendizaje funcion = new DAprendizaje();
            LAprendizaje parametros = new LAprendizaje();
            parametros.NombreEsEvaluacion = txtEstrEva.Text;
            if (funcion.InsertarEstrategiaEvaluacion(parametros) == true)
            {
                UCPlanDidactico pd= new UCPlanDidactico();
                MessageBox.Show("Estretegía de evaluación insertada con éxito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                funcion.MostrarEstrategiaEvaluacion(pd.cbEnseApren);
            }
        }
        private void InsertarEstrategiadeAprendizaje()
        {
            DAprendizaje funcion = new DAprendizaje();
            LAprendizaje parametros = new LAprendizaje();
            parametros.NombreEstApren = txtEstrEnseApre.Text;
            if (funcion.InsertarEstrAprea(parametros) == true)
            {

                MessageBox.Show("Estretegía de aprendizaje insertada con éxito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnEstrEnseApre_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEstrEnseApre.Text))
            {
                InsertarEstrategiadeAprendizaje();
            }
            else
            {
                MessageBox.Show("Ingrese la estretagía de aprendizaje ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void InsertarFrmEva()
        {
            DAprendizaje funcion = new DAprendizaje();
            LAprendizaje parametros = new LAprendizaje();
            parametros.NombreFrmEva = txtForEva.Text;
            if (funcion.InsertarFormaEvaluacion(parametros) == true)
            {

                MessageBox.Show("Forma de evaluación insertada con éxito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void btnForEva_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtForEva.Text))
            {
                InsertarFrmEva();
            }
            else
            {
                MessageBox.Show("Ingrese la forma de evaluación", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    } 
}
