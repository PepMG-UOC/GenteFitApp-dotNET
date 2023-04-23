using GenteFitApp.Conrolers;
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
    public partial class frmReservasAdmin : Form
    {
        public frmReservasAdmin(int IDClase)
        {
            InitializeComponent();
            ShowClaseDetails(IDClase);
        }

        private void ShowClaseDetails(int IDClase)
        {
            var estaClase = GestionCentro.getClaseByID(IDClase);
            txtbxActividad.Text = estaClase.Actividad.nombre;
            var estaActividad = GestionCentro.getActividadByNombre(estaClase.Actividad.nombre);
            var monitor = Usuarios.getMonitorById(estaActividad.Monitor.id_Monitor);
            txtbxMonitor.Text = monitor.Persona.nombre + " " + monitor.Persona.apellido1;
            txtbxFecha.Text = estaClase.fechaHora.ToString("dd/MM/yyyy");
            txtbxHora.Text = estaClase.fechaHora.ToString("HH:mm");            
            txtbxAforo.Text = estaClase.Sala.numPlazas.ToString();
            int numReservas = ConsultasBase.reservasDeClase(estaClase);
            if (estaClase.Sala.numPlazas >= numReservas)
            {
                txtbxPlazas.Text = (estaClase.Sala.numPlazas - numReservas).ToString();
            }
            else txtbxPlazas.Text = "0";
            

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
