# -*- coding: utf-8 -*-
import os
import xml.etree.ElementTree as ET
import xmlrpc.client
from datetime import datetime

conexion = xmlrpc.client.ServerProxy('http://localhost:8069/xmlrpc/2/common')
uid = conexion.authenticate('GentefitDB', 'dotnetdotnet2023@gmail.com', 'fit123', {})
modelo = xmlrpc.client.ServerProxy('http://localhost:8069/xmlrpc/2/object')
modelo_name = 'x_clase'

if uid:
    xml_file = os.path.abspath(os.path.join(os.path.dirname(__file__), 'Clase.xml'))
    xml_tree = ET.parse(xml_file)
    xml_root = xml_tree.getroot()
    clases = xml_root.findall(".//ClaseView")

    for clase in clases:
        id_Clase = clase.find("id_Clase").text
        actividadID = clase.find("actividadID").text   
        salaID = clase.find("salaID").text 
        fechaHora = clase.find("fechaHora").text
        fechaHora = datetime.strptime(fechaHora, '%Y-%m-%dT%H:%M:%S').strftime('%Y-%m-%d %H:%M:%S')
        clase_existente = modelo.execute_kw('GentefitDB', uid, 'fit123', modelo_name, 'search', [[('x_id_Clase', '=', id_Clase)]])
        vals = {'x_id_Clase': id_Clase, 'x_actividadID': actividadID, 'x_salaID': salaID, 'x_fechaHora': fechaHora }
        if clase_existente:
            modelo.execute_kw('GentefitDB', uid, 'fit123', modelo_name, 'write', [clase_existente, vals])
        else:
            modelo.execute_kw('GentefitDB', uid, 'fit123', modelo_name, 'create', [vals])
    print('Clases Cargadas correctamente')
else:
    print('Error al conectar a Odoo')