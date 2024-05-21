using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Informes
    {

        private static void MostrarDocumentosPorEstado(Escaner e,Documento.Paso estado ,out int extension, out int cantidad, out string resumen)
        {
            extension = 0;
            cantidad = 0;
            StringBuilder resumenBuilder = new StringBuilder();

            foreach (Documento doc in e.ListaDocumentos)
            {
                if (doc.Estado == estado)
                {

                    if (e.Tipo == Escaner.TipoDoc.libro && doc is Libro libro)
                    {
                        cantidad++;
                        extension += libro.NumPaginas;
                        resumenBuilder.AppendLine(libro.ToString());
                    }
                    else if (e.Tipo == Escaner.TipoDoc.mapa && doc is Mapa mapa)
                    {
                        cantidad++;
                        extension += mapa.Superficie;
                        resumenBuilder.AppendLine(mapa.ToString());
                    }
                }

            }
           resumen = resumenBuilder.ToString();
        }

        public static void MostrarDistribuidos(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            MostrarDocumentosPorEstado(e,Documento.Paso.Distribuido,out extension,out cantidad,out resumen);
        }

        public static void MostrarEnEscaner(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            MostrarDocumentosPorEstado(e, Documento.Paso.EnEscaner, out extension, out cantidad, out resumen);
        }

        public static void MostrarEnRevision(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            MostrarDocumentosPorEstado(e, Documento.Paso.EnRevision, out extension, out cantidad, out resumen);
        }

        public static void MostrarTerminados(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            MostrarDocumentosPorEstado(e, Documento.Paso.Terminado, out extension, out cantidad, out resumen);
        }
    }
}
