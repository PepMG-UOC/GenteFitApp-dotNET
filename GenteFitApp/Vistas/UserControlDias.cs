using GenteFitApp.Conrolers;
using GenteFitApp.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
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

        public void dias(int numdia)
        {
            lbdias.Text = numdia.ToString();            
        }

        public void CargaClasesDelDia(DateTime fecha)
        {            
            Color micolor;
            var clasesEventos = ConsultasBase.listarClasesPorFecha(fecha);

            dGVEventos.AutoGenerateColumns = false;
            dGVEventos.Columns.Clear();

            var idClaseColumn = new DataGridViewTextBoxColumn();
            idClaseColumn.DataPropertyName = "id_Clase";
            idClaseColumn.Visible = false;
            dGVEventos.Columns.Add(idClaseColumn);

            var fechaHoraColumn = new DataGridViewTextBoxColumn();
            fechaHoraColumn.DataPropertyName = "fechaHora";
            fechaHoraColumn.DefaultCellStyle.Format = "HH:mm";
            dGVEventos.Columns.Add(fechaHoraColumn);

            var nombreActividadColumn = new DataGridViewTextBoxColumn();
            nombreActividadColumn.DataPropertyName = "nombreActividad";
            dGVEventos.Columns.Add(nombreActividadColumn);

            foreach (var unaclase in clasesEventos)
            {
                DataGridViewRow nuevaFila = new DataGridViewRow();
                nuevaFila.CreateCells(dGVEventos, unaclase.id_Clase, unaclase.fechaHora, unaclase.Actividad.nombre);
                if(unaclase.fechaHora>DateTime.Now) 
                {
                    micolor = EventosCalendar.colorLinea(unaclase);
                    nuevaFila.DefaultCellStyle.BackColor = micolor;
                    dGVEventos.ColumnHeadersDefaultCellStyle.BackColor = micolor;
                    dGVEventos.DefaultCellStyle.SelectionBackColor = micolor;
                    dGVEventos.DefaultCellStyle.ForeColor = Color.Black;
                    dGVEventos.DefaultCellStyle.SelectionForeColor = Color.Black;
                } 
                else
                {
                    micolor = Color.Gray;
                    nuevaFila.DefaultCellStyle.BackColor = micolor;
                    dGVEventos.ColumnHeadersDefaultCellStyle.BackColor = micolor;
                    dGVEventos.DefaultCellStyle.SelectionBackColor = micolor;
                    dGVEventos.DefaultCellStyle.ForeColor = Color.Black;
                    dGVEventos.DefaultCellStyle.SelectionForeColor = Color.Black;
                    dGVEventos.Enabled= false;
                }                
                dGVEventos.Rows.Add(nuevaFila);                
                dGVEventos.ClearSelection();
            }           
        }
  
        private void dGVEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dGVEventos.Rows[e.RowIndex];
                int idClase = Convert.ToInt32(row.Cells[0].Value);
                dGVEventos.CurrentCell = null;
                row.Selected = true;
                if (idClase > 0)
                {
                    frmEventos _frmEvento = new frmEventos(idClase);
                    _frmEvento.BringToFront();
                    _frmEvento.Show();
                }
                
            }
        }
    }
}
