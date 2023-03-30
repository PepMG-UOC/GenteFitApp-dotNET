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
           
            switch (cbTablaSelect.SelectedIndex)
            {
                case 0: //Monitor
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Usuarios.listarMonitores();                    
                    break;
                case 1: //Cliente
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Usuarios.listarClientes();                    
                    break;
                case 2: //Administrador
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Usuarios.listarAdministradores();                    
                    break;
                case 3: //Sala
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = GestionCentro.listarSalas();                    
                    break;
                case 4: //Actividad
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = GestionCentro.listarActividades();
                    break;
                case 5: //Clase
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = GestionCentro.listarClases();
                    break;
                case 6: //Reserva
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ConsultasBase.listarReservas();
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
                switch (cbTablaSelect.SelectedIndex)
                    {
                        case 0: //Monitor


                            break;
                        case 1: //Cliente

                            break;
                        case 2: //Administrador

                            break;
                        case 3: //Sala
                            filePath = Path.Combine(filePath, "Sala.xml");
                            ConexionERP.XMLdeSala(filePath);
                            break;
                        case 4: //Actividad
                            filePath= Path.Combine(filePath, "Actividad.xml");
                            ConexionERP.XMLdeActividad(filePath);
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

        private void btnImport_Click(object sender, EventArgs e)
        {
            string filePath;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                string fileName = Path.GetFileName(filePath);

                switch(fileName)
                {
                    case "Monitor.xml":

                        break;
                    case "Cliente.xml":

                        break;
                    case "Administrador.xml":

                        break;
                    case "Sala.xml":
                        ConexionERP.updateBDDesdeXmlSala(filePath);
                        break;
                    case "Actividad.xml":
                        ConexionERP.updateBDDesdeXmlActividad(filePath);
                        break;
                    case "Clase.xml":

                        break;
                    case "Reserva.xml":

                        break;




                }

                
            }
            
        }
    }
}
