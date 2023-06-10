namespace UNAN.Presentacion
{
    partial class UCAsistencia
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnHrEntrada = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtHrEntrada = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.nudBloque = new System.Windows.Forms.NumericUpDown();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pnBloques = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblbloque = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGrupo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCarrera = new System.Windows.Forms.ComboBox();
            this.cbModalidad = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbAsignaturas = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbContenido = new System.Windows.Forms.ComboBox();
            this.cbActividad = new System.Windows.Forms.ComboBox();
            this.btnAddBloque = new System.Windows.Forms.Button();
            this.pnHrSalida = new System.Windows.Forms.Panel();
            this.dtHrSalida = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cbProgreso = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.dataAsistencia = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnHrEntrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBloque)).BeginInit();
            this.pnBloques.SuspendLayout();
            this.pnHrSalida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAsistencia)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 45);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1113, 17);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1113, 16);
            this.panel2.TabIndex = 0;
            // 
            // pnHrEntrada
            // 
            this.pnHrEntrada.Controls.Add(this.btnAceptar);
            this.pnHrEntrada.Controls.Add(this.lblFecha);
            this.pnHrEntrada.Controls.Add(this.nudBloque);
            this.pnHrEntrada.Controls.Add(this.label2);
            this.pnHrEntrada.Controls.Add(this.dtHrEntrada);
            this.pnHrEntrada.Controls.Add(this.label1);
            this.pnHrEntrada.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHrEntrada.Location = new System.Drawing.Point(0, 45);
            this.pnHrEntrada.Name = "pnHrEntrada";
            this.pnHrEntrada.Size = new System.Drawing.Size(1113, 47);
            this.pnHrEntrada.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hora de entrada:";
            // 
            // dtHrEntrada
            // 
            this.dtHrEntrada.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHrEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHrEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHrEntrada.Location = new System.Drawing.Point(465, 14);
            this.dtHrEntrada.Name = "dtHrEntrada";
            this.dtHrEntrada.Size = new System.Drawing.Size(101, 26);
            this.dtHrEntrada.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(618, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bloques a impartir:";
            // 
            // nudBloque
            // 
            this.nudBloque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBloque.Location = new System.Drawing.Point(854, 14);
            this.nudBloque.Name = "nudBloque";
            this.nudBloque.Size = new System.Drawing.Size(51, 26);
            this.nudBloque.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(72, 13);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(66, 24);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "label3";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(957, 6);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 33);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // pnBloques
            // 
            this.pnBloques.Controls.Add(this.btnAddBloque);
            this.pnBloques.Controls.Add(this.cbActividad);
            this.pnBloques.Controls.Add(this.cbContenido);
            this.pnBloques.Controls.Add(this.cbCarrera);
            this.pnBloques.Controls.Add(this.label5);
            this.pnBloques.Controls.Add(this.cbModalidad);
            this.pnBloques.Controls.Add(this.label10);
            this.pnBloques.Controls.Add(this.label6);
            this.pnBloques.Controls.Add(this.label8);
            this.pnBloques.Controls.Add(this.cbGrupo);
            this.pnBloques.Controls.Add(this.lblCod);
            this.pnBloques.Controls.Add(this.label19);
            this.pnBloques.Controls.Add(this.label4);
            this.pnBloques.Controls.Add(this.cbAsignaturas);
            this.pnBloques.Controls.Add(this.lblbloque);
            this.pnBloques.Controls.Add(this.label3);
            this.pnBloques.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBloques.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnBloques.Location = new System.Drawing.Point(0, 92);
            this.pnBloques.Name = "pnBloques";
            this.pnBloques.Size = new System.Drawing.Size(1113, 148);
            this.pnBloques.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bloque: #";
            // 
            // lblbloque
            // 
            this.lblbloque.AutoSize = true;
            this.lblbloque.Location = new System.Drawing.Point(147, 18);
            this.lblbloque.Name = "lblbloque";
            this.lblbloque.Size = new System.Drawing.Size(21, 24);
            this.lblbloque.TabIndex = 6;
            this.lblbloque.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Grupo:";
            // 
            // cbGrupo
            // 
            this.cbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrupo.FormattingEnabled = true;
            this.cbGrupo.Location = new System.Drawing.Point(533, 15);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(121, 28);
            this.cbGrupo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(671, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Carrera:";
            // 
            // cbCarrera
            // 
            this.cbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCarrera.FormattingEnabled = true;
            this.cbCarrera.Location = new System.Drawing.Point(773, 18);
            this.cbCarrera.Name = "cbCarrera";
            this.cbCarrera.Size = new System.Drawing.Size(247, 28);
            this.cbCarrera.TabIndex = 10;
            this.cbCarrera.SelectedIndexChanged += new System.EventHandler(this.cbCarrera_SelectedIndexChanged);
            // 
            // cbModalidad
            // 
            this.cbModalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbModalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModalidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModalidad.FormattingEnabled = true;
            this.cbModalidad.Location = new System.Drawing.Point(315, 19);
            this.cbModalidad.Name = "cbModalidad";
            this.cbModalidad.Size = new System.Drawing.Size(110, 26);
            this.cbModalidad.TabIndex = 48;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.Control;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(185, 18);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(113, 24);
            this.label19.TabIndex = 47;
            this.label19.Text = "Modalidad:";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(1037, 22);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(72, 18);
            this.lblCod.TabIndex = 46;
            this.lblCod.Text = "CodigoC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(922, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 24);
            this.label6.TabIndex = 40;
            this.label6.Text = "Actividad:";
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
            this.cbAsignaturas.Location = new System.Drawing.Point(185, 71);
            this.cbAsignaturas.Name = "cbAsignaturas";
            this.cbAsignaturas.Size = new System.Drawing.Size(260, 26);
            this.cbAsignaturas.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(480, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 24);
            this.label8.TabIndex = 34;
            this.label8.Text = "Contenido:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(35, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 24);
            this.label10.TabIndex = 33;
            this.label10.Text = "Asignatura:";
            // 
            // cbContenido
            // 
            this.cbContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbContenido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContenido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbContenido.FormattingEnabled = true;
            this.cbContenido.Items.AddRange(new object[] {
            "Estructura l",
            "Estructura ll",
            "Prog Alg",
            "Inf Bas",
            "Fund Prog"});
            this.cbContenido.Location = new System.Drawing.Point(627, 72);
            this.cbContenido.Name = "cbContenido";
            this.cbContenido.Size = new System.Drawing.Size(260, 26);
            this.cbContenido.TabIndex = 49;
            // 
            // cbActividad
            // 
            this.cbActividad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActividad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActividad.FormattingEnabled = true;
            this.cbActividad.Items.AddRange(new object[] {
            "Estructura l",
            "Estructura ll",
            "Prog Alg",
            "Inf Bas",
            "Fund Prog"});
            this.cbActividad.Location = new System.Drawing.Point(1058, 72);
            this.cbActividad.Name = "cbActividad";
            this.cbActividad.Size = new System.Drawing.Size(260, 26);
            this.cbActividad.TabIndex = 50;
            // 
            // btnAddBloque
            // 
            this.btnAddBloque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddBloque.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAddBloque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddBloque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBloque.Location = new System.Drawing.Point(522, 104);
            this.btnAddBloque.Name = "btnAddBloque";
            this.btnAddBloque.Size = new System.Drawing.Size(179, 33);
            this.btnAddBloque.TabIndex = 51;
            this.btnAddBloque.Text = "Agregar Bloque";
            this.btnAddBloque.UseVisualStyleBackColor = false;
            // 
            // pnHrSalida
            // 
            this.pnHrSalida.Controls.Add(this.txtObservaciones);
            this.pnHrSalida.Controls.Add(this.label11);
            this.pnHrSalida.Controls.Add(this.cbProgreso);
            this.pnHrSalida.Controls.Add(this.label9);
            this.pnHrSalida.Controls.Add(this.dtHrSalida);
            this.pnHrSalida.Controls.Add(this.label7);
            this.pnHrSalida.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHrSalida.Location = new System.Drawing.Point(0, 240);
            this.pnHrSalida.Name = "pnHrSalida";
            this.pnHrSalida.Size = new System.Drawing.Size(1113, 87);
            this.pnHrSalida.TabIndex = 4;
            // 
            // dtHrSalida
            // 
            this.dtHrSalida.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHrSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHrSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHrSalida.Location = new System.Drawing.Point(226, 18);
            this.dtHrSalida.Name = "dtHrSalida";
            this.dtHrSalida.Size = new System.Drawing.Size(101, 26);
            this.dtHrSalida.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Hora de Salida:";
            // 
            // cbProgreso
            // 
            this.cbProgreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbProgreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProgreso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProgreso.FormattingEnabled = true;
            this.cbProgreso.Location = new System.Drawing.Point(588, 18);
            this.cbProgreso.Name = "cbProgreso";
            this.cbProgreso.Size = new System.Drawing.Size(110, 26);
            this.cbProgreso.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(364, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 24);
            this.label9.TabIndex = 49;
            this.label9.Text = "Progreso del tema:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(735, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 24);
            this.label11.TabIndex = 51;
            this.label11.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(926, 6);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(178, 57);
            this.txtObservaciones.TabIndex = 52;
            // 
            // dataAsistencia
            // 
            this.dataAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAsistencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataAsistencia.Location = new System.Drawing.Point(0, 327);
            this.dataAsistencia.Name = "dataAsistencia";
            this.dataAsistencia.Size = new System.Drawing.Size(1113, 243);
            this.dataAsistencia.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(578, 6);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 33);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnGuardar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 528);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1113, 42);
            this.panel4.TabIndex = 7;
            // 
            // UCAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataAsistencia);
            this.Controls.Add(this.pnHrSalida);
            this.Controls.Add(this.pnBloques);
            this.Controls.Add(this.pnHrEntrada);
            this.Controls.Add(this.panel1);
            this.Name = "UCAsistencia";
            this.Size = new System.Drawing.Size(1113, 570);
            this.Load += new System.EventHandler(this.UCAsistencia_Load);
            this.panel1.ResumeLayout(false);
            this.pnHrEntrada.ResumeLayout(false);
            this.pnHrEntrada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBloque)).EndInit();
            this.pnBloques.ResumeLayout(false);
            this.pnBloques.PerformLayout();
            this.pnHrSalida.ResumeLayout(false);
            this.pnHrSalida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAsistencia)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnHrEntrada;
        private System.Windows.Forms.DateTimePicker dtHrEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.NumericUpDown nudBloque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel pnBloques;
        private System.Windows.Forms.Label lblbloque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCarrera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbGrupo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbModalidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbAsignaturas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddBloque;
        private System.Windows.Forms.ComboBox cbActividad;
        private System.Windows.Forms.ComboBox cbContenido;
        private System.Windows.Forms.Panel pnHrSalida;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbProgreso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtHrSalida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataAsistencia;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel4;
    }
}
