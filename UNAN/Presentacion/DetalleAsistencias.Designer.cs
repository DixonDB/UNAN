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
            this.cabezera = new System.Windows.Forms.Panel();
            this.pie = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvdetalleasistencia = new System.Windows.Forms.DataGridView();
            this.izquierda = new System.Windows.Forms.Panel();
            this.derecha = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBloques = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cabezera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalleasistencia)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // cabezera
            // 
            this.cabezera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cabezera.Controls.Add(this.lblBloques);
            this.cabezera.Controls.Add(this.label4);
            this.cabezera.Controls.Add(this.lblSalida);
            this.cabezera.Controls.Add(this.label3);
            this.cabezera.Controls.Add(this.lblEntrada);
            this.cabezera.Controls.Add(this.label1);
            this.cabezera.Dock = System.Windows.Forms.DockStyle.Top;
            this.cabezera.Location = new System.Drawing.Point(14, 46);
            this.cabezera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cabezera.Name = "cabezera";
            this.cabezera.Size = new System.Drawing.Size(673, 63);
            this.cabezera.TabIndex = 0;
            // 
            // pie
            // 
            this.pie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pie.Location = new System.Drawing.Point(14, 495);
            this.pie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pie.Name = "pie";
            this.pie.Size = new System.Drawing.Size(673, 19);
            this.pie.TabIndex = 1;
            // 
            // dgvdetalleasistencia
            // 
            this.dgvdetalleasistencia.AllowUserToAddRows = false;
            this.dgvdetalleasistencia.AllowUserToDeleteRows = false;
            this.dgvdetalleasistencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdetalleasistencia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvdetalleasistencia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvdetalleasistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetalleasistencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvdetalleasistencia.Location = new System.Drawing.Point(14, 109);
            this.dgvdetalleasistencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvdetalleasistencia.Name = "dgvdetalleasistencia";
            this.dgvdetalleasistencia.ReadOnly = true;
            this.dgvdetalleasistencia.RowHeadersWidth = 82;
            this.dgvdetalleasistencia.RowTemplate.Height = 33;
            this.dgvdetalleasistencia.Size = new System.Drawing.Size(673, 386);
            this.dgvdetalleasistencia.TabIndex = 2;
            // 
            // izquierda
            // 
            this.izquierda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.izquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.izquierda.Location = new System.Drawing.Point(0, 46);
            this.izquierda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.izquierda.Name = "izquierda";
            this.izquierda.Size = new System.Drawing.Size(14, 468);
            this.izquierda.TabIndex = 3;
            // 
            // derecha
            // 
            this.derecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.derecha.Dock = System.Windows.Forms.DockStyle.Right;
            this.derecha.Location = new System.Drawing.Point(687, 46);
            this.derecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.derecha.Name = "derecha";
            this.derecha.Size = new System.Drawing.Size(14, 468);
            this.derecha.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblFecha);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(701, 46);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::UNAN.Properties.Resources.help_32px;
            this.pictureBox1.Location = new System.Drawing.Point(633, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.Image = global::UNAN.Properties.Resources.cancel;
            this.btnCerrar.Location = new System.Drawing.Point(668, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 46);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(0, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(633, 46);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "--";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hora Entrada:";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada.ForeColor = System.Drawing.Color.Green;
            this.lblEntrada.Location = new System.Drawing.Point(154, 16);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(21, 20);
            this.lblEntrada.TabIndex = 6;
            this.lblEntrada.Text = "--";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSalida.Location = new System.Drawing.Point(390, 16);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(21, 20);
            this.lblSalida.TabIndex = 8;
            this.lblSalida.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(256, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hora Salida:";
            // 
            // lblBloques
            // 
            this.lblBloques.AutoSize = true;
            this.lblBloques.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloques.ForeColor = System.Drawing.Color.Black;
            this.lblBloques.Location = new System.Drawing.Point(594, 16);
            this.lblBloques.Name = "lblBloques";
            this.lblBloques.Size = new System.Drawing.Size(21, 20);
            this.lblBloques.TabIndex = 10;
            this.lblBloques.Text = "--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(492, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bloques:";
            // 
            // DetalleAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(701, 514);
            this.ControlBox = false;
            this.Controls.Add(this.dgvdetalleasistencia);
            this.Controls.Add(this.pie);
            this.Controls.Add(this.cabezera);
            this.Controls.Add(this.izquierda);
            this.Controls.Add(this.derecha);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DetalleAsistencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DetalleAsistencias_Load);
            this.cabezera.ResumeLayout(false);
            this.cabezera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalleasistencia)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cabezera;
        private System.Windows.Forms.FlowLayoutPanel pie;
        private System.Windows.Forms.DataGridView dgvdetalleasistencia;
        private System.Windows.Forms.Panel izquierda;
        private System.Windows.Forms.Panel derecha;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lblBloques;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label label1;
    }
}