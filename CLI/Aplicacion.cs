using Servicios;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace CLI
{
    public class Aplicacion
    {
        public string Archivo { get; set; }
        /// <summary>
        /// Ejecuta la aplicación principal
        /// </summary>
        public void Run()
        {
            ServiciosImportacion imp = new ServiciosImportacion();
            imp.ImportarCSV(Archivo);
            //Console.WriteLine(Archivo);
            //Console.ReadLine();
        }
    }
}
