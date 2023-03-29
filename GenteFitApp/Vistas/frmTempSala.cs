using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenteFitApp.Conrolers;
using GenteFitApp.Modelo;

namespace GenteFitApp.Vistas
{
    public partial class frmTempSala : Form
    {
        public frmTempSala()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (tbPlazas.Text!="")
            {
                GestionCentro.altaSala(int.Parse(tbPlazas.Text), int.Parse(tbDimension.Text));
            } else
            {
                MessageBox.Show("Debes insertar el numero de plazas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Sala estaSala = new Sala();
            if (tbPedirSala.Text!="")
            {
                estaSala = GestionCentro.getSala(int.Parse(tbPedirSala.Text));
            }
            tbVnum.Text = estaSala.id_Sala.ToString();
            tbVNPlazas.Text = estaSala.numPlazas.ToString();
            tbVDimen.Text =estaSala.dimensionM2.ToString();

        }
    }
}
