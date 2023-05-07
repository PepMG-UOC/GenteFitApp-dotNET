# -*- coding: utf-8 -*-
import os
import xml.etree.ElementTree as ET
import xmlrpc.client

# Conexión a Odoo
conexion = xmlrpc.client.ServerProxy('http://localhost:8069/xmlrpc/2/common')
uid = conexion.authenticate('GentefitDB', 'dotnetdotnet2023@gmail.com', 'fit123', {})
modelo = xmlrpc.client.ServerProxy('http://localhost:8069/xmlrpc/2/object')
modelo_name = 'x_monitor'

if uid:
    # Obtener datos del modelo 
    monitores = modelo.execute_kw('GentefitDB', uid, 'fit123', modelo_name, 'search_read', [[]], {'fields': ['x_id_Monitor', 'x_personaID', 'x_precioHora', 'x_fechaAlta']})
    
    # Crear el árbol XML si hay datos
    if len(monitores) > 0:
        root = ET.Element("MonitorLst")
        for monitor in monitores:
            monitor_view = ET.SubElement(root, "MonitorView")
            ET.SubElement(monitor_view, "id_Monitor").text = str(monitor['x_id_Monitor'])
            ET.SubElement(monitor_view, "personaID").text = str(monitor['x_personaID'])
            ET.SubElement(monitor_view, "precioHora").text = str(monitor['x_precioHora'])
            ET.SubElement(monitor_view, "fechaAlta").text = str(monitor['x_fechaAlta'].replace(' ', 'T'))
    
        # Guardar el archivo XML
        tree = ET.ElementTree(root)
        xml_file = os.path.abspath(os.path.join(os.path.dirname(__file__), 'Monitor.xml'))
        tree.write(xml_file, encoding="utf-8", xml_declaration=True)
        print('Archivo XML generado correctamente')
    else:
        print('No hay datos en el modelo')
else:
    print('Error al conectar a Odoo')