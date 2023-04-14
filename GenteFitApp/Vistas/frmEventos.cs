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
        private ClaseEvento estaClase;
        public frmEventos(ClaseEvento estaClase)
        {
            InitializeComponent();
            this.estaClase = estaClase;
        }

        private void frmEventos_Load(object sender, EventArgs e)
        {
            //txtbxFecha.Text = frmCalendario.dia + "/" + frmCalendario.mes + "/" +  frmCalendario.año;
            txtbxActividad.Text = estaClase.nombreActividad.ToString();
            txtbxFecha.Text = estaClase.fechaHora.ToString("dd/MM/yyyy");
            txtbxHora.Text = estaClase.fechaHora.ToString("HH:mm");
            txtbxDescrip.Text = estaClase.descripcionActividad.ToString();
            txtbxAforo.Text = estaClase.numPlazasSala.ToString();
            // Calcular plazas
            if (estaClase.numPlazasSala >= estaClase.numReservas)
            {
                txtbxPlazas.Text = (estaClase.numPlazasSala - estaClase.numReservas).ToString();
            } else
            {
                txtbxPlazas.Text = "0";
                txtbxListaEspera.Text = (estaClase.numReservas - estaClase.numPlazasSala).ToString();
            }           

        }
    }
}
