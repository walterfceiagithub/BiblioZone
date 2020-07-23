using System;

namespace CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            // DECLARACION
            Aplicacion app;

            //ASIGNACION
            app = new Aplicacion();

            app.Archivo = "C:\\cursocsharp2020\\libros.csv";
            app.Run();

            //Console.WriteLine("Hello World!");
        }
    }
}
