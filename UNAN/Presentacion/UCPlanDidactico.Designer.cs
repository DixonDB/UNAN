namespace UNAN.FrmPlanDidactico
{
    partial class UCPlanDidactico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtPlan = new System.Windows.Forms.DataGridView();
            this.GBDetalles = new System.Windows.Forms.GroupBox();
            this.lblCodAsig = new System.Windows.Forms.Label();
            this.btnAddAsig = new System.Windows.Forms.Button();
            this.btnAddGrupo = new System.Windows.Forms.Button();
            this.cbModalidad = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.btnCarrera = new System.Windows.Forms.Button();
            this.cbCarrera = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbSemestre = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbGrupo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDocente = new System.Windows.Forms.TextBox();
            this.txtAAcademico = new System.Windows.Forms.TextBox();
            this.cbAsignaturas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSemFin = new System.Windows.Forms.TextBox();
            this.txtObj = new System.Windows.Forms.TextBox();
            this.txtCont = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInico = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnSubirPlan = new System.Windows.Forms.Button();
            this.btnSubir = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.PCargarPlan = new System.Windows.Forms.Panel();
            this.btnCerrarP = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.cboHojas = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.btnEE = new System.Windows.Forms.Button();
            this.btnFE = new System.Windows.Forms.Button();
            this.btnEEA = new System.Windows.Forms.Button();
            this.cbEstrEvaluacion = new System.Windows.Forms.ComboBox();
            this.cbFormaEvaluacion = new System.Windows.Forms.ComboBox();
            this.cbEnseApren = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSemInicio = new System.Windows.Forms.TextBox();
            this.pnBotones = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pncarga = new System.Windows.Forms.Panel();
            this.pbrCarga = new System.Windows.Forms.ProgressBar();
            this.lblCarga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtPlan)).BeginInit();
            this.GBDetalles.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.PCargarPlan.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.pnBotones.SuspendLayout();
            this.pncarga.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtPlan
            // 
            this.dtPlan.AllowUserToOrderColumns = true;
            this.dtPlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtPlan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtPlan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtPlan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtPlan.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtPlan.Location = new System.Drawing.Point(0, 857);
            this.dtPlan.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtPlan.Name = "dtPlan";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtPlan.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtPlan.RowHeadersVisible = false;
            this.dtPlan.RowHeadersWidth = 82;
            this.dtPlan.Size = new System.Drawing.Size(2588, 918);
            this.dtPlan.TabIndex = 3;
            // 
            // GBDetalles
            // 
            this.GBDetalles.BackColor = System.Drawing.Color.White;
            this.GBDetalles.Controls.Add(this.lblCodAsig);
            this.GBDetalles.Controls.Add(this.btnAddAsig);
            this.GBDetalles.Controls.Add(this.btnAddGrupo);
            this.GBDetalles.Controls.Add(this.cbModalidad);
            this.GBDetalles.Controls.Add(this.label19);
            this.GBDetalles.Controls.Add(this.lblCod);
            this.GBDetalles.Controls.Add(this.btnCarrera);
            this.GBDetalles.Controls.Add(this.cbCarrera);
            this.GBDetalles.Controls.Add(this.label17);
            this.GBDetalles.Controls.Add(this.cbSemestre);
            this.GBDetalles.Controls.Add(this.label6);
            this.GBDetalles.Controls.Add(this.cbGrupo);
            this.GBDetalles.Controls.Add(this.label4);
            this.GBDetalles.Controls.Add(this.txtDocente);
            this.GBDetalles.Controls.Add(this.txtAAcademico);
            this.GBDetalles.Controls.Add(this.cbAsignaturas);
            this.GBDetalles.Controls.Add(this.label5);
            this.GBDetalles.Controls.Add(this.label3);
            this.GBDetalles.Controls.Add(this.label2);
            this.GBDetalles.Dock = System.Windows.Forms.DockStyle.Top;
            this.GBDetalles.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBDetalles.Location = new System.Drawing.Point(0, 87);
            this.GBDetalles.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.GBDetalles.Name = "GBDetalles";
            this.GBDetalles.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.GBDetalles.Size = new System.Drawing.Size(2588, 212);
            this.GBDetalles.TabIndex = 1;
            this.GBDetalles.TabStop = false;
            this.GBDetalles.Visible = false;
            // 
            // lblCodAsig
            // 
            this.lblCodAsig.AutoSize = true;
            this.lblCodAsig.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodAsig.Location = new System.Drawing.Point(938, 135);
            this.lblCodAsig.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCodAsig.Name = "lblCodAsig";
            this.lblCodAsig.Size = new System.Drawing.Size(134, 36);
            this.lblCodAsig.TabIndex = 34;
            this.lblCodAsig.Text = "CodigoA";
            // 
            // btnAddAsig
            // 
            this.btnAddAsig.BackgroundImage = global::UNAN.Properties.Resources.classroom;
            this.btnAddAsig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddAsig.Location = new System.Drawing.Point(828, 110);
            this.btnAddAsig.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddAsig.Name = "btnAddAsig";
            this.btnAddAsig.Size = new System.Drawing.Size(82, 85);
            this.btnAddAsig.TabIndex = 33;
            this.btnAddAsig.UseVisualStyleBackColor = true;
            this.btnAddAsig.Click += new System.EventHandler(this.btnAddAsig_Click);
            // 
            // btnAddGrupo
            // 
            this.btnAddGrupo.BackgroundImage = global::UNAN.Properties.Resources.Addteam;
            this.btnAddGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddGrupo.Location = new System.Drawing.Point(1898, 29);
            this.btnAddGrupo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddGrupo.Name = "btnAddGrupo";
            this.btnAddGrupo.Size = new System.Drawing.Size(82, 85);
            this.btnAddGrupo.TabIndex = 32;
            this.btnAddGrupo.UseVisualStyleBackColor = true;
            this.btnAddGrupo.Click += new System.EventHandler(this.btnAddGrupo_Click);
            // 
            // cbModalidad
            // 
            this.cbModalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbModalidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbModalidad.BackColor = System.Drawing.Color.White;
            this.cbModalidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModalidad.FormattingEnabled = true;
            this.cbModalidad.Location = new System.Drawing.Point(286, 50);
            this.cbModalidad.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbModalidad.Name = "cbModalidad";
            this.cbModalidad.Size = new System.Drawing.Size(216, 44);
            this.cbModalidad.TabIndex = 31;
            this.cbModalidad.SelectedIndexChanged += new System.EventHandler(this.cbModalidad_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(48, 48);
            this.label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(227, 49);
            this.label19.TabIndex = 30;
            this.label19.Text = "Modalidad:";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(1306, 56);
            this.lblCod.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(136, 36);
            this.lblCod.TabIndex = 29;
            this.lblCod.Text = "CodigoC";
            // 
            // btnCarrera
            // 
            this.btnCarrera.BackgroundImage = global::UNAN.Properties.Resources.addC;
            this.btnCarrera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCarrera.Location = new System.Drawing.Point(1212, 29);
            this.btnCarrera.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCarrera.Name = "btnCarrera";
            this.btnCarrera.Size = new System.Drawing.Size(82, 85);
            this.btnCarrera.TabIndex = 28;
            this.btnCarrera.UseVisualStyleBackColor = true;
            this.btnCarrera.Click += new System.EventHandler(this.btnCarrera_Click);
            // 
            // cbCarrera
            // 
            this.cbCarrera.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCarrera.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbCarrera.BackColor = System.Drawing.Color.White;
            this.cbCarrera.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCarrera.FormattingEnabled = true;
            this.cbCarrera.Location = new System.Drawing.Point(720, 48);
            this.cbCarrera.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbCarrera.Name = "cbCarrera";
            this.cbCarrera.Size = new System.Drawing.Size(476, 44);
            this.cbCarrera.TabIndex = 27;
            this.cbCarrera.SelectedIndexChanged += new System.EventHandler(this.cbCarrera_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(528, 44);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(175, 49);
            this.label17.TabIndex = 26;
            this.label17.Text = "Carrera:";
            // 
            // cbSemestre
            // 
            this.cbSemestre.BackColor = System.Drawing.Color.White;
            this.cbSemestre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSemestre.FormattingEnabled = true;
            this.cbSemestre.Location = new System.Drawing.Point(2238, 44);
            this.cbSemestre.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbSemestre.Name = "cbSemestre";
            this.cbSemestre.Size = new System.Drawing.Size(124, 44);
            this.cbSemestre.TabIndex = 25;
            this.cbSemestre.SelectedIndexChanged += new System.EventHandler(this.cbSemestre_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2010, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 49);
            this.label6.TabIndex = 23;
            this.label6.Text = "Semestre:";
            // 
            // cbGrupo
            // 
            this.cbGrupo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbGrupo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbGrupo.BackColor = System.Drawing.Color.White;
            this.cbGrupo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrupo.FormattingEnabled = true;
            this.cbGrupo.Location = new System.Drawing.Point(1652, 44);
            this.cbGrupo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(204, 44);
            this.cbGrupo.TabIndex = 24;
            this.cbGrupo.SelectedIndexChanged += new System.EventHandler(this.cbGrupo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1490, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 49);
            this.label4.TabIndex = 22;
            this.label4.Text = "Grupo:";
            // 
            // txtDocente
            // 
            this.txtDocente.BackColor = System.Drawing.Color.White;
            this.txtDocente.Enabled = false;
            this.txtDocente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocente.Location = new System.Drawing.Point(1400, 129);
            this.txtDocente.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDocente.Name = "txtDocente";
            this.txtDocente.Size = new System.Drawing.Size(516, 44);
            this.txtDocente.TabIndex = 21;
            // 
            // txtAAcademico
            // 
            this.txtAAcademico.BackColor = System.Drawing.Color.White;
            this.txtAAcademico.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAAcademico.Location = new System.Drawing.Point(2326, 135);
            this.txtAAcademico.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAAcademico.Name = "txtAAcademico";
            this.txtAAcademico.Size = new System.Drawing.Size(196, 44);
            this.txtAAcademico.TabIndex = 20;
            this.txtAAcademico.Text = "20";
            // 
            // cbAsignaturas
            // 
            this.cbAsignaturas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAsignaturas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbAsignaturas.BackColor = System.Drawing.Color.White;
            this.cbAsignaturas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAsignaturas.FormattingEnabled = true;
            this.cbAsignaturas.Location = new System.Drawing.Point(296, 129);
            this.cbAsignaturas.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbAsignaturas.Name = "cbAsignaturas";
            this.cbAsignaturas.Size = new System.Drawing.Size(516, 44);
            this.cbAsignaturas.TabIndex = 18;
            this.cbAsignaturas.SelectedIndexChanged += new System.EventHandler(this.cbAsignaturas_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1194, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 49);
            this.label5.TabIndex = 17;
            this.label5.Text = "Docente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1984, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 49);
            this.label3.TabIndex = 19;
            this.label3.Text = "Año Académico:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 49);
            this.label2.TabIndex = 16;
            this.label2.Text = "Asignatura:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2588, 31);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 31);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2588, 33);
            this.panel3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2588, 87);
            this.panel1.TabIndex = 0;
            // 
            // txtSemFin
            // 
            this.txtSemFin.BackColor = System.Drawing.Color.White;
            this.txtSemFin.Location = new System.Drawing.Point(1568, 37);
            this.txtSemFin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSemFin.Name = "txtSemFin";
            this.txtSemFin.Size = new System.Drawing.Size(112, 44);
            this.txtSemFin.TabIndex = 0;
            // 
            // txtObj
            // 
            this.txtObj.Location = new System.Drawing.Point(220, 123);
            this.txtObj.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtObj.Multiline = true;
            this.txtObj.Name = "txtObj";
            this.txtObj.Size = new System.Drawing.Size(976, 133);
            this.txtObj.TabIndex = 0;
            // 
            // txtCont
            // 
            this.txtCont.Location = new System.Drawing.Point(1462, 123);
            this.txtCont.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCont.Multiline = true;
            this.txtCont.Name = "txtCont";
            this.txtCont.Size = new System.Drawing.Size(976, 133);
            this.txtCont.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(904, 40);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 39);
            this.label7.TabIndex = 1;
            this.label7.Text = "Fecha Fin:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1342, 42);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 39);
            this.label8.TabIndex = 1;
            this.label8.Text = "Semana Fin:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 127);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 45);
            this.label9.TabIndex = 1;
            this.label9.Text = "Objetivos:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1490, 317);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(452, 45);
            this.label13.TabIndex = 1;
            this.label13.Text = "Estrategia de Evaluación:";
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.Location = new System.Drawing.Point(1100, 29);
            this.dtFechaFin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(214, 44);
            this.dtFechaFin.TabIndex = 2;
            // 
            // dtFechaInico
            // 
            this.dtFechaInico.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInico.Location = new System.Drawing.Point(236, 35);
            this.dtFechaInico.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtFechaInico.Name = "dtFechaInico";
            this.dtFechaInico.Size = new System.Drawing.Size(214, 44);
            this.dtFechaInico.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.btnInsertar);
            this.flowLayoutPanel1.Controls.Add(this.btnSubirPlan);
            this.flowLayoutPanel1.Controls.Add(this.btnSubir);
            this.flowLayoutPanel1.Controls.Add(this.btnAyuda);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(644, 8);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1312, 96);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.Visible = false;
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnInsertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInsertar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertar.FlatAppearance.BorderSize = 0;
            this.btnInsertar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.ForeColor = System.Drawing.Color.Black;
            this.btnInsertar.Image = global::UNAN.Properties.Resources.Add_32x;
            this.btnInsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertar.Location = new System.Drawing.Point(6, 6);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(242, 75);
            this.btnInsertar.TabIndex = 5;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertar.UseVisualStyleBackColor = false;
            // 
            // btnSubirPlan
            // 
            this.btnSubirPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSubirPlan.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubirPlan.ForeColor = System.Drawing.Color.Black;
            this.btnSubirPlan.Image = global::UNAN.Properties.Resources.save32px;
            this.btnSubirPlan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubirPlan.Location = new System.Drawing.Point(260, 6);
            this.btnSubirPlan.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSubirPlan.Name = "btnSubirPlan";
            this.btnSubirPlan.Size = new System.Drawing.Size(356, 75);
            this.btnSubirPlan.TabIndex = 6;
            this.btnSubirPlan.Text = "Guardar Plan Didáctico";
            this.btnSubirPlan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubirPlan.UseVisualStyleBackColor = false;
            this.btnSubirPlan.Click += new System.EventHandler(this.btnSubirPlan_Click);
            // 
            // btnSubir
            // 
            this.btnSubir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSubir.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubir.ForeColor = System.Drawing.Color.Black;
            this.btnSubir.Image = global::UNAN.Properties.Resources.up_32px;
            this.btnSubir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubir.Location = new System.Drawing.Point(628, 6);
            this.btnSubir.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(452, 75);
            this.btnSubir.TabIndex = 5;
            this.btnSubir.Text = "Subir Plan Didáctico";
            this.btnSubir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubir.UseVisualStyleBackColor = false;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAyuda.Font = new System.Drawing.Font("Arial", 14.25F);
            this.btnAyuda.Image = global::UNAN.Properties.Resources.help_32px;
            this.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.Location = new System.Drawing.Point(1092, 6);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(202, 75);
            this.btnAyuda.TabIndex = 8;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAyuda.UseVisualStyleBackColor = false;
            // 
            // PCargarPlan
            // 
            this.PCargarPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PCargarPlan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PCargarPlan.Controls.Add(this.btnCerrarP);
            this.PCargarPlan.Controls.Add(this.btnCargar);
            this.PCargarPlan.Controls.Add(this.cboHojas);
            this.PCargarPlan.Controls.Add(this.btnBuscar);
            this.PCargarPlan.Controls.Add(this.txtRuta);
            this.PCargarPlan.Controls.Add(this.label1);
            this.PCargarPlan.Controls.Add(this.label18);
            this.PCargarPlan.Location = new System.Drawing.Point(2446, 48);
            this.PCargarPlan.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PCargarPlan.Name = "PCargarPlan";
            this.PCargarPlan.Size = new System.Drawing.Size(132, 89);
            this.PCargarPlan.TabIndex = 7;
            this.PCargarPlan.Visible = false;
            // 
            // btnCerrarP
            // 
            this.btnCerrarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarP.Location = new System.Drawing.Point(550, 233);
            this.btnCerrarP.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCerrarP.Name = "btnCerrarP";
            this.btnCerrarP.Size = new System.Drawing.Size(150, 58);
            this.btnCerrarP.TabIndex = 18;
            this.btnCerrarP.Text = "Cerrar";
            this.btnCerrarP.UseVisualStyleBackColor = true;
            this.btnCerrarP.Click += new System.EventHandler(this.btnCerrarP_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Enabled = false;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(824, 162);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(150, 58);
            this.btnCargar.TabIndex = 17;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // cboHojas
            // 
            this.cboHojas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHojas.FormattingEnabled = true;
            this.cboHojas.Location = new System.Drawing.Point(376, 165);
            this.cboHojas.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboHojas.Name = "cboHojas";
            this.cboHojas.Size = new System.Drawing.Size(432, 45);
            this.cboHojas.TabIndex = 16;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(614, 42);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 56);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "...";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuta.Location = new System.Drawing.Point(142, 48);
            this.txtRuta.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(430, 44);
            this.txtRuta.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Hoja Encontradas:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(24, 48);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 37);
            this.label18.TabIndex = 13;
            this.label18.Text = "Ruta:";
            // 
            // gbDatos
            // 
            this.gbDatos.BackColor = System.Drawing.Color.White;
            this.gbDatos.Controls.Add(this.pncarga);
            this.gbDatos.Controls.Add(this.btnEE);
            this.gbDatos.Controls.Add(this.btnFE);
            this.gbDatos.Controls.Add(this.btnEEA);
            this.gbDatos.Controls.Add(this.cbEstrEvaluacion);
            this.gbDatos.Controls.Add(this.cbFormaEvaluacion);
            this.gbDatos.Controls.Add(this.cbEnseApren);
            this.gbDatos.Controls.Add(this.label14);
            this.gbDatos.Controls.Add(this.PCargarPlan);
            this.gbDatos.Controls.Add(this.txtPorcentaje);
            this.gbDatos.Controls.Add(this.dtFechaInico);
            this.gbDatos.Controls.Add(this.dtFechaFin);
            this.gbDatos.Controls.Add(this.label13);
            this.gbDatos.Controls.Add(this.label12);
            this.gbDatos.Controls.Add(this.label11);
            this.gbDatos.Controls.Add(this.label10);
            this.gbDatos.Controls.Add(this.label9);
            this.gbDatos.Controls.Add(this.label16);
            this.gbDatos.Controls.Add(this.label8);
            this.gbDatos.Controls.Add(this.label15);
            this.gbDatos.Controls.Add(this.label7);
            this.gbDatos.Controls.Add(this.txtCont);
            this.gbDatos.Controls.Add(this.txtObj);
            this.gbDatos.Controls.Add(this.txtSemInicio);
            this.gbDatos.Controls.Add(this.txtSemFin);
            this.gbDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDatos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.Location = new System.Drawing.Point(0, 299);
            this.gbDatos.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbDatos.Size = new System.Drawing.Size(2588, 458);
            this.gbDatos.TabIndex = 2;
            this.gbDatos.TabStop = false;
            this.gbDatos.Visible = false;
            // 
            // btnEE
            // 
            this.btnEE.BackColor = System.Drawing.Color.Gray;
            this.btnEE.BackgroundImage = global::UNAN.Properties.Resources.EstrEva;
            this.btnEE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEE.Location = new System.Drawing.Point(1984, 367);
            this.btnEE.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEE.Name = "btnEE";
            this.btnEE.Size = new System.Drawing.Size(82, 85);
            this.btnEE.TabIndex = 36;
            this.btnEE.UseVisualStyleBackColor = false;
            this.btnEE.Click += new System.EventHandler(this.btnEE_Click);
            // 
            // btnFE
            // 
            this.btnFE.BackgroundImage = global::UNAN.Properties.Resources.Evaluation;
            this.btnFE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFE.Location = new System.Drawing.Point(1312, 367);
            this.btnFE.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnFE.Name = "btnFE";
            this.btnFE.Size = new System.Drawing.Size(82, 85);
            this.btnFE.TabIndex = 35;
            this.btnFE.UseVisualStyleBackColor = true;
            this.btnFE.Click += new System.EventHandler(this.btnFE_Click);
            // 
            // btnEEA
            // 
            this.btnEEA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEEA.BackgroundImage = global::UNAN.Properties.Resources.Estrategia;
            this.btnEEA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEEA.Location = new System.Drawing.Point(528, 367);
            this.btnEEA.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEEA.Name = "btnEEA";
            this.btnEEA.Size = new System.Drawing.Size(82, 77);
            this.btnEEA.TabIndex = 34;
            this.btnEEA.UseVisualStyleBackColor = false;
            this.btnEEA.Click += new System.EventHandler(this.btnEEA_Click);
            // 
            // cbEstrEvaluacion
            // 
            this.cbEstrEvaluacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEstrEvaluacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbEstrEvaluacion.BackColor = System.Drawing.Color.White;
            this.cbEstrEvaluacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstrEvaluacion.FormattingEnabled = true;
            this.cbEstrEvaluacion.Location = new System.Drawing.Point(1490, 387);
            this.cbEstrEvaluacion.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbEstrEvaluacion.Name = "cbEstrEvaluacion";
            this.cbEstrEvaluacion.Size = new System.Drawing.Size(476, 44);
            this.cbEstrEvaluacion.TabIndex = 30;
            // 
            // cbFormaEvaluacion
            // 
            this.cbFormaEvaluacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFormaEvaluacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbFormaEvaluacion.BackColor = System.Drawing.Color.White;
            this.cbFormaEvaluacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFormaEvaluacion.FormattingEnabled = true;
            this.cbFormaEvaluacion.Location = new System.Drawing.Point(810, 390);
            this.cbFormaEvaluacion.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbFormaEvaluacion.Name = "cbFormaEvaluacion";
            this.cbFormaEvaluacion.Size = new System.Drawing.Size(476, 44);
            this.cbFormaEvaluacion.TabIndex = 29;
            // 
            // cbEnseApren
            // 
            this.cbEnseApren.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEnseApren.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbEnseApren.BackColor = System.Drawing.Color.White;
            this.cbEnseApren.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEnseApren.FormattingEnabled = true;
            this.cbEnseApren.Location = new System.Drawing.Point(18, 390);
            this.cbEnseApren.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbEnseApren.Name = "cbEnseApren";
            this.cbEnseApren.Size = new System.Drawing.Size(476, 44);
            this.cbEnseApren.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(2210, 317);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 45);
            this.label14.TabIndex = 4;
            this.label14.Text = "%:";
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Location = new System.Drawing.Point(2180, 390);
            this.txtPorcentaje.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(122, 44);
            this.txtPorcentaje.TabIndex = 3;
            this.txtPorcentaje.Text = "%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(810, 317);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(392, 45);
            this.label12.TabIndex = 1;
            this.label12.Text = "Forma de Evaluación:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1242, 152);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(204, 45);
            this.label11.TabIndex = 1;
            this.label11.Text = "Contenido:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 317);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(684, 45);
            this.label10.TabIndex = 1;
            this.label10.Text = "Estrategia de Enseñanza - Aprendizaje:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(478, 46);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(244, 39);
            this.label16.TabIndex = 1;
            this.label16.Text = "Semana Inicio:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(22, 40);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(215, 39);
            this.label15.TabIndex = 1;
            this.label15.Text = "Fecha Inicio:";
            // 
            // txtSemInicio
            // 
            this.txtSemInicio.BackColor = System.Drawing.Color.White;
            this.txtSemInicio.Location = new System.Drawing.Point(738, 40);
            this.txtSemInicio.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSemInicio.Name = "txtSemInicio";
            this.txtSemInicio.Size = new System.Drawing.Size(114, 44);
            this.txtSemInicio.TabIndex = 0;
            // 
            // pnBotones
            // 
            this.pnBotones.Controls.Add(this.flowLayoutPanel1);
            this.pnBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBotones.Location = new System.Drawing.Point(0, 757);
            this.pnBotones.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnBotones.Name = "pnBotones";
            this.pnBotones.Size = new System.Drawing.Size(2588, 100);
            this.pnBotones.TabIndex = 8;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // pncarga
            // 
            this.pncarga.Controls.Add(this.pbrCarga);
            this.pncarga.Controls.Add(this.lblCarga);
            this.pncarga.Location = new System.Drawing.Point(2106, 240);
            this.pncarga.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pncarga.Name = "pncarga";
            this.pncarga.Size = new System.Drawing.Size(2322, 933);
            this.pncarga.TabIndex = 11;
            // 
            // pbrCarga
            // 
            this.pbrCarga.Location = new System.Drawing.Point(576, 585);
            this.pbrCarga.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pbrCarga.Name = "pbrCarga";
            this.pbrCarga.Size = new System.Drawing.Size(1398, 44);
            this.pbrCarga.TabIndex = 10;
            // 
            // lblCarga
            // 
            this.lblCarga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarga.ForeColor = System.Drawing.Color.Black;
            this.lblCarga.Location = new System.Drawing.Point(0, 0);
            this.lblCarga.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCarga.Name = "lblCarga";
            this.lblCarga.Size = new System.Drawing.Size(2322, 933);
            this.lblCarga.TabIndex = 9;
            this.lblCarga.Text = "Bienvenidos";
            this.lblCarga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCPlanDidactico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtPlan);
            this.Controls.Add(this.pnBotones);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.GBDetalles);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "UCPlanDidactico";
            this.Size = new System.Drawing.Size(2588, 1775);
            this.Load += new System.EventHandler(this.UCPlanDidactico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtPlan)).EndInit();
            this.GBDetalles.ResumeLayout(false);
            this.GBDetalles.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.PCargarPlan.ResumeLayout(false);
            this.PCargarPlan.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.pnBotones.ResumeLayout(false);
            this.pncarga.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dtPlan;
        private System.Windows.Forms.GroupBox GBDetalles;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSemFin;
        private System.Windows.Forms.TextBox txtObj;
        private System.Windows.Forms.TextBox txtCont;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.DateTimePicker dtFechaInico;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnSubirPlan;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.Panel PCargarPlan;
        private System.Windows.Forms.Button btnCerrarP;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ComboBox cboHojas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSemInicio;
        private System.Windows.Forms.Button btnAddGrupo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Button btnCarrera;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbSemestre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDocente;
        private System.Windows.Forms.TextBox txtAAcademico;
        private System.Windows.Forms.ComboBox cbAsignaturas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAyuda;
        public System.Windows.Forms.ComboBox cbModalidad;
        public System.Windows.Forms.ComboBox cbCarrera;
        public System.Windows.Forms.ComboBox cbGrupo;
        private System.Windows.Forms.Button btnAddAsig;
        private System.Windows.Forms.Label lblCodAsig;
        private System.Windows.Forms.Panel pnBotones;
        public System.Windows.Forms.ComboBox cbEstrEvaluacion;
        public System.Windows.Forms.ComboBox cbFormaEvaluacion;
        public System.Windows.Forms.ComboBox cbEnseApren;
        private System.Windows.Forms.Button btnEEA;
        private System.Windows.Forms.Button btnEE;
        private System.Windows.Forms.Button btnFE;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pncarga;
        private System.Windows.Forms.ProgressBar pbrCarga;
        private System.Windows.Forms.Label lblCarga;
    }
}
