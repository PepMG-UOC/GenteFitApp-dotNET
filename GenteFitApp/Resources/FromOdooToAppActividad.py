# -*- coding: utf-8 -*-
import os
import xml.etree.ElementTree as ET
import xmlrpc.client

# Conexión a Odoo
conexion = xmlrpc.client.ServerProxy('http://localhost:8069/xmlrpc/2/common')
uid = conexion.authenticate('GentefitDB', 'dotnetdotnet2023@gmail.com', 'fit123', {})
modelo = xmlrpc.client.ServerProxy('http://localhost:8069/xmlrpc/2/object')
modelo_name = 'x_actividad'

if uid:
    # Obtener datos del modelo 
    actividades = modelo.execute_kw('GentefitDB', uid, 'fit123', modelo_name, 'search_read', [[]], {'fields': ['x_id_Actividad', 'x_nombre', 'x_descripcion', 'x_monitorID']})
    
    # Crear el árbol XML
    if len(actividades) > 0:
        root = ET.Element("ActividadLst")
        for actividad in actividades:
            actividad_view = ET.SubElement(root, "ActividadView")
            ET.SubElement(actividad_view, "id_Actividad").text = str(actividad['x_id_Actividad'])
            ET.SubElement(actividad_view, "nombre").text = str(actividad['x_nombre'])
            ET.SubElement(actividad_view, "descripcion").text = str(actividad['x_descripcion'])
            ET.SubElement(actividad_view, "monitorID").text = str(actividad['x_monitorID'])
    
        # Guardar el archivo XML
        tree = ET.ElementTree(root)
        xml_file = os.path.abspath(os.path.join(os.path.dirname(__file__), 'Actividad.xml'))
        tree.write(xml_file, encoding="utf-8", xml_declaration=True)
        print('Archivo XML generado correctamente')
    else:
        print('No hay datos en el modelo')
else:
    print('Error al conectar a Odoo')