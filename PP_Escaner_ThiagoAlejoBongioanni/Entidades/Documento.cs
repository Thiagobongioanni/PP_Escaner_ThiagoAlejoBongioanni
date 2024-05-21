using System.Numerics;
using System.Text;

namespace Entidades
{
    public abstract class Documento
    {
        public enum Paso
        {
            Inicio,
            Distribuido,
            EnEscaner,
            EnRevision,
            Terminado
        }

        int anio;
        string autor;
        string barcode;
        Paso estado;
        string numNormalizado;
        string titulo;

        public Documento(string titulo,string autor,int anio,string numNormalizado,string barcode)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anio = anio;
            this.numNormalizado = numNormalizado;
            this.barcode = barcode;
            this.estado = Paso.Inicio; // Inicializar el estado en Inicio
        }

        public int Anio { get => anio;}
        public string Autor { get => autor;}
        public string Barcode { get => barcode;}
        public Paso Estado { get => estado;}
        protected string NumNormalizado { get => numNormalizado;}
        public string Titulo { get => titulo;}

        public bool AvanzarEstado()
        {
            bool retorno = true;

            if (Estado == Paso.Terminado)
            {
                retorno = false;
            }
            
            estado = estado + 1;
            return retorno;
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine($"Titulo: {this.Titulo}");
            text.AppendLine($"Autor: {this.Autor}");
            text.AppendLine($"Año: {this.Anio}");
            text.AppendLine($"Cod. de Barras: {this.Barcode}");

            return text.ToString();
        }

    }
}
