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
    public partial class FrmInscripcionEvento : Form
    {
        public FrmInscripcionEvento()
        {
            InitializeComponent();
        }

        private void FrmInscripcionEvento_Load(object sender, EventArgs e)
        {
            combo_participantes();
            combo_competencias();
            cargar_tabla();
        }
        private void combo_participantes()
        {
            cmbParticipante.DisplayMember = "Apellido Nombre";
            cmbParticipante.ValueMember = "Atl_ID";
            cmbParticipante.DataSource = TrabajarAtleta.combo_nombreatletas();
        }
        private void combo_competencias()
        {
            cmbCompetencia.DisplayMember = "Nombre";
            cmbCompetencia.ValueMember = "ID";
            cmbCompetencia.DataSource = TrabajarCompetencias.listarCompetencias();
        }
        private void cargar_tabla()
        {
            dgvEvento.DataSource = Trabajar_Evento.listar_evento();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Evento evento = new Evento();
            evento.Com_ID = (int)cmbCompetencia.SelectedValue;
            evento.Atl_ID = (int)cmbParticipante.SelectedValue;
            evento.Eve_Estado = "Inscripto";

            DataTable buscar_atl = Trabajar_Evento.buscar_inscripcion_atleta(evento.Atl_ID, evento.Com_ID);
            
            if (buscar_atl.Rows.Count > 0)
            {
                MessageBox.Show("Ya esta inscripto el participante en la competencia", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DateTime horario_actual = DateTime.Now;
                DataTable horario_com = TrabajarCompetencias.verificar_horario_competencia(evento.Com_ID, horario_actual);
                
                if (horario_com.Rows.Count > 0)
                {
                    DataTable estado_com = TrabajarCompetencias.verificar_estado_competencia(evento.Com_ID);
                    
                    if (estado_com.Rows.Count > 0)
                    {
                        Trabajar_Evento.agregar_evento(evento);
                        cargar_tabla();
                    }
                    else
                    {
                        MessageBox.Show("No se puede inscribir a la competencia. La competencia fue Cancelada  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ya no se puede inscribir.El horario esta fuera de termino  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
