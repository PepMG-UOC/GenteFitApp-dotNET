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

namespace GenteFitApp.Vistas
{
    public partial class frmGestionUsers : Form
    {
        private Persona usuario;
        
        public frmGestionUsers()
        {
            InitializeComponent();
            gBDetallesUser.Enabled= false;
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            usuario= new Persona();
            usuario = Usuarios.personaByMail(tbEmail.Text);
            if (usuario != null)
            {
                gBDetallesUser.Enabled = true;
                tbDNI.Text = usuario.dniNifNie;
                tbNombre.Text = usuario.nombre;
                tbApellido.Text = usuario.apellido1;
                tbDireccion.Text = usuario.direccion;
                tbProvincia.Text = usuario.provincia;
                tbCodigoPost.Text = usuario.codigoPostal.ToString();
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
