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
        public string Origen { get; set; }
        private DateTime myDia;
        public UserControlDias()
        {
            InitializeComponent();           
        }

        public void setMyDia(DateTime fechadia)
        {
            lbdias.Text = fechadia.Day.ToString();  
            myDia= fechadia;            
        }

        public void CargaClasesDelDia(DateTime fechaDelDia)
        {                        
            var clasesEventos = ConsultasBase.listarClasesPorFecha(fechaDelDia);           

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
            if (e.Index < 0)
            {                
                return;
            }
            e.DrawBackground();
            e.DrawFocusRectangle();
            var item = listBox1.Items[e.Index];
            string textoFila = ((dynamic)item).Texto;
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
                if (Origen.Equals("MenuCliente_Clases"))
                {
                    // Para Cliente                    
                    Color colorFondo = ((dynamic)item).ColorFondo;
                    listBox1.SelectedItems.Clear();
                    if (idClase != 0)
                    {
                        frmEventos _frmEvento = new frmEventos(idClase, colorFondo);
                        _frmEvento.BringToFront();
                        _frmEvento.ShowDialog();
                    }
                } else if(Origen.Equals("MenuAdmin_Reservas"))
                {
                    // Para Admin
                    frmReservasAdmin infoReservasAdmin = new frmReservasAdmin(idClase);
                    infoReservasAdmin.BringToFront();
                    infoReservasAdmin.ShowDialog();
                }
                listBox1.SelectedItems.Clear();
                


            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (Origen.Equals("Admin_Clases")) 
            {                
                if (myDia.Date >= DateTime.Now.Date)
                {                    
                    Form form = this.FindForm();
                    if (form != null)
                    {
                        frmClasesAdmin clasesAdmin = new frmClasesAdmin(myDia);
                        clasesAdmin.Show();
                        form.Close();
                    }                                        
                }   
            } 
        }
    }
}
