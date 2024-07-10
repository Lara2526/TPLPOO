namespace Vistas
{
    partial class FrmABMResultados
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
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.txtCompetenciaID = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblParticipantes = new System.Windows.Forms.Label();
            this.lblAbandonos = new System.Windows.Forms.Label();
            this.lblDescalificados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResultados
            // 
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(12, 81);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.Size = new System.Drawing.Size(745, 250);
            this.dgvResultados.TabIndex = 0;
            // 
            // txtCompetenciaID
            // 
            this.txtCompetenciaID.Location = new System.Drawing.Point(12, 33);
            this.txtCompetenciaID.Name = "txtCompetenciaID";
            this.txtCompetenciaID.Size = new System.Drawing.Size(283, 20);
            this.txtCompetenciaID.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(301, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(133, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblParticipantes
            // 
            this.lblParticipantes.AutoSize = true;
            this.lblParticipantes.Location = new System.Drawing.Point(9, 357);
            this.lblParticipantes.Name = "lblParticipantes";
            this.lblParticipantes.Size = new System.Drawing.Size(71, 13);
            this.lblParticipantes.TabIndex = 3;
            this.lblParticipantes.Text = "Participantes:";
            // 
            // lblAbandonos
            // 
            this.lblAbandonos.AutoSize = true;
            this.lblAbandonos.Location = new System.Drawing.Point(9, 387);
            this.lblAbandonos.Name = "lblAbandonos";
            this.lblAbandonos.Size = new System.Drawing.Size(64, 13);
            this.lblAbandonos.TabIndex = 4;
            this.lblAbandonos.Text = "Abandonos:";
            // 
            // lblDescalificados
            // 
            this.lblDescalificados.AutoSize = true;
            this.lblDescalificados.Location = new System.Drawing.Point(9, 417);
            this.lblDescalificados.Name = "lblDescalificados";
            this.lblDescalificados.Size = new System.Drawing.Size(79, 13);
            this.lblDescalificados.TabIndex = 5;
            this.lblDescalificados.Text = "Descalificados:";
            // 
            // FrmABMResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDescalificados);
            this.Controls.Add(this.lblAbandonos);
            this.Controls.Add(this.lblParticipantes);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCompetenciaID);
            this.Controls.Add(this.dgvResultados);
            this.Name = "FrmABMResultados";
            this.Text = "FrmABMResultados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.TextBox txtCompetenciaID;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblParticipantes;
        private System.Windows.Forms.Label lblAbandonos;
        private System.Windows.Forms.Label lblDescalificados;
    }
}