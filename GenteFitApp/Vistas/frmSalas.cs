﻿using System;
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
    public partial class frmSalas : Form
    {
        public frmSalas()
        {
            InitializeComponent();
        }

        private void resetCamposNEW()
        {
            tbPlazas.Text = "";
            tbDimension.Text = "";
        }

        private void resetCamposShow()
        {
            tbVnum.Text = "";
            tbVNPlazas.Text = "";
            tbVDimen.Text = "";
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = -1;
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                var idSalas = dBGfit.Sala.Select(s => s.id_Sala).ToList();
                comboBox1.DataSource = idSalas;
            }
            resetCamposNEW();
        }
        private void comboBox2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                var idSalas = dBGfit.Sala.Select(s => s.id_Sala).ToList();
                comboBox2.DataSource = idSalas;
            }
            resetCamposNEW();
            resetCamposShow();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            resetCamposShow();
            if (tbPlazas.Text!="")
            {
                GestionCentro.altaSala(int.Parse(tbPlazas.Text), int.Parse(tbDimension.Text));
                MessageBox.Show("La sala se ha creado correctamente.");
            } else
            {
                MessageBox.Show("Debes insertar el numero de plazas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Sala estaSala = new Sala();
            if (comboBox1.SelectedValue != null)
            {
                estaSala = GestionCentro.getSalaById((int)comboBox1.SelectedValue);
            }
            tbVnum.Text = estaSala.id_Sala.ToString();
            tbVNPlazas.Text = estaSala.numPlazas.ToString();
            tbVDimen.Text = estaSala.dimensionM2.ToString();
            comboBox1.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmGestionCentro gestionCentro= new frmGestionCentro();
            gestionCentro.Show();            
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {            
            if (comboBox2.SelectedValue != null)
            {
                if(GestionCentro.bajaSalaById((int)comboBox2.SelectedValue))
                {                   
                    MessageBox.Show("La sala se ha eliminado correctamente.");
                } else MessageBox.Show("La operacion no se ha realizado. ");
                comboBox2.SelectedIndex = -1;
            }
        }
    }
}
