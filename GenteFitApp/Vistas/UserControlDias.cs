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
            var clasesEventos = ConsultasBase.listarClasesPorFecha(fecha);           

            foreach (var unaclase in clasesEventos)
            {                
                string textoFila = string.Format("{0:HH:mm}\t{1}", unaclase.fechaHora, unaclase.Actividad.nombre);
                Color colorFondo;
                if(unaclase.fechaHora > DateTime.Now)
                {
                    colorFondo = EventosCalendar.colorLinea(unaclase.id_Clase);
                    listBox1.Enabled = true;
                }
                else
                {
                    colorFondo = Color.Gray;
                    listBox1.Enabled = false;
                }
                listBox1.Items.Add(new { miFecha = unaclase.fechaHora, Texto = textoFila, Datos = unaclase.id_Clase, ColorFondo = colorFondo });
            }           
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            var item = listBox1.Items[e.Index];
            string textoFila = ((dynamic)item).Texto;            
            //int id_Clase = ((dynamic)item).Datos;
            //DateTime fechaHora = ((dynamic)item).miFecha;
            Color colorFondo = ((dynamic)item).ColorFondo;
            Brush brushFondo = new SolidBrush(colorFondo);
            Brush brushTexto = new SolidBrush(Color.Black);
            e.Graphics.FillRectangle(brushFondo, e.Bounds);
            e.Graphics.DrawString(textoFila, e.Font, brushTexto, e.Bounds);
            brushFondo.Dispose();
            brushTexto.Dispose();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {                
                var item = listBox1.Items[listBox1.SelectedIndex];
                int idClase = ((dynamic)item).Datos;
                Color colorFondo = ((dynamic)item).ColorFondo;
                listBox1.SelectedItems.Clear();
                this.Refresh();
                if (idClase != 0)
                {
                    frmEventos _frmEvento = new frmEventos(idClase,colorFondo);
                    _frmEvento.BringToFront();
                    _frmEvento.ShowDialog(); 
                }
                
            }
        }

        //private void dGVEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        DataGridViewRow row = dGVEventos.Rows[e.RowIndex];
        //        int idClase = Convert.ToInt32(row.Cells[0].Value);
        //        dGVEventos.CurrentCell = null;
        //        row.Selected = true;
        //        if (idClase > 0)
        //        {
        //            frmEventos _frmEvento = new frmEventos(idClase);
        //            _frmEvento.BringToFront();
        //            _frmEvento.Show();
        //        }

        //    }
        //}
    }
}
