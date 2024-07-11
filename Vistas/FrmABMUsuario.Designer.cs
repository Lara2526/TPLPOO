namespace Vistas
{
    partial class FrmABMUsuario
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombreusuario = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.txtapellidonombre = new System.Windows.Forms.TextBox();
            this.boxrol = new System.Windows.Forms.ComboBox();
            this.dgvusuario = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtbuscarNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscarNombre = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Chocolate;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Location = new System.Drawing.Point(76, 343);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 33);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(39, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(66, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(44, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido y Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(96, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rol";
            // 
            // txtnombreusuario
            // 
            this.txtnombreusuario.Location = new System.Drawing.Point(220, 174);
            this.txtnombreusuario.Name = "txtnombreusuario";
            this.txtnombreusuario.Size = new System.Drawing.Size(100, 20);
            this.txtnombreusuario.TabIndex = 5;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(220, 202);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(100, 20);
            this.txtcontraseña.TabIndex = 6;
            // 
            // txtapellidonombre
            // 
            this.txtapellidonombre.Location = new System.Drawing.Point(220, 230);
            this.txtapellidonombre.Name = "txtapellidonombre";
            this.txtapellidonombre.Size = new System.Drawing.Size(100, 20);
            this.txtapellidonombre.TabIndex = 7;
            // 
            // boxrol
            // 
            this.boxrol.FormattingEnabled = true;
            this.boxrol.Location = new System.Drawing.Point(220, 258);
            this.boxrol.Name = "boxrol";
            this.boxrol.Size = new System.Drawing.Size(100, 21);
            this.boxrol.TabIndex = 8;
            // 
            // dgvusuario
            // 
            this.dgvusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusuario.Location = new System.Drawing.Point(349, 139);
            this.dgvusuario.Name = "dgvusuario";
            this.dgvusuario.Size = new System.Drawing.Size(513, 217);
            this.dgvusuario.TabIndex = 9;
            this.dgvusuario.CurrentCellChanged += new System.EventHandler(this.dgvusuario_CurrentCellChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Chocolate;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminar.Location = new System.Drawing.Point(644, 485);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 33);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtbuscarNombre
            // 
            this.txtbuscarNombre.Location = new System.Drawing.Point(462, 93);
            this.txtbuscarNombre.Name = "txtbuscarNombre";
            this.txtbuscarNombre.Size = new System.Drawing.Size(305, 20);
            this.txtbuscarNombre.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Buscar por Apellido y Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "ID";
            this.label6.Visible = false;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(251, 153);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(13, 13);
            this.lbID.TabIndex = 14;
            this.lbID.Text = "0";
            this.lbID.Visible = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Chocolate;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificar.Location = new System.Drawing.Point(349, 485);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 33);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscarNombre
            // 
            this.btnBuscarNombre.BackColor = System.Drawing.Color.Chocolate;
            this.btnBuscarNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarNombre.Location = new System.Drawing.Point(775, 86);
            this.btnBuscarNombre.Name = "btnBuscarNombre";
            this.btnBuscarNombre.Size = new System.Drawing.Size(87, 33);
            this.btnBuscarNombre.TabIndex = 16;
            this.btnBuscarNombre.Text = "BUSCAR";
            this.btnBuscarNombre.UseVisualStyleBackColor = false;
            this.btnBuscarNombre.Click += new System.EventHandler(this.btnBuscarNombre_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Chocolate;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Location = new System.Drawing.Point(173, 343);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(87, 33);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label7.Location = new System.Drawing.Point(102, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 24);
            this.label7.TabIndex = 33;
            this.label7.Text = "Formulario - Usuario";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(346, 406);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(204, 13);
            this.label15.TabIndex = 69;
            this.label15.Text = "Seleccione al usuario en la base de datos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(641, 403);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 13);
            this.label8.TabIndex = 70;
            this.label8.Text = "Seleccione al usuario en la base de datos";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(641, 426);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(126, 13);
            this.label22.TabIndex = 87;
            this.label22.Text = "y clic en el boton Eliminar";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(641, 383);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 13);
            this.label20.TabIndex = 86;
            this.label20.Text = "Para  Eliminar";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(346, 428);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 13);
            this.label19.TabIndex = 84;
            this.label19.Text = "Paso 2";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(346, 386);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 13);
            this.label18.TabIndex = 83;
            this.label18.Text = "Para  Modificar";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(346, 459);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(132, 13);
            this.label16.TabIndex = 82;
            this.label16.Text = "y clic en el boton modificar";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(346, 446);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(275, 13);
            this.label17.TabIndex = 81;
            this.label17.Text = "Los dato se mostraran en campos, modifique el deseado ";
            // 
            // FrmABMUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Vistas.Properties.Resources.fondo1;
            this.ClientSize = new System.Drawing.Size(873, 562);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscarNombre);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbuscarNombre);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvusuario);
            this.Controls.Add(this.boxrol);
            this.Controls.Add(this.txtapellidonombre);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtnombreusuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Name = "FrmABMUsuario";
            this.Text = "ABMUsuario";
            this.Load += new System.EventHandler(this.ABMUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnombreusuario;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.TextBox txtapellidonombre;
        private System.Windows.Forms.ComboBox boxrol;
        private System.Windows.Forms.DataGridView dgvusuario;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtbuscarNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscarNombre;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}