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
    public partial class FrmLogin : Form
    {
        public bool loginSuccess { get; private set; }
        public int Rol { get; private set; }

        bool usr_valido = false;
        bool contra_valido = true;

        public FrmLogin()
        {
            InitializeComponent();
            this.loginSuccess = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (usr_valido && contra_valido)
            {
                DataTable user = TrabajarUsuario.VerificarUsu(txtUserName.Text, txtPassword.Text);
                if (user.Rows.Count > 0)
                {
                    bool autorizado = false;
                    autorizado = true;
                    if (autorizado)
                    {
                        string msg = "Ingresando " + "Desea continuar";
                        DialogResult result = MessageBox.Show(msg, "Credenciales aceptadas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if(result == DialogResult.Yes)
                        {
                            this.loginSuccess = true;

                            Rol = int.Parse(user.Rows[0]["Rol_Codigo"].ToString());

                            this.Close();
                        }
                    }
                }
                else
                { MessageBox.Show("Datos Incorrectos", "Credenciales Denegadas", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                MessageBox.Show("Ingrese sus credenciales", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txtPassword_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                contra_valido = false;
            }
            else 
            {
                contra_valido = true;
            }
        }

        private void txtUserName_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                usr_valido = false;
            }
            else
            {
                usr_valido = true;
            }
        }
        

        

        
    }
}
