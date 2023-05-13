# -*- coding: utf-8 -*-
import os
import xml.etree.ElementTree as ET
import xmlrpc.client

# Conexión a Odoo
conexion = xmlrpc.client.ServerProxy('http://localhost:8069/xmlrpc/2/common')
uid = conexion.authenticate('GentefitDB', 'dotnetdotnet2023@gmail.com', 'fit123', {})
modelo = xmlrpc.client.ServerProxy('http://localhost:8069/xmlrpc/2/object')
modelo_name = 'x_clase'

if uid:
    # Obtener datos del modelo 
    clases = modelo.execute_kw('GentefitDB', uid, 'fit123', modelo_name, 'search_read', [[]], {'fields': ['x_id_Clase', 'x_actividadID', 'x_salaID', 'x_fechaHora']})
    
    # Crear el árbol XML
    if len(clases) > 0:
        root = ET.Element("ClaseLst")
        for clase in clases:
            clase_view = ET.SubElement(root, "ClaseView")
            ET.SubElement(clase_view, "id_Clase").text = str(clase['x_id_Clase'])
            ET.SubElement(clase_view, "actividadID").text = str(clase['x_actividadID'])
            ET.SubElement(clase_view, "salaID").text = str(clase['x_salaID'])
            ET.SubElement(clase_view, "fechaHora").text = str(clase['x_fechaHora'].replace(' ', 'T'))
    
        # Guardar el archivo XML
        tree = ET.ElementTree(root)
        xml_file = os.path.abspath(os.path.join(os.path.dirname(__file__), 'Clase.xml'))
        tree.write(xml_file, encoding="utf-8", xml_declaration=True)
        print('Archivo XML Clases importado correctamente')
    else:
        print('No hay datos en el modelo')
else:
    print('Error al conectar a Odoo')