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
                    Evento eventoRow = new Evento();
                    // Leer los datos de cada columna de la fila
                    var idEvento = row.Cells["IDEvento"].Value;
                    var idAtleta = row.Cells["IDAtleta"].Value;
                    var estado = row.Cells["Estado"].Value;
                    var horafin = row.Cells["HoraFin"].Value;

                    if (idEvento.ToString().Length > 0)
                    {
                        eventoRow.Eve_ID = (int)idEvento;
                        eventoRow.Atl_ID = (int)idAtleta;
                        eventoRow.Com_ID = (int)cmbCompetencias.SelectedValue;
                        eventoRow.Eve_HoraInicio = dtpInicio.Value;
                        eventoRow.Eve_HoraFin = (DateTime)horafin;
                        eventoRow.Eve_Estado = "Finalizado";

                        Trabajar_Evento.modificarEvento(eventoRow);

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
            if (selectedRowIndex >= 0 && selectedRowIndex < dgvAtletas.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvAtletas.Rows[selectedRowIndex];

                Evento eventoDescalificado = new Evento();
                var idEvento = selectedRow.Cells["IDEvento"].Value;
                var idAtleta = selectedRow.Cells["IDAtleta"].Value;
                var horafin = selectedRow.Cells["Horafin"].Value;

                if (idEvento.ToString().Length > 0)
                {
                    eventoDescalificado.Eve_ID = (int)idEvento;
                    eventoDescalificado.Atl_ID = (int)idAtleta;
                    eventoDescalificado.Com_ID = (int)cmbCompetencias.SelectedValue;
                    eventoDescalificado.Eve_HoraInicio = dtpInicio.Value;
                    eventoDescalificado.Eve_HoraFin = (DateTime)horafin;
                    eventoDescalificado.Eve_Estado  = "Descalificado";

                    Trabajar_Evento.modificarEvento(eventoDescalificado);
                }
                else
                {
                    MessageBox.Show("La fila seleccionada no tiene datos .Por favor, selecciona una fila válida.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila válida.");
            }
        }

        private void btnAbandono_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0 && selectedRowIndex < dgvAtletas.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvAtletas.Rows[selectedRowIndex];

                Evento eventoAbandonado = new Evento();
                // Ejemplo de cómo acceder a los datos de la fila seleccionada
                var idEvento = selectedRow.Cells["IDEvento"].Value;
                var idAtleta = selectedRow.Cells["IDAtleta"].Value;
                var horafin = selectedRow.Cells["Horafin"].Value;

                if(idEvento.ToString().Length > 0)
                {
                    eventoAbandonado.Eve_ID = (int)idEvento;
                    eventoAbandonado.Atl_ID = (int)idAtleta;
                    eventoAbandonado.Com_ID = (int)cmbCompetencias.SelectedValue;
                    eventoAbandonado.Eve_HoraInicio = dtpInicio.Value;
                    eventoAbandonado.Eve_HoraFin = (DateTime)horafin;
                    eventoAbandonado.Eve_Estado = "Abandonado";

                    Trabajar_Evento.modificarEvento(eventoAbandonado );
                }
                else
                {
                    MessageBox.Show("La fila seleccionada no tiene datos .Por favor, selecciona una fila válida.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila válida.");
            }
        }

        private DataTable cargarEventos(int idCompetencia ,string estado)
        {
            return Trabajar_Evento.buscar_atletas(idCompetencia, estado);
        }

    }

}
