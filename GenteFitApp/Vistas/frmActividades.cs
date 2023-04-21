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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GenteFitApp.Vistas
{
    public partial class frmActividades : Form
    {
        public frmActividades()
        {
            InitializeComponent();
        }

        private void cBMostrar_Click(object sender, EventArgs e)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                var actividadesShow = dBGfit.Actividad.ToList();
                cBMostrar.DataSource = actividadesShow;
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Actividad estaActividad= new Actividad();            
            if(cBMostrar!=null)
            {
                estaActividad = GestionCentro.getActividadById((int)cBMostrar.SelectedValue);
            }
            tbVNombre.Text = estaActividad.nombre;
            tbVDescrip.Text = estaActividad.descripcion;
            var monitor = Usuarios.getMonitorById(estaActividad.Monitor.id_Monitor);            
            tbVMonitor.Text = monitor.Persona.nombre + " " + monitor.Persona.apellido1;
            cBMostrar.SelectedIndex = -1;            
        }





        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmGestionCentro gestionCentro = new frmGestionCentro();
            gestionCentro.Show();
            this.Close();
        }
    }
}
