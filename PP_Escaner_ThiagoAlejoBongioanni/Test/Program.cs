using Entidades;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

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
                Console.WriteLine($"{doc.Titulo} - Estado: {doc.Estado}");
            }
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
