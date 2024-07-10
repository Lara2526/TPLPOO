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
            this.cmbCompetencia = new System.Windows.Forms.ComboBox();
            this.cmbParticipante = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.no = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvEvento = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvento)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCompetencia
            // 
            this.cmbCompetencia.FormattingEnabled = true;
            this.cmbCompetencia.Location = new System.Drawing.Point(169, 187);
            this.cmbCompetencia.Name = "cmbCompetencia";
            this.cmbCompetencia.Size = new System.Drawing.Size(162, 21);
            this.cmbCompetencia.TabIndex = 110;
            // 
            // cmbParticipante
            // 
            this.cmbParticipante.FormattingEnabled = true;
            this.cmbParticipante.Location = new System.Drawing.Point(169, 151);
            this.cmbParticipante.Name = "cmbParticipante";
            this.cmbParticipante.Size = new System.Drawing.Size(162, 21);
            this.cmbParticipante.TabIndex = 109;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Chocolate;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Location = new System.Drawing.Point(90, 269);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 33);
            this.btnAgregar.TabIndex = 108;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.no.Location = new System.Drawing.Point(87, 132);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(18, 13);
            this.no.TabIndex = 107;
            this.no.Text = "id ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 106;
            this.label3.Text = "Competencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 105;
            this.label2.Text = "Participante";
            // 
            // dgvEvento
            // 
            this.dgvEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvento.Location = new System.Drawing.Point(400, 116);
            this.dgvEvento.Name = "dgvEvento";
            this.dgvEvento.Size = new System.Drawing.Size(357, 126);
            this.dgvEvento.TabIndex = 111;
            // 
            // FrmInscripcionEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 404);
            this.Controls.Add(this.dgvEvento);
            this.Controls.Add(this.cmbCompetencia);
            this.Controls.Add(this.cmbParticipante);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.no);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FrmInscripcionEvento";
            this.Text = "FrmInscripcionEvento";
            this.Load += new System.EventHandler(this.FrmInscripcionEvento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvento)).EndInit();
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
    }
}