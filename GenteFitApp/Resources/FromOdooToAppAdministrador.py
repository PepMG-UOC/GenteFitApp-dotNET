# -*- coding: utf-8 -*-
import os
import xml.etree.ElementTree as ET
import xmlrpc.client

# Conexión a Odoo
conexion = xmlrpc.client.ServerProxy('http://localhost:8069/xmlrpc/2/common')
uid = conexion.authenticate('GentefitDB', 'dotnetdotnet2023@gmail.com', 'fit123', {})
modelo = xmlrpc.client.ServerProxy('http://localhost:8069/xmlrpc/2/object')
modelo_name = 'x_administrador'

if uid:
    # Obtener datos del modelo 
    administradores = modelo.execute_kw('GentefitDB', uid, 'fit123', modelo_name, 'search_read', [[]], {'fields': ['x_id_Admin', 'x_personaID']})
    
    # Crear el árbol XML
    if len(administradores) > 0:
        root = ET.Element("AdministradorLst")
        for administrador in administradores:
            administrador_view = ET.SubElement(root, "AdministradorView")
            ET.SubElement(administrador_view, "id_Admin").text = str(administrador['x_id_Admin'])
            ET.SubElement(administrador_view, "personaID").text = str(administrador['x_personaID'])        
    
        # Guardar el archivo XML
        tree = ET.ElementTree(root)
        xml_file = os.path.abspath(os.path.join(os.path.dirname(__file__), 'Administrador.xml'))
        tree.write(xml_file, encoding="utf-8", xml_declaration=True)
        print('Archivo XML importado correctamente')
    else:
        print('No hay datos en el modelo')
else:
    print('Error al conectar a Odoo')
