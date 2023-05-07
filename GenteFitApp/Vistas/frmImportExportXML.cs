﻿using GenteFitApp.Conrolers;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GenteFitApp.Vistas
{
    public partial class frmImportExportXML : Form
    {
        public frmImportExportXML()
        {
            InitializeComponent();
        }

        private void frmImportExportXML_Load(object sender, EventArgs e)
        {
            ConexionERP.CheckAndCopyFiles();
        }

        private void cbTablaSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            switch (cbTablaSelect.SelectedItem)
            {
                case "Actividad":
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = GestionCentro.listarActividades();
                    break;
                case "Administrador":
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Usuarios.listarAdministradores();
                    break;
                case "Clase":
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = GestionCentro.listarClases();
                    break;
                case "Cliente":
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Usuarios.listarClientes();
                    break;
                case "Monitor":
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Usuarios.listarMonitores();                   
                    break;
                case "Persona":
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Usuarios.listarPersonas();
                    break;
                case "Reserva":
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ConsultasBase.listarReservas();
                    break;
                case "Sala":
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = GestionCentro.listarSalas();                    
                    break;   
            }
        }

       
        private void btnExport_Click(object sender, EventArgs e)
        {            
            string filePath;
            string resultMsg= string.Empty;
            // Inicializo el la ruta de los archivos en la carpeta Documentos por defecto del ordenador
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            filePath = documentsPath + @"\_XMLfiles";

            if (cbTablaSelect.SelectedIndex != -1) 
            { 
                switch (cbTablaSelect.SelectedItem)
                {
                    case "Actividad":
                        filePath = Path.Combine(filePath, "Actividad.xml");
                        ConexionERP.ActividadToXML(filePath);
                        resultMsg = ConexionERP.fromAppToOdoo(filePath);
                        break;
                    case "Administrador":
                        filePath = Path.Combine(filePath, "Administrador.xml");
                        ConexionERP.AdministradorToXML(filePath);
                        resultMsg = ConexionERP.fromAppToOdoo(filePath);
                        break;
                    case "Clase":
                        filePath = Path.Combine(filePath, "Clase.xml");
                        ConexionERP.ClaseToXML(filePath);
                        resultMsg = ConexionERP.fromAppToOdoo(filePath);
                        break;
                    case "Cliente":
                        filePath = Path.Combine(filePath, "Cliente.xml");
                        ConexionERP.ClienteToXML(filePath);
                        resultMsg = ConexionERP.fromAppToOdoo(filePath);
                        break;
                    case "Monitor":
                        filePath = Path.Combine(filePath, "Monitor.xml");
                        ConexionERP.MonitorToXML(filePath);
                        resultMsg = ConexionERP.fromAppToOdoo(filePath);
                        break;
                    case "Persona":
                        filePath = Path.Combine(filePath, "Persona.xml");
                        ConexionERP.PersonaToXML(filePath);
                        resultMsg = ConexionERP.fromAppToOdoo(filePath);
                        break;
                    case "Reserva":
                        filePath = Path.Combine(filePath, "Reserva.xml");
                        ConexionERP.ReservaToXML(filePath);
                        resultMsg = ConexionERP.fromAppToOdoo(filePath);
                        break;
                    case "Sala":
                        filePath = Path.Combine(filePath, "Sala.xml");
                        ConexionERP.SalaToXML(filePath);
                        resultMsg = ConexionERP.fromAppToOdoo(filePath);
                        break;                    
                }
                MessageBox.Show(resultMsg);
            } else MessageBox.Show("Seleccione una tabla de datos.");
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string filePath;
            string resultMsg = string.Empty;
            // Inicializo el la ruta de los archivos en la carpeta Documentos por defecto del ordenador
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            filePath = documentsPath + @"\_XMLfiles";

            if (cbTablaSelect.SelectedIndex != -1)
            {
                switch (cbTablaSelect.SelectedItem)
                {
                    case "Actividad":
                        filePath = Path.Combine(filePath, "Actividad.xml");
                        resultMsg = ConexionERP.fromOdooToApp(filePath);
                        ConexionERP.XmlToActividad(filePath);
                        break;
                    case "Administrador":
                        filePath = Path.Combine(filePath, "Administrador.xml");
                        resultMsg = ConexionERP.fromOdooToApp(filePath);
                        ConexionERP.XmlToAdministrador(filePath);                        
                        break;
                    case "Clase":
                        filePath = Path.Combine(filePath, "Clase.xml");
                        resultMsg = ConexionERP.fromOdooToApp(filePath);
                        ConexionERP.XmlToClase(filePath);                        
                        break;
                    case "Cliente":
                        filePath = Path.Combine(filePath, "Cliente.xml");
                        resultMsg = ConexionERP.fromOdooToApp(filePath);
                        ConexionERP.XmlToCliente(filePath);                        
                        break;
                    case "Monitor":
                        filePath = Path.Combine(filePath, "Monitor.xml");
                        resultMsg = ConexionERP.fromOdooToApp(filePath);
                        ConexionERP.XmlToMonitor(filePath);                        
                        break;
                    case "Persona":
                        filePath = Path.Combine(filePath, "Persona.xml");
                        resultMsg = ConexionERP.fromOdooToApp(filePath);
                        ConexionERP.XmlToPersona(filePath);                         
                        break;
                    case "Reserva":
                        filePath = Path.Combine(filePath, "Reserva.xml");
                        resultMsg = ConexionERP.fromOdooToApp(filePath);
                        ConexionERP.XmlToReserva(filePath);                        ;
                        break;
                    case "Sala":
                        filePath = Path.Combine(filePath, "Sala.xml");
                        resultMsg = ConexionERP.fromOdooToApp(filePath);
                        ConexionERP.XmlToSala(filePath);                                            
                        break;
                }
                dataGridView1.Refresh();
                MessageBox.Show(resultMsg);
            } else MessageBox.Show("Seleccione una tabla de datos.");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenuAdmin menuAdmin = new frmMenuAdmin();
            menuAdmin.Show();
            this.Close();
        }

        
    }
}
