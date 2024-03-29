# -*- coding: utf-8 -*-
import os
import xml.etree.ElementTree as ET
import xmlrpc.client

# Conexión a Odoo
conexion = xmlrpc.client.ServerProxy('http://localhost:8069/xmlrpc/2/common')
uid = conexion.authenticate('GentefitDB', 'dotnetdotnet2023@gmail.com', 'fit123', {})
modelo = xmlrpc.client.ServerProxy('http://localhost:8069/xmlrpc/2/object')
modelo_name = 'x_sala'

if uid:
    # Obtener datos del modelo x_sala
    salas = modelo.execute_kw('GentefitDB', uid, 'fit123', modelo_name, 'search_read', [[]], {'fields': ['x_id_Sala', 'x_numPlazas', 'x_dimensionM2']})
    
    # Crear el árbol XML
    if len(salas) > 0:
        root = ET.Element("SalaLst")
        for sala in salas:
            sala_view = ET.SubElement(root, "SalaView")
            ET.SubElement(sala_view, "id_Sala").text = str(sala['x_id_Sala'])
            ET.SubElement(sala_view, "numPlazas").text = str(sala['x_numPlazas'])
            ET.SubElement(sala_view, "dimensionM2").text = str(sala['x_dimensionM2'])
    
        # Guardar el archivo XML
        tree = ET.ElementTree(root)
        xml_file = os.path.abspath(os.path.join(os.path.dirname(__file__), 'Sala.xml'))
        tree.write(xml_file, encoding="utf-8", xml_declaration=True)
        print('Archivo XML Salas importado correctamente')
    else:
        print('No hay datos en el modelo')
else:
    print('Error al conectar a Odoo')
