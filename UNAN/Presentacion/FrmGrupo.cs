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
            mod.MostrarModalidades(cbModalidad);
            cr.MostrarCarrera(cbCarrera);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
