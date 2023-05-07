# -*- coding: utf-8 -*-
import os
import xml.etree.ElementTree as ET
import xmlrpc.client
from datetime import datetime

conexion = xmlrpc.client.ServerProxy('http://localhost:8069/xmlrpc/2/common')
uid = conexion.authenticate('GentefitDB', 'dotnetdotnet2023@gmail.com', 'fit123', {})
modelo = xmlrpc.client.ServerProxy('http://localhost:8069/xmlrpc/2/object')
modelo_name = 'x_monitor'

if uid:
    xml_file = os.path.abspath(os.path.join(os.path.dirname(__file__), 'Monitor.xml'))
    xml_tree = ET.parse(xml_file)
    xml_root = xml_tree.getroot()
    monitores = xml_root.findall(".//MonitorView")

    for monitor in monitores:
        id_Monitor = monitor.find("id_Monitor").text
        personaID = monitor.find("personaID").text  
        precioHora = monitor.find("precioHora").text
        fechaAlta = monitor.find("fechaAlta").text
        fechaAlta = datetime.strptime(fechaAlta, '%Y-%m-%dT%H:%M:%S').strftime('%Y-%m-%d %H:%M:%S')
        monitor_existente = modelo.execute_kw('GentefitDB', uid, 'fit123', modelo_name, 'search', [[('x_id_Monitor', '=', id_Monitor)]])
        vals = {'x_id_Monitor': id_Monitor, 'x_personaID': personaID, 'x_precioHora': precioHora, 'x_fechaAlta': fechaAlta }
        if monitor_existente:
            modelo.execute_kw('GentefitDB', uid, 'fit123', modelo_name, 'write', [monitor_existente, vals])
        else:
            modelo.execute_kw('GentefitDB', uid, 'fit123', modelo_name, 'create', [vals])
    print('Monitores Cargados correctamente')
else:
    print('Error al conectar a Odoo')