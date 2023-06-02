using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UNAN.Control_Usuario;
using UNAN.FrmPlanDidactico;
using UNAN.Presentacion;

namespace UNAN
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelPadre.Controls.Clear();
            UCPlanDidactico plan = new UCPlanDidactico();
            plan.Dock = DockStyle.Fill;
            panelPadre.Controls.Add(plan);
            lblNombre.Text = "Plan Didactico Semestral";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelPadre.Controls.Clear();
            Usuarios plan = new Usuarios();
            plan.Dock = DockStyle.Fill;
            panelPadre.Controls.Add(plan);
            lblNombre.Text = "Usuarios";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelPadre.Controls.Clear();
            UCProfes P = new UCProfes();
            P.Dock = DockStyle.Fill;
            panelPadre.Controls.Add(P);
            lblNombre.Text = "Personal";
        }

        private void reloj_Tick(object sender, EventArgs e)
        {
           lblReloj.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            reloj.Enabled = true;
        }
    }
}
