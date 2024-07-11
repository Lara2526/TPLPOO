namespace Vistas
{
    partial class FrmCronometraje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCronometraje));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rtgFooter = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rtgCabecera = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lblLPOOI = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblGrupo07 = new System.Windows.Forms.Label();
            this.lblCompetencia = new System.Windows.Forms.Label();
            this.cmbCompetencias = new System.Windows.Forms.ComboBox();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dgvAtletas = new System.Windows.Forms.DataGridView();
            this.lblAtleta = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnDescalificado = new System.Windows.Forms.Button();
            this.btnAbandono = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.recFooter = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.recCabecera = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtletas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rtgFooter,
            this.rtgCabecera});
            this.shapeContainer1.Size = new System.Drawing.Size(884, 461);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rtgFooter
            // 
            this.rtgFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rtgFooter.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rtgFooter.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.rtgFooter.Location = new System.Drawing.Point(-2, 440);
            this.rtgFooter.Name = "rtgFooter";
            this.rtgFooter.Size = new System.Drawing.Size(885, 20);
            // 
            // rtgCabecera
            // 
            this.rtgCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rtgCabecera.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rtgCabecera.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.rtgCabecera.Location = new System.Drawing.Point(0, 0);
            this.rtgCabecera.Name = "rtgCabecera";
            this.rtgCabecera.Size = new System.Drawing.Size(885, 50);
            // 
            // lblLPOOI
            // 
            this.lblLPOOI.AutoSize = true;
            this.lblLPOOI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblLPOOI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLPOOI.ForeColor = System.Drawing.Color.White;
            this.lblLPOOI.Location = new System.Drawing.Point(-1, 441);
            this.lblLPOOI.Name = "lblLPOOI";
            this.lblLPOOI.Size = new System.Drawing.Size(380, 15);
            this.lblLPOOI.TabIndex = 1;
            this.lblLPOOI.Text = "Laboratorio de Programación Orientada a Objetos I - 2024";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(292, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(296, 37);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "CRONOMETRAJE";
            // 
            // lblGrupo07
            // 
            this.lblGrupo07.AutoSize = true;
            this.lblGrupo07.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblGrupo07.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo07.ForeColor = System.Drawing.Color.White;
            this.lblGrupo07.Location = new System.Drawing.Point(819, 443);
            this.lblGrupo07.Name = "lblGrupo07";
            this.lblGrupo07.Size = new System.Drawing.Size(59, 13);
            this.lblGrupo07.TabIndex = 3;
            this.lblGrupo07.Text = "Grupo 07";
            // 
            // lblCompetencia
            // 
            this.lblCompetencia.AutoSize = true;
            this.lblCompetencia.BackColor = System.Drawing.Color.Transparent;
            this.lblCompetencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetencia.Location = new System.Drawing.Point(129, 146);
            this.lblCompetencia.Name = "lblCompetencia";
            this.lblCompetencia.Size = new System.Drawing.Size(217, 20);
            this.lblCompetencia.TabIndex = 5;
            this.lblCompetencia.Text = "Seleccione una competencia:";
            // 
            // cmbCompetencias
            // 
            this.cmbCompetencias.FormattingEnabled = true;
            this.cmbCompetencias.Location = new System.Drawing.Point(352, 148);
            this.cmbCompetencias.Name = "cmbCompetencias";
            this.cmbCompetencias.Size = new System.Drawing.Size(121, 21);
            this.cmbCompetencias.TabIndex = 6;
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicio.Location = new System.Drawing.Point(129, 106);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(111, 20);
            this.lblHoraInicio.TabIndex = 11;
            this.lblHoraInicio.Text = "Hora de Inicio:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.CustomFormat = "HH:mm";
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.Location = new System.Drawing.Point(352, 105);
            this.dtpInicio.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(77, 20);
            this.dtpInicio.TabIndex = 13;
            this.dtpInicio.Value = new System.DateTime(2024, 7, 9, 12, 0, 0, 0);
            // 
            // dgvAtletas
            // 
            this.dgvAtletas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtletas.Location = new System.Drawing.Point(133, 232);
            this.dgvAtletas.Name = "dgvAtletas";
            this.dgvAtletas.Size = new System.Drawing.Size(548, 150);
            this.dgvAtletas.TabIndex = 15;
            // 
            // lblAtleta
            // 
            this.lblAtleta.AutoSize = true;
            this.lblAtleta.BackColor = System.Drawing.Color.Transparent;
            this.lblAtleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtleta.Location = new System.Drawing.Point(129, 188);
            this.lblAtleta.Name = "lblAtleta";
            this.lblAtleta.Size = new System.Drawing.Size(443, 20);
            this.lblAtleta.TabIndex = 8;
            this.lblAtleta.Text = "Seleccione un atleta y complete la hora de llegada en la tabla:";
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnGrabar.Location = new System.Drawing.Point(488, 148);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 16;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnModificar.Location = new System.Drawing.Point(488, 146);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnDescalificado
            // 
            this.btnDescalificado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDescalificado.Location = new System.Drawing.Point(687, 336);
            this.btnDescalificado.Name = "btnDescalificado";
            this.btnDescalificado.Size = new System.Drawing.Size(84, 23);
            this.btnDescalificado.TabIndex = 18;
            this.btnDescalificado.Text = "Descalificado";
            this.btnDescalificado.UseVisualStyleBackColor = false;
            this.btnDescalificado.Click += new System.EventHandler(this.btnDescalificado_Click);
            // 
            // btnAbandono
            // 
            this.btnAbandono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAbandono.Location = new System.Drawing.Point(687, 359);
            this.btnAbandono.Name = "btnAbandono";
            this.btnAbandono.Size = new System.Drawing.Size(84, 23);
            this.btnAbandono.TabIndex = 19;
            this.btnAbandono.Text = "Abandonó";
            this.btnAbandono.UseVisualStyleBackColor = false;
            this.btnAbandono.Click += new System.EventHandler(this.btnAbandono_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnGuardar.Location = new System.Drawing.Point(687, 312);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(84, 23);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.recFooter,
            this.recCabecera});
            this.shapeContainer2.Size = new System.Drawing.Size(884, 461);
            this.shapeContainer2.TabIndex = 21;
            this.shapeContainer2.TabStop = false;
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
            // recCabecera
            // 
            this.recCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.recCabecera.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.recCabecera.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.recCabecera.Location = new System.Drawing.Point(0, 0);
            this.recCabecera.Name = "recCabecera";
            this.recCabecera.Size = new System.Drawing.Size(885, 50);
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(20, 2);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(36, 47);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 10;
            this.imgLogo.TabStop = false;
            // 
            // FrmCronometraje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAbandono);
            this.Controls.Add(this.btnDescalificado);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.dgvAtletas);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.lblHoraInicio);
            this.Controls.Add(this.lblAtleta);
            this.Controls.Add(this.cmbCompetencias);
            this.Controls.Add(this.lblCompetencia);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.lblGrupo07);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblLPOOI);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.shapeContainer2);
            this.Name = "FrmCronometraje";
            this.Text = "FrmCronometraje";
            this.Load += new System.EventHandler(this.FrmCronometraje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtletas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rtgFooter;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rtgCabecera;
        private System.Windows.Forms.Label lblLPOOI;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblGrupo07;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblCompetencia;
        private System.Windows.Forms.ComboBox cmbCompetencias;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DataGridView dgvAtletas;
        private System.Windows.Forms.Label lblAtleta;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnDescalificado;
        private System.Windows.Forms.Button btnAbandono;
        private System.Windows.Forms.Button btnGuardar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape recFooter;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape recCabecera;
    }
}