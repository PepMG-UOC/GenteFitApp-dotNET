using GenteFitApp.Conrolers;
using System;
using System.IO;
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
            // Inicializo el folderBrowserdialog en la carpeta documentos del usuario.
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.SelectedPath = documentsPath;

            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            { 
                filePath = folderBrowserDialog1.SelectedPath;
                switch (cbTablaSelect.SelectedItem)
                {
                    case "Actividad":
                        filePath = Path.Combine(filePath, "Actividad.xml");
                        ConexionERP.ActividadToXML(filePath);
                        break;
                    case "Administrador":
                        filePath = Path.Combine(filePath, "Administrador.xml");
                        ConexionERP.AdministradorToXML(filePath);
                        break;
                    case "Clase":
                        filePath = Path.Combine(filePath, "Clase.xml");
                        ConexionERP.ClaseToXML(filePath);
                        break;
                    case "Cliente":
                        filePath = Path.Combine(filePath, "Cliente.xml");
                        ConexionERP.ClienteToXML(filePath);
                        break;
                    case "Monitor":
                        filePath = Path.Combine(filePath, "Monitor.xml");
                        ConexionERP.MonitorToXML(filePath);
                        break;
                    case "Persona":
                        filePath = Path.Combine(filePath, "Persona.xml");
                        ConexionERP.PersonaToXML(filePath);
                        break;
                    case "Reserva":
                        filePath = Path.Combine(filePath, "Reserva.xml");
                        ConexionERP.ReservaToXML(filePath);
                        break;
                    case "Sala":
                        filePath = Path.Combine(filePath, "Sala.xml");
                        ConexionERP.SalaToXML(filePath);
                        break;                    
                }
                MessageBox.Show("El archivo XML se a Exportado con exito.");
            }             
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string filePath;
            cbTablaSelect.SelectedItem = null;
            dataGridView1.DataSource = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                string fileName = Path.GetFileName(filePath);

                switch(fileName)
                {
                    case "Actividad.xml":
                        ConexionERP.XmlToActividad(filePath);
                        break;
                    case "Administrador.xml":
                        ConexionERP.XmlToAdministrador(filePath);
                        break;
                    case "Clase.xml":
                        ConexionERP.XmlToClase(filePath);
                        break;
                    case "Cliente.xml":
                        ConexionERP.XmlToCliente(filePath);
                        break;
                    case "Monitor.xml":
                        ConexionERP.XmlToMonitor(filePath);
                        break;
                    case "Persona.xml":
                        ConexionERP.XmlToPersona(filePath);
                        break;
                    case "Reserva.xml":
                        ConexionERP.XmlToReserva(filePath);
                        break;
                    case "Sala.xml":
                        ConexionERP.XmlToSala(filePath);
                        break;
                }
                MessageBox.Show("El archivo XML se a Importado con exito.");
            }            
        }
    }
}
