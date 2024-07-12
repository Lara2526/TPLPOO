namespace Vistas
{
    partial class FrmABMParticipantes
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
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.cmbNacionalidad = new System.Windows.Forms.ComboBox();
            this.nudPeso = new System.Windows.Forms.NumericUpDown();
            this.nudAltura = new System.Windows.Forms.NumericUpDown();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEntrenador = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAtleta = new System.Windows.Forms.DataGridView();
            this.lbID = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscarNombre = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtbuscarNombre = new System.Windows.Forms.TextBox();
            this.rbtnOrdenadoporDNI = new System.Windows.Forms.RadioButton();
            this.rbtnOrdenadoporApellido = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.recCabecera = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.recFooter = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lblGrupo07 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblLPOOI = new System.Windows.Forms.Label();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.lblEliminar1 = new System.Windows.Forms.Label();
            this.lblModificar = new System.Windows.Forms.Label();
            this.lblModificar1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtleta)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNac.Location = new System.Drawing.Point(118, 269);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaNac.TabIndex = 56;
            // 
            // cmbNacionalidad
            // 
            this.cmbNacionalidad.FormattingEnabled = true;
            this.cmbNacionalidad.Items.AddRange(new object[] {
            "Argentina",
            "Brasil",
            "Uruguay",
            "Estados Unidos",
            "Mexico"});
            this.cmbNacionalidad.Location = new System.Drawing.Point(116, 134);
            this.cmbNacionalidad.Name = "cmbNacionalidad";
            this.cmbNacionalidad.Size = new System.Drawing.Size(164, 21);
            this.cmbNacionalidad.TabIndex = 55;
            this.cmbNacionalidad.Text = "Argentina";
            // 
            // nudPeso
            // 
            this.nudPeso.Location = new System.Drawing.Point(116, 242);
            this.nudPeso.Name = "nudPeso";
            this.nudPeso.Size = new System.Drawing.Size(58, 20);
            this.nudPeso.TabIndex = 53;
            // 
            // nudAltura
            // 
            this.nudAltura.Location = new System.Drawing.Point(116, 217);
            this.nudAltura.Name = "nudAltura";
            this.nudAltura.Size = new System.Drawing.Size(58, 20);
            this.nudAltura.TabIndex = 52;
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.BackColor = System.Drawing.Color.Transparent;
            this.rbtnFemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFemenino.Location = new System.Drawing.Point(204, 190);
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Size = new System.Drawing.Size(86, 20);
            this.rbtnFemenino.TabIndex = 51;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "Femenino";
            this.rbtnFemenino.UseVisualStyleBackColor = false;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.BackColor = System.Drawing.Color.Transparent;
            this.rbtnMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMasculino.Location = new System.Drawing.Point(118, 190);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(87, 20);
            this.rbtnMasculino.TabIndex = 50;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(116, 350);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(199, 20);
            this.txtEmail.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(61, 350);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 20);
            this.label12.TabIndex = 48;
            this.label12.Text = "Email:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(116, 302);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(199, 44);
            this.txtDireccion.TabIndex = 47;
            // 
            // txtEntrenador
            // 
            this.txtEntrenador.Location = new System.Drawing.Point(116, 162);
            this.txtEntrenador.Name = "txtEntrenador";
            this.txtEntrenador.Size = new System.Drawing.Size(164, 20);
            this.txtEntrenador.TabIndex = 46;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(116, 108);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(102, 20);
            this.txtDNI.TabIndex = 45;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(116, 84);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(164, 20);
            this.txtApellido.TabIndex = 44;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(116, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(164, 20);
            this.txtNombre.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(34, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 20);
            this.label11.TabIndex = 42;
            this.label11.Text = "Dirección:";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(-2, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 36);
            this.label10.TabIndex = 41;
            this.label10.Text = "Fecha de Nacimiento:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(64, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "Peso:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(58, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "Altura:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(46, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Género:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(20, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Entrenador:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(9, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Nacionalidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(72, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(44, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(44, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nombre:";
            // 
            // dgvAtleta
            // 
            this.dgvAtleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtleta.Location = new System.Drawing.Point(332, 130);
            this.dgvAtleta.Name = "dgvAtleta";
            this.dgvAtleta.Size = new System.Drawing.Size(531, 248);
            this.dgvAtleta.TabIndex = 58;
            this.dgvAtleta.CurrentCellChanged += new System.EventHandler(this.dgvAtleta_CurrentCellChanged);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbID.Location = new System.Drawing.Point(205, 26);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(13, 13);
            this.lbID.TabIndex = 60;
            this.lbID.Text = "0";
            this.lbID.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(138, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 59;
            this.label13.Text = "ID";
            this.label13.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(118, 372);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(91, 32);
            this.btnLimpiar.TabIndex = 64;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(118, 403);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(91, 32);
            this.btnModificar.TabIndex = 63;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(208, 403);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(91, 32);
            this.btnEliminar.TabIndex = 62;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(208, 372);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(91, 32);
            this.btnAgregar.TabIndex = 61;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscarNombre
            // 
            this.btnBuscarNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBuscarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarNombre.ForeColor = System.Drawing.Color.White;
            this.btnBuscarNombre.Location = new System.Drawing.Point(494, 80);
            this.btnBuscarNombre.Name = "btnBuscarNombre";
            this.btnBuscarNombre.Size = new System.Drawing.Size(87, 33);
            this.btnBuscarNombre.TabIndex = 67;
            this.btnBuscarNombre.Text = "Buscar";
            this.btnBuscarNombre.UseVisualStyleBackColor = false;
            this.btnBuscarNombre.Click += new System.EventHandler(this.btnBuscarNombre_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(329, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 16);
            this.label14.TabIndex = 66;
            this.label14.Text = "Buscar por apellido:";
            // 
            // txtbuscarNombre
            // 
            this.txtbuscarNombre.Location = new System.Drawing.Point(332, 93);
            this.txtbuscarNombre.Name = "txtbuscarNombre";
            this.txtbuscarNombre.Size = new System.Drawing.Size(156, 20);
            this.txtbuscarNombre.TabIndex = 65;
            // 
            // rbtnOrdenadoporDNI
            // 
            this.rbtnOrdenadoporDNI.AutoSize = true;
            this.rbtnOrdenadoporDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnOrdenadoporDNI.Location = new System.Drawing.Point(17, 22);
            this.rbtnOrdenadoporDNI.Name = "rbtnOrdenadoporDNI";
            this.rbtnOrdenadoporDNI.Size = new System.Drawing.Size(46, 19);
            this.rbtnOrdenadoporDNI.TabIndex = 80;
            this.rbtnOrdenadoporDNI.TabStop = true;
            this.rbtnOrdenadoporDNI.Text = "DNI";
            this.rbtnOrdenadoporDNI.UseVisualStyleBackColor = true;
            // 
            // rbtnOrdenadoporApellido
            // 
            this.rbtnOrdenadoporApellido.AutoSize = true;
            this.rbtnOrdenadoporApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnOrdenadoporApellido.Location = new System.Drawing.Point(67, 22);
            this.rbtnOrdenadoporApellido.Name = "rbtnOrdenadoporApellido";
            this.rbtnOrdenadoporApellido.Size = new System.Drawing.Size(69, 19);
            this.rbtnOrdenadoporApellido.TabIndex = 81;
            this.rbtnOrdenadoporApellido.TabStop = true;
            this.rbtnOrdenadoporApellido.Text = "Apellido";
            this.rbtnOrdenadoporApellido.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnOrdenar);
            this.groupBox1.Controls.Add(this.rbtnOrdenadoporApellido);
            this.groupBox1.Controls.Add(this.rbtnOrdenadoporDNI);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(600, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 53);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordenado por ";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.ForeColor = System.Drawing.Color.White;
            this.btnOrdenar.Location = new System.Drawing.Point(147, 14);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(87, 33);
            this.btnOrdenar.TabIndex = 82;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // recCabecera
            // 
            this.recCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.recCabecera.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.recCabecera.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.recCabecera.Location = new System.Drawing.Point(0, 0);
            this.recCabecera.Name = "recCabecera";
            this.recCabecera.Size = new System.Drawing.Size(885, 50);
            // 
            // recFooter
            // 
            this.recFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.recFooter.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.recFooter.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.recFooter.Location = new System.Drawing.Point(0, 436);
            this.recFooter.Name = "recFooter";
            this.recFooter.Size = new System.Drawing.Size(885, 25);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.recFooter,
            this.recCabecera});
            this.shapeContainer1.Size = new System.Drawing.Size(884, 461);
            this.shapeContainer1.TabIndex = 83;
            this.shapeContainer1.TabStop = false;
            // 
            // lblGrupo07
            // 
            this.lblGrupo07.AutoSize = true;
            this.lblGrupo07.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblGrupo07.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo07.ForeColor = System.Drawing.Color.White;
            this.lblGrupo07.Location = new System.Drawing.Point(823, 441);
            this.lblGrupo07.Name = "lblGrupo07";
            this.lblGrupo07.Size = new System.Drawing.Size(59, 13);
            this.lblGrupo07.TabIndex = 86;
            this.lblGrupo07.Text = "Grupo 07";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(296, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(296, 37);
            this.lblTitulo.TabIndex = 85;
            this.lblTitulo.Text = "CRONOMETRAJE";
            // 
            // lblLPOOI
            // 
            this.lblLPOOI.AutoSize = true;
            this.lblLPOOI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblLPOOI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLPOOI.ForeColor = System.Drawing.Color.White;
            this.lblLPOOI.Location = new System.Drawing.Point(3, 439);
            this.lblLPOOI.Name = "lblLPOOI";
            this.lblLPOOI.Size = new System.Drawing.Size(380, 15);
            this.lblLPOOI.TabIndex = 84;
            this.lblLPOOI.Text = "Laboratorio de Programación Orientada a Objetos I - 2024";
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.BackColor = System.Drawing.Color.Transparent;
            this.lblEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblEliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEliminar.Location = new System.Drawing.Point(774, 379);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(91, 16);
            this.lblEliminar.TabIndex = 118;
            this.lblEliminar.Text = "Para  Eliminar";
            this.lblEliminar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblEliminar1
            // 
            this.lblEliminar1.BackColor = System.Drawing.Color.Transparent;
            this.lblEliminar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblEliminar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEliminar1.Location = new System.Drawing.Point(616, 395);
            this.lblEliminar1.Name = "lblEliminar1";
            this.lblEliminar1.Size = new System.Drawing.Size(249, 40);
            this.lblEliminar1.TabIndex = 117;
            this.lblEliminar1.Text = "Seleccione al participante en la tabla y presione ELIMINAR.";
            this.lblEliminar1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.BackColor = System.Drawing.Color.Transparent;
            this.lblModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblModificar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblModificar.Location = new System.Drawing.Point(333, 382);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(98, 16);
            this.lblModificar.TabIndex = 116;
            this.lblModificar.Text = "Para  Modificar";
            // 
            // lblModificar1
            // 
            this.lblModificar1.BackColor = System.Drawing.Color.Transparent;
            this.lblModificar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblModificar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblModificar1.Location = new System.Drawing.Point(333, 398);
            this.lblModificar1.Name = "lblModificar1";
            this.lblModificar1.Size = new System.Drawing.Size(257, 37);
            this.lblModificar1.TabIndex = 119;
            this.lblModificar1.Text = "Seleccione al participante, editelo y presione MODIFICAR.";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmABMParticipantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Vistas.Properties.Resources.fondo1;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.lblModificar1);
            this.Controls.Add(this.lblEliminar);
            this.Controls.Add(this.lblEliminar1);
            this.Controls.Add(this.lblModificar);
            this.Controls.Add(this.lblGrupo07);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblLPOOI);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscarNombre);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtbuscarNombre);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvAtleta);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.cmbNacionalidad);
            this.Controls.Add(this.nudPeso);
            this.Controls.Add(this.nudAltura);
            this.Controls.Add(this.rbtnFemenino);
            this.Controls.Add(this.rbtnMasculino);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtEntrenador);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "FrmABMParticipantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmABMParticipantes";
            this.Load += new System.EventHandler(this.FrmABMParticipantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtleta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.ComboBox cmbNacionalidad;
        private System.Windows.Forms.NumericUpDown nudPeso;
        private System.Windows.Forms.NumericUpDown nudAltura;
        private System.Windows.Forms.RadioButton rbtnFemenino;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtEntrenador;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAtleta;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscarNombre;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtbuscarNombre;
        private System.Windows.Forms.RadioButton rbtnOrdenadoporDNI;
        private System.Windows.Forms.RadioButton rbtnOrdenadoporApellido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOrdenar;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape recCabecera;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape recFooter;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label lblGrupo07;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblLPOOI;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.Label lblEliminar1;
        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.Label lblModificar1;
        private System.Windows.Forms.ErrorProvider errorProvider1;

    }
}