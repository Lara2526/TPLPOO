namespace Vistas
{
    partial class FrmAnularInscripcion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnOrdenadoporId = new System.Windows.Forms.RadioButton();
            this.rbtnOrdenadoporDNI = new System.Windows.Forms.RadioButton();
            this.txtbuscarParticipante = new System.Windows.Forms.TextBox();
            this.btnBuscarNombre = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAnular = new System.Windows.Forms.Button();
            this.dgvAtleta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtleta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnOrdenadoporId);
            this.groupBox1.Controls.Add(this.rbtnOrdenadoporDNI);
            this.groupBox1.Controls.Add(this.txtbuscarParticipante);
            this.groupBox1.Controls.Add(this.btnBuscarNombre);
            this.groupBox1.Location = new System.Drawing.Point(10, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 70);
            this.groupBox1.TabIndex = 133;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por";
            // 
            // rbtnOrdenadoporId
            // 
            this.rbtnOrdenadoporId.AutoSize = true;
            this.rbtnOrdenadoporId.Location = new System.Drawing.Point(67, 36);
            this.rbtnOrdenadoporId.Name = "rbtnOrdenadoporId";
            this.rbtnOrdenadoporId.Size = new System.Drawing.Size(34, 17);
            this.rbtnOrdenadoporId.TabIndex = 81;
            this.rbtnOrdenadoporId.TabStop = true;
            this.rbtnOrdenadoporId.Text = "Id";
            this.rbtnOrdenadoporId.UseVisualStyleBackColor = true;
            // 
            // rbtnOrdenadoporDNI
            // 
            this.rbtnOrdenadoporDNI.AutoSize = true;
            this.rbtnOrdenadoporDNI.Location = new System.Drawing.Point(16, 36);
            this.rbtnOrdenadoporDNI.Name = "rbtnOrdenadoporDNI";
            this.rbtnOrdenadoporDNI.Size = new System.Drawing.Size(44, 17);
            this.rbtnOrdenadoporDNI.TabIndex = 80;
            this.rbtnOrdenadoporDNI.TabStop = true;
            this.rbtnOrdenadoporDNI.Text = "DNI";
            this.rbtnOrdenadoporDNI.UseVisualStyleBackColor = true;
            // 
            // txtbuscarParticipante
            // 
            this.txtbuscarParticipante.Location = new System.Drawing.Point(143, 36);
            this.txtbuscarParticipante.Name = "txtbuscarParticipante";
            this.txtbuscarParticipante.Size = new System.Drawing.Size(166, 20);
            this.txtbuscarParticipante.TabIndex = 112;
            // 
            // btnBuscarNombre
            // 
            this.btnBuscarNombre.BackColor = System.Drawing.Color.Chocolate;
            this.btnBuscarNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarNombre.Location = new System.Drawing.Point(325, 28);
            this.btnBuscarNombre.Name = "btnBuscarNombre";
            this.btnBuscarNombre.Size = new System.Drawing.Size(87, 33);
            this.btnBuscarNombre.TabIndex = 114;
            this.btnBuscarNombre.Text = "BUSCAR";
            this.btnBuscarNombre.UseVisualStyleBackColor = false;
            this.btnBuscarNombre.Click += new System.EventHandler(this.btnBuscarNombre_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(588, 307);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(126, 13);
            this.label22.TabIndex = 132;
            this.label22.Text = "y clic en el boton Eliminar";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(588, 274);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 13);
            this.label20.TabIndex = 131;
            this.label20.Text = "Para  Eliminar";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(588, 294);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(225, 13);
            this.label21.TabIndex = 130;
            this.label21.Text = "Seleccione al participante en la base de datos";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(588, 182);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 13);
            this.label19.TabIndex = 129;
            this.label19.Text = "Paso 2";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(588, 141);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 13);
            this.label18.TabIndex = 128;
            this.label18.Text = "Para  Modificar";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(588, 201);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(275, 13);
            this.label17.TabIndex = 127;
            this.label17.Text = "Los dato se mostraran en campos, modifique el deseado ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(588, 160);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(225, 13);
            this.label15.TabIndex = 126;
            this.label15.Text = "Seleccione al participante en la base de datos";
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.Color.Chocolate;
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAnular.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAnular.Location = new System.Drawing.Point(76, 393);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(87, 33);
            this.btnAnular.TabIndex = 125;
            this.btnAnular.Text = "ANULAR";
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // dgvAtleta
            // 
            this.dgvAtleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtleta.Location = new System.Drawing.Point(10, 141);
            this.dgvAtleta.Name = "dgvAtleta";
            this.dgvAtleta.Size = new System.Drawing.Size(514, 232);
            this.dgvAtleta.TabIndex = 124;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 123;
            this.label1.Text = "Anular Inscripcion ";
            // 
            // FrmAnularInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vistas.Properties.Resources.fondo1;
            this.ClientSize = new System.Drawing.Size(881, 457);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.dgvAtleta);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmAnularInscripcion";
            this.Text = "FrmAnularInscripcion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtleta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnOrdenadoporId;
        private System.Windows.Forms.RadioButton rbtnOrdenadoporDNI;
        private System.Windows.Forms.TextBox txtbuscarParticipante;
        private System.Windows.Forms.Button btnBuscarNombre;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.DataGridView dgvAtleta;
        private System.Windows.Forms.Label label1;
    }
}