using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class FrmAcreditaciones : Form
    {
        public FrmAcreditaciones()
        {
            InitializeComponent();
        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            string participante = txtbuscarParticipante.Text;

            if (rbtnOrdenadoporDNI.Checked == true)
            {
                dgvAtleta.DataSource = TrabajarAtleta.Buscar_por_Dni(participante);
            }
            else if (rbtnOrdenadoporId.Checked == true)
            {
                dgvAtleta.DataSource = TrabajarAtleta.Buscar_por_Id(Convert.ToInt32(participante));
            }
            else
            {
                MessageBox.Show("No seleccionó ninguna opción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAcreditar_Click(object sender, EventArgs e)
        {
            if (dgvAtleta.CurrentRow != null)
            {
                if (dgvAtleta.CurrentRow.Cells["Estado"].Value.ToString() != "Acreditado")
                {
                    int ID = int.Parse(dgvAtleta.CurrentRow.Cells["ID Evento"].Value.ToString());
                    TrabajarAtleta.AcreditarInscripcion(ID);
                    MessageBox.Show("Inscripcion Acreditada");
                    string participante = txtbuscarParticipante.Text;

                    if (rbtnOrdenadoporDNI.Checked == true)
                    {
                        dgvAtleta.DataSource = TrabajarAtleta.Buscar_por_Dni(participante);
                    }
                    else if (rbtnOrdenadoporId.Checked == true)
                    {
                        dgvAtleta.DataSource = TrabajarAtleta.Buscar_por_Id(Convert.ToInt32(participante));
                    }
                    else
                    {
                        MessageBox.Show("Error ", "No selecciono ninguna opcion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else { MessageBox.Show("Esta Inscripcion se encuentra Acreditada ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }

            else
            {
                MessageBox.Show("Error ", "No selecciono ninguna Atleta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
