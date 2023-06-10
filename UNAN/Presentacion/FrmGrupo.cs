using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UNAN.Datos;

namespace UNAN.Presentacion
{
    public partial class FrmGrupo : Form
    {
        DCarreras carreras = new DCarreras();
        DModalidades mod = new DModalidades();
        public FrmGrupo()
        {
            InitializeComponent();
        }

        private void FrmGrupo_Load(object sender, EventArgs e)
        {
            carreras.MostrarCarrera(cbCarrera);
            mod.MostrarModalidades(cbModalidad);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
