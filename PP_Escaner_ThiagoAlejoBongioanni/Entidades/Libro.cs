using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro : Documento
    {
        int numPaginas;

        public Libro(string titulo,string autor,int anio,string numNormalizado,string codebar,int numPaginas)
            : base(titulo, autor, anio, numNormalizado,codebar)
        {
            this.numPaginas = numPaginas;
        }

        public int NumPaginas { get => numPaginas;}
        public string ISBN { get => this.NumNormalizado; }


        public static bool operator ==(Libro libro1, Libro libro2)
        {
            bool retorno = false;

            if (ReferenceEquals(libro1, null) || ReferenceEquals(libro2, null))
            {
                retorno = false;
            }
            else
            {
                retorno = libro1.Barcode == libro2.Barcode || libro1.ISBN == libro2.ISBN || (libro1.Titulo == libro2.Titulo && libro1.Autor == libro2.Autor);
            }
            return retorno;
        }
        public static bool operator !=(Libro libro1,Libro libro2)
        {
            return !(libro1 == libro2);
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder(base.ToString());

            int barcodeIndex = text.ToString().IndexOf("Cod. de Barras:");

            // Si se encuentra "Cod. de Barras:", insertar la línea de ISBN antes de ella
            if (barcodeIndex != -1)
            {
                text.Insert(barcodeIndex, $"ISBN: {this.ISBN}\n");
            }
            text.AppendLine($"Numero de paginas: {this.NumPaginas}");
           
            return text.ToString();
        }
    }
}
