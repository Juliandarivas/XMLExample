using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace XMLExample
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerarAPartirDeObjeto();
            GenerarAPartirDeMultiplesObjetos();


            Console.WriteLine("Hello World!");
        }

        private static void GenerarAPartirDeMultiplesObjetos()
        {
            List<Directorio> directorios = new List<Directorio>
            {
                new Directorio(1, "Andres", "Serna", "3015263365"),
                new Directorio(1, "Felipe", "Rojas", "3015263365"),
                new Directorio(1, "Andres", "Serna", "3015263365"),
                new Directorio(1, "Felipe", "Rojas", "3015263365"),
                new Directorio(1, "Felipe", "Serna", "3015263365"),
                new Directorio(1, "Andres", "Rojas", "3015263365"),
                new Directorio(1, "Felipe", "Serna", "3015263365"),
                new Directorio(1, "Felipe", "Rojas", "3015263365"),
                new Directorio(1, "Felipe", "Serna", "3015263365"),
                new Directorio(1, "Andres", "Rojas", "3015263365"),
                new Directorio(1, "Felipe", "Serna", "3015263365"),
            };

            XmlSerializer serializador = new XmlSerializer(directorios.GetType());

            var ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//directorios.xml";

            FileStream archivo = File.Create(ruta);

            serializador.Serialize(archivo, directorios);

            archivo.Close();
        }

        private static void GenerarAPartirDeObjeto()
        {
            Directorio directorio = new Directorio(1, "Andres", "Serna", "3015263365");

            XmlSerializer serializador = new XmlSerializer(typeof(Directorio));

            var ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//directorio.xml";

            FileStream archivo = File.Create(ruta);

            serializador.Serialize(archivo, directorio);

            archivo.Close();
        }
    }
}
