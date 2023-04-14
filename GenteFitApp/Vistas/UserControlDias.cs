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
    public partial class UserControlDias : UserControl
    {
        public static string dia;

        public UserControlDias()
        {
            InitializeComponent();
        }

        private void UserControlDias_Load(object sender, EventArgs e)
        {

        }
        public void dias(int numdia)
        {
            lbdias.Text = numdia.ToString();            
        }

        public void CargaClasesDelDia(DateTime fecha)
        {
            var clasesEventos = ConsultasBase.ObtenerClasesPorFecha(fecha);
            dGVEventos.AutoGenerateColumns = false;
            dGVEventos.Columns.Clear();
                        
            var fechaHoraColumn = new DataGridViewTextBoxColumn();
            fechaHoraColumn.DataPropertyName = "fechaHora";
            dGVEventos.Columns.Add(fechaHoraColumn);

            var nombreActividadColumn = new DataGridViewTextBoxColumn();
            nombreActividadColumn.DataPropertyName = "nombreActividad";
            fechaHoraColumn.DefaultCellStyle.Format = "HH:mm";
            dGVEventos.Columns.Add(nombreActividadColumn);

            var idClaseColumn = new DataGridViewTextBoxColumn();
            idClaseColumn.DataPropertyName = "id_Clase";           
            idClaseColumn.Visible = false;
            dGVEventos.Columns.Add(idClaseColumn);

            var descripcionActividadColumn = new DataGridViewTextBoxColumn();
            descripcionActividadColumn.DataPropertyName = "descripcionActividad";
            descripcionActividadColumn.Visible = false;            
            dGVEventos.Columns.Add(descripcionActividadColumn);

            var numPlazasSalaColumn = new DataGridViewTextBoxColumn();
            numPlazasSalaColumn.DataPropertyName = "numPlazasSala";
            numPlazasSalaColumn.Visible = false;            
            dGVEventos.Columns.Add(numPlazasSalaColumn);

            var numReservasColumn = new DataGridViewTextBoxColumn();
            numReservasColumn.DataPropertyName = "numReservas";
            numReservasColumn.Visible = false;
            dGVEventos.Columns.Add(numReservasColumn);

            dGVEventos.DataSource= clasesEventos;
        }
        //public void insertaEvento(Label evento)
        //{
        //   // evento.Click += new EventHandler(abreEvento);
        //    dGVEventos.Controls.Add(evento);
        //}
        
        //private void abreEvento(object sender, EventArgs e)
        //{
        //    Label label = (Label)sender;
        //    string activ = label.Text;

        //   // dia = lbdias.Text;
        //    frmEventos _frmEvento = new frmEventos();
        //    _frmEvento.Show();
        //}

        private void dGVEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener la entidad ClaseEvento de la fila seleccionada
                var claseEventoSeleccionada = (ClaseEvento)dGVEventos.Rows[e.RowIndex].DataBoundItem;

                //// Usar la entidad seleccionada para realizar alguna acción
                //int idClaseSeleccionada = claseEventoSeleccionada.id_Clase;
                //string nombreActividadSeleccionada = claseEventoSeleccionada.nombreActividad;
                //string descripcionActividadSeleccionada = claseEventoSeleccionada.descripcionActividad;
                //int numPlazasSalaSeleccionada = claseEventoSeleccionada.numPlazasSala;
                //DateTime fechaHoraSeleccionada = claseEventoSeleccionada.fechaHora;

                frmEventos _frmEvento = new frmEventos(claseEventoSeleccionada);
                _frmEvento.Show();
            }
        }
    }
}
