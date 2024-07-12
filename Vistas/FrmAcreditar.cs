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
    public partial class FrmAcreditar : Form
    {
        public FrmAcreditar()
        {
            InitializeComponent();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (dgvAtleta.CurrentRow != null)
            {
                int id_evento = int.Parse(dgvAtleta.CurrentRow.Cells["IDEvento"].Value.ToString());
                Trabajar_Evento.modificarEstadoEvento(id_evento, "DESCALIFICADO");
                MessageBox.Show("Registro actualizado");

                if (rbtnOrdenadoporDNI.Checked == true)
                {
                    dgvAtleta.DataSource = TrabajarAtleta.Buscar_por_Dni(participante);
                }
                else if (rbtnOrdenadoporId.Checked == true)
                {
                    dgvAtleta.DataSource = TrabajarAtleta.Buscar_por_Id(participante);
                }
                else
                {
                    MessageBox.Show("Error ", "No seleccionó ninguna opción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error ", "No selecciono ninguna Atleta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                dgvAtleta.DataSource = TrabajarAtleta.Buscar_por_Id(participante);
            }
            else
            {
                MessageBox.Show("No seleccionó ninguna opción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmAcreditar_Load(object sender, EventArgs e)
        {

        }

    }
}
