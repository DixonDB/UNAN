using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UNAN.Presentacion
{
    public partial class UCAsistencia : UserControl
    {
        public UCAsistencia()
        {
            InitializeComponent();
        }

        private void UCAsistencia_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }
    }
}
