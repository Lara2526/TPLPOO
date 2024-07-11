namespace Vistas
{
    partial class FrmABMDisciplina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmABMDisciplina));
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbid = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvDisciplina = new System.Windows.Forms.DataGridView();
            this.lblGrupo07 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblLPOOI = new System.Windows.Forms.Label();
            this.recCabecera = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.recFooter = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lblModificar1 = new System.Windows.Forms.Label();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.lblEliminar1 = new System.Windows.Forms.Label();
            this.lblModificar = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(111, 167);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(145, 20);
            this.txtDescripcion.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Descripción:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(111, 128);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(145, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre:";
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbid.Location = new System.Drawing.Point(218, 27);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(18, 13);
            this.lbid.TabIndex = 24;
            this.lbid.Text = "id ";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Location = new System.Drawing.Point(72, 224);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(91, 32);
            this.btnLimpiar.TabIndex = 66;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Location = new System.Drawing.Point(164, 224);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(91, 32);
            this.btnAgregar.TabIndex = 65;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificar.Location = new System.Drawing.Point(72, 262);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(91, 32);
            this.btnModificar.TabIndex = 93;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminar.Location = new System.Drawing.Point(164, 262);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(91, 32);
            this.btnEliminar.TabIndex = 92;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvDisciplina
            // 
            this.dgvDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisciplina.Location = new System.Drawing.Point(318, 76);
            this.dgvDisciplina.Name = "dgvDisciplina";
            this.dgvDisciplina.Size = new System.Drawing.Size(528, 254);
            this.dgvDisciplina.TabIndex = 91;
            this.dgvDisciplina.CurrentCellChanged += new System.EventHandler(this.dgvDisciplina_CurrentCellChanged);
            // 
            // lblGrupo07
            // 
            this.lblGrupo07.AutoSize = true;
            this.lblGrupo07.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblGrupo07.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo07.ForeColor = System.Drawing.Color.White;
            this.lblGrupo07.Location = new System.Drawing.Point(823, 440);
            this.lblGrupo07.Name = "lblGrupo07";
            this.lblGrupo07.Size = new System.Drawing.Size(59, 13);
            this.lblGrupo07.TabIndex = 104;
            this.lblGrupo07.Text = "Grupo 07";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(330, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(225, 37);
            this.lblTitulo.TabIndex = 103;
            this.lblTitulo.Text = "DISCIPLINAS";
            // 
            // lblLPOOI
            // 
            this.lblLPOOI.AutoSize = true;
            this.lblLPOOI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblLPOOI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLPOOI.ForeColor = System.Drawing.Color.White;
            this.lblLPOOI.Location = new System.Drawing.Point(3, 438);
            this.lblLPOOI.Name = "lblLPOOI";
            this.lblLPOOI.Size = new System.Drawing.Size(380, 15);
            this.lblLPOOI.TabIndex = 102;
            this.lblLPOOI.Text = "Laboratorio de Programación Orientada a Objetos I - 2024";
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
            this.shapeContainer1.TabIndex = 105;
            this.shapeContainer1.TabStop = false;
            // 
            // lblModificar1
            // 
            this.lblModificar1.BackColor = System.Drawing.Color.Transparent;
            this.lblModificar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblModificar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblModificar1.Location = new System.Drawing.Point(315, 381);
            this.lblModificar1.Name = "lblModificar1";
            this.lblModificar1.Size = new System.Drawing.Size(257, 40);
            this.lblModificar1.TabIndex = 119;
            this.lblModificar1.Text = "Seleccione al participante, editelo y presione MODIFICAR.";
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.BackColor = System.Drawing.Color.Transparent;
            this.lblEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblEliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEliminar.Location = new System.Drawing.Point(769, 365);
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
            this.lblEliminar1.Location = new System.Drawing.Point(611, 381);
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
            this.lblModificar.Location = new System.Drawing.Point(315, 365);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(98, 16);
            this.lblModificar.TabIndex = 116;
            this.lblModificar.Text = "Para  Modificar";
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imgLogo.Location = new System.Drawing.Point(20, 2);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(36, 47);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 120;
            this.imgLogo.TabStop = false;
            // 
            // FrmABMDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Vistas.Properties.Resources.fondo1;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.lblEliminar);
            this.Controls.Add(this.lblEliminar1);
            this.Controls.Add(this.lblModificar);
            this.Controls.Add(this.lblGrupo07);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblLPOOI);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvDisciplina);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblModificar1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "FrmABMDisciplina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAltaDisciplina";
            this.Load += new System.EventHandler(this.FrmABMDisciplina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvDisciplina;
        private System.Windows.Forms.Label lblGrupo07;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblLPOOI;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape recCabecera;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape recFooter;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label lblModificar1;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.Label lblEliminar1;
        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.PictureBox imgLogo;
    }
}