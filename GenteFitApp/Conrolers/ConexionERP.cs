using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenteFitApp.Modelo;
using System.Xml.Serialization;
using System.IO;
using System.Data.Entity;
using System.Xml;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Globalization;

namespace GenteFitApp.Conrolers
{
    public class ConexionERP
    {
        public static void CheckAndCopyFiles()
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string folderPath = Path.Combine(documentsPath, "_XMLfiles");
            string[] fileNames = { 
                "FromAppToOdooSala.py",
                "FromAppToOdooClase.py",
                "FromAppToOdooPersona.py",
                "FromAppToOdooMonitor.py",
                "FromAppToOdooReserva.py",
                "FromAppToOdooCliente.py",
                "FromAppToOdooAdministrador.py",
                "FromAppToOdooActividad.py",
                "FromOdooToAppActividad.py",
                "FromOdooToAppAdministrador.py",
                "FromOdooToAppClase.py",
                "FromOdooToAppCliente.py",
                "FromOdooToAppMonitor.py",
                "FromOdooToAppPersona.py",
                "FromOdooToAppReserva.py",
                "FromOdooToAppSala.py" };

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            foreach (string fileName in fileNames)
            {
                string filePath = Path.Combine(folderPath, fileName);

                if (!File.Exists(filePath))
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    string resourceName = "GenteFitApp.Resources." + fileName;

                    using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                    {
                        using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            stream.CopyTo(fileStream);
                        }
                    }
                }
            }
        }

        public static string fromAppToOdoo(string filePath)
        {
            if (File.Exists(filePath))
            {
                string ruta = Path.GetDirectoryName(filePath);
                string tablaName = Path.GetFileNameWithoutExtension(filePath);
                var scripName = ruta + @"\FromAppToOdoo" + tablaName + ".py";
                var ejecutaPY = new ProcessStartInfo();
                string rutaPython = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Programs", "Python", "Python310", "python.exe");
                ejecutaPY.FileName = rutaPython;

                ejecutaPY.Arguments = $"\"{scripName}\"";
                Process bgrProceso = new Process();
                bgrProceso.StartInfo = ejecutaPY;
                bgrProceso.StartInfo.UseShellExecute = false;
                bgrProceso.StartInfo.RedirectStandardInput = true;
                bgrProceso.StartInfo.RedirectStandardOutput = true;
                bgrProceso.StartInfo.CreateNoWindow = true;
                Cursor.Current = Cursors.WaitCursor;
                bgrProceso.Start();
                string resultMsg = bgrProceso.StandardOutput.ReadToEnd();
                bgrProceso.WaitForExit();
                Cursor.Current = Cursors.Default;
                return resultMsg;
            }
            else return "No hay datos en la tabla.";             

        }

        public static string fromOdooToApp(string filePath)
        {
            string ruta = Path.GetDirectoryName(filePath);
            string tablaName = Path.GetFileNameWithoutExtension(filePath);
            var scripName = ruta + @"\FromOdooToApp" + tablaName + ".py";
            var ejecutaPY = new ProcessStartInfo();            
            string rutaPython = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Programs", "Python", "Python310", "python.exe");
            ejecutaPY.FileName = rutaPython;

            ejecutaPY.Arguments = $"\"{scripName}\"";
            Process bgrProceso = new Process();
            bgrProceso.StartInfo = ejecutaPY;
            bgrProceso.StartInfo.UseShellExecute = false;
            bgrProceso.StartInfo.RedirectStandardInput = true;
            bgrProceso.StartInfo.RedirectStandardOutput = true;
            bgrProceso.StartInfo.CreateNoWindow = true;
            Cursor.Current = Cursors.WaitCursor;
            bgrProceso.Start();
            string resultMsg = bgrProceso.StandardOutput.ReadToEnd();
            bgrProceso.WaitForExit();
            Cursor.Current = Cursors.Default;
            return resultMsg;

        }


        public static void  ActividadToXML(string filePath)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                // Recuperamos el objeto lista de objetos ActividadView
                List<ActividadView> listaActividades = GestionCentro.listarActividades();
                if(listaActividades.Count > 0)
                {
                    // Serializar el objeto (lista) en formato XML
                    XmlSerializer serializer = new XmlSerializer(typeof(List<ActividadView>), new XmlRootAttribute("ActividadLst"));
                    using (TextWriter writer = new StreamWriter(filePath))
                    {
                        serializer.Serialize(writer, listaActividades);
                    }
                }
                
            }
        }

        public static void AdministradorToXML(string filePath)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                List<AdministradorView> listaAdministradores = Usuarios.listarAdministradores();
                if(listaAdministradores.Count > 0)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<AdministradorView>), new XmlRootAttribute("AdministradorLst"));
                    using (TextWriter writer = new StreamWriter(filePath))
                    {
                        serializer.Serialize(writer, listaAdministradores);
                    }
                }
                
            }
        }

        public static void ClaseToXML(string filePath)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                List<ClaseView> listaClases = GestionCentro.listarClases();
                if(listaClases.Count > 0)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<ClaseView>), new XmlRootAttribute("ClaseLst"));
                    using (TextWriter writer = new StreamWriter(filePath))
                    {
                        serializer.Serialize(writer, listaClases);
                    }
                }
                
            }
        }

        public static void ClienteToXML(string filePath)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                List<ClienteView> listaClientes = Usuarios.listarClientes();
                if(listaClientes.Count > 0)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<ClienteView>), new XmlRootAttribute("ClienteLst"));
                    using (TextWriter writer = new StreamWriter(filePath))
                    {
                        serializer.Serialize(writer, listaClientes);
                    }
                }
                
            }
        }

        public static void MonitorToXML(string filePath)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                List<MonitorView> listaMonitores = Usuarios.listarMonitores();
                if(listaMonitores.Count > 0)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<MonitorView>), new XmlRootAttribute("MonitorLst"));
                    using (TextWriter writer = new StreamWriter(filePath))
                    {
                        serializer.Serialize(writer, listaMonitores);
                    }
                }
                
            }
        }

        public static void PersonaToXML(string filePath)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                List<PersonaView> listaPersonas = Usuarios.listarPersonas();
                if(listaPersonas.Count > 0)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<PersonaView>), new XmlRootAttribute("PersonaLst"));
                    using (TextWriter writer = new StreamWriter(filePath))
                    {
                        serializer.Serialize(writer, listaPersonas);
                    }
                }
                
            }
        }

        public static void ReservaToXML(string filePath)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                List<ReservaView> listaReservas = ConsultasBase.listarReservas();   
                if(listaReservas.Count > 0)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<ReservaView>), new XmlRootAttribute("ReservaLst"));
                    using (TextWriter writer = new StreamWriter(filePath))
                    {
                        serializer.Serialize(writer, listaReservas);
                    }
                }
                
            }
        }

        public static void SalaToXML(string filePath)
        {
            using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
            {
                List<SalaView> listaSalas = GestionCentro.listarSalas(); 
                if(listaSalas.Count > 0)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<SalaView>), new XmlRootAttribute("SalaLst"));
                    using (TextWriter writer = new StreamWriter(filePath))
                    {
                        serializer.Serialize(writer, listaSalas);
                    }
                }
                
            }
        }



        public static void XmlToActividad(string filePath)
        {
            ActividadLst ActividadXmlLst = new ActividadLst();
            XmlSerializer serializer = new XmlSerializer(typeof(ActividadLst));
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    ActividadXmlLst = (ActividadLst)serializer.Deserialize(reader);
                }

                using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
                {
                    // Recuperar todas las Actividades de la BD
                    var ActividadBDLst = dBGfit.Actividad.ToList();
                    foreach (var ActividadXml in ActividadXmlLst.Actividades)
                    {
                        // Buscar si la Actividad ya existe en la BD
                        var ActividadBD = ActividadBDLst.FirstOrDefault(s => s.id_Actividad == ActividadXml.id_Actividad);
                        if (ActividadBD != null)
                        {
                            // Actualiza los datos
                            ActividadBD.nombre = ActividadXml.nombre;
                            ActividadBD.descripcion = ActividadXml.descripcion;
                            ActividadBD.monitorID = ActividadXml.monitorID;
                            dBGfit.Entry(ActividadBD).State = EntityState.Modified;
                        }
                        else
                        {
                            // La Actividad no existe en la BD, crear un nuevo objeto Actividad y agregarlo
                            var ActividadNueva = new Actividad
                            {
                                id_Actividad = ActividadXml.id_Actividad,
                                nombre = ActividadXml.nombre,
                                descripcion = ActividadXml.descripcion,
                                monitorID = ActividadXml.monitorID
                            };
                            dBGfit.Actividad.Add(ActividadNueva);
                        }
                    }
                    //// Eliminar las Actividades de la BD que no aparecen en el archivo XML
                    //foreach (var ActividadBD in ActividadBDLst)
                    //{
                    //    var ActividadXml = ActividadXmlLst.Actividades.FirstOrDefault(s => s.id_Actividad == ActividadBD.id_Actividad);
                    //    if (ActividadXml == null)
                    //    {
                    //        dBGfit.Actividad.Remove(ActividadBD);
                    //    }
                    //}
                    // Guardar los cambios en la BD
                    dBGfit.SaveChanges();
                }
            }
            
        }

        public static void XmlToAdministrador(string filePath)
        {
            AdministradorLst AdministradorXmlLst = new AdministradorLst();
            XmlSerializer serializer = new XmlSerializer(typeof(AdministradorLst));
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    AdministradorXmlLst = (AdministradorLst)serializer.Deserialize(reader);
                }

                using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
                {
                    // Recuperar de la BD
                    var AdministradorBDLst = dBGfit.Administrador.ToList();
                    foreach (var AdministradorXml in AdministradorXmlLst.Administradores)
                    {
                        // Buscar si existe.
                        var AdministradorBD = AdministradorBDLst.FirstOrDefault(s => s.id_Admin == AdministradorXml.id_Admin);
                        if (AdministradorBD != null)
                        {
                            // Actualiza los datos
                            AdministradorBD.personaID = AdministradorXml.personaID;
                            dBGfit.Entry(AdministradorBD).State = EntityState.Modified;
                        }
                        else
                        {
                            // Crear nuevo
                            var AdministradorNueva = new Administrador
                            {
                                id_Admin = AdministradorXml.id_Admin,
                                personaID = AdministradorXml.personaID
                            };
                            dBGfit.Administrador.Add(AdministradorNueva);
                        }
                    }
                    //// Eliminar 
                    //foreach (var AdministradorBD in AdministradorBDLst)
                    //{
                    //    var AdministradorXml = AdministradorXmlLst.Administradores.FirstOrDefault(s => s.id_Admin == AdministradorBD.id_Admin);
                    //    if (AdministradorXml == null)
                    //    {
                    //        dBGfit.Administrador.Remove(AdministradorBD);
                    //    }
                    //}
                    // Guardar 
                    dBGfit.SaveChanges();
                }
            }
            
        }

        public static void XmlToClase(string filePath)
        {
            ClaseLst ClaseXmlLst = new ClaseLst();
            XmlSerializer serializer = new XmlSerializer(typeof(ClaseLst));
            if (File.Exists(filePath)) 
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    ClaseXmlLst = (ClaseLst)serializer.Deserialize(reader);
                }

                using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
                {
                    // Recuperar de la BD
                    var ClaseBDLst = dBGfit.Clase.ToList();
                    foreach (var ClaseXml in ClaseXmlLst.Clases)
                    {
                        // Buscar si existe.
                        var ClaseBD = ClaseBDLst.FirstOrDefault(s => s.id_Clase == ClaseXml.id_Clase);
                        if (ClaseBD != null)
                        {
                            // Actualiza los datos
                            ClaseBD.actividadID = ClaseXml.actividadID;
                            ClaseBD.salaID = ClaseXml.salaID;
                            ClaseBD.fechaHora = ClaseXml.fechaHora;

                            dBGfit.Entry(ClaseBD).State = EntityState.Modified;
                        }
                        else
                        {
                            // Crear nuevo
                            var ClaseNueva = new Clase
                            {
                                id_Clase = ClaseXml.id_Clase,
                                actividadID = ClaseXml.actividadID,
                                salaID = ClaseXml.salaID,
                                fechaHora = ClaseXml.fechaHora
                            };
                            dBGfit.Clase.Add(ClaseNueva);
                        }
                    }
                    //// Eliminar 
                    //foreach (var ClaseBD in ClaseBDLst)
                    //{
                    //    var ClaseXml = ClaseXmlLst.Clases.FirstOrDefault(s => s.id_Clase == ClaseBD.id_Clase);
                    //    if (ClaseXml == null)
                    //    {
                    //        dBGfit.Clase.Remove(ClaseBD);
                    //    }
                    //}
                    // Guardar 
                    dBGfit.SaveChanges();
                }
            }
            
        }

        public static void XmlToCliente(string filePath)
        {
            ClienteLst ClienteXmlLst = new ClienteLst();
            XmlSerializer serializer = new XmlSerializer(typeof(ClienteLst));
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    ClienteXmlLst = (ClienteLst)serializer.Deserialize(reader);
                }

                using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
                {
                    // Recuperar de la BD
                    var ClienteBDLst = dBGfit.Cliente.ToList();
                    foreach (var ClienteXml in ClienteXmlLst.Clientes)
                    {
                        // Buscar si existe.
                        var ClienteBD = ClienteBDLst.FirstOrDefault(s => s.id_Cliente == ClienteXml.id_Cliente);
                        if (ClienteBD != null)
                        {
                            // Actualiza los datos
                            ClienteBD.personaID = ClienteXml.personaID;
                            ClienteBD.fechaAlta = ClienteXml.fechaAlta;

                            dBGfit.Entry(ClienteBD).State = EntityState.Modified;
                        }
                        else
                        {
                            // Crear nuevo
                            var ClienteNueva = new Cliente
                            {
                                id_Cliente = ClienteXml.id_Cliente,
                                personaID = ClienteXml.personaID,
                                fechaAlta = ClienteXml.fechaAlta

                            };
                            dBGfit.Cliente.Add(ClienteNueva);
                        }
                    }
                    //// Eliminar 
                    //foreach (var ClienteBD in ClienteBDLst)
                    //{
                    //    var ClienteXml = ClienteXmlLst.Clientes.FirstOrDefault(s => s.id_Cliente == ClienteBD.id_Cliente);
                    //    if (ClienteXml == null)
                    //    {
                    //        dBGfit.Cliente.Remove(ClienteBD);
                    //    }
                    //}
                    // Guardar 
                    dBGfit.SaveChanges();
                }
            }
            
        }

        public static void XmlToMonitor(string filePath)
        {
            MonitorLst MonitorXmlLst = new MonitorLst();
            XmlSerializer serializer = new XmlSerializer(typeof(MonitorLst));
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    MonitorXmlLst = (MonitorLst)serializer.Deserialize(reader);
                }

                using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
                {
                    // Recuperar de la BD
                    var MonitorBDLst = dBGfit.Monitor.ToList();
                    foreach (var MonitorXml in MonitorXmlLst.Monitores)
                    {
                        // Buscar si existe.
                        var MonitorBD = MonitorBDLst.FirstOrDefault(s => s.id_Monitor == MonitorXml.id_Monitor);
                        if (MonitorBD != null)
                        {
                            // Actualiza los datos
                            MonitorBD.personaID = MonitorXml.personaID;
                            MonitorBD.precioHora = MonitorXml.precioHora;
                            MonitorBD.fechaAlta = MonitorXml.fechaAlta;

                            dBGfit.Entry(MonitorBD).State = EntityState.Modified;
                        }
                        else
                        {
                            // Crear nuevo
                            var MonitorNueva = new Monitor
                            {
                                id_Monitor = MonitorXml.id_Monitor,
                                personaID = MonitorXml.personaID,
                                precioHora = MonitorXml.precioHora,
                                fechaAlta = MonitorXml.fechaAlta

                            };
                            dBGfit.Monitor.Add(MonitorNueva);
                        }
                    }
                    //// Eliminar 
                    //foreach (var MonitorBD in MonitorBDLst)
                    //{
                    //    var MonitorXml = MonitorXmlLst.Monitores.FirstOrDefault(s => s.id_Monitor == MonitorBD.id_Monitor);
                    //    if (MonitorXml == null)
                    //    {
                    //        dBGfit.Monitor.Remove(MonitorBD);
                    //    }
                    //}
                    // Guardar 
                    dBGfit.SaveChanges();
                }
            }
            
        }

        public static void XmlToPersona(string filePath)
        {
            PersonaLst PersonaXmlLst = new PersonaLst();
            XmlSerializer serializer = new XmlSerializer(typeof(PersonaLst));
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    PersonaXmlLst = (PersonaLst)serializer.Deserialize(reader);
                }

                using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
                {
                    // Recuperar de la BD
                    var PersonaBDLst = dBGfit.Persona.ToList();
                    foreach (var PersonaXml in PersonaXmlLst.Personas)
                    {
                        // Buscar si existe.
                        var PersonaBD = PersonaBDLst.FirstOrDefault(s => s.id_Persona == PersonaXml.id_Persona);
                        if (PersonaBD != null)
                        {
                            // Actualiza los datos
                            PersonaBD.email = PersonaXml.email;
                            PersonaBD.nombre = PersonaXml.nombre;
                            PersonaBD.apellido1 = PersonaXml.apellido1;
                            PersonaBD.apellido2 = PersonaXml.apellido2;
                            PersonaBD.direccion = PersonaXml.direccion;
                            PersonaBD.codigoPostal = PersonaXml.codigoPostal;
                            PersonaBD.provincia = PersonaXml.provincia;
                            PersonaBD.dniNifNie = PersonaXml.dniNifNie;
                            PersonaBD.password = PersonaXml.password;

                            dBGfit.Entry(PersonaBD).State = EntityState.Modified;
                        }
                        else
                        {
                            // Crear nuevo
                            var PersonaNueva = new Persona
                            {
                                id_Persona = PersonaXml.id_Persona,
                                email = PersonaXml.email,
                                nombre = PersonaXml.nombre,
                                apellido1 = PersonaXml.apellido1,
                                apellido2 = PersonaXml.apellido2,
                                direccion = PersonaXml.direccion,
                                codigoPostal = PersonaXml.codigoPostal,
                                provincia = PersonaXml.provincia,
                                dniNifNie = PersonaXml.dniNifNie,
                                password = PersonaXml.password

                            };
                            dBGfit.Persona.Add(PersonaNueva);
                        }
                    }
                    //// Eliminar 
                    //foreach (var PersonaBD in PersonaBDLst)
                    //{
                    //    var PersonaXml = PersonaXmlLst.Personas.FirstOrDefault(s => s.id_Persona == PersonaBD.id_Persona);
                    //    if (PersonaXml == null)
                    //    {
                    //        dBGfit.Persona.Remove(PersonaBD);
                    //    }
                    //}
                    //// Guardar 
                    dBGfit.SaveChanges();
                }
            }            
        }

        public static void XmlToReserva(string filePath)
        {
            ReservaLst ReservaXmlLst = new ReservaLst();
            XmlSerializer serializer = new XmlSerializer(typeof(ReservaLst));
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    ReservaXmlLst = (ReservaLst)serializer.Deserialize(reader);
                }

                using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
                {
                    // Recuperar de la BD
                    var ReservaBDLst = dBGfit.Reserva.ToList();
                    foreach (var ReservaXml in ReservaXmlLst.Reservas)
                    {
                        // Buscar si existe.
                        var ReservaBD = ReservaBDLst.FirstOrDefault(s => s.id_Reserva == ReservaXml.id_Reserva);
                        if (ReservaBD != null)
                        {
                            // Actualiza los datos
                            ReservaBD.posicion = ReservaXml.posicion;
                            ReservaBD.claseID = ReservaXml.claseID;
                            ReservaBD.clienteID = ReservaXml.clienteID;
                            ReservaBD.confirmada = ReservaXml.confirmada;

                            dBGfit.Entry(ReservaBD).State = EntityState.Modified;
                        }
                        else
                        {
                            // Crear nuevo
                            var ReservaNueva = new Reserva
                            {
                                id_Reserva = ReservaXml.id_Reserva,
                                posicion = ReservaXml.posicion,
                                claseID = ReservaXml.claseID,
                                clienteID = ReservaXml.clienteID,
                                confirmada = ReservaXml.confirmada
                            };

                            dBGfit.Reserva.Add(ReservaNueva);
                        }
                    }
                    //// Eliminar 
                    //foreach (var ReservaBD in ReservaBDLst)
                    //{
                    //    var ReservaXml = ReservaXmlLst.Reservas.FirstOrDefault(s => s.id_Reserva == ReservaBD.id_Reserva);
                    //    if (ReservaXml == null)
                    //    {
                    //        dBGfit.Reserva.Remove(ReservaBD);
                    //    }
                    //}
                    //// Guardar 
                    dBGfit.SaveChanges();
                }
            }
            
        }

        public static void XmlToSala(string filePath)
        {
            SalaLst salasXmlLst = new SalaLst();
            XmlSerializer serializer = new XmlSerializer(typeof(SalaLst));
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    salasXmlLst = (SalaLst)serializer.Deserialize(reader);
                    // hacer algo con la lista de salas...
                }

                using (GenteFitDBEntities dBGfit = new GenteFitDBEntities())
                {
                    // Recuperar todas las salas de la BD
                    var salaBDLst = dBGfit.Sala.ToList();
                    foreach (var salaXml in salasXmlLst.Salas)
                    {
                        // Buscar si la sala ya existe en la BD
                        var salaBD = salaBDLst.FirstOrDefault(s => s.id_Sala == salaXml.id_Sala);
                        if (salaBD != null)
                        {
                            // Actualizar los datos de la sala en la BD
                            salaBD.numPlazas = salaXml.numPlazas;
                            salaBD.dimensionM2 = salaXml.dimensionM2;
                            dBGfit.Entry(salaBD).State = EntityState.Modified;
                        }
                        else
                        {
                            // La sala no existe en la BD, crear un nuevo objeto Sala y agregarlo
                            var salaNueva = new Sala
                            {
                                id_Sala = salaXml.id_Sala,
                                numPlazas = salaXml.numPlazas,
                                dimensionM2 = salaXml.dimensionM2
                            };
                            dBGfit.Sala.Add(salaNueva);
                        }
                    }
                    //// Eliminar las salas de la BD que no aparecen en el archivo XML
                    //foreach (var salaBD in salaBDLst)
                    //{
                    //    var salaXml = salasXmlLst.Salas.FirstOrDefault(s => s.id_Sala == salaBD.id_Sala);
                    //    if (salaXml == null)
                    //    {
                    //        dBGfit.Sala.Remove(salaBD);
                    //    }
                    //}
                    // Guardar los cambios en la BD
                    dBGfit.SaveChanges();
                }
            }            
        }



    }
}
