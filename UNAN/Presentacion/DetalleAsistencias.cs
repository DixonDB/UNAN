using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNAN.Datos;
using UNAN.Logica;

namespace UNAN.Presentacion
{
    public partial class DetalleAsistencias : Form
    {

        public int idasistencias;
        private int conteo;

        public DetalleAsistencias()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            DataTable dt = new DataTable();
            dgvdetalleasistencia.DataSource = dt;
            int idasis = idasistencias;
            DAsistencia funcion = new DAsistencia();
            funcion.MostrarDetalleAsistencia(ref dt, idasis);
            DiseñoDgv();
        }
        private void DiseñoDgv()
        {
            Bases.DiseñoDtv(ref dgvdetalleasistencia);
            dgvdetalleasistencia.Columns[0].Visible= false;
            dgvdetalleasistencia.Columns[1].Visible= false;
        }
        private void DetalleAsistencias_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
