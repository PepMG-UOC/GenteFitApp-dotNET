# -*- coding: utf-8 -*-
import os
import xml.etree.ElementTree as ET
import xmlrpc.client

# Conexión a Odoo
conexion = xmlrpc.client.ServerProxy('http://localhost:8069/xmlrpc/2/common')
uid = conexion.authenticate('GentefitDB', 'dotnetdotnet2023@gmail.com', 'fit123', {})
modelo = xmlrpc.client.ServerProxy('http://localhost:8069/xmlrpc/2/object')
modelo_name = 'x_persona'

if uid:
    # Obtener datos del modelo 
    personas = modelo.execute_kw('GentefitDB', uid, 'fit123', modelo_name, 'search_read', [[]], {'fields': ['x_id_Persona', 'x_email', 'x_nombre', 'x_apellido1', 'x_apellido2', 'x_direccion', 'x_codigoPostal', 'x_provincia', 'x_dniNifNie', 'x_password']})
    
    # Crear el árbol XML
    if len(personas) > 0:
        root = ET.Element("PersonaLst")
        for persona in personas:
            persona_view = ET.SubElement(root, "PersonaView")
            ET.SubElement(persona_view, "id_Persona").text = str(persona['x_id_Persona'])
            ET.SubElement(persona_view, "email").text = str(persona['x_email'])
            ET.SubElement(persona_view, "nombre").text = str(persona['x_nombre'])
            ET.SubElement(persona_view, "apellido1").text = str(persona['x_apellido1'])
            ET.SubElement(persona_view, "apellido2").text = str(persona['x_apellido2'])
            ET.SubElement(persona_view, "direccion").text = str(persona['x_direccion'])
            ET.SubElement(persona_view, "codigoPostal").text = str(persona['x_codigoPostal'])
            ET.SubElement(persona_view, "provincia").text = str(persona['x_provincia'])
            ET.SubElement(persona_view, "dniNifNie").text = str(persona['x_dniNifNie'])
            ET.SubElement(persona_view, "password").text = str(persona['x_password'])
    
        # Guardar el archivo XML
        tree = ET.ElementTree(root)
        xml_file = os.path.abspath(os.path.join(os.path.dirname(__file__), 'Persona.xml'))
        tree.write(xml_file, encoding="utf-8", xml_declaration=True)
        print('Archivo XML importado correctamente')
    else:
        print('No hay datos en el modelo')
else:
    print('Error al conectar a Odoo')