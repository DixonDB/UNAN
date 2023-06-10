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
            this.dtPlan = new System.Windows.Forms.DataGridView();
            this.GBDetalles = new System.Windows.Forms.GroupBox();
            this.cbModalidad = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
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
            this.txtEstEnsApr = new System.Windows.Forms.TextBox();
            this.txtCont = new System.Windows.Forms.TextBox();
            this.txtForEva = new System.Windows.Forms.TextBox();
            this.btnAddCarrera = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInico = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PCargarPlan = new System.Windows.Forms.Panel();
            this.btnCerrarP = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.cboHojas = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSemInicio = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnSubirPlan = new System.Windows.Forms.Button();
            this.btnSubir = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnAddGrupo = new System.Windows.Forms.Button();
            this.btnCarrera = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtPlan)).BeginInit();
            this.GBDetalles.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.PCargarPlan.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtPlan
            // 
            this.dtPlan.AllowUserToOrderColumns = true;
            this.dtPlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtPlan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtPlan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtPlan.Location = new System.Drawing.Point(0, 451);
            this.dtPlan.Name = "dtPlan";
            this.dtPlan.RowHeadersVisible = false;
            this.dtPlan.RowHeadersWidth = 82;
            this.dtPlan.Size = new System.Drawing.Size(1294, 472);
            this.dtPlan.TabIndex = 3;
            // 
            // GBDetalles
            // 
            this.GBDetalles.BackColor = System.Drawing.Color.White;
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
            this.GBDetalles.Location = new System.Drawing.Point(0, 45);
            this.GBDetalles.Name = "GBDetalles";
            this.GBDetalles.Size = new System.Drawing.Size(1294, 110);
            this.GBDetalles.TabIndex = 1;
            this.GBDetalles.TabStop = false;
            // 
            // cbModalidad
            // 
            this.cbModalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbModalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModalidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModalidad.FormattingEnabled = true;
            this.cbModalidad.Location = new System.Drawing.Point(143, 19);
            this.cbModalidad.Name = "cbModalidad";
            this.cbModalidad.Size = new System.Drawing.Size(110, 26);
            this.cbModalidad.TabIndex = 31;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(24, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(113, 26);
            this.label19.TabIndex = 30;
            this.label19.Text = "Modalidad:";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(653, 29);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(72, 18);
            this.lblCod.TabIndex = 29;
            this.lblCod.Text = "CodigoC";
            // 
            // cbCarrera
            // 
            this.cbCarrera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarrera.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCarrera.FormattingEnabled = true;
            this.cbCarrera.Location = new System.Drawing.Point(360, 19);
            this.cbCarrera.Name = "cbCarrera";
            this.cbCarrera.Size = new System.Drawing.Size(240, 26);
            this.cbCarrera.TabIndex = 27;
            this.cbCarrera.SelectedIndexChanged += new System.EventHandler(this.cbCarrera_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(264, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 26);
            this.label17.TabIndex = 26;
            this.label17.Text = "Carrera:";
            // 
            // cbSemestre
            // 
            this.cbSemestre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSemestre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSemestre.FormattingEnabled = true;
            this.cbSemestre.Items.AddRange(new object[] {
            "l",
            "ll"});
            this.cbSemestre.Location = new System.Drawing.Point(1119, 23);
            this.cbSemestre.Name = "cbSemestre";
            this.cbSemestre.Size = new System.Drawing.Size(64, 26);
            this.cbSemestre.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1005, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 26);
            this.label6.TabIndex = 23;
            this.label6.Text = "Semestre:";
            // 
            // cbGrupo
            // 
            this.cbGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrupo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrupo.FormattingEnabled = true;
            this.cbGrupo.Items.AddRange(new object[] {
            "SIV1",
            "SIV2",
            "SIV3",
            "SIV4",
            "SIV5"});
            this.cbGrupo.Location = new System.Drawing.Point(826, 23);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(104, 26);
            this.cbGrupo.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(745, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 26);
            this.label4.TabIndex = 22;
            this.label4.Text = "Grupo:";
            // 
            // txtDocente
            // 
            this.txtDocente.BackColor = System.Drawing.Color.White;
            this.txtDocente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocente.Location = new System.Drawing.Point(530, 67);
            this.txtDocente.Name = "txtDocente";
            this.txtDocente.Size = new System.Drawing.Size(260, 26);
            this.txtDocente.TabIndex = 21;
            // 
            // txtAAcademico
            // 
            this.txtAAcademico.BackColor = System.Drawing.Color.White;
            this.txtAAcademico.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAAcademico.Location = new System.Drawing.Point(993, 70);
            this.txtAAcademico.Name = "txtAAcademico";
            this.txtAAcademico.Size = new System.Drawing.Size(100, 26);
            this.txtAAcademico.TabIndex = 20;
            this.txtAAcademico.Text = "20";
            // 
            // cbAsignaturas
            // 
            this.cbAsignaturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbAsignaturas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAsignaturas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAsignaturas.FormattingEnabled = true;
            this.cbAsignaturas.Items.AddRange(new object[] {
            "Estructura l",
            "Estructura ll",
            "Prog Alg",
            "Inf Bas",
            "Fund Prog"});
            this.cbAsignaturas.Location = new System.Drawing.Point(148, 67);
            this.cbAsignaturas.Name = "cbAsignaturas";
            this.cbAsignaturas.Size = new System.Drawing.Size(260, 26);
            this.cbAsignaturas.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(427, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 26);
            this.label5.TabIndex = 17;
            this.label5.Text = "Docente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(822, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 26);
            this.label3.TabIndex = 19;
            this.label3.Text = "Año Académico:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Asignatura:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1294, 16);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1294, 17);
            this.panel3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1294, 45);
            this.panel1.TabIndex = 0;
            // 
            // txtSemFin
            // 
            this.txtSemFin.BackColor = System.Drawing.Color.White;
            this.txtSemFin.Location = new System.Drawing.Point(344, 71);
            this.txtSemFin.Name = "txtSemFin";
            this.txtSemFin.Size = new System.Drawing.Size(58, 26);
            this.txtSemFin.TabIndex = 0;
            this.txtSemFin.TextChanged += new System.EventHandler(this.txtSemFin_TextChanged);
            // 
            // txtObj
            // 
            this.txtObj.Location = new System.Drawing.Point(536, 32);
            this.txtObj.Multiline = true;
            this.txtObj.Name = "txtObj";
            this.txtObj.Size = new System.Drawing.Size(249, 71);
            this.txtObj.TabIndex = 0;
            // 
            // txtEstEnsApr
            // 
            this.txtEstEnsApr.Location = new System.Drawing.Point(9, 142);
            this.txtEstEnsApr.Multiline = true;
            this.txtEstEnsApr.Name = "txtEstEnsApr";
            this.txtEstEnsApr.Size = new System.Drawing.Size(352, 78);
            this.txtEstEnsApr.TabIndex = 0;
            // 
            // txtCont
            // 
            this.txtCont.Location = new System.Drawing.Point(913, 25);
            this.txtCont.Multiline = true;
            this.txtCont.Name = "txtCont";
            this.txtCont.Size = new System.Drawing.Size(235, 78);
            this.txtCont.TabIndex = 0;
            // 
            // txtForEva
            // 
            this.txtForEva.Location = new System.Drawing.Point(394, 142);
            this.txtForEva.Multiline = true;
            this.txtForEva.Name = "txtForEva";
            this.txtForEva.Size = new System.Drawing.Size(352, 78);
            this.txtForEva.TabIndex = 0;
            // 
            // btnAddCarrera
            // 
            this.btnAddCarrera.Location = new System.Drawing.Point(779, 142);
            this.btnAddCarrera.Multiline = true;
            this.btnAddCarrera.Name = "btnAddCarrera";
            this.btnAddCarrera.Size = new System.Drawing.Size(352, 78);
            this.btnAddCarrera.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Fecha Fin:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(231, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Semana Fin:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(433, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "Objetivos:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(845, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(225, 24);
            this.label13.TabIndex = 1;
            this.label13.Text = "Estrategia de Evaluacion:";
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.Location = new System.Drawing.Point(110, 67);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(109, 26);
            this.dtFechaFin.TabIndex = 2;
            // 
            // dtFechaInico
            // 
            this.dtFechaInico.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInico.Location = new System.Drawing.Point(118, 18);
            this.dtFechaInico.Name = "dtFechaInico";
            this.dtFechaInico.Size = new System.Drawing.Size(109, 26);
            this.dtFechaInico.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnInsertar);
            this.flowLayoutPanel1.Controls.Add(this.btnSubirPlan);
            this.flowLayoutPanel1.Controls.Add(this.btnSubir);
            this.flowLayoutPanel1.Controls.Add(this.btnAyuda);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(279, 238);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(656, 50);
            this.flowLayoutPanel1.TabIndex = 6;
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
            this.PCargarPlan.Location = new System.Drawing.Point(969, 238);
            this.PCargarPlan.Name = "PCargarPlan";
            this.PCargarPlan.Size = new System.Drawing.Size(68, 48);
            this.PCargarPlan.TabIndex = 7;
            this.PCargarPlan.Visible = false;
            // 
            // btnCerrarP
            // 
            this.btnCerrarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarP.Location = new System.Drawing.Point(275, 121);
            this.btnCerrarP.Name = "btnCerrarP";
            this.btnCerrarP.Size = new System.Drawing.Size(75, 30);
            this.btnCerrarP.TabIndex = 18;
            this.btnCerrarP.Text = "Cerrar";
            this.btnCerrarP.UseVisualStyleBackColor = true;
            this.btnCerrarP.Click += new System.EventHandler(this.btnCerrarP_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Enabled = false;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(412, 84);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 30);
            this.btnCargar.TabIndex = 17;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // cboHojas
            // 
            this.cboHojas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHojas.FormattingEnabled = true;
            this.cboHojas.Location = new System.Drawing.Point(188, 86);
            this.cboHojas.Name = "cboHojas";
            this.cboHojas.Size = new System.Drawing.Size(218, 28);
            this.cboHojas.TabIndex = 16;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(307, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(58, 29);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "...";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuta.Location = new System.Drawing.Point(71, 25);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(217, 26);
            this.txtRuta.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Hoja Encontradas:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(12, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 20);
            this.label18.TabIndex = 13;
            this.label18.Text = "Ruta:";
            // 
            // gbDatos
            // 
            this.gbDatos.BackColor = System.Drawing.Color.White;
            this.gbDatos.Controls.Add(this.PCargarPlan);
            this.gbDatos.Controls.Add(this.flowLayoutPanel1);
            this.gbDatos.Controls.Add(this.label14);
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
            this.gbDatos.Controls.Add(this.btnAddCarrera);
            this.gbDatos.Controls.Add(this.txtForEva);
            this.gbDatos.Controls.Add(this.txtCont);
            this.gbDatos.Controls.Add(this.txtEstEnsApr);
            this.gbDatos.Controls.Add(this.txtObj);
            this.gbDatos.Controls.Add(this.txtSemInicio);
            this.gbDatos.Controls.Add(this.txtSemFin);
            this.gbDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDatos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.Location = new System.Drawing.Point(0, 155);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(1294, 296);
            this.gbDatos.TabIndex = 2;
            this.gbDatos.TabStop = false;
            this.gbDatos.Enter += new System.EventHandler(this.gbDatos_Enter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1171, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 24);
            this.label14.TabIndex = 4;
            this.label14.Text = "%:";
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Location = new System.Drawing.Point(1159, 142);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(63, 26);
            this.txtPorcentaje.TabIndex = 3;
            this.txtPorcentaje.Text = "%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(472, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(195, 24);
            this.label12.TabIndex = 1;
            this.label12.Text = "Forma de Evaluacion:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(796, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 24);
            this.label11.TabIndex = 1;
            this.label11.Text = "Contenido:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(342, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "Estrategia de Enseñanza - Aprendizaje:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(239, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 21);
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
            this.label15.Location = new System.Drawing.Point(11, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 21);
            this.label15.TabIndex = 1;
            this.label15.Text = "Fecha Inicio:";
            // 
            // txtSemInicio
            // 
            this.txtSemInicio.BackColor = System.Drawing.Color.White;
            this.txtSemInicio.Location = new System.Drawing.Point(369, 21);
            this.txtSemInicio.Name = "txtSemInicio";
            this.txtSemInicio.Size = new System.Drawing.Size(59, 26);
            this.txtSemInicio.TabIndex = 0;
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
            this.btnInsertar.Location = new System.Drawing.Point(3, 3);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(121, 39);
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
            this.btnSubirPlan.Location = new System.Drawing.Point(130, 3);
            this.btnSubirPlan.Name = "btnSubirPlan";
            this.btnSubirPlan.Size = new System.Drawing.Size(178, 39);
            this.btnSubirPlan.TabIndex = 6;
            this.btnSubirPlan.Text = "Guardar Plan Didáctico";
            this.btnSubirPlan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubirPlan.UseVisualStyleBackColor = false;
            // 
            // btnSubir
            // 
            this.btnSubir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSubir.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubir.ForeColor = System.Drawing.Color.Black;
            this.btnSubir.Image = global::UNAN.Properties.Resources.up_32px;
            this.btnSubir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubir.Location = new System.Drawing.Point(314, 3);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(226, 39);
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
            this.btnAyuda.Location = new System.Drawing.Point(546, 3);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(101, 39);
            this.btnAyuda.TabIndex = 8;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAyuda.UseVisualStyleBackColor = false;
            // 
            // btnAddGrupo
            // 
            this.btnAddGrupo.BackgroundImage = global::UNAN.Properties.Resources.Addteam;
            this.btnAddGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddGrupo.Location = new System.Drawing.Point(949, 15);
            this.btnAddGrupo.Name = "btnAddGrupo";
            this.btnAddGrupo.Size = new System.Drawing.Size(41, 44);
            this.btnAddGrupo.TabIndex = 32;
            this.btnAddGrupo.UseVisualStyleBackColor = true;
            this.btnAddGrupo.Click += new System.EventHandler(this.btnAddGrupo_Click);
            // 
            // btnCarrera
            // 
            this.btnCarrera.BackgroundImage = global::UNAN.Properties.Resources.addC;
            this.btnCarrera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCarrera.Location = new System.Drawing.Point(606, 15);
            this.btnCarrera.Name = "btnCarrera";
            this.btnCarrera.Size = new System.Drawing.Size(41, 44);
            this.btnCarrera.TabIndex = 28;
            this.btnCarrera.UseVisualStyleBackColor = true;
            this.btnCarrera.Click += new System.EventHandler(this.btnCarrera_Click_1);
            // 
            // UCPlanDidactico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtPlan);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.GBDetalles);
            this.Controls.Add(this.panel1);
            this.Name = "UCPlanDidactico";
            this.Size = new System.Drawing.Size(1294, 923);
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
        private System.Windows.Forms.TextBox txtEstEnsApr;
        private System.Windows.Forms.TextBox txtCont;
        private System.Windows.Forms.TextBox txtForEva;
        private System.Windows.Forms.TextBox btnAddCarrera;
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
        private System.Windows.Forms.ComboBox cbModalidad;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Button btnCarrera;
        private System.Windows.Forms.ComboBox cbCarrera;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbSemestre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbGrupo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDocente;
        private System.Windows.Forms.TextBox txtAAcademico;
        private System.Windows.Forms.ComboBox cbAsignaturas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAyuda;
    }
}
