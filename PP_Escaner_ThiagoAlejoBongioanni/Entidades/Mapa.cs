using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mapa : Documento
    {
        int alto;
        int ancho;

        public Mapa(string titulo, string autor, int anio, string numNormalizado, string codebar,int alto, int ancho)
            :base(titulo,autor,anio,"", codebar)
        {
            this.alto = alto;
            this.ancho = ancho;
            
        }

        public int Alto { get => alto;}
        public int Ancho { get => ancho; }
        public int Superficie { get => alto * ancho; }

        public static bool operator ==(Mapa m1, Mapa m2)
        {
            bool retorno = false;

            if (ReferenceEquals(m1, null) || ReferenceEquals(m2, null))
            {
                retorno = false;
            }
            else
            {
                retorno = m1.Barcode == m2.Barcode || (m1.Titulo == m2.Titulo && m1.Autor == m2.Autor && m1.Anio == m2.Anio && m1.Superficie == m2.Superficie);
            }
            return retorno;
        }
        public static bool operator !=(Mapa m1, Mapa m2)
        {
            return !(m1 == m2);
        }

        public override string ToString()
        {

            StringBuilder text = new StringBuilder(base.ToString());
            text.AppendLine($"Superficie: {this.Ancho} * {this.Alto} = {this.Superficie} cm2.");

            if(this.NumNormalizado != "")
            {
                text.AppendLine($"ISBN:{this.NumNormalizado}");
            }
            return text.ToString();
        }
    }
}
