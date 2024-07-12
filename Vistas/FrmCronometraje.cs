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
    public partial class FrmCronometraje : Form
    {
        public FrmCronometraje()
        {
            InitializeComponent();
        }

        private int competenciaSeleccionada;

        private void FrmCronometraje_Load(object sender, EventArgs e)
        {
            btnModificar.Visible = false;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = false;
            btnAbandono.Enabled = false;
            btnDescalificado.Enabled = false;
            dgvAtletas.Visible = false;
            cargarComboCompetencias();
            dtpInicio.Value = DateTime.Now;
            dtpInicio.Focus();
        }

        private void cargarComboCompetencias()
        {
            cmbCompetencias.DisplayMember = "Descripcion";
            cmbCompetencias.ValueMember = "ID";
            cmbCompetencias.DataSource = TrabajarCompetencias.listarCompetencias();
        }

        private void cargar_tabla()
        {
            if (competenciaSeleccionada <= 0)
            {
                dgvAtletas.Controls.Clear();
                dgvAtletas.Columns.Clear();
                dgvAtletas.Rows.Clear();
            }
            else
            {
                dgvAtletas.DataSource = cargarEventos(competenciaSeleccionada, "Acreditado");

                DataGridViewCellStyle estilo = new DataGridViewCellStyle();
                estilo.Format = "HH:mm";

                dgvAtletas.Columns["HoraFin"].ReadOnly = false;
                dgvAtletas.Columns["HoraFin"].CellTemplate.Style = estilo;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            competenciaSeleccionada = (int)cmbCompetencias.SelectedValue;

            if (competenciaSeleccionada > 0)
            {
                DataTable dt = cargarEventos(competenciaSeleccionada, "Acreditado");

                foreach (DataRow row in dt.Rows)
                {
                    Evento eventoRow = new Evento();
                    // Leer los datos de cada columna de la fila
                    int idEvento = (int)row["IDEvento"];
                    var idAtleta = (int)row["IDAtleta"];
                    var estado   = (string)row["Estado"];

                    if (idEvento > 0)
                    {
                        eventoRow.Eve_ID = idEvento;
                        eventoRow.Atl_ID = idAtleta;
                        eventoRow.Com_ID = (int)cmbCompetencias.SelectedValue;
                        eventoRow.Eve_HoraInicio = dtpInicio.Value;
                        eventoRow.Eve_HoraFin = dtpInicio.Value;
                        eventoRow.Eve_Estado = estado.ToString();

                        Trabajar_Evento.modificarEvento(eventoRow);
                    }
                }

                cargar_tabla();

                dtpInicio.Enabled = false;
                btnGrabar.Visible = false;
                btnGrabar.Enabled = false;
                btnModificar.Visible = true;
                btnModificar.Enabled = true;
                btnGuardar.Enabled = true;
                btnAbandono.Enabled = true;
                btnDescalificado.Enabled = true;
                cmbCompetencias.Enabled = false;
                dgvAtletas.Visible = true;
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una competencia.");
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            dtpInicio.Enabled = true;
            btnGrabar.Enabled = true;
            btnGrabar.Visible = true;
            btnModificar.Visible = false;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = false;
            btnAbandono.Enabled = false;
            btnDescalificado.Enabled = false;
            dgvAtletas.Visible = false;
            dtpInicio.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {            
            foreach (DataGridViewRow row in dgvAtletas.Rows)
            {
                // Verificar que la fila no sea la fila de nueva entrada
                if (!row.IsNewRow)
                {
                    // Leer los datos de cada columna de la fila
                    int idEvento = (int)row.Cells["IDEvento"].Value;
                    DateTime horafin = (DateTime)row.Cells["HoraFin"].Value;

                    if (idEvento.ToString().Length > 0)
                    {
                        Trabajar_Evento.modificarEstadoEvento(idEvento, "FINALIZADO");
                        Trabajar_Evento.modificarHoraFinEvento(idEvento, horafin);

                        MessageBox.Show("Datos guardados.");
                        cargar_tabla();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, selecciona una fila válida.");
                    }
                }
            }
        }

        private int selectedRowIndex = -1;

        private void dgvAtletas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegúrate de que el índice de la fila es válido
            {
                selectedRowIndex = e.RowIndex;
            }
        }

        private void btnDescalificado_Click(object sender, EventArgs e)
        {
            if (dgvAtletas.CurrentRow != null)
            {
                int id_evento = int.Parse(dgvAtletas.CurrentRow.Cells["IDEvento"].Value.ToString());
                Trabajar_Evento.modificarEstadoEvento(id_evento, "DESCALIFICADO");
                MessageBox.Show("Registro actualizado");
                cargar_tabla();
            }
            else
            {
                MessageBox.Show("Error ", "No selecciono ninguna Atleta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAbandono_Click(object sender, EventArgs e)
        {
            if (dgvAtletas.CurrentRow != null)
            {
                int id_evento = int.Parse(dgvAtletas.CurrentRow.Cells["IDEvento"].Value.ToString());
                Trabajar_Evento.modificarEstadoEvento(id_evento, "ABANDONO");
                MessageBox.Show("Registro actualizado");
                cargar_tabla();
            }
            else
            {
                MessageBox.Show("Error ", "No seleccionó ningún Atleta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable cargarEventos(int idCompetencia ,string estado)
        {
            return Trabajar_Evento.buscar_atletas(idCompetencia, estado);
        }

    }

}
