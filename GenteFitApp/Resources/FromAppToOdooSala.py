# -*- coding: utf-8 -*-
import os
import xml.etree.ElementTree as ET
import xmlrpc.client

conexion = xmlrpc.client.ServerProxy('http://localhost:8069/xmlrpc/2/common')
uid = conexion.authenticate('GentefitDB', 'dotnetdotnet2023@gmail.com', 'fit123', {})
modelo = xmlrpc.client.ServerProxy('http://localhost:8069/xmlrpc/2/object')
modelo_name = 'x_sala'

if uid:
    xml_file = os.path.abspath(os.path.join(os.path.dirname(__file__), 'Sala.xml'))
    xml_tree = ET.parse(xml_file)
    xml_root = xml_tree.getroot()
    sala_views = xml_root.findall(".//SalaView")

    for sala_view in sala_views:
        id_sala = sala_view.find("id_Sala").text
        num_plazas = sala_view.find("numPlazas").text
        dimension_m2 = sala_view.find("dimensionM2").text
        sala_existente = modelo.execute_kw('GentefitDB', uid, 'fit123', modelo_name, 'search', [[('x_id_Sala', '=', id_sala)]])
        vals = {'x_id_Sala': id_sala, 'x_numPlazas': num_plazas, 'x_dimensionM2': dimension_m2}
        if sala_existente:
            modelo.execute_kw('GentefitDB', uid, 'fit123', modelo_name, 'write', [sala_existente, vals])
        else:
            modelo.execute_kw('GentefitDB', uid, 'fit123', modelo_name, 'create', [vals])
    print('Salas Cargadas correctamente')
else:
    print('Error al conectar a Odoo')