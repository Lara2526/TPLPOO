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
    public partial class FrmABMParticipantes : Form
    {
        public FrmABMParticipantes()
        {
            InitializeComponent();
        }

        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Atleta oAtleta = new Atleta();
            oAtleta.Atl_DNI= txtDNI.Text;
            oAtleta.Atl_Apellido =txtApellido.Text;
            oAtleta.Atl_Nombre = txtNombre.Text;
            oAtleta.Atl_Nacionalidad = cmbNacionalidad.Text;
            oAtleta.Atl_Entrenador=txtEntrenador.Text;
            oAtleta.Atl_Genero = this.GetSelectedRadioButton();
            oAtleta.Atl_Altura =(double)nudAltura.Value;
            oAtleta.Atl_Peso =(double)nudPeso.Value;;
            oAtleta.Atl_FechaNac=dtpFechaNac.Value;
            oAtleta.Atl_Direccion = txtDireccion.Text;
            oAtleta.Atl_Email = txtEmail.Text;
            TrabajarAtleta.agregar_atleta(oAtleta);
            cargar_tabla();
            limpiar();
        }
        private char GetSelectedRadioButton()
        {
            char opcion = 'x';
            if (rbtnFemenino.Checked)
            {

                opcion = 'F';
            }
            else if (rbtnMasculino.Checked)
            {

                opcion = 'M';
            }
            return opcion;
        }
        private void limpiar()
        {
            foreach (object obj in Controls)
                if (obj is TextBox)
                    ((TextBox)obj).Text = "";
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }
        private void cargar_tabla()
        {
            dgvAtleta.DataSource = TrabajarAtleta.lista_atletas();

        }

        private void FrmABMParticipantes_Load(object sender, EventArgs e)
        {
            cargar_tabla();
            limpiar();

           
            lbID.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string atlEliminado;
            atlEliminado = lbID.Text;
            TrabajarAtleta.eliminar_atleta(atlEliminado);
            cargar_tabla();
            limpiar();
        }

        private void dgvAtleta_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvAtleta.CurrentRow != null)
            {

                
                txtNombre.Text = dgvAtleta.CurrentRow.Cells["Nombre Completo"].Value.ToString();
                txtApellido.Text = dgvAtleta.CurrentRow.Cells["Apellido"].Value.ToString();
                txtDNI.Text = dgvAtleta.CurrentRow.Cells["DNI"].Value.ToString();
                cmbNacionalidad.Text = dgvAtleta.CurrentRow.Cells["Nacionalidad"].Value.ToString();
                txtEntrenador.Text = dgvAtleta.CurrentRow.Cells["Entrenador"].Value.ToString();
                
                if (dgvAtleta.CurrentRow.Cells["Genero"].Value.ToString() == "F")
                {

                    rbtnFemenino.Checked= true ;
                }
                else if (dgvAtleta.CurrentRow.Cells["Genero"].Value.ToString() == "M")
                {
                    rbtnMasculino.Checked = true;
                }
                nudAltura.Text = dgvAtleta.CurrentRow.Cells["Altura"].Value.ToString();
                nudPeso.Text = dgvAtleta.CurrentRow.Cells["Peso"].Value.ToString();
                dtpFechaNac.Value = Convert.ToDateTime(dgvAtleta.CurrentRow.Cells["Fecha de Nacimiento"].Value.ToString()); 
                txtDireccion.Text=dgvAtleta.CurrentRow.Cells["Direccion"].Value.ToString();
                txtEmail.Text = dgvAtleta.CurrentRow.Cells["Email"].Value.ToString(); 
                lbID.Text = dgvAtleta.CurrentRow.Cells["ID"].Value.ToString();

               
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                borrar_error();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Atleta oAtleta = new Atleta();
            oAtleta.Atl_ID = Convert.ToInt32(lbID.Text);
            oAtleta.Atl_DNI = txtDNI.Text;
            oAtleta.Atl_Apellido = txtApellido.Text;
            oAtleta.Atl_Nombre = txtNombre.Text;
            oAtleta.Atl_Nacionalidad = cmbNacionalidad.Text;
            oAtleta.Atl_Entrenador = txtEntrenador.Text;
            oAtleta.Atl_Genero = this.GetSelectedRadioButton();
            oAtleta.Atl_Altura = (double)nudAltura.Value;
            oAtleta.Atl_Peso = (double)nudPeso.Value; ;
            oAtleta.Atl_FechaNac = dtpFechaNac.Value;
            oAtleta.Atl_Direccion = txtDireccion.Text;
            oAtleta.Atl_Email = txtEmail.Text;
            TrabajarAtleta.modificar_atleta(oAtleta);
            cargar_tabla();
            limpiar();
        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            string apellido = txtbuscarNombre.Text;

            dgvAtleta.DataSource = TrabajarAtleta.buscar_atletas(apellido);
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (rbtnOrdenadoporDNI.Checked == true)
            {
                dgvAtleta.DataSource = TrabajarAtleta.ordear_DNI_atletas__SP();
            }
            else if (rbtnOrdenadoporApellido.Checked == true)
            {
                dgvAtleta.DataSource = TrabajarAtleta.ordear_Apellido_atletas__SP();
            }
            else
            {
                MessageBox.Show("Error ", "No selecciono ninguna opcion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private bool validar_espacios_en_blanco()
        {
            bool validacion = true;
            if (txtNombre.Text == "")
            {
                validacion = false;
                errorProvider1.SetError(txtNombre, "Ingresar nombre");
            }
            if (txtApellido.Text == "")
            {
                validacion = false;
                errorProvider1.SetError(txtApellido, "Ingresar apellido");
            }
            if (txtDNI.Text == "")
            {
                validacion = false;
                errorProvider1.SetError(txtDNI, "Ingresar el dni");
            }
            if (txtEntrenador.Text == "")
            {
                validacion = false;
                errorProvider1.SetError(txtEntrenador, "Ingresar el entrenador");
            }
            if (txtDireccion.Text == "")
            {
                validacion = false;
                errorProvider1.SetError(txtDireccion, "Ingresar la dirección");
            }

            if (txtEmail.Text == "")
            {
                validacion = false;
                errorProvider1.SetError(txtEmail, "Ingresar el sponsors");
            }
            return validacion;
        }
        private void borrar_error()
        {
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtApellido, "");
            errorProvider1.SetError(txtDNI, "");
            errorProvider1.SetError(txtEntrenador, "");
            errorProvider1.SetError(txtDireccion, "");
            errorProvider1.SetError(txtEmail, "");
        }
    }
}
