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
    public partial class FrmAnularInscripcion : Form
    {
        public FrmAnularInscripcion()
        {
            InitializeComponent();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (dgvAtleta.CurrentRow != null)
            {
                if (dgvAtleta.CurrentRow.Cells["Estado"].Value.ToString() != "Anulado")
                {
                    int ID = int.Parse(dgvAtleta.CurrentRow.Cells["ID Evento"].Value.ToString());
                    TrabajarAtleta.AnularInscripcion(ID);
                    MessageBox.Show("Inscripción Anulada");
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
                        MessageBox.Show("Error ", "No seleccionó ninguna opción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else { MessageBox.Show("Esta inscripción se encuentra Anulada ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }

            else
            {
                MessageBox.Show("Error ", "No seleccionó ningún Atleta", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void FrmAnularInscripcion_Load(object sender, EventArgs e)
        {

        }
    }
}
