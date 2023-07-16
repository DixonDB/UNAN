using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace UNAN.Presentacion
{
    public partial class UCAvanceP : UserControl
    {
        public UCAvanceP()
        {
            InitializeComponent();
            carga();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pnAvanceP.Visible = true;
            pnAvanceP.Dock = DockStyle.Fill;
            PanelPaginado.Visible = false;
            panel4.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            pnAvanceP.Visible = false;
            PanelPaginado.Visible = true;
            panel4.Visible = true;
        }
        private void carga()
        {
            if (backgroundWorker1.IsBusy != true)
            {
                pncarga.Dock = DockStyle.Fill;
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(100);
                backgroundWorker1.ReportProgress(i * 10);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbrCarga.Value = e.ProgressPercentage;
            lblCarga.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pncarga.Visible = false;
        }
    }
}
