namespace UNAN.Presentacion
{
    partial class UCGraficos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title11 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartUsuariosRol = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCantUsuarios = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pncarga = new System.Windows.Forms.Panel();
            this.pbrCarga = new System.Windows.Forms.ProgressBar();
            this.lblCarga = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsuariosRol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pncarga.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartUsuariosRol
            // 
            this.chartUsuariosRol.BackColor = System.Drawing.Color.DodgerBlue;
            this.chartUsuariosRol.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea11.Area3DStyle.Enable3D = true;
            chartArea11.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea11.BackColor = System.Drawing.Color.RoyalBlue;
            chartArea11.Name = "ChartArea1";
            this.chartUsuariosRol.ChartAreas.Add(chartArea11);
            legend11.Alignment = System.Drawing.StringAlignment.Center;
            legend11.BackColor = System.Drawing.Color.DarkTurquoise;
            legend11.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            legend11.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Unscaled;
            legend11.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            legend11.DockedToChartArea = "ChartArea1";
            legend11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend11.IsDockedInsideChartArea = false;
            legend11.IsTextAutoFit = false;
            legend11.Name = "Legend1";
            this.chartUsuariosRol.Legends.Add(legend11);
            this.chartUsuariosRol.Location = new System.Drawing.Point(24, 160);
            this.chartUsuariosRol.Name = "chartUsuariosRol";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series11.IsValueShownAsLabel = true;
            series11.LabelForeColor = System.Drawing.Color.White;
            series11.Legend = "Legend1";
            series11.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross;
            series11.Name = "Series1";
            this.chartUsuariosRol.Series.Add(series11);
            this.chartUsuariosRol.Size = new System.Drawing.Size(669, 369);
            this.chartUsuariosRol.TabIndex = 0;
            this.chartUsuariosRol.Text = "chart1";
            title11.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title11.ForeColor = System.Drawing.Color.White;
            title11.Name = "Title1";
            title11.Text = "Cantidad de Usuarios por Rol";
            this.chartUsuariosRol.Titles.Add(title11);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total de Usuarios:";
            // 
            // lblCantUsuarios
            // 
            this.lblCantUsuarios.AutoSize = true;
            this.lblCantUsuarios.BackColor = System.Drawing.Color.White;
            this.lblCantUsuarios.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantUsuarios.Location = new System.Drawing.Point(170, 71);
            this.lblCantUsuarios.Name = "lblCantUsuarios";
            this.lblCantUsuarios.Size = new System.Drawing.Size(30, 22);
            this.lblCantUsuarios.TabIndex = 2;
            this.lblCantUsuarios.Text = "--";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(19, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 85);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::UNAN.Properties.Resources.usuario1;
            this.pictureBox2.Location = new System.Drawing.Point(35, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pncarga
            // 
            this.pncarga.Controls.Add(this.pbrCarga);
            this.pncarga.Controls.Add(this.lblCarga);
            this.pncarga.Location = new System.Drawing.Point(870, 5);
            this.pncarga.Name = "pncarga";
            this.pncarga.Size = new System.Drawing.Size(130, 120);
            this.pncarga.TabIndex = 13;
            // 
            // pbrCarga
            // 
            this.pbrCarga.Location = new System.Drawing.Point(288, 355);
            this.pbrCarga.Name = "pbrCarga";
            this.pbrCarga.Size = new System.Drawing.Size(699, 23);
            this.pbrCarga.TabIndex = 10;
            // 
            // lblCarga
            // 
            this.lblCarga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarga.ForeColor = System.Drawing.Color.Black;
            this.lblCarga.Location = new System.Drawing.Point(0, 0);
            this.lblCarga.Name = "lblCarga";
            this.lblCarga.Size = new System.Drawing.Size(130, 120);
            this.lblCarga.TabIndex = 9;
            this.lblCarga.Text = "Bienvenidos";
            this.lblCarga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // UCGraficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pncarga);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblCantUsuarios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartUsuariosRol);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCGraficos";
            this.Size = new System.Drawing.Size(1003, 532);
            this.Load += new System.EventHandler(this.UCGraficos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartUsuariosRol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pncarga.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartUsuariosRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCantUsuarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pncarga;
        private System.Windows.Forms.ProgressBar pbrCarga;
        private System.Windows.Forms.Label lblCarga;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
