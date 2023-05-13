# -*- coding: utf-8 -*-
import os
import xml.etree.ElementTree as ET
import xmlrpc.client

# Conexión a Odoo
conexion = xmlrpc.client.ServerProxy('http://localhost:8069/xmlrpc/2/common')
uid = conexion.authenticate('GentefitDB', 'dotnetdotnet2023@gmail.com', 'fit123', {})
modelo = xmlrpc.client.ServerProxy('http://localhost:8069/xmlrpc/2/object')
modelo_name = 'x_reserva'

if uid:
    # Obtener datos del modelo 
    reservas = modelo.execute_kw('GentefitDB', uid, 'fit123', modelo_name, 'search_read', [[]], {'fields': ['x_id_Reserva', 'x_posicion', 'x_claseID', 'x_clienteID', 'x_confirmada']})
    
    # Crear el árbol XML
    if len(reservas) > 0:
        root = ET.Element("ReservaLst")
        for reserva in reservas:
            reserva_view = ET.SubElement(root, "ReservaView")
            ET.SubElement(reserva_view, "id_Reserva").text = str(reserva['x_id_Reserva'])
            ET.SubElement(reserva_view, "posicion").text = str(reserva['x_posicion'])
            ET.SubElement(reserva_view, "claseID").text = str(reserva['x_claseID'])
            ET.SubElement(reserva_view, "clienteID").text = str(reserva['x_clienteID'])
            ET.SubElement(reserva_view, "confirmada").text = str(reserva['x_confirmada'])
    
        # Guardar el archivo XML
        tree = ET.ElementTree(root)
        xml_file = os.path.abspath(os.path.join(os.path.dirname(__file__), 'Reserva.xml'))
        tree.write(xml_file, encoding="utf-8", xml_declaration=True)
        print('Archivo XML Reservas importado correctamente')
    else:
        print('No hay datos en el modelo')
else:
    print('Error al conectar a Odoo')