# -*- coding: utf-8 -*-
import os
import xml.etree.ElementTree as ET
import xmlrpc.client

conexion = xmlrpc.client.ServerProxy('http://localhost:8069/xmlrpc/2/common')
uid = conexion.authenticate('GentefitDB', 'dotnetdotnet2023@gmail.com', 'fit123', {})
modelo = xmlrpc.client.ServerProxy('http://localhost:8069/xmlrpc/2/object')
modelo_name = 'x_administrador'

if uid:
    xml_file = os.path.abspath(os.path.join(os.path.dirname(__file__), 'Administrador.xml'))
    xml_tree = ET.parse(xml_file)
    xml_root = xml_tree.getroot()
    admin_views = xml_root.findall(".//AdministradorView")

    for admin_view in admin_views:
        id_Admin = admin_view.find("id_Admin").text
        personaID = admin_view.find("personaID").text  
        admin_existente = modelo.execute_kw('GentefitDB', uid, 'fit123', modelo_name, 'search', [[('x_id_Administrador', '=', id_Admin)]])
        vals = {'x_id_Administrador': id_Admin, 'x_personaID': personaID}
        if admin_existente:
            modelo.execute_kw('GentefitDB', uid, 'fit123', modelo_name, 'write', [admin_existente, vals])
        else:
            modelo.execute_kw('GentefitDB', uid, 'fit123', modelo_name, 'create', [vals])
    print('Administradores Cargados correctamente')
else:
    print('Error al conectar a Odoo')