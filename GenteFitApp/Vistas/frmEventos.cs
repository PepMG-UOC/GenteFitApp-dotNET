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
    public partial class frmEventos : Form
    {
        private Clase estaClase;
        private Reserva miReserva;
        private Cliente cliente;        
        private int numReservas;
        public frmEventos(int IDClase, Color miColor)
        {
            InitializeComponent();
            this.estaClase = ConsultasBase.getClasebyID(IDClase);
            BackColor = miColor;
        }

        private void frmEventos_Load(object sender, EventArgs e)
        {
            txtbxActividad.Text = estaClase.Actividad.nombre;
            txtbxFecha.Text = estaClase.fechaHora.ToString("dd/MM/yyyy");
            txtbxHora.Text = estaClase.fechaHora.ToString("HH:mm");
            txtbxDescrip.Text = estaClase.Actividad.descripcion;
            txtbxAforo.Text = estaClase.Sala.numPlazas.ToString();
            numReservas = ConsultasBase.reservasDeClase(estaClase);
            cliente = Usuarios.getClienteDePersona(Session.idPersona);            
            
            if (cliente != null)
            {
                miReserva = EventosCalendar.getReservaClaseCliente(estaClase.id_Clase, cliente.id_Cliente);
                // Calcular plazas
                if (miReserva != null)
                {
                    btnApunta.Visible = false;
                    btnDesapunta.Visible = true;
                }
                else
                {
                    btnApunta.Visible = true;
                    btnDesapunta.Visible = false;
                }
                if (estaClase.Sala.numPlazas >= numReservas)
                {
                    txtbxPlazas.Text = (estaClase.Sala.numPlazas - numReservas).ToString();
                }
                else
                {
                    txtbxPlazas.Text = "";
                    txtbxListaEspera.Text = (numReservas - estaClase.Sala.numPlazas).ToString();
                }
            }
                     

        }

        private void btnApunta_Click(object sender, EventArgs e)
        {
            Reserva nuevaReserva = new Reserva();
            nuevaReserva.posicion = numReservas + 1;
            nuevaReserva.claseID = estaClase.id_Clase;
            nuevaReserva.clienteID = cliente.id_Cliente;
            if (nuevaReserva.posicion <= estaClase.Sala.numPlazas) nuevaReserva.confirmada = true;
            else nuevaReserva.confirmada = false;
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                dBGfit.Reserva.Add(nuevaReserva);
                dBGfit.SaveChanges();
                MessageBox.Show("Reserva correctamente");
                this.Close();
            }
        }

        private void btnDesapunta_Click(object sender, EventArgs e)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                if (miReserva != null)
                {
                    dBGfit.Reserva.Attach(miReserva);
                    dBGfit.Reserva.Remove(miReserva);
                    dBGfit.SaveChanges();
                    MessageBox.Show("Reserva eliminada correctamente");
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                
    }
}
