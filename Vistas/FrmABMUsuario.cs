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
    public partial class FrmABMUsuario : Form
    {
        public FrmABMUsuario()
        {
            InitializeComponent();
        }
        private void ABMUsuario_Load(object sender, EventArgs e)
        {
            cargar_tabla();
            combo_roles();
            limpiar();
            lbID.Visible = false;
            lbID.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

        }
        private void cargar_tabla()
        {
            dgvusuario.DataSource = TrabajarUsuario.lista_usuarios();

        }
        

        private void combo_roles()
        {
            boxrol.DisplayMember = "Rol_Descripcion";
            boxrol.ValueMember = "Rol_Codigo";
            boxrol.DataSource = TrabajarUsuario.list_roles();
        }

        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
             borrar_error();
             if (validar_espacios_en_blanco())
             {
                 Usuario oUser = new Usuario();
                 oUser.Rol_Codigo = (int)boxrol.SelectedValue;
                 oUser.Usu_NombreUsuario = txtnombreusuario.Text;
                 oUser.Usu_Contraseña = txtcontraseña.Text;
                 oUser.Usu_ApellidoNombre = txtapellidonombre.Text;

                 TrabajarUsuario.agregar_usuario(oUser);
                 cargar_tabla();
                 limpiar();
             }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string usuEliminado;
            usuEliminado = lbID.Text;
            TrabajarUsuario.eliminar_usuario(usuEliminado);
            cargar_tabla();
            limpiar();
        }

        private void dgvusuario_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvusuario.CurrentRow!=null )
            {

                boxrol.SelectedValue = dgvusuario.CurrentRow.Cells["Rol_id"].Value.ToString();
                txtapellidonombre.Text = dgvusuario.CurrentRow.Cells["Nombre Completo"].Value.ToString();
                txtnombreusuario.Text = dgvusuario.CurrentRow.Cells["Usuario"].Value.ToString();
                txtcontraseña.Text = dgvusuario.CurrentRow.Cells["Contraseña"].Value.ToString();
                lbID.Text = dgvusuario.CurrentRow.Cells["ID"].Value.ToString();

                lbID.Visible = true;
                
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                borrar_error();
        }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Usuario oUser = new Usuario();
            oUser.Rol_Codigo = (int)boxrol.SelectedValue;
            oUser.Usu_NombreUsuario = txtnombreusuario.Text;
            oUser.Usu_Contraseña = txtcontraseña.Text;
            oUser.Usu_ApellidoNombre = txtapellidonombre.Text;
            oUser.Usu_ID = Convert.ToInt32(lbID.Text);
            TrabajarUsuario.modificar_usuario(oUser);
            cargar_tabla();
            limpiar();
        }

        private void limpiar()
        {
            foreach (object obj in Controls)
                if (obj is TextBox)
                    ((TextBox)obj).Text = "";
        
        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            string nameusu = txtbuscarNombre.Text;

            dgvusuario.DataSource = TrabajarUsuario.buscar_usuarios_SP(nameusu);
                
           

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }
        private bool validar_espacios_en_blanco()
        {
            bool validacion = true;
            if (txtnombreusuario.Text == "")
            {
                validacion = false;
                errorProvider1.SetError(txtnombreusuario, "Ingresar nombre");
            }
            if (txtcontraseña.Text == "")
            {
                validacion = false;
                errorProvider1.SetError(txtcontraseña, "Ingresar la contraseña");
            }
            if (txtapellidonombre.Text == "")
            {
                validacion = false;
                errorProvider1.SetError(txtapellidonombre, "Ingresar nombre completo");
            }

            return validacion;
        }
        private void borrar_error()
        {
            errorProvider1.SetError(txtnombreusuario, "");
            errorProvider1.SetError(txtcontraseña, "");

            errorProvider1.SetError(txtapellidonombre, "");
        }
        
}
}