namespace Vistas
{
    partial class FrmResultados
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
            this.dvgResultados = new System.Windows.Forms.DataGridView();
            this.txtCompetenciaID = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblParticipantes = new System.Windows.Forms.Label();
            this.lblAbandonos = new System.Windows.Forms.Label();
            this.lblDescalificados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgResultados
            // 
            this.dvgResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgResultados.Location = new System.Drawing.Point(12, 59);
            this.dvgResultados.Name = "dvgResultados";
            this.dvgResultados.Size = new System.Drawing.Size(607, 195);
            this.dvgResultados.TabIndex = 0;
            // 
            // txtCompetenciaID
            // 
            this.txtCompetenciaID.Location = new System.Drawing.Point(13, 33);
            this.txtCompetenciaID.Name = "txtCompetenciaID";
            this.txtCompetenciaID.Size = new System.Drawing.Size(308, 20);
            this.txtCompetenciaID.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(328, 30);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblParticipantes
            // 
            this.lblParticipantes.AutoSize = true;
            this.lblParticipantes.Location = new System.Drawing.Point(13, 279);
            this.lblParticipantes.Name = "lblParticipantes";
            this.lblParticipantes.Size = new System.Drawing.Size(71, 13);
            this.lblParticipantes.TabIndex = 3;
            this.lblParticipantes.Text = "Participantes:";
            // 
            // lblAbandonos
            // 
            this.lblAbandonos.AutoSize = true;
            this.lblAbandonos.Location = new System.Drawing.Point(13, 310);
            this.lblAbandonos.Name = "lblAbandonos";
            this.lblAbandonos.Size = new System.Drawing.Size(64, 13);
            this.lblAbandonos.TabIndex = 4;
            this.lblAbandonos.Text = "Abandonos:";
            // 
            // lblDescalificados
            // 
            this.lblDescalificados.AutoSize = true;
            this.lblDescalificados.Location = new System.Drawing.Point(13, 338);
            this.lblDescalificados.Name = "lblDescalificados";
            this.lblDescalificados.Size = new System.Drawing.Size(79, 13);
            this.lblDescalificados.TabIndex = 5;
            this.lblDescalificados.Text = "Descalificados:";
            // 
            // FrmResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 360);
            this.Controls.Add(this.lblDescalificados);
            this.Controls.Add(this.lblAbandonos);
            this.Controls.Add(this.lblParticipantes);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCompetenciaID);
            this.Controls.Add(this.dvgResultados);
            this.Name = "FrmResultados";
            this.Text = "FrmResultados";
            ((System.ComponentModel.ISupportInitialize)(this.dvgResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgResultados;
        private System.Windows.Forms.TextBox txtCompetenciaID;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblParticipantes;
        private System.Windows.Forms.Label lblAbandonos;
        private System.Windows.Forms.Label lblDescalificados;
    }
}