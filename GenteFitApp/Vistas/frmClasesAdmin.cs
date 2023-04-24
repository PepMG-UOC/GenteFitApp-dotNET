using GenteFitApp.Conrolers;
using GenteFitApp.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GenteFitApp.Vistas
{
    public partial class frmClasesAdmin : Form
    {
        public DateTime myFecha;
        public frmClasesAdmin(DateTime mifecha)
        {
            InitializeComponent();
            myFecha = mifecha;
            
        }

        private void clasesDelDia(DateTime mifecha)
        {
            var clasesEventos = ConsultasBase.listarClasesPorFecha(mifecha);
            dGVClases.Columns.Clear();
            dGVClases.Columns.Add("ID", "ID");
            dGVClases.Columns.Add("Hora", "Hora");
            dGVClases.Columns.Add("Actividad", "Actividad");
            dGVClases.Columns.Add("Monitor", "Monitor");
            dGVClases.Columns["ID"].Visible = false;
            int index;
            foreach (var unaclase in clasesEventos)
            {
                string textoHora = string.Format("{0:HH:mm}", unaclase.fechaHora);
                var estaActividad = GestionCentro.getActividadByNombre(unaclase.Actividad.nombre);
                var monitor = Usuarios.getMonitorById(estaActividad.Monitor.id_Monitor);                
                index = dGVClases.Rows.Add();
                dGVClases.Rows[index].Cells["ID"].Value = unaclase.id_Clase;
                dGVClases.Rows[index].Cells["Hora"].Value = textoHora;
                dGVClases.Rows[index].Cells["Actividad"].Value = estaActividad.nombre;
                dGVClases.Rows[index].Cells["Monitor"].Value = monitor.Persona.nombre + " " + monitor.Persona.apellido1;                
            }
            dGVClases.CurrentCell = null;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmCalendario adminCalendar = new frmCalendario();
            adminCalendar.Origen = "Administracion De Clases";
            adminCalendar.Show();            
            this.Close();
        }

        private void frmClasesAdmin_Load(object sender, EventArgs e)
        {
            tbDia.Text = myFecha.ToString("d");
            pBClases.Focus();
            clasesDelDia(myFecha);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dGVClases.SelectedRows.Count == 0) return;
            int rowIndex = dGVClases.SelectedRows[0].Index;
            int id = Convert.ToInt32(dGVClases.Rows[rowIndex].Cells["ID"].Value);
            var clase = GestionCentro.getClaseByID(id);
            GestionCentro.bajaClase(clase);
            MessageBox.Show("La Clase se ha eliminado correctamente.");
            clasesDelDia(myFecha);
        }

        private void cBActividad_Click(object sender, EventArgs e)
        {
            cBActividad.DataSource = GestionCentro.getNombresActividades();
        }

        private void cBSala_Click(object sender, EventArgs e)
        {
            cBSala.DataSource = GestionCentro.getSalasIds();
        }

        private void dGVClases_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cBActividad.SelectedIndex = -1;
            cBSala.SelectedIndex = -1;
            cBHora.SelectedIndex = -1;
        }

        private void cBSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cBSala.SelectedItem!= null)
            {
                int id = (int)cBSala.SelectedValue;
                tbSalaDetails.Text = GestionCentro.detallesSala(id);
            }            
        }

        private void cBHora_Click(object sender, EventArgs e)
        {
            List<DateTime> horas = new List<DateTime>();
            DateTime hora = new DateTime(1, 1, 1, 6, 0, 0); // 6:00 AM
            DateTime limite = new DateTime(1, 1, 1, 22, 0, 0); // 10:00 PM
            while (hora <= limite)
            {
                horas.Add(hora);
                hora = hora.AddMinutes(30); // Agrega 30 minutos
            }            
            foreach (DateTime unahora in horas)
            {
                cBHora.Items.Add(unahora.ToString("HH:mm"));
            }            
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if((cBHora.SelectedIndex != -1) && (cBActividad.SelectedIndex!= -1) && (cBSala.SelectedIndex!=-1))
            {
                var activity = GestionCentro.getActividadByNombre(cBActividad.SelectedItem.ToString());
                int idSala = (int)cBSala.SelectedValue;
                string horaSeleccionada = cBHora.SelectedItem.ToString();
                DateTime myHora = DateTime.ParseExact(horaSeleccionada, "HH\\:mm", CultureInfo.InvariantCulture);
                DateTime fechaCombinada = new DateTime(myFecha.Year, myFecha.Month, myFecha.Day, myHora.Hour, myHora.Minute, 0);
                GestionCentro.altaClase(activity.id_Actividad, idSala, fechaCombinada);
                MessageBox.Show("La Clase se ha creado correctamente.");
                clasesDelDia(myFecha);
            } else MessageBox.Show("Deve seleccionar los campos.");
        }
    }
}
