using Entidades;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //examen completado unicamente queda asegurarse de que no rompa!!!!!!!!!!!!!
            //y mostrar correctamente la consola 
            //revisar clase a clase que no falte nada
            Escaner escanerLibros = new Escaner("Canon", Escaner.TipoDoc.libro);
            Escaner escanerMapas = new Escaner("Canon", Escaner.TipoDoc.mapa);

            // Crear algunos documentos
            Documento doc1 = new Libro("El Quijote", "Miguel de Cervantes", 1605, "ISBN123", "123456", 500);
            Documento doc2 = new Libro("1984", "George Orwell", 1949, "ISBN456", "789012", 300);
            Documento doc6 = new Libro("El ", "Miel de Cervantes", 105, "IS123", "123", 100);
            Documento doc7 = new Libro("El ", "Cervantes", 10, "I13", "12", 10);
            Documento doc8 = new Libro("El ", "Miel ", 15, "I23", "23", 1);

            Documento doc3 = new Mapa("Mapa del mundo", "Autor", 2024, "Map123", "MapCode", 100, 200);
            Documento doc4 = new Mapa("Map del mundo", "Auto", 2024, "Map23", "MpCode", 100, 200);
            Documento doc5 = new Mapa("Ma delndo", "Auo", 202, "Ma23", "Mode", 200, 200);
            Documento doc9 = new Mapa("Ma o", "Ao", 22, "M23", "Mde", 500, 200);


            // Añadir documentos al escáner de libros
            bool added1 = escanerLibros + doc1;
            bool added2 = escanerLibros + doc2;
            bool added6 = escanerLibros + doc6;
            bool added7 = escanerLibros + doc7;
            bool added8 = escanerLibros + doc8;

            // Añadir documentos al escáner de mapas
            bool added3 = escanerMapas + doc3;
            bool added4 = escanerMapas + doc4;
            bool added5 = escanerMapas + doc5;
            bool added9 = escanerMapas + doc9;


            doc5.AvanzarEstado();
            doc6.AvanzarEstado();

            doc7.AvanzarEstado();
            doc8.AvanzarEstado();
            doc7.AvanzarEstado();
            doc8.AvanzarEstado();

            doc9.AvanzarEstado();
            doc9.AvanzarEstado();
            doc9.AvanzarEstado();
   


            // Mostrar resultados usando el método estático para libros
            Informes.MostrarDistribuidos(escanerLibros, out int extensionLibros, out int cantidadLibros, out string resumenLibros);
            Console.WriteLine("Resultados del Informe de Libros Distribuidos:");
            Console.WriteLine($"Extensión Total: {extensionLibros}");
            Console.WriteLine($"Cantidad Total: {cantidadLibros}");
            Console.WriteLine("Resumen:");
            Console.WriteLine(resumenLibros);

            // Mostrar resultados usando el método estático para mapas
            Informes.MostrarDistribuidos(escanerMapas, out int extensionMapas, out int cantidadMapas, out string resumenMapas);
            Console.WriteLine("Resultados del Informe de Mapas Distribuidos:");
            Console.WriteLine($"Extensión Total: {extensionMapas}");
            Console.WriteLine($"Cantidad Total: {cantidadMapas}");
            Console.WriteLine("Resumen:");
            Console.WriteLine(resumenMapas);

            // Mostrar resultados usando el método estático para libros
            Informes.MostrarEnEscaner(escanerLibros, out int extensionLibros2, out int cantidadLibros2, out string resumenLibros2);
            Console.WriteLine("Resultados del Informe de Libros escaner:");
            Console.WriteLine($"Extensión Total: {extensionLibros2}");
            Console.WriteLine($"Cantidad Total: {cantidadLibros2}");
            Console.WriteLine("Resumen:");
            Console.WriteLine(resumenLibros2);

            // Mostrar resultados usando el método estático para mapas
            Informes.MostrarEnEscaner(escanerMapas, out int extensionMapas2, out int cantidadMapas2, out string resumenMapas2);
            Console.WriteLine("Resultados del Informe de Mapas en escaner:");
            Console.WriteLine($"Extensión Total: {extensionMapas2}");
            Console.WriteLine($"Cantidad Total: {cantidadMapas2}");
            Console.WriteLine("Resumen:");
            Console.WriteLine(resumenMapas2);

            // Mostrar resultados usando el método estático para libros
            Informes.MostrarEnRevision(escanerLibros, out int extensionLibros3, out int cantidadLibros3, out string resumenLibros3);
            Console.WriteLine("Resultados del Informe de Libros revision:");
            Console.WriteLine($"Extensión Total: {extensionLibros3}");
            Console.WriteLine($"Cantidad Total: {cantidadLibros3}");
            Console.WriteLine("Resumen:");
            Console.WriteLine(resumenLibros3);


            Informes.MostrarTerminados(escanerMapas, out int extensionMapas3, out int cantidadMapas3, out string resumenMapas3);
            Console.WriteLine("Resultados del Informe de Mapas en escaner:");
            Console.WriteLine($"Extensión Total: {extensionMapas3}");
            Console.WriteLine($"Cantidad Total: {cantidadMapas3}");
            Console.WriteLine("Resumen:");
            Console.WriteLine(resumenMapas3);


            /* //tercer test
            // Crear una instancia de Escaner
             Escaner escaner = new Escaner("Canon", Escaner.TipoDoc.libro);

             // Crear algunos documentos
             Documento doc1 = new Libro("El Quijote", "Miguel de Cervantes", 1605, "ISBN123", "123456", 500);
             Documento doc2 = new Libro("1984", "George Orwell", 1949, "ISBN456", "789012", 300);
             Documento doc3 = new Mapa("Mapa del mundo", "Autor", 2024, "Map123", "MapCode", 100, 200);
             Documento doc4 = new Mapa("Mapa del mundo", "Autor", 2024, "Map123", "MapCode", 100, 200);

             Console.WriteLine("\nVerificando documentos en el escáner:");
             Console.WriteLine($"¿doc1 está en el escáner? {(escaner == doc1 ? "Sí" : "No")}");
             Console.WriteLine($"¿doc2 está en el escáner? {(escaner == doc2 ? "Sí" : "No")}");
             Console.WriteLine($"¿doc3 está en el escáner? {(escaner == doc3 ? "Sí" : "No")}");

             foreach (Documento doc in escaner.ListaDocumentos)
             {
                 Console.WriteLine($"{doc.Titulo} - Estado: {doc.Estado}");
             }

             // Probar la sobrecarga del operador +
             Console.WriteLine("\nAñadiendo documentos al escáner:");
             Console.WriteLine($"¿Se añadió doc1? {escaner + doc1}");
             Console.WriteLine($"¿Se añadió doc2? {escaner + doc2}");
             Console.WriteLine($"¿Se añadió doc3? {escaner + doc3}");
             Console.WriteLine($"¿Se añadió doc4? {escaner + doc4}");

             // Probar la sobrecarga del operador ==
             Console.WriteLine("\nVerificando documentos en el escáner:");
             Console.WriteLine($"¿doc1 está en el escáner? {(escaner == doc1 ? "Sí" : "No")}");
             Console.WriteLine($"¿doc2 está en el escáner? {(escaner == doc2 ? "Sí" : "No")}");
             Console.WriteLine($"¿doc3 está en el escáner? {(escaner == doc3 ? "Sí" : "No")}\n");


             foreach (Documento doc in escaner.ListaDocumentos)
             {
                 //escaner.CambiarEstadoDocumento(doc);
                 Console.WriteLine($"{doc.Titulo} - Estado: {doc.Estado}");
             }

             //prueba mostrar distribuido
             Informes.MostrarDistribuidos(escaner, out int extensionLibros, out int cantidadLibros, out string resumenLibros);
             Console.WriteLine("Resultados del Informe de Libros:");
             Console.WriteLine($"Extensión Total: {extensionLibros}");
             Console.WriteLine($"Cantidad Total: {cantidadLibros}");
             Console.WriteLine("Resumen:");
             Console.WriteLine(resumenLibros);
            */

            //Segundo test
            /* // Crear un escáner
             Escaner escaner = new Escaner("Canon", Escaner.TipoDoc.libro);

             Documento doc1 = new Libro("El Quijote", "Miguel de Cervantes", 1605, "ISBN123", "123456", 500);
             Documento doc2 = new Libro("1984", "George Orwell", 1949, "ISBN456", "789012", 300);
             Documento doc3 = new Mapa("Mapa del mundo", "Autor", 2024, "Map123", "MapCode", 100, 200);
             escaner.ListaDocumentos.Add(doc1);
             escaner.ListaDocumentos.Add(doc2);
             escaner.ListaDocumentos.Add(doc3);

             // Mostrar los documentos antes de cambiar el estado
             Console.WriteLine("Documentos antes de cambiar el estado:");
             foreach (Documento doc in escaner.ListaDocumentos)
             {
                 Console.WriteLine($"{doc.Titulo} - Estado: {doc.Estado}");
             }

             // Cambiar el estado de un documento existente (en este caso, el primer documento en la lista)
             Console.WriteLine("\nCambiando el estado del primer documento...");
             bool cambioExitoso = escaner.CambiarEstadoDocumento(doc1);

             // Mostrar el resultado del cambio de estado
             Console.WriteLine($"El cambio de estado fue exitoso: {cambioExitoso}");

             // Mostrar los documentos después de cambiar el estado
             Console.WriteLine("\nDocumentos después de cambiar el estado:");
             foreach (Documento doc in escaner.ListaDocumentos)
             {
                 Console.WriteLine($"{doc.Titulo} - Estado: {doc.Estado}");
             }*/

            //primer testeo
            /* Libro doc = new Libro("el jaja", "epe", 12, "ee", "ddd",10);
             Libro doc2 = new Libro("el jajas", "pepe", 12, "e", "dd", 10);

             Mapa m1 = new Mapa("dune","argento",2003,"algo","ppp222",2,2);

             //onsole.WriteLine(doc.ToString());
            // Console.WriteLine(doc2.ToString());

             Console.WriteLine(m1.ToString());

             Console.WriteLine(doc == doc2);*/



        }
    }
}
