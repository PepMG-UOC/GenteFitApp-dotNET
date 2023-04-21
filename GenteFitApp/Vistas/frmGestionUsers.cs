using GenteFitApp.Conrolers;
using GenteFitApp.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.Entity;

namespace GenteFitApp.Vistas
{
    public partial class frmGestionUsers : Form
    {
        private Persona usuario;
        
        public frmGestionUsers()
        {
            InitializeComponent();           
            
        }
        private void frmGestionUsers_Load(object sender, EventArgs e)
        {
            reseteaForm();
        }

        private void reseteaForm()
        {
            tbEmail.Text = "eMail";
            foreach (Control control in gBDetallesUser.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = "";
                }
            }
            gBDetallesUser.Enabled = false;            
            gBTipo.Enabled = false;
            btnAlta.Visible = false;
            btnBaja.Visible = false;
            btnModificar.Visible = false;
            lbSueldo.Visible = false;
            tbSueldo.Visible = false;
            lbSueldo2.Visible = false;
            pictureBox1.Focus();
        }

        private void tbEmail_Enter(object sender, EventArgs e)
        {
            if (tbEmail.Text == "eMail")
            {
                tbEmail.Text = string.Empty;
            }
        }
        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                tbEmail.Text = "eMail";
            }
        }
        private void tbEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Usuarios.formatoEmailCorrecto(tbEmail.Text))
                {
                    gBDetallesUser.Enabled = true;
                    gBTipo.Enabled = true;
                    usuario = new Persona();
                    usuario = Usuarios.personaByMail(tbEmail.Text);
                    if (usuario != null)
                    {
                        btnModificar.Visible= true;
                        btnBaja.Visible=true;
                        cargaUsuarioEnForm();
                    } else
                    {
                        btnAlta.Visible = true;
                        btnBaja.Visible=true;
                        e.SuppressKeyPress = true;
                        tbDNI.Select();
                    }  
                }
                else MessageBox.Show("Formato de eMail Incorrecto. Intente de nuevo.");
            }
        }

        private void tbDNI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete && tbDNI.Text.Length > 9)
            {
                e.SuppressKeyPress = true;
            }
        }


        private void tbCodigoPost_KeyDown(object sender, KeyEventArgs e)
        {
            // Solo permitir números
            if (e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete && (e.KeyValue < 48 || e.KeyValue > 57))
            {
                // Si no es un número, suprimir la tecla presionada
                e.SuppressKeyPress = true;
            }
        }

        private void tbSueldo_KeyDown(object sender, KeyEventArgs e)
        {
            // Solo permitir números
            if (e.KeyCode != Keys.Back && !e.KeyCode.Equals(',') && !e.KeyCode.Equals('.') && e.KeyCode != Keys.Delete && (e.KeyValue < 48 || e.KeyValue > 57))
            {    

                // Si no es un número, suprimir la tecla presionada
                e.SuppressKeyPress = true;
            }
        }
        private void rBMonitor_CheckedChanged(object sender, EventArgs e)
        {
            if (rBMonitor.Checked)
            { 
                lbSueldo.Visible= true;
                tbSueldo.Visible= true;
                lbSueldo2.Visible= true;
            }else
            {
                lbSueldo.Visible= false;
                tbSueldo.Visible= false;
                lbSueldo2.Visible= false;
            }
        }
        private void btnAlta_Click(object sender, EventArgs e)
        {
            bool esCliente = rBCliente.Checked;
            bool esMonitor = rBMonitor.Checked;
            bool esAdmin = rBAdmin.Checked;
            usuario = new Persona();
            cargaDatosToUsuario();
            if(Usuarios.altaUsuario(esCliente, esMonitor, esAdmin, tbSueldo, usuario))
            {
                MessageBox.Show("Usuario añadido correctamente");
            } else MessageBox.Show("Usuario no se ha podido añadir");
            reseteaForm();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            bool esMonitor = rBMonitor.Checked;
            cargaDatosToUsuario();
            if(Usuarios.modificarUsuario(esMonitor, tbSueldo, usuario))
            {
                MessageBox.Show("Usuario modificado correctamente");
            } else MessageBox.Show("Usuario no puede modificarse");
            reseteaForm();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            cargaDatosToUsuario();
            Usuarios.bajaUsuario(usuario.id_Persona);            
            reseteaForm();
        }

        private void cargaDatosToUsuario()
        {
            usuario.email = tbEmail.Text;
            usuario.dniNifNie = tbDNI.Text;
            usuario.nombre = tbNombre.Text;
            usuario.apellido1 = tbApellido.Text;
            usuario.apellido2 = tbApellido2.Text;
            usuario.direccion = tbDireccion.Text;
            usuario.provincia = tbProvincia.Text;
            usuario.codigoPostal = int.Parse(tbCodigoPost.Text);
            usuario.password = tbPass.Text;
        }

        private void cargaUsuarioEnForm()
        {            
            tbDNI.Text = usuario.dniNifNie;
            tbNombre.Text = usuario.nombre;
            tbApellido.Text = usuario.apellido1;
            tbApellido2.Text = usuario.apellido2;
            tbDireccion.Text = usuario.direccion;
            tbProvincia.Text = usuario.provincia;
            tbCodigoPost.Text = usuario.codigoPostal.ToString();
            tbPass.Text = usuario.password;
            if(usuario.Cliente.Count!=0)
            {
                rBCliente.Enabled= true;
                rBCliente.Checked = true;
                rBMonitor.Enabled = false;
                rBAdmin.Enabled = false;
            } else if(usuario.Monitor.Count!=0)
            {
                rBMonitor.Enabled= true;
                rBMonitor.Checked = true;
                rBAdmin.Enabled = false;
                rBCliente.Enabled = false;
                Monitor miMonitor = Usuarios.getMonitorDePersona(usuario.id_Persona);
                tbSueldo.Text = miMonitor.precioHora.ToString();
            } else if(usuario.Administrador.Count!=0)
            {
                rBAdmin.Enabled= true;
                rBAdmin.Checked = true;
                rBCliente.Enabled = false;
                rBMonitor.Enabled = false;
            }       

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenuAdmin menuAdmin = new frmMenuAdmin();
            menuAdmin.Show();
            this.Close();
        }

        
    }
}
