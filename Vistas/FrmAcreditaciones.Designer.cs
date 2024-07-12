namespace Vistas
{
    partial class FrmAcreditaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAcreditaciones));
            this.recCabecera = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnOrdenadoporId = new System.Windows.Forms.RadioButton();
            this.rbtnOrdenadoporDNI = new System.Windows.Forms.RadioButton();
            this.txtbuscarParticipante = new System.Windows.Forms.TextBox();
            this.btnBuscarNombre = new System.Windows.Forms.Button();
            this.btnAcreditar = new System.Windows.Forms.Button();
            this.dgvAtleta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtleta)).BeginInit();
            this.SuspendLayout();
            // 
            // recCabecera
            // 
            this.recCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.recCabecera.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.recCabecera.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.recCabecera.Location = new System.Drawing.Point(-1, -1);
            this.recCabecera.Name = "recCabecera";
            this.recCabecera.Size = new System.Drawing.Size(885, 50);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.recCabecera});
            this.shapeContainer1.Size = new System.Drawing.Size(884, 461);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(21, 3);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(36, 47);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 139;
            this.imgLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(251, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(459, 37);
            this.lblTitulo.TabIndex = 140;
            this.lblTitulo.Text = "ACREDITARS INSCRIPCIÓN";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbtnOrdenadoporId);
            this.groupBox1.Controls.Add(this.rbtnOrdenadoporDNI);
            this.groupBox1.Controls.Add(this.txtbuscarParticipante);
            this.groupBox1.Controls.Add(this.btnBuscarNombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(270, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 70);
            this.groupBox1.TabIndex = 141;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por";
            // 
            // rbtnOrdenadoporId
            // 
            this.rbtnOrdenadoporId.AutoSize = true;
            this.rbtnOrdenadoporId.Location = new System.Drawing.Point(67, 36);
            this.rbtnOrdenadoporId.Name = "rbtnOrdenadoporId";
            this.rbtnOrdenadoporId.Size = new System.Drawing.Size(39, 20);
            this.rbtnOrdenadoporId.TabIndex = 81;
            this.rbtnOrdenadoporId.TabStop = true;
            this.rbtnOrdenadoporId.Text = "ID";
            this.rbtnOrdenadoporId.UseVisualStyleBackColor = true;
            // 
            // rbtnOrdenadoporDNI
            // 
            this.rbtnOrdenadoporDNI.AutoSize = true;
            this.rbtnOrdenadoporDNI.Location = new System.Drawing.Point(16, 36);
            this.rbtnOrdenadoporDNI.Name = "rbtnOrdenadoporDNI";
            this.rbtnOrdenadoporDNI.Size = new System.Drawing.Size(49, 20);
            this.rbtnOrdenadoporDNI.TabIndex = 80;
            this.rbtnOrdenadoporDNI.TabStop = true;
            this.rbtnOrdenadoporDNI.Text = "DNI";
            this.rbtnOrdenadoporDNI.UseVisualStyleBackColor = true;
            // 
            // txtbuscarParticipante
            // 
            this.txtbuscarParticipante.Location = new System.Drawing.Point(122, 33);
            this.txtbuscarParticipante.Name = "txtbuscarParticipante";
            this.txtbuscarParticipante.Size = new System.Drawing.Size(166, 22);
            this.txtbuscarParticipante.TabIndex = 112;
            // 
            // btnBuscarNombre
            // 
            this.btnBuscarNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBuscarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarNombre.ForeColor = System.Drawing.Color.White;
            this.btnBuscarNombre.Location = new System.Drawing.Point(304, 26);
            this.btnBuscarNombre.Name = "btnBuscarNombre";
            this.btnBuscarNombre.Size = new System.Drawing.Size(91, 32);
            this.btnBuscarNombre.TabIndex = 114;
            this.btnBuscarNombre.Text = "Buscar";
            this.btnBuscarNombre.UseVisualStyleBackColor = false;
            this.btnBuscarNombre.Click += new System.EventHandler(this.btnBuscarNombre_Click);
            // 
            // btnAcreditar
            // 
            this.btnAcreditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAcreditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcreditar.ForeColor = System.Drawing.Color.White;
            this.btnAcreditar.Location = new System.Drawing.Point(739, 175);
            this.btnAcreditar.Name = "btnAcreditar";
            this.btnAcreditar.Size = new System.Drawing.Size(91, 32);
            this.btnAcreditar.TabIndex = 142;
            this.btnAcreditar.Text = "Acreditar";
            this.btnAcreditar.UseVisualStyleBackColor = false;
            this.btnAcreditar.Click += new System.EventHandler(this.btnAcreditar_Click);
            // 
            // dgvAtleta
            // 
            this.dgvAtleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtleta.Location = new System.Drawing.Point(208, 175);
            this.dgvAtleta.Name = "dgvAtleta";
            this.dgvAtleta.Size = new System.Drawing.Size(514, 232);
            this.dgvAtleta.TabIndex = 143;
            // 
            // FrmAcreditaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vistas.Properties.Resources.fondo1;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.dgvAtleta);
            this.Controls.Add(this.btnAcreditar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "FrmAcreditaciones";
            this.Text = "FrmAcreditaciones";
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtleta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.RectangleShape recCabecera;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnOrdenadoporId;
        private System.Windows.Forms.RadioButton rbtnOrdenadoporDNI;
        private System.Windows.Forms.TextBox txtbuscarParticipante;
        private System.Windows.Forms.Button btnBuscarNombre;
        private System.Windows.Forms.Button btnAcreditar;
        private System.Windows.Forms.DataGridView dgvAtleta;
    }
}