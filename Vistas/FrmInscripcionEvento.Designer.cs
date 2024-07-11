namespace Vistas
{
    partial class FrmInscripcionEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInscripcionEvento));
            this.cmbCompetencia = new System.Windows.Forms.ComboBox();
            this.cmbParticipante = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.no = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvEvento = new System.Windows.Forms.DataGridView();
            this.recCabecera = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.recFooter = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lblGrupo07 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblLPOOI = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCompetencia
            // 
            this.cmbCompetencia.FormattingEnabled = true;
            this.cmbCompetencia.Location = new System.Drawing.Point(460, 85);
            this.cmbCompetencia.Name = "cmbCompetencia";
            this.cmbCompetencia.Size = new System.Drawing.Size(162, 21);
            this.cmbCompetencia.TabIndex = 110;
            // 
            // cmbParticipante
            // 
            this.cmbParticipante.FormattingEnabled = true;
            this.cmbParticipante.Location = new System.Drawing.Point(137, 85);
            this.cmbParticipante.Name = "cmbParticipante";
            this.cmbParticipante.Size = new System.Drawing.Size(162, 21);
            this.cmbParticipante.TabIndex = 109;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(666, 85);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(91, 32);
            this.btnAgregar.TabIndex = 108;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.no.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.no.Location = new System.Drawing.Point(183, 27);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(18, 13);
            this.no.TabIndex = 107;
            this.no.Text = "id ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(351, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 106;
            this.label3.Text = "Competencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 105;
            this.label2.Text = "Participante";
            // 
            // dgvEvento
            // 
            this.dgvEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvento.Location = new System.Drawing.Point(42, 137);
            this.dgvEvento.Name = "dgvEvento";
            this.dgvEvento.Size = new System.Drawing.Size(818, 280);
            this.dgvEvento.TabIndex = 111;
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
            this.shapeContainer1.TabIndex = 112;
            this.shapeContainer1.TabStop = false;
            // 
            // lblGrupo07
            // 
            this.lblGrupo07.AutoSize = true;
            this.lblGrupo07.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblGrupo07.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo07.ForeColor = System.Drawing.Color.White;
            this.lblGrupo07.Location = new System.Drawing.Point(823, 443);
            this.lblGrupo07.Name = "lblGrupo07";
            this.lblGrupo07.Size = new System.Drawing.Size(59, 13);
            this.lblGrupo07.TabIndex = 115;
            this.lblGrupo07.Text = "Grupo 07";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(327, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(235, 37);
            this.lblTitulo.TabIndex = 114;
            this.lblTitulo.Text = "INSCRIPCIÓN";
            // 
            // lblLPOOI
            // 
            this.lblLPOOI.AutoSize = true;
            this.lblLPOOI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblLPOOI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLPOOI.ForeColor = System.Drawing.Color.White;
            this.lblLPOOI.Location = new System.Drawing.Point(3, 441);
            this.lblLPOOI.Name = "lblLPOOI";
            this.lblLPOOI.Size = new System.Drawing.Size(380, 15);
            this.lblLPOOI.TabIndex = 113;
            this.lblLPOOI.Text = "Laboratorio de Programación Orientada a Objetos I - 2024";
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
            this.imgLogo.TabIndex = 116;
            this.imgLogo.TabStop = false;
            // 
            // FrmInscripcionEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vistas.Properties.Resources.fondo1;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.lblGrupo07);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblLPOOI);
            this.Controls.Add(this.dgvEvento);
            this.Controls.Add(this.cmbCompetencia);
            this.Controls.Add(this.cmbParticipante);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.no);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "FrmInscripcionEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInscripcionEvento";
            this.Load += new System.EventHandler(this.FrmInscripcionEvento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCompetencia;
        private System.Windows.Forms.ComboBox cmbParticipante;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label no;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvEvento;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape recCabecera;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape recFooter;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label lblGrupo07;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblLPOOI;
        private System.Windows.Forms.PictureBox imgLogo;
    }
}