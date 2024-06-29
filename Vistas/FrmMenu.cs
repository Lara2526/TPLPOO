using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmMenu : Form
    {
        
        public FrmMenu(int Rol)
        {
            InitializeComponent();
            switch (Rol)
            {
                case 1:
                    usuarioMenuItem.Enabled = true;
                    competenciasMenuItem.Enabled = false;
                    participantesMenuItem.Enabled = false;
                    eventosMenuItem.Enabled = false;
                    disciplinaMenuItem.Enabled = false;
                    categoriaMenuItem.Enabled = false;

                    break;
                case 2:
                    usuarioMenuItem.Enabled = false;
                    competenciasMenuItem.Enabled = true;
                    participantesMenuItem.Enabled = true;
                    eventosMenuItem.Enabled = false;
                    disciplinaMenuItem.Enabled = false;
                    categoriaMenuItem.Enabled = false;
                    break;
                case 3:
                    usuarioMenuItem.Enabled = true;
                    competenciasMenuItem.Enabled = true;
                    participantesMenuItem.Enabled = true;
                    eventosMenuItem.Enabled = true;
                    disciplinaMenuItem.Enabled = true;
                    categoriaMenuItem.Enabled = true;
                    break;

            }

        }

        

        private void abmUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmABMUsuario ofrmUsu = new FrmABMUsuario();
            ofrmUsu.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

           
        }

        private void ABMParticipanteMenuItem_Click(object sender, EventArgs e)
        {
            FrmABMParticipantes ofrmAtl = new FrmABMParticipantes();
            ofrmAtl.Show();
        }

        private void crearDisciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmABMDisciplina ofrmdis = new FrmABMDisciplina();
            ofrmdis.Show();
        }

        private void crearNuevaCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmABMCategoria ofrmCategoria = new FrmABMCategoria();
            ofrmCategoria.Show();
        }

        private void aBMCompetenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmABMCompetencias ofrmCompetencias = new FrmABMCompetencias();
            ofrmCompetencias.Show();
        }
    }
}
