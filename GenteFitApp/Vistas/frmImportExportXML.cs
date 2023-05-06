using GenteFitApp.Conrolers;
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
                        ConexionERP.fromAppToOdoo(filePath);
                        break;
                    case "Administrador":
                        filePath = Path.Combine(filePath, "Administrador.xml");
                        ConexionERP.AdministradorToXML(filePath);
                        ConexionERP.fromAppToOdoo(filePath);
                        break;
                    case "Clase":
                        filePath = Path.Combine(filePath, "Clase.xml");
                        ConexionERP.ClaseToXML(filePath);
                        ConexionERP.fromAppToOdoo(filePath);
                        break;
                    case "Cliente":
                        filePath = Path.Combine(filePath, "Cliente.xml");
                        ConexionERP.ClienteToXML(filePath);
                        ConexionERP.fromAppToOdoo(filePath);
                        break;
                    case "Monitor":
                        filePath = Path.Combine(filePath, "Monitor.xml");
                        ConexionERP.MonitorToXML(filePath);
                        ConexionERP.fromAppToOdoo(filePath);
                        break;
                    case "Persona":
                        filePath = Path.Combine(filePath, "Persona.xml");
                        ConexionERP.PersonaToXML(filePath);
                        ConexionERP.fromAppToOdoo(filePath);
                        break;
                    case "Reserva":
                        filePath = Path.Combine(filePath, "Reserva.xml");
                        ConexionERP.ReservaToXML(filePath);
                        ConexionERP.fromAppToOdoo(filePath);
                        break;
                    case "Sala":
                        filePath = Path.Combine(filePath, "Sala.xml");
                        ConexionERP.SalaToXML(filePath);
                        ConexionERP.fromAppToOdoo(filePath);
                        break;                    
                }
                MessageBox.Show("El archivo XML se a Exportado con exito.");
            } else MessageBox.Show("Seleccione una tabla de datos.");
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string filePath;
            // Inicializo el la ruta de los archivos en la carpeta Documentos por defecto del ordenador
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            filePath = documentsPath + @"\_XMLfiles";

            if (cbTablaSelect.SelectedIndex != -1)
            {
                switch (cbTablaSelect.SelectedItem)
                {
                    case "Actividad":
                        ConexionERP.XmlToActividad(filePath + @"\Actividad.xml");
                        break;
                    case "Administrador":
                        ConexionERP.XmlToAdministrador(filePath + @"\Administrador.xml");
                        break;
                    case "Clase":
                        ConexionERP.XmlToClase(filePath + @"\Clase.xml");
                        break;
                    case "Cliente":
                        ConexionERP.XmlToCliente(filePath + @"\Cliente.xml");
                        break;
                    case "Monitor":
                        ConexionERP.XmlToMonitor(filePath + @"\Monitor.xml");
                        break;
                    case "Persona":
                        ConexionERP.XmlToPersona(filePath + @"\Persona.xml");
                        break;
                    case "Reserva":
                        ConexionERP.XmlToReserva(filePath + @"\Reserva.xml");
                        break;
                    case "Sala":
                        ConexionERP.XmlToSala(filePath + @"\Sala.xml");
                        break;
                }
                MessageBox.Show("El archivo XML se a Importado con exito.");
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
