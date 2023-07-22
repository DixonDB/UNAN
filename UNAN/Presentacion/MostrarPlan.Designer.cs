namespace UNAN.Presentacion
{
    partial class MostrarPlan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtDetallePlan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetallePlan)).BeginInit();
            this.SuspendLayout();
            // 
            // dtDetallePlan
            // 
            this.dtDetallePlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDetallePlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtDetallePlan.Location = new System.Drawing.Point(0, 0);
            this.dtDetallePlan.Name = "dtDetallePlan";
            this.dtDetallePlan.RowHeadersWidth = 82;
            this.dtDetallePlan.RowTemplate.Height = 33;
            this.dtDetallePlan.Size = new System.Drawing.Size(2328, 803);
            this.dtDetallePlan.TabIndex = 0;
            // 
            // MostrarPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2328, 803);
            this.Controls.Add(this.dtDetallePlan);
            this.Name = "MostrarPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle Plan Didactico";
            this.Load += new System.EventHandler(this.MostrarPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDetallePlan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtDetallePlan;
    }
}