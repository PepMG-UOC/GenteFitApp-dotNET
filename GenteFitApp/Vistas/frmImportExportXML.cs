using GenteFitApp.Conrolers;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToolTip = System.Windows.Forms.ToolTip;

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
            string fileTable;
            DialogResult result;
            string resultMsg= string.Empty;
            // Inicializo el la ruta de los archivos en la carpeta Documentos por defecto del ordenador
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            filePath = documentsPath + @"\_XMLfiles";

            if (cbTablaSelect.SelectedIndex != -1) 
            { 
                switch (cbTablaSelect.SelectedItem)
                {
                    case "Actividad":
                        result = MessageBox.Show("Al exportar Actividades tambien se exportaran Personas y monitores", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            fileTable = Path.Combine(filePath, "Persona.xml");
                            ConexionERP.PersonaToXML(fileTable);
                            resultMsg = ConexionERP.fromAppToOdoo(fileTable);
                            labelMsg.Text = resultMsg;
                            labelMsg.Visible = true;
                            this.Refresh();
                            fileTable = Path.Combine(filePath, "Monitor.xml");
                            ConexionERP.MonitorToXML(fileTable);
                            resultMsg = ConexionERP.fromAppToOdoo(fileTable);
                            labelMsg.Text = resultMsg;
                            labelMsg.Visible = true;
                            this.Refresh();
                            fileTable = Path.Combine(filePath, "Actividad.xml");
                            ConexionERP.ActividadToXML(fileTable);
                            resultMsg = ConexionERP.fromAppToOdoo(fileTable);
                            labelMsg.Visible = false;
                        }
                        else resultMsg = "Operación Cancelada.";
                        break;
                    case "Administrador":
                        result = MessageBox.Show("Al exportar Administradores tambien se exportaran Personas", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            fileTable = Path.Combine(filePath, "Persona.xml");
                            ConexionERP.PersonaToXML(fileTable);
                            resultMsg = ConexionERP.fromAppToOdoo(fileTable);
                            labelMsg.Text = resultMsg;
                            labelMsg.Visible = true;
                            this.Refresh();
                            fileTable = Path.Combine(filePath, "Administrador.xml");
                            ConexionERP.AdministradorToXML(fileTable);
                            resultMsg = ConexionERP.fromAppToOdoo(fileTable);
                            labelMsg.Visible = false;
                        }
                        else resultMsg = "Operación Cancelada.";
                        break;
                    case "Clase":
                        result = MessageBox.Show("Al exportar Clases tambien se exportaran Personas, Monitores, Actividades y Salas.", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            fileTable = Path.Combine(filePath, "Sala.xml");
                            ConexionERP.SalaToXML(fileTable);
                            resultMsg = ConexionERP.fromAppToOdoo(fileTable);
                            labelMsg.Text = resultMsg;
                            labelMsg.Visible = true;
                            this.Refresh();
                            fileTable = Path.Combine(filePath, "Persona.xml");
                            ConexionERP.PersonaToXML(fileTable);
                            resultMsg = ConexionERP.fromAppToOdoo(fileTable);
                            labelMsg.Text = resultMsg;
                            labelMsg.Visible = true;
                            this.Refresh();
                            fileTable = Path.Combine(filePath, "Monitor.xml");
                            ConexionERP.MonitorToXML(fileTable);
                            resultMsg = ConexionERP.fromAppToOdoo(fileTable);
                            labelMsg.Text = resultMsg;
                            labelMsg.Visible = true;
                            this.Refresh();
                            fileTable = Path.Combine(filePath, "Actividad.xml");
                            ConexionERP.ActividadToXML(fileTable);
                            resultMsg = ConexionERP.fromAppToOdoo(fileTable);
                            labelMsg.Text = resultMsg;
                            labelMsg.Visible = true;
                            this.Refresh();
                            fileTable = Path.Combine(filePath, "Clase.xml");
                            ConexionERP.ClaseToXML(fileTable);
                            resultMsg = ConexionERP.fromAppToOdoo(fileTable);
                            labelMsg.Visible = false;
                        }
                        else resultMsg = "Operación Cancelada.";
                        break;
                    case "Cliente":
                        result = MessageBox.Show("Al exportar Clientes tambien se exportaran Personas", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            fileTable = Path.Combine(filePath, "Persona.xml");
                            ConexionERP.PersonaToXML(fileTable);
                            resultMsg = ConexionERP.fromAppToOdoo(fileTable);
                            labelMsg.Text = resultMsg;
                            labelMsg.Visible = true;
                            this.Refresh();
                            fileTable = Path.Combine(filePath, "Cliente.xml");
                            ConexionERP.ClienteToXML(fileTable);
                            resultMsg = ConexionERP.fromAppToOdoo(fileTable);
                            labelMsg.Visible = false;
                        }
                        else resultMsg = "Operación Cancelada.";
                        break;
                    case "Monitor":
                        result = MessageBox.Show("Al exportar Monitores tambien se exportaran Personas", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            fileTable = Path.Combine(filePath, "Persona.xml");
                            ConexionERP.PersonaToXML(fileTable);
                            resultMsg = ConexionERP.fromAppToOdoo(fileTable);
                            labelMsg.Text = resultMsg;
                            labelMsg.Visible = true;
                            this.Refresh();
                            fileTable = Path.Combine(filePath, "Monitor.xml");
                            ConexionERP.MonitorToXML(fileTable);
                            resultMsg = ConexionERP.fromAppToOdoo(fileTable);
                            labelMsg.Visible = false;
                        }
                        else resultMsg = "Operación Cancelada.";
                        break;
                    case "Persona":
                        fileTable = Path.Combine(filePath, "Persona.xml");
                        ConexionERP.PersonaToXML(fileTable);
                        resultMsg = ConexionERP.fromAppToOdoo(fileTable);
                        labelMsg.Visible = false;
                        break;
                    case "Reserva":
                        result = MessageBox.Show("Al exportar Reservas tambien se exportaran Clases,Personas, Monitores, Actividades y Salas.", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            fileTable = Path.Combine(filePath, "Sala.xml");
                            ConexionERP.SalaToXML(fileTable);
                            resultMsg = ConexionERP.fromAppToOdoo(fileTable);
                            labelMsg.Text = resultMsg;
                            labelMsg.Visible = true;
                            this.Refresh();
                            fileTable = Path.Combine(filePath, "Persona.xml");
                            ConexionERP.PersonaToXML(fileTable);
                            resultMsg = ConexionERP.fromAppToOdoo(fileTable);
                            labelMsg.Text = resultMsg;
                            labelMsg.Visible = true;
                            this.Refresh();
                            fileTable = Path.Combine(filePath, "Monitor.xml");
                            ConexionERP.MonitorToXML(fileTable);
                            resultMsg = ConexionERP.fromAppToOdoo(fileTable);
                            labelMsg.Text = resultMsg;
                            labelMsg.Visible = true;
                            this.Refresh();
                            fileTable = Path.Combine(filePath, "Actividad.xml");
                            ConexionERP.ActividadToXML(fileTable);
                            resultMsg = ConexionERP.fromAppToOdoo(fileTable);
                            labelMsg.Text = resultMsg;
                            labelMsg.Visible = true;
                            this.Refresh();
                            fileTable = Path.Combine(filePath, "Clase.xml");
                            ConexionERP.ClaseToXML(fileTable);
                            resultMsg = ConexionERP.fromAppToOdoo(fileTable);
                            labelMsg.Text = resultMsg;
                            labelMsg.Visible = true;
                            this.Refresh();
                            fileTable = Path.Combine(filePath, "Reserva.xml");
                            ConexionERP.ReservaToXML(fileTable);
                            resultMsg = ConexionERP.fromAppToOdoo(fileTable);
                            labelMsg.Visible = false;
                        }
                        else resultMsg = "Operación Cancelada.";
                        break;
                    case "Sala":
                        fileTable = Path.Combine(filePath, "Sala.xml");
                        ConexionERP.SalaToXML(fileTable);
                        resultMsg = ConexionERP.fromAppToOdoo(fileTable);
                        labelMsg.Visible = false;
                        break;                    
                }
                MessageBox.Show(resultMsg);
            } else MessageBox.Show("Seleccione una tabla de datos.");
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string filePath;
            string fileTable;
            DialogResult result;
            string resultMsg = string.Empty;
            // Inicializo el la ruta de los archivos en la carpeta Documentos por defecto del ordenador
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            filePath = documentsPath + @"\_XMLfiles";

            if (cbTablaSelect.SelectedIndex != -1)
            {
                switch (cbTablaSelect.SelectedItem)
                {
                    case "Actividad":
                        result = MessageBox.Show("Al importar Actividades tambien se importaran Personas y monitores", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            fileTable = Path.Combine(filePath, "Persona.xml");
                            resultMsg = ConexionERP.fromOdooToApp(fileTable);
                            ConexionERP.XmlToPersona(fileTable);
                            labelMsg.Text = resultMsg;
                            labelMsg.Visible = true;
                            this.Refresh();
                            fileTable = Path.Combine(filePath, "Monitor.xml");
                            resultMsg = ConexionERP.fromOdooToApp(fileTable);
                            ConexionERP.XmlToMonitor(fileTable);
                            labelMsg.Text = resultMsg;
                            labelMsg.Visible = true;
                            this.Refresh();
                            filePath = Path.Combine(filePath, "Actividad.xml");
                            resultMsg = ConexionERP.fromOdooToApp(filePath);
                            ConexionERP.XmlToActividad(filePath);
                            labelMsg.Visible = false;
                        }
                        else resultMsg = "Operación Cancelada.";
                        break;
                    case "Administrador":
                        result = MessageBox.Show("Al importar Administradores tambien se importaran Personas", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            fileTable = Path.Combine(filePath, "Persona.xml");
                            resultMsg = ConexionERP.fromOdooToApp(fileTable);
                            ConexionERP.XmlToPersona(fileTable);
                            labelMsg.Text = resultMsg;
                            labelMsg.Visible = true;
                            this.Refresh();
                            filePath = Path.Combine(filePath, "Administrador.xml");
                            resultMsg = ConexionERP.fromOdooToApp(filePath);
                            ConexionERP.XmlToAdministrador(filePath);
                            labelMsg.Visible = false;
                        }
                        else resultMsg = "Operación Cancelada.";
                        break;
                    case "Clase":
                        result = MessageBox.Show("Al importar Clases tambien se importaran Personas, Monitores, Actividades y Salas.", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            fileTable = Path.Combine(filePath, "Persona.xml");
                            resultMsg = ConexionERP.fromOdooToApp(fileTable);
                            ConexionERP.XmlToPersona(fileTable);
                            labelMsg.Text = resultMsg;
                            labelMsg.Visible = true;
                            this.Refresh();
                            fileTable = Path.Combine(filePath, "Monitor.xml");
                            resultMsg = ConexionERP.fromOdooToApp(fileTable);
                            ConexionERP.XmlToMonitor(fileTable);
                            labelMsg.Text = resultMsg;
                            labelMsg.Visible = true;
                            this.Refresh();
                            fileTable = Path.Combine(filePath, "Actividad.xml");
                            resultMsg = ConexionERP.fromOdooToApp(fileTable);
                            ConexionERP.XmlToActividad(fileTable);
                            labelMsg.Text = resultMsg;
                            labelMsg.Visible = true;
                            this.Refresh();
                            fileTable = Path.Combine(filePath, "Sala.xml");
                            resultMsg = ConexionERP.fromOdooToApp(fileTable);
                            ConexionERP.XmlToSala(fileTable);
                            labelMsg.Text = resultMsg;
                            labelMsg.Visible = true;
                            this.Refresh();
                            filePath = Path.Combine(filePath, "Clase.xml");
                            resultMsg = ConexionERP.fromOdooToApp(filePath);
                            ConexionERP.XmlToClase(filePath);
                            labelMsg.Visible = false;
                        }
                        else resultMsg = "Operación Cancelada.";
                        break;
                    case "Cliente":
                        result = MessageBox.Show("Al importar Clientes tambien se importaran Personas", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            fileTable = Path.Combine(filePath, "Persona.xml");
                            resultMsg = ConexionERP.fromOdooToApp(fileTable);
                            ConexionERP.XmlToPersona(fileTable);
                            labelMsg.Text = resultMsg;
                            labelMsg.Visible = true;
                            this.Refresh();
                            filePath = Path.Combine(filePath, "Cliente.xml");
                            resultMsg = ConexionERP.fromOdooToApp(filePath);
                            ConexionERP.XmlToCliente(filePath);
                            labelMsg.Visible = false;
                        }
                        else resultMsg = "Operación Cancelada.";
                        break;
                    case "Monitor":
                        result = MessageBox.Show("Al importar Monitores tambien se importaran Personas", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            fileTable = Path.Combine(filePath, "Persona.xml");
                            resultMsg = ConexionERP.fromOdooToApp(fileTable);
                            ConexionERP.XmlToPersona(fileTable);
                            labelMsg.Text = resultMsg;
                            labelMsg.Visible = true;
                            this.Refresh();
                            filePath = Path.Combine(filePath, "Monitor.xml");
                            resultMsg = ConexionERP.fromOdooToApp(filePath);
                            ConexionERP.XmlToMonitor(filePath);
                            labelMsg.Visible = false;
                        }
                        else resultMsg = "Operación Cancelada.";
                        break;
                    case "Persona":
                        filePath = Path.Combine(filePath, "Persona.xml");
                        resultMsg = ConexionERP.fromOdooToApp(filePath);
                        ConexionERP.XmlToPersona(filePath);                         
                        break;
                    case "Reserva":
                        result = MessageBox.Show("Al importar Reservas tambien se importaran Clases,Personas, Monitores, Actividades y Salas.", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            fileTable = Path.Combine(filePath, "Persona.xml");
                            resultMsg = ConexionERP.fromOdooToApp(fileTable);
                            ConexionERP.XmlToPersona(fileTable);
                            labelMsg.Text = resultMsg;
                            labelMsg.Visible = true;
                            this.Refresh();
                            fileTable = Path.Combine(filePath, "Monitor.xml");
                            resultMsg = ConexionERP.fromOdooToApp(fileTable);
                            ConexionERP.XmlToMonitor(fileTable);
                            labelMsg.Text = resultMsg;
                            labelMsg.Visible = true;
                            this.Refresh();
                            fileTable = Path.Combine(filePath, "Actividad.xml");
                            resultMsg = ConexionERP.fromOdooToApp(fileTable);
                            ConexionERP.XmlToActividad(fileTable);
                            labelMsg.Text = resultMsg;
                            labelMsg.Visible = true;
                            this.Refresh();
                            fileTable = Path.Combine(filePath, "Sala.xml");
                            resultMsg = ConexionERP.fromOdooToApp(fileTable);
                            ConexionERP.XmlToSala(fileTable);
                            labelMsg.Text = resultMsg;
                            labelMsg.Visible = true;
                            this.Refresh();
                            fileTable = Path.Combine(filePath, "Clase.xml");
                            resultMsg = ConexionERP.fromOdooToApp(fileTable);
                            ConexionERP.XmlToClase(fileTable);
                            labelMsg.Text = resultMsg;
                            labelMsg.Visible = true;
                            this.Refresh();
                            filePath = Path.Combine(filePath, "Reserva.xml");
                            resultMsg = ConexionERP.fromOdooToApp(filePath);
                            ConexionERP.XmlToReserva(filePath);
                            labelMsg.Visible = false;
                        }
                        else resultMsg = "Operación Cancelada.";
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
