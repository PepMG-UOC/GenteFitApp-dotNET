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

        private void resetCamposNEW()
        {
            tbNombre.Text = string.Empty;
            tbDescripcion.Text = string.Empty;
            cBMonitor.SelectedIndex = -1;
        }

        private void resetCamposShow()
        {
            tbVNombre.Text = string.Empty;
            tbVDescrip.Text = string.Empty;
            tbVMonitor.Text = string.Empty;
        }

        private void cBMostrar_Click(object sender, EventArgs e)
        {            
            cBMostrar.DataSource = GestionCentro.getNombresActividades();
            resetCamposNEW();
            cBMonitor.SelectedIndex = -1;
            cBEliminar.SelectedIndex = -1;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {                       
            if(cBMostrar.SelectedItem != null)
            {
                var estaActividad = GestionCentro.getActividadByNombre(cBMostrar.SelectedItem.ToString());
                tbVNombre.Text = estaActividad.nombre;
                tbVDescrip.Text = estaActividad.descripcion;
                var monitor = Usuarios.getMonitorById(estaActividad.Monitor.id_Monitor);
                tbVMonitor.Text = monitor.Persona.nombre + " " + monitor.Persona.apellido1;
                cBMostrar.SelectedIndex = -1;
            }                        
        }

        private void cBMonitor_Click(object sender, EventArgs e)
        {
            cBMonitor.DataSource= Usuarios.getNombresMonitores();   
            cBEliminar.SelectedIndex= -1;
            cBMostrar.SelectedIndex= -1;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(tbNombre.Text!="" && cBMonitor.SelectedItem !=null)
            {
                var monitor = Usuarios.getMonitorByNombre(cBMonitor.SelectedItem.ToString());
                GestionCentro.altaActividad(tbNombre.Text, tbDescripcion.Text, monitor.id_Monitor);
                MessageBox.Show("Actividad creada correctamente.");
            } else MessageBox.Show("Debe rellenar los campos.");
        }

        private void cBEliminar_Click(object sender, EventArgs e)
        {
            cBEliminar.DataSource = GestionCentro.getNombresActividades();
            cBMostrar.SelectedIndex = -1;
            cBMonitor.SelectedIndex= -1;
            resetCamposNEW();
            resetCamposShow();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(cBEliminar.SelectedItem!=null)
            {
                var estaActividad = GestionCentro.getActividadByNombre(cBEliminar.SelectedItem.ToString());
                GestionCentro.bajaActividad(estaActividad);
                MessageBox.Show("Actividad eliminada correctamente.");
            } else MessageBox.Show("Debe seleccionar una actividad a eliminar.");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmGestionCentro gestionCentro = new frmGestionCentro();
            gestionCentro.Show();
            this.Close();
        }

        private void tbNombre_Enter(object sender, EventArgs e)
        {
            cBEliminar.SelectedIndex = -1;
            cBMostrar.SelectedIndex = -1;
            resetCamposShow();
        }

        private void tbDescripcion_Enter(object sender, EventArgs e)
        {
            cBEliminar.SelectedIndex = -1;
            cBMostrar.SelectedIndex = -1;
            resetCamposShow();
        }
    }
}
