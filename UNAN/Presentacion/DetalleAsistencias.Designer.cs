namespace UNAN.Presentacion
{
    partial class DetalleAsistencias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cabezera = new System.Windows.Forms.Panel();
            this.pie = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvdetalleasistencia = new System.Windows.Forms.DataGridView();
            this.izquierda = new System.Windows.Forms.Panel();
            this.derecha = new System.Windows.Forms.Panel();
            this.dtDetallePlan = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalleasistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetallePlan)).BeginInit();
            this.SuspendLayout();
            // 
            // cabezera
            // 
            this.cabezera.Dock = System.Windows.Forms.DockStyle.Top;
            this.cabezera.Location = new System.Drawing.Point(0, 0);
            this.cabezera.Name = "cabezera";
            this.cabezera.Size = new System.Drawing.Size(1807, 121);
            this.cabezera.TabIndex = 0;
            // 
            // pie
            // 
            this.pie.Controls.Add(this.dtDetallePlan);
            this.pie.Controls.Add(this.btnVolver);
            this.pie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pie.Location = new System.Drawing.Point(28, 752);
            this.pie.Name = "pie";
            this.pie.Size = new System.Drawing.Size(1751, 115);
            this.pie.TabIndex = 1;
            // 
            // dgvdetalleasistencia
            // 
            this.dgvdetalleasistencia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvdetalleasistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetalleasistencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvdetalleasistencia.Location = new System.Drawing.Point(28, 121);
            this.dgvdetalleasistencia.Name = "dgvdetalleasistencia";
            this.dgvdetalleasistencia.RowHeadersWidth = 82;
            this.dgvdetalleasistencia.RowTemplate.Height = 33;
            this.dgvdetalleasistencia.Size = new System.Drawing.Size(1751, 746);
            this.dgvdetalleasistencia.TabIndex = 2;
            // 
            // izquierda
            // 
            this.izquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.izquierda.Location = new System.Drawing.Point(0, 121);
            this.izquierda.Name = "izquierda";
            this.izquierda.Size = new System.Drawing.Size(28, 746);
            this.izquierda.TabIndex = 3;
            // 
            // derecha
            // 
            this.derecha.Dock = System.Windows.Forms.DockStyle.Right;
            this.derecha.Location = new System.Drawing.Point(1779, 121);
            this.derecha.Name = "derecha";
            this.derecha.Size = new System.Drawing.Size(28, 746);
            this.derecha.TabIndex = 4;
            // 
            // dtDetallePlan
            // 
            this.dtDetallePlan.AllowUserToAddRows = false;
            this.dtDetallePlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtDetallePlan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtDetallePlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtDetallePlan.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtDetallePlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtDetallePlan.Location = new System.Drawing.Point(4, 4);
            this.dtDetallePlan.Margin = new System.Windows.Forms.Padding(4);
            this.dtDetallePlan.Name = "dtDetallePlan";
            this.dtDetallePlan.ReadOnly = true;
            this.dtDetallePlan.RowHeadersWidth = 82;
            this.dtDetallePlan.RowTemplate.Height = 33;
            this.dtDetallePlan.Size = new System.Drawing.Size(1744, 0);
            this.dtDetallePlan.TabIndex = 5;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(3, 11);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(131, 77);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Cerrar";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // DetalleAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1807, 867);
            this.Controls.Add(this.pie);
            this.Controls.Add(this.dgvdetalleasistencia);
            this.Controls.Add(this.derecha);
            this.Controls.Add(this.izquierda);
            this.Controls.Add(this.cabezera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetalleAsistencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetalleAsistencias";
            this.Load += new System.EventHandler(this.DetalleAsistencias_Load);
            this.pie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalleasistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetallePlan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cabezera;
        private System.Windows.Forms.FlowLayoutPanel pie;
        private System.Windows.Forms.DataGridView dgvdetalleasistencia;
        private System.Windows.Forms.Panel izquierda;
        private System.Windows.Forms.Panel derecha;
        private System.Windows.Forms.DataGridView dtDetallePlan;
        private System.Windows.Forms.Button btnVolver;
    }
}