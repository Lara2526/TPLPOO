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
    public partial class FrmResultados : Form
    {
        public FrmResultados()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int competenciaID = int.Parse(txtCompetenciaID.Text);
            Trabajar_Evento trabajarEvento = new Trabajar_Evento();
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

            lblParticipantes.Text = eventos.Count.ToString();
            lblAbandonos.Text = eventos.Count(ev => ev.Eve_Estado == "Abandono").ToString();
            lblDescalificados.Text = eventos.Count(ev => ev.Eve_Estado == "Descalificados").ToString();
        }
    }
}
