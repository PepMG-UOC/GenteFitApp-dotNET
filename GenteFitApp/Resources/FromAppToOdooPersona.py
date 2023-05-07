# -*- coding: utf-8 -*-
import os
import xml.etree.ElementTree as ET
import xmlrpc.client

conexion = xmlrpc.client.ServerProxy('http://localhost:8069/xmlrpc/2/common')
uid = conexion.authenticate('GentefitDB', 'dotnetdotnet2023@gmail.com', 'fit123', {})
modelo = xmlrpc.client.ServerProxy('http://localhost:8069/xmlrpc/2/object')
modelo_name = 'x_persona'

if uid:
    xml_file = os.path.abspath(os.path.join(os.path.dirname(__file__), 'Persona.xml'))
    xml_tree = ET.parse(xml_file)
    xml_root = xml_tree.getroot()
    personas = xml_root.findall(".//PersonaView")

    for persona in personas:
        id_Persona = persona.find("id_Persona").text
        email = persona.find("email").text
        nombre = persona.find("nombre").text
        apellido1 = persona.find("apellido1").text
        apellido2 = persona.find("apellido2").text
        direccion = persona.find("direccion").text
        codigoPostal = persona.find("codigoPostal").text
        provincia = persona.find("provincia").text
        dniNifNie = persona.find("dniNifNie").text
        password = persona.find("password").text
        persona_existente = modelo.execute_kw('GentefitDB', uid, 'fit123', modelo_name, 'search', [[('x_id_Persona', '=', id_Persona)]])
        vals = {'x_id_Persona': id_Persona, 'x_email': email, 'x_nombre': nombre, 'x_apellido1': apellido1, 'x_apellido2': apellido2, 'x_direccion': direccion, 'x_codigoPostal': codigoPostal, 'x_provincia': provincia, 'x_dniNifNie': dniNifNie, 'x_password': password }
        if persona_existente:
            modelo.execute_kw('GentefitDB', uid, 'fit123', modelo_name, 'write', [persona_existente, vals])
        else:
            modelo.execute_kw('GentefitDB', uid, 'fit123', modelo_name, 'create', [vals])
    print('Personas Cargadas correctamente')
else:
    print('Error al conectar a Odoo')