using System;
using System.Windows.Forms;

namespace UNAN.Presentacion
{
    public partial class FrmAcercade : Form
    {
        public FrmAcercade()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
