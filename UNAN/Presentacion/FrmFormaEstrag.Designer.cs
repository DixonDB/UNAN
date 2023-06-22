namespace UNAN.Presentacion
{
    partial class FrmFormaEstrag
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.PnEstraEnseApren = new System.Windows.Forms.Panel();
            this.pnForEva = new System.Windows.Forms.Panel();
            this.pnEstraEva = new System.Windows.Forms.Panel();
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.txtEstrEnseApre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEstrEnseApre = new System.Windows.Forms.Button();
            this.btnForEva = new System.Windows.Forms.Button();
            this.txtForEva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEstrEva = new System.Windows.Forms.Button();
            this.txtEstrEva = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.PnEstraEnseApren.SuspendLayout();
            this.pnForEva.SuspendLayout();
            this.pnEstraEva.SuspendLayout();
            this.pnPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 32);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::UNAN.Properties.Resources.help_32px;
            this.pictureBox1.Location = new System.Drawing.Point(374, 0);
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
            this.btnCerrar.Location = new System.Drawing.Point(406, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 32);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(328, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Estrategia de Enseñanza - Aprendizaje:";
            // 
            // PnEstraEnseApren
            // 
            this.PnEstraEnseApren.Controls.Add(this.btnEstrEnseApre);
            this.PnEstraEnseApren.Controls.Add(this.txtEstrEnseApre);
            this.PnEstraEnseApren.Controls.Add(this.label2);
            this.PnEstraEnseApren.Location = new System.Drawing.Point(16, 99);
            this.PnEstraEnseApren.Name = "PnEstraEnseApren";
            this.PnEstraEnseApren.Size = new System.Drawing.Size(301, 213);
            this.PnEstraEnseApren.TabIndex = 2;
            this.PnEstraEnseApren.Visible = false;
            // 
            // pnForEva
            // 
            this.pnForEva.Controls.Add(this.btnForEva);
            this.pnForEva.Controls.Add(this.txtForEva);
            this.pnForEva.Controls.Add(this.label1);
            this.pnForEva.Location = new System.Drawing.Point(317, 150);
            this.pnForEva.Name = "pnForEva";
            this.pnForEva.Size = new System.Drawing.Size(301, 213);
            this.pnForEva.TabIndex = 3;
            this.pnForEva.Visible = false;
            // 
            // pnEstraEva
            // 
            this.pnEstraEva.Controls.Add(this.btnEstrEva);
            this.pnEstraEva.Controls.Add(this.txtEstrEva);
            this.pnEstraEva.Controls.Add(this.label3);
            this.pnEstraEva.Location = new System.Drawing.Point(567, 112);
            this.pnEstraEva.Name = "pnEstraEva";
            this.pnEstraEva.Size = new System.Drawing.Size(301, 213);
            this.pnEstraEva.TabIndex = 3;
            this.pnEstraEva.Visible = false;
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.Controls.Add(this.pnEstraEva);
            this.pnPrincipal.Controls.Add(this.pnForEva);
            this.pnPrincipal.Controls.Add(this.PnEstraEnseApren);
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(436, 258);
            this.pnPrincipal.TabIndex = 4;
            // 
            // txtEstrEnseApre
            // 
            this.txtEstrEnseApre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstrEnseApre.Location = new System.Drawing.Point(30, 51);
            this.txtEstrEnseApre.Multiline = true;
            this.txtEstrEnseApre.Name = "txtEstrEnseApre";
            this.txtEstrEnseApre.Size = new System.Drawing.Size(225, 96);
            this.txtEstrEnseApre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(455, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese Estrategia de Enseñanza - Aprendizaje:";
            // 
            // btnEstrEnseApre
            // 
            this.btnEstrEnseApre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstrEnseApre.Image = global::UNAN.Properties.Resources.Check;
            this.btnEstrEnseApre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstrEnseApre.Location = new System.Drawing.Point(77, 157);
            this.btnEstrEnseApre.Name = "btnEstrEnseApre";
            this.btnEstrEnseApre.Size = new System.Drawing.Size(127, 37);
            this.btnEstrEnseApre.TabIndex = 4;
            this.btnEstrEnseApre.Text = "Agregar";
            this.btnEstrEnseApre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEstrEnseApre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEstrEnseApre.UseVisualStyleBackColor = true;
            // 
            // btnForEva
            // 
            this.btnForEva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForEva.Image = global::UNAN.Properties.Resources.Check;
            this.btnForEva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnForEva.Location = new System.Drawing.Point(90, 160);
            this.btnForEva.Name = "btnForEva";
            this.btnForEva.Size = new System.Drawing.Size(127, 37);
            this.btnForEva.TabIndex = 7;
            this.btnForEva.Text = "Agregar";
            this.btnForEva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnForEva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnForEva.UseVisualStyleBackColor = true;
            // 
            // txtForEva
            // 
            this.txtForEva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForEva.Location = new System.Drawing.Point(38, 43);
            this.txtForEva.Multiline = true;
            this.txtForEva.Name = "txtForEva";
            this.txtForEva.Size = new System.Drawing.Size(225, 96);
            this.txtForEva.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingrese Forma de Evaluación:";
            // 
            // btnEstrEva
            // 
            this.btnEstrEva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstrEva.Image = global::UNAN.Properties.Resources.Check;
            this.btnEstrEva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstrEva.Location = new System.Drawing.Point(90, 160);
            this.btnEstrEva.Name = "btnEstrEva";
            this.btnEstrEva.Size = new System.Drawing.Size(127, 37);
            this.btnEstrEva.TabIndex = 7;
            this.btnEstrEva.Text = "Agregar";
            this.btnEstrEva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEstrEva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEstrEva.UseVisualStyleBackColor = true;
            // 
            // txtEstrEva
            // 
            this.txtEstrEva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstrEva.Location = new System.Drawing.Point(38, 43);
            this.txtEstrEva.Multiline = true;
            this.txtEstrEva.Name = "txtEstrEva";
            this.txtEstrEva.Size = new System.Drawing.Size(225, 96);
            this.txtEstrEva.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingrese Estrategia de Evaluación:";
            // 
            // FrmFormaEstrag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 258);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(436, 258);
            this.MinimumSize = new System.Drawing.Size(436, 258);
            this.Name = "FrmFormaEstrag";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.PnEstraEnseApren.ResumeLayout(false);
            this.PnEstraEnseApren.PerformLayout();
            this.pnForEva.ResumeLayout(false);
            this.pnForEva.PerformLayout();
            this.pnEstraEva.ResumeLayout(false);
            this.pnEstraEva.PerformLayout();
            this.pnPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel pnPrincipal;
        private System.Windows.Forms.TextBox txtEstrEnseApre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEstrEnseApre;
        private System.Windows.Forms.Button btnForEva;
        private System.Windows.Forms.TextBox txtForEva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEstrEva;
        private System.Windows.Forms.TextBox txtEstrEva;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.Panel PnEstraEnseApren;
        public System.Windows.Forms.Panel pnForEva;
        public System.Windows.Forms.Panel pnEstraEva;
    }
}