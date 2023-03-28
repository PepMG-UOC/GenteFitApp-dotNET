using GenteFitApp.Conrolers;
using GenteFitApp.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenteFitApp.Vistas
{
    public partial class frmImportExportXML : Form
    {
        public frmImportExportXML()
        {
            InitializeComponent();
        }
               
        private void cbTablaSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (cbTablaSelect.SelectedIndex)
            {
                case 0: //Monitor
                    dataGridView1.DataSource = null;
                    List<Monitor> listaMonitores = Usuarios.listarMonitores();
                    dataGridView1.DataSource = listaMonitores;
                    break;
                case 1: //Cliente
                    dataGridView1.DataSource = null;
                    List<Cliente> listaClientes = Usuarios.listarClientes();
                    dataGridView1.DataSource = listaClientes;
                    break;
                case 2: //Administrador
                    dataGridView1.DataSource = null;
                    List<Administrador> listaAdministradores = Usuarios.listarAdministradores();
                    dataGridView1.DataSource = listaAdministradores;
                    break;
                case 3: //Sala
                    dataGridView1.DataSource = null;
                    List<Sala> listaSalas = GestionCentro.listarSalas();
                    dataGridView1.DataSource = listaSalas;
                    break;
                case 4: //Actividad
                    dataGridView1.DataSource = null;
                    List<Actividad> listaActividades = GestionCentro.listarActividades();
                    dataGridView1.DataSource = listaActividades;
                    break;
                case 5: //Clase
                    dataGridView1.DataSource = null;
                    List<Clase> listaClases = GestionCentro.listarClases();
                    dataGridView1.DataSource = listaClases;
                    break;
                case 6: //Reserva
                    dataGridView1.DataSource = null;
                    List<Reserva> listaReservas = ConsultasBase.listarReservas();
                    dataGridView1.DataSource = listaReservas;
                    break;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {            
                string filePath;
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    filePath = folderBrowserDialog1.SelectedPath;
                    switch (cbTablaSelect.SelectedIndex)
                    {
                        case 0: //Monitor


                            break;
                        case 1: //Cliente

                            break;
                        case 2: //Administrador

                            break;
                        case 3: //Sala
                            filePath = Path.Combine(filePath, "Sala");
                            ConexionERP.crearXMLdeSala(filePath);
                            break;
                        case 4: //Actividad
                           
                            break;
                        case 5: //Clase
                           
                            break;
                        case 6: //Reserva
                           
                            break;
                    }


                }
                else
                {

                }


            
        }
    }
}
