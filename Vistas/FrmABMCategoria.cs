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
    
    public partial class FrmABMCategoria : Form
    {
       
        public FrmABMCategoria()
        {
            InitializeComponent();
        }

       

       
        

        private void FrmABMCategoria_Load(object sender, EventArgs e)
        {
            cargar_tabla();
            limpiar();
        }
        private void dgvCategoria_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvCategoria.CurrentRow != null)
            {


                txtNombre.Text = dgvCategoria.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = dgvCategoria.CurrentRow.Cells["Descripcion"].Value.ToString();
                lbid.Text = dgvCategoria.CurrentRow.Cells["ID"].Value.ToString();
            }
        }
        private void cargar_tabla()
        {
            dgvCategoria.DataSource = TrabajarCategoria.listarCategoria();

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

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtDescripcion.Text != "")
            {
                Categoria ocat = new Categoria();
                ocat.Cat_Descripcion = txtDescripcion.Text;
                ocat.Cat_Nombre = txtNombre.Text;
                TrabajarCategoria.agregar_categoria_SP(ocat);
                cargar_tabla();
                limpiar();
            }
            else
            {
                MessageBox.Show("Rellene las casillas correspondientes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string msg = "Desea continuar";
            DialogResult result = MessageBox.Show(msg, "Modificando.. ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Categoria ocat = new Categoria();
                ocat.Cat_Descripcion = txtDescripcion.Text;
                ocat.Cat_Nombre = txtNombre.Text;
                ocat.Cat_ID = Convert.ToInt32(lbid.Text);
                TrabajarCategoria.mosdificar_disciplina_SP(ocat);
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
                string catEliminado;
                catEliminado = lbid.Text;
                TrabajarCategoria.eliminar_categoria(catEliminado);
                cargar_tabla();
                limpiar();

            }
        }


       
    }
}
