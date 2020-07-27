using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XMLExample
{
    public class Directorio
    {
        public Directorio(int id, string nombre, string apellido, string telefono)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
        }
        public Directorio()
        {

        }


        [XmlAttribute("Numero")]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [XmlElement("Celular")]
        public string Telefono { get; set; }
    }
}
