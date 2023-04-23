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
        private int IDLaClase { get; set; }
        public frmReservasAdmin(int IDClase)
        {
            InitializeComponent();
            IDLaClase = IDClase;
            ShowClaseDetails();
        }

        private void ShowClaseDetails()
        {
            var estaClase = GestionCentro.getClaseByID(IDLaClase);
            txtbxActividad.Text = estaClase.Actividad.nombre;
            var estaActividad = GestionCentro.getActividadByNombre(estaClase.Actividad.nombre);
            var monitor = Usuarios.getMonitorById(estaActividad.Monitor.id_Monitor);
            txtbxMonitor.Text = monitor.Persona.nombre + " " + monitor.Persona.apellido1;
            txtbxFecha.Text = estaClase.fechaHora.ToString("dd/MM/yyyy");
            txtbxHora.Text = estaClase.fechaHora.ToString("HH:mm");            
            txtbxAforo.Text = estaClase.Sala.numPlazas.ToString();
            int numReservas = ConsultasBase.numReservasClase(IDLaClase);
            if (estaClase.Sala.numPlazas >= numReservas)
            {
                txtbxPlazas.Text = (estaClase.Sala.numPlazas - numReservas).ToString();
            }
            else txtbxPlazas.Text = "0";
            usuariosConPlaza();
            listaDeEspera();

        }

        private void usuariosConPlaza()
        {            
            lBUsersPlaza.DataSource = ConsultasBase.clientesConPlaza(IDLaClase);            
        }

        private void listaDeEspera()
        {
            lBListaEspera.DataSource = ConsultasBase.clientesEnEspera(IDLaClase);              
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
