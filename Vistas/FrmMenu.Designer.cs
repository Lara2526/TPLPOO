namespace Vistas
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.competenciasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMCompetenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.participantesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ABMParticipanteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearDisciplinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearNuevaCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abmUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cronometrajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.DarkOrange;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.competenciasMenuItem,
            this.participantesMenuItem,
            this.eventosMenuItem,
            this.disciplinaMenuItem,
            this.categoriaMenuItem,
            this.usuarioMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(570, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem1.Text = "Sistema";
            // 
            // competenciasMenuItem
            // 
            this.competenciasMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMCompetenciasToolStripMenuItem});
            this.competenciasMenuItem.Name = "competenciasMenuItem";
            this.competenciasMenuItem.Size = new System.Drawing.Size(95, 20);
            this.competenciasMenuItem.Text = "Competencias";
            // 
            // aBMCompetenciasToolStripMenuItem
            // 
            this.aBMCompetenciasToolStripMenuItem.Name = "aBMCompetenciasToolStripMenuItem";
            this.aBMCompetenciasToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.aBMCompetenciasToolStripMenuItem.Text = "ABM Competencias";
            this.aBMCompetenciasToolStripMenuItem.Click += new System.EventHandler(this.aBMCompetenciasToolStripMenuItem_Click);
            // 
            // participantesMenuItem
            // 
            this.participantesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ABMParticipanteMenuItem});
            this.participantesMenuItem.Name = "participantesMenuItem";
            this.participantesMenuItem.Size = new System.Drawing.Size(87, 20);
            this.participantesMenuItem.Text = "Participantes";
            // 
            // ABMParticipanteMenuItem
            // 
            this.ABMParticipanteMenuItem.Name = "ABMParticipanteMenuItem";
            this.ABMParticipanteMenuItem.Size = new System.Drawing.Size(168, 22);
            this.ABMParticipanteMenuItem.Text = "ABMParticipantes";
            this.ABMParticipanteMenuItem.Click += new System.EventHandler(this.ABMParticipanteMenuItem_Click);
            // 
            // eventosMenuItem
            // 
            this.eventosMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cronometrajeToolStripMenuItem});
            this.eventosMenuItem.Name = "eventosMenuItem";
            this.eventosMenuItem.Size = new System.Drawing.Size(60, 20);
            this.eventosMenuItem.Text = "Eventos";
            // 
            // disciplinaMenuItem
            // 
            this.disciplinaMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearDisciplinaToolStripMenuItem});
            this.disciplinaMenuItem.Name = "disciplinaMenuItem";
            this.disciplinaMenuItem.Size = new System.Drawing.Size(70, 20);
            this.disciplinaMenuItem.Text = "Disciplina";
            // 
            // crearDisciplinaToolStripMenuItem
            // 
            this.crearDisciplinaToolStripMenuItem.Name = "crearDisciplinaToolStripMenuItem";
            this.crearDisciplinaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.crearDisciplinaToolStripMenuItem.Text = "Crear Disciplina";
            this.crearDisciplinaToolStripMenuItem.Click += new System.EventHandler(this.crearDisciplinaToolStripMenuItem_Click);
            // 
            // categoriaMenuItem
            // 
            this.categoriaMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearNuevaCategoriaToolStripMenuItem});
            this.categoriaMenuItem.Name = "categoriaMenuItem";
            this.categoriaMenuItem.Size = new System.Drawing.Size(70, 20);
            this.categoriaMenuItem.Text = "Categoria";
            // 
            // crearNuevaCategoriaToolStripMenuItem
            // 
            this.crearNuevaCategoriaToolStripMenuItem.Name = "crearNuevaCategoriaToolStripMenuItem";
            this.crearNuevaCategoriaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.crearNuevaCategoriaToolStripMenuItem.Text = "Crear nueva Categoria";
            this.crearNuevaCategoriaToolStripMenuItem.Click += new System.EventHandler(this.crearNuevaCategoriaToolStripMenuItem_Click);
            // 
            // usuarioMenuItem
            // 
            this.usuarioMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abmUsuarioToolStripMenuItem});
            this.usuarioMenuItem.Name = "usuarioMenuItem";
            this.usuarioMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioMenuItem.Text = "Usuario";
            // 
            // abmUsuarioToolStripMenuItem
            // 
            this.abmUsuarioToolStripMenuItem.Name = "abmUsuarioToolStripMenuItem";
            this.abmUsuarioToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.abmUsuarioToolStripMenuItem.Text = "abmUsuario";
            this.abmUsuarioToolStripMenuItem.Click += new System.EventHandler(this.abmUsuarioToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(96, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 317);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // cronometrajeToolStripMenuItem
            // 
            this.cronometrajeToolStripMenuItem.Name = "cronometrajeToolStripMenuItem";
            this.cronometrajeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cronometrajeToolStripMenuItem.Text = "Cronometraje";
            this.cronometrajeToolStripMenuItem.Click += new System.EventHandler(this.cronometrajeToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(570, 347);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem competenciasMenuItem;
        private System.Windows.Forms.ToolStripMenuItem participantesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ABMParticipanteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disciplinaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearDisciplinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearNuevaCategoriaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem usuarioMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abmUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMCompetenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cronometrajeToolStripMenuItem;
    }
}