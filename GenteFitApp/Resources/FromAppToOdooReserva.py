# -*- coding: utf-8 -*-
import os
import xml.etree.ElementTree as ET
import xmlrpc.client

conexion = xmlrpc.client.ServerProxy('http://localhost:8069/xmlrpc/2/common')
uid = conexion.authenticate('GentefitDB', 'dotnetdotnet2023@gmail.com', 'fit123', {})
modelo = xmlrpc.client.ServerProxy('http://localhost:8069/xmlrpc/2/object')
modelo_name = 'x_reserva'

if uid:
    xml_file = os.path.abspath(os.path.join(os.path.dirname(__file__), 'Reserva.xml'))
    xml_tree = ET.parse(xml_file)
    xml_root = xml_tree.getroot()
    reservas = xml_root.findall(".//ReservaView")

    for reserva in reservas:
        id_Reserva = reserva.find("id_Reserva").text
        posicion = reserva.find("posicion").text
        clienteID = reserva.find("clienteID").text
        confirmada = reserva.find("confirmada").text
        reserva_existente = modelo.execute_kw('GentefitDB', uid, 'fit123', modelo_name, 'search', [[('x_id_Reserva', '=', id_Reserva)]])
        vals = {'x_id_Reserva': id_Reserva, 'x_posicion': posicion, 'x_clienteID': clienteID, 'x_confirmada': confirmada }
        if reserva_existente:
            modelo.execute_kw('GentefitDB', uid, 'fit123', modelo_name, 'write', [reserva_existente, vals])
        else:
            modelo.execute_kw('GentefitDB', uid, 'fit123', modelo_name, 'create', [vals])
    print('Reservas Cargadas correctamente')
else:
    print('Error al conectar a Odoo')