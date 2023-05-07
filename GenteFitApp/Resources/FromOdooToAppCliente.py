# -*- coding: utf-8 -*-
import os
import xml.etree.ElementTree as ET
import xmlrpc.client

# Conexión a Odoo
conexion = xmlrpc.client.ServerProxy('http://localhost:8069/xmlrpc/2/common')
uid = conexion.authenticate('GentefitDB', 'dotnetdotnet2023@gmail.com', 'fit123', {})
modelo = xmlrpc.client.ServerProxy('http://localhost:8069/xmlrpc/2/object')
modelo_name = 'x_cliente'

if uid:
    # Obtener datos del modelo 
    clientes = modelo.execute_kw('GentefitDB', uid, 'fit123', modelo_name, 'search_read', [[]], {'fields': ['x_id_Cliente', 'x_personaID', 'x_fechaAlta']})
    
    # Crear el árbol XML
    if len(clientes) > 0:
        root = ET.Element("ClienteLst")
        for cliente in clientes:
            cliente_view = ET.SubElement(root, "ClienteView")
            ET.SubElement(cliente_view, "id_Cliente").text = str(cliente['x_id_Cliente'])
            ET.SubElement(cliente_view, "personaID").text = str(cliente['x_personaID'])
            ET.SubElement(cliente_view, "fechaAlta").text = str(cliente['x_fechaAlta'].replace(' ', 'T'))
    
        # Guardar el archivo XML
        tree = ET.ElementTree(root)
        xml_file = os.path.abspath(os.path.join(os.path.dirname(__file__), 'Cliente.xml'))
        tree.write(xml_file, encoding="utf-8", xml_declaration=True)
        print('Archivo XML generado correctamente')
    else:
        print('No hay datos en el modelo')
else:
    print('Error al conectar a Odoo')
