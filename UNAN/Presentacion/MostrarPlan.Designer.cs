﻿namespace UNAN.Presentacion
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtDetallePlan = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PnOpciones = new System.Windows.Forms.Panel();
            this.flBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPDF = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pncarga = new System.Windows.Forms.Panel();
            this.pbrCarga = new System.Windows.Forms.ProgressBar();
            this.lblCarga = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtDetallePlan)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.PnOpciones.SuspendLayout();
            this.flBotones.SuspendLayout();
            this.pncarga.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtDetallePlan
            // 
            this.dtDetallePlan.AllowUserToAddRows = false;
            this.dtDetallePlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtDetallePlan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtDetallePlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtDetallePlan.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtDetallePlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtDetallePlan.Location = new System.Drawing.Point(10, 47);
            this.dtDetallePlan.Margin = new System.Windows.Forms.Padding(2);
            this.dtDetallePlan.Name = "dtDetallePlan";
            this.dtDetallePlan.ReadOnly = true;
            this.dtDetallePlan.RowHeadersWidth = 82;
            this.dtDetallePlan.RowTemplate.Height = 33;
            this.dtDetallePlan.Size = new System.Drawing.Size(872, 394);
            this.dtDetallePlan.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(892, 32);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::UNAN.Properties.Resources.help_32px;
            this.pictureBox1.Location = new System.Drawing.Point(830, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.Image = global::UNAN.Properties.Resources.cancel;
            this.btnCerrar.Location = new System.Drawing.Point(862, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 32);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalle Plan Didáctico";
            this.label1.Visible = false;
            // 
            // PnOpciones
            // 
            this.PnOpciones.Controls.Add(this.flBotones);
            this.PnOpciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnOpciones.Location = new System.Drawing.Point(0, 441);
            this.PnOpciones.Name = "PnOpciones";
            this.PnOpciones.Size = new System.Drawing.Size(892, 69);
            this.PnOpciones.TabIndex = 2;
            // 
            // flBotones
            // 
            this.flBotones.Controls.Add(this.btnPDF);
            this.flBotones.Controls.Add(this.label2);
            this.flBotones.Controls.Add(this.btnExcel);
            this.flBotones.Controls.Add(this.btnGuardar);
            this.flBotones.Controls.Add(this.btnCancelar);
            this.flBotones.Location = new System.Drawing.Point(116, 3);
            this.flBotones.Name = "flBotones";
            this.flBotones.Size = new System.Drawing.Size(656, 66);
            this.flBotones.TabIndex = 3;
            this.flBotones.Visible = false;
            // 
            // btnPDF
            // 
            this.btnPDF.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.Image = global::UNAN.Properties.Resources.export_pdf_48px;
            this.btnPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPDF.Location = new System.Drawing.Point(3, 3);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(104, 57);
            this.btnPDF.TabIndex = 0;
            this.btnPDF.Text = "PDF";
            this.btnPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPDF.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(113, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 54);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descargar Plan Didáctico";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Image = global::UNAN.Properties.Resources.microsoft_excel_2019_48px;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(224, 3);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(104, 57);
            this.btnExcel.TabIndex = 1;
            this.btnExcel.Text = "EXCEL";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::UNAN.Properties.Resources.save32px;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(334, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 57);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Editar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::UNAN.Properties.Resources.Atras;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(457, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 57);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel13
            // 
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(10, 32);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(882, 15);
            this.panel13.TabIndex = 14;
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(0, 32);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(10, 409);
            this.panel12.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(882, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 394);
            this.panel1.TabIndex = 15;
            // 
            // pncarga
            // 
            this.pncarga.Controls.Add(this.pbrCarga);
            this.pncarga.Controls.Add(this.lblCarga);
            this.pncarga.Location = new System.Drawing.Point(218, 149);
            this.pncarga.Name = "pncarga";
            this.pncarga.Size = new System.Drawing.Size(457, 213);
            this.pncarga.TabIndex = 16;
            // 
            // pbrCarga
            // 
            this.pbrCarga.Location = new System.Drawing.Point(20, 113);
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
            this.lblCarga.Size = new System.Drawing.Size(457, 213);
            this.lblCarga.TabIndex = 9;
            this.lblCarga.Text = "Bienvenidos";
            this.lblCarga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MostrarPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 510);
            this.Controls.Add(this.pncarga);
            this.Controls.Add(this.dtDetallePlan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.PnOpciones);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MostrarPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle Plan Didactico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MostrarPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDetallePlan)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.PnOpciones.ResumeLayout(false);
            this.flBotones.ResumeLayout(false);
            this.pncarga.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtDetallePlan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel PnOpciones;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.FlowLayoutPanel flBotones;
        public System.Windows.Forms.Button btnPDF;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnExcel;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pncarga;
        private System.Windows.Forms.ProgressBar pbrCarga;
        private System.Windows.Forms.Label lblCarga;
        private System.Windows.Forms.Timer timer1;
    }
}