﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GenteFitApp
{
    public partial class frmEventos : Form
    {
        public frmEventos()
        {
            InitializeComponent();
        }

        private void frmEventos_Load(object sender, EventArgs e)
        {
            txtbxFecha.Text = UserControlDias.static_dia + "/" + frmCalendario.static_mes + "/" +  frmCalendario.static_año;
        }
    }
}
