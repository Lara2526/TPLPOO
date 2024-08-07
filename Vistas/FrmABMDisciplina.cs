﻿using System;
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

    public partial class FrmABMDisciplina : Form
    {

        public FrmABMDisciplina()
        {
            InitializeComponent();
        }

        private void FrmABMDisciplina_Load(object sender, EventArgs e)
        {
            cargar_tabla();
            limpiar();
            
            lbid.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }
        

        private void dgvDisciplina_CurrentCellChanged(object sender, EventArgs e)
        {


            if (dgvDisciplina.CurrentRow != null)
            {


                txtNombre.Text = dgvDisciplina.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = dgvDisciplina.CurrentRow.Cells["Descripcion"].Value.ToString();
                lbid.Text = dgvDisciplina.CurrentRow.Cells["ID"].Value.ToString();
                
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                borrar_error();
            }

        }
        private void cargar_tabla()
        {
            dgvDisciplina.DataSource = TrabajarDisciplina.listarDisciplina();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            foreach (object obj in Controls)
                if (obj is TextBox)
                    ((TextBox)obj).Text = "";
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
           

        }
          
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            borrar_error();
            if (validar_espacios_en_blanco())
            {
                Disciplina odis = new Disciplina();
                odis.Dis_Descripcion = txtDescripcion.Text;
                odis.Dis_Nombre = txtNombre.Text;
                TrabajarDisciplina.agregar_disciplina_SP(odis);
                cargar_tabla();
                limpiar();
            }
            
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            string msg = "Desea continuar";
             DialogResult result = MessageBox.Show(msg, "Modificando.. ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            Disciplina odis = new Disciplina();
                            odis.Dis_Descripcion = txtDescripcion.Text;
                            odis.Dis_Nombre = txtNombre.Text;
                            odis.Dis_ID = Convert.ToInt32(lbid.Text);
                            TrabajarDisciplina.mosdificar_disciplina_SP(odis);
                            cargar_tabla();
                            limpiar();
                        }
                        
                           // string ms = "Elemento a Modificar";
                            //MessageBox.Show(ms, "No Se encontro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string msg = "Desea continuar ";
            DialogResult result = MessageBox.Show(msg, "Eliminando..", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            string disEliminado;
                            disEliminado = lbid.Text;
                            TrabajarDisciplina.eliminar_disciplina(disEliminado);
                            cargar_tabla();
                            limpiar();

                        }
                        
                           // string ms = "Elemento a Eliminar";
                           // MessageBox.Show(ms,"No Se encontro",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        
        }

        private bool validar_espacios_en_blanco()
        {
            bool validacion = true;
            if (txtNombre.Text == "")
            {
                validacion = false;
                errorProvider1.SetError(txtNombre, "Ingresar nombre");
            }
            if (txtDescripcion.Text == "")
            {
                validacion = false;
                errorProvider1.SetError(txtDescripcion, "Ingresar la descripcion");
            }

            return validacion;
        }
        private void borrar_error()
        {
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtDescripcion, "");

        }
        
    }
}
