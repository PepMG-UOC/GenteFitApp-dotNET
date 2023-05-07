# -*- coding: utf-8 -*-
import os
import xml.etree.ElementTree as ET
import xmlrpc.client
from datetime import datetime

conexion = xmlrpc.client.ServerProxy('http://localhost:8069/xmlrpc/2/common')
uid = conexion.authenticate('GentefitDB', 'dotnetdotnet2023@gmail.com', 'fit123', {})
modelo = xmlrpc.client.ServerProxy('http://localhost:8069/xmlrpc/2/object')
modelo_name = 'x_cliente'

if uid:
    xml_file = os.path.abspath(os.path.join(os.path.dirname(__file__), 'Cliente.xml'))
    xml_tree = ET.parse(xml_file)
    xml_root = xml_tree.getroot()
    clientes = xml_root.findall(".//ClienteView")

    for cliente in clientes:
        id_Cliente = cliente.find("id_Cliente").text
        personaID = cliente.find("personaID").text          
        fechaAlta = cliente.find("fechaAlta").text
        fechaAlta = datetime.strptime(fechaAlta, '%Y-%m-%dT%H:%M:%S').strftime('%Y-%m-%d %H:%M:%S')
        cliente_existente = modelo.execute_kw('GentefitDB', uid, 'fit123', modelo_name, 'search', [[('x_id_Cliente', '=', id_Cliente)]])
        vals = {'x_id_Cliente': id_Cliente, 'x_personaID': personaID, 'x_fechaAlta': fechaAlta }
        if cliente_existente:
            modelo.execute_kw('GentefitDB', uid, 'fit123', modelo_name, 'write', [cliente_existente, vals])
        else:
            modelo.execute_kw('GentefitDB', uid, 'fit123', modelo_name, 'create', [vals])
    print('Clientes Cargados correctamente')
else:
    print('Error al conectar a Odoo')