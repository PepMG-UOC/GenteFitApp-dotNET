# -*- coding: utf-8 -*-
import os
import xml.etree.ElementTree as ET
import xmlrpc.client

conexion = xmlrpc.client.ServerProxy('http://localhost:8069/xmlrpc/2/common')
uid = conexion.authenticate('GentefitDB', 'dotnetdotnet2023@gmail.com', 'fit123', {})
modelo = xmlrpc.client.ServerProxy('http://localhost:8069/xmlrpc/2/object')
modelo_name = 'x_actividad'

if uid:
    xml_file = os.path.abspath(os.path.join(os.path.dirname(__file__), 'Actividad.xml'))
    xml_tree = ET.parse(xml_file)
    xml_root = xml_tree.getroot()
    actividades = xml_root.findall(".//ActividadView")

    for actividad in actividades:
        id_Actividad = actividad.find("id_Actividad").text
        nombre = actividad.find("nombre").text   
        descripcion = actividad.find("descripcion").text 
        monitorID = actividad.find("monitorID").text
        actividad_existente = modelo.execute_kw('GentefitDB', uid, 'fit123', modelo_name, 'search', [[('x_id_Actividad', '=', id_Actividad)]])
        vals = {'x_id_Actividad': id_Actividad, 'x_nombre': nombre, 'x_descripcion': descripcion, 'x_monitorID': monitorID }
        if actividad_existente:
            modelo.execute_kw('GentefitDB', uid, 'fit123', modelo_name, 'write', [actividad_existente, vals])
        else:
            modelo.execute_kw('GentefitDB', uid, 'fit123', modelo_name, 'create', [vals])
    print('Actividades Cargadas correctamente')
else:
    print('Error al conectar a Odoo')