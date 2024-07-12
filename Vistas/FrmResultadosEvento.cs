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
    public partial class FrmResultadosEvento : Form
    {
        public FrmResultadosEvento()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreCompetencia = txtCompetenciaNombre.Text;
            Trabajar_Evento trabajarEvento = new Trabajar_Evento();
            int competenciaID = trabajarEvento.ObtenerCompetenciaIDNombre(nombreCompetencia);

            if (competenciaID > 0)
            {
                List<Evento> eventos = trabajarEvento.ObtenerResultados(competenciaID);
                List<Evento> eventosOrdenados = trabajarEvento.CalcularOrden(eventos);

                dvgResultados.DataSource = eventosOrdenados.Select((ev, index) =>
                   new
                   {
                       Orden = index + 1,
                       Atleta = trabajarEvento.ObtenerNombreAtleta(ev.Atl_ID),
                       Categoria = trabajarEvento.ObtenerCategoria(ev.Atl_ID),
                       Disiplina = trabajarEvento.ObtenerDisciplina(ev.Com_ID),
                       TiempoLLegada = (ev.Eve_HoraFin - ev.Eve_HoraInicio).ToString(@"dd\.hh\:mm\:ss")
                   }
                 ).ToList();

                lblParticipantes.Text = String.Format("Participantes: {0}", eventos.Count);
                lblAbandonos.Text = String.Format("Abandonos: {0}", eventos.Count(ev => ev.Eve_Estado == "Abandono"));
                lblDescalificados.Text = String.Format("Descalificados: {0}", eventos.Count(ev => ev.Eve_Estado == "Descalificados"));
            }
            else 
            {
                MessageBox.Show("Competencia no encontrada.");
            }
            
        }

    }
}
