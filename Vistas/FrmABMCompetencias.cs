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
    public partial class FrmABMCompetencias : Form
    {
        public FrmABMCompetencias()
        {
            InitializeComponent();
        }

        private void FrmABMCompetencias_Load(object sender, EventArgs e)
        {
            cargar_tabla();
            limpiar();
            combo_Disciplina();
            combo_Categoria();
            combo_Estado();
        }

        
        private void limpiar()
        {
            foreach (object obj in Controls)
                if (obj is TextBox)
                    ((TextBox)obj).Text = "";

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void cargar_tabla()
        {
            dgvCompetencias.DataSource = TrabajarCompetencias.listarCompetencias();

        }
        private void combo_Disciplina()
        {
            cmbDisciplina.DisplayMember = "Descripcion";
            cmbDisciplina.ValueMember = "ID";
            cmbDisciplina.DataSource = TrabajarDisciplina.listarDisciplina();
        }
        private void combo_Categoria()
        {
            cmbCategoria.DisplayMember = "Descripcion";
            cmbCategoria.ValueMember = "ID";
            cmbCategoria.DataSource = TrabajarCategoria.listarCategoria();
        }
        private void combo_Estado()
        {
            var oEstado = Enum.GetNames(typeof(ClasesBase.Competencia.Estado));
            cmbEstado.DataSource = oEstado; 
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtDescripcion.Text != "")
            {
                Competencia ocom = new Competencia();
                ocom.Com_Nombre = txtNombre.Text;
                ocom.Com_Descripcion = txtDescripcion.Text;
                ocom.Com_FechaInicio = dtpFechaInicio.Value;
                ocom.Com_FechaFin = dtpFechaFin.Value;
                ocom.Com_Estado = Convert.ToString(cmbEstado.SelectedValue);
                ocom.Com_Organizador = txtOrganizador.Text;
                ocom.Com_Ubicacion = txtUbicacion.Text;
                ocom.Com_Sponsors = txtSponsors.Text;
                ocom.Cat_ID = (int)cmbCategoria.SelectedValue;
                ocom.Dis_ID = (int)cmbDisciplina.SelectedValue;



                TrabajarCompetencias.agregar_Competencia_SP(ocom);
                cargar_tabla();
                limpiar();
            }
            else
            {
                MessageBox.Show("Rellene las casillas correspondientes", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCompetencias_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvCompetencias.CurrentRow != null)
            {
                txtNombre.Text = dgvCompetencias.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = dgvCompetencias.CurrentRow.Cells["Descripcion"].Value.ToString();
                dtpFechaInicio.Value = Convert.ToDateTime(dgvCompetencias.CurrentRow.Cells["Fecha Inicio"].Value.ToString());
                dtpFechaFin.Value = Convert.ToDateTime(dgvCompetencias.CurrentRow.Cells["Fecha Fin"].Value.ToString());
                
                txtOrganizador.Text = dgvCompetencias.CurrentRow.Cells["Organizador"].Value.ToString();
                txtUbicacion.Text = dgvCompetencias.CurrentRow.Cells["Ubicacion"].Value.ToString();
                txtSponsors.Text = dgvCompetencias.CurrentRow.Cells["Sponsors"].Value.ToString();
                cmbCategoria.SelectedValue = dgvCompetencias.CurrentRow.Cells["Id Categoria"].Value.ToString();
                cmbDisciplina.SelectedValue = dgvCompetencias.CurrentRow.Cells["Id Disciplina"].Value.ToString();
                lbid.Text = dgvCompetencias.CurrentRow.Cells["ID"].Value.ToString();

                cmbEstado.Text = dgvCompetencias.CurrentRow.Cells["Estado"].Value.ToString();

              
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string msg = "Desea continuar";
            DialogResult result = MessageBox.Show(msg, "Modificando.. ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Competencia ocom = new Competencia();
                ocom.Com_Nombre = txtNombre.Text;
                ocom.Com_Descripcion = txtDescripcion.Text;
                ocom.Com_FechaInicio = dtpFechaInicio.Value;
                ocom.Com_FechaFin = dtpFechaFin.Value;
                ocom.Com_Estado = Convert.ToString(cmbEstado.SelectedValue);
                ocom.Com_Organizador = txtOrganizador.Text;
                ocom.Com_Ubicacion = txtUbicacion.Text;
                ocom.Com_Sponsors = txtSponsors.Text;
                ocom.Cat_ID = (int)cmbCategoria.SelectedValue;
                ocom.Dis_ID = (int)cmbDisciplina.SelectedValue;

                ocom.Com_ID = Convert.ToInt32(lbid.Text);
                TrabajarCompetencias.mosdificar_competencias_SP(ocom);
                cargar_tabla();
                limpiar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string msg = "Desea continuar ";
            DialogResult result = MessageBox.Show(msg, "Eliminando..", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string comEliminado;
                comEliminado = lbid.Text;
                TrabajarCompetencias.eliminar_competencia(comEliminado);
                cargar_tabla();
                limpiar();

            }
        }

    }
}
