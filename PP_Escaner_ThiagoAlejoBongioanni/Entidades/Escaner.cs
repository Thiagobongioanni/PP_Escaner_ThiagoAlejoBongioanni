using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Escaner
    {
        public enum Departamento
        {
            nulo,
            mapoteca,
            procesosTecnicos
        }
        public enum TipoDoc
        {
            libro,
            mapa
        }


        List<Documento> listaDocumentos;
        Departamento locacion;
        string marca;
        TipoDoc tipo;

        public Escaner(string marca,TipoDoc tipo)
        {
            this.marca = marca;
            this.tipo = tipo;
            this.listaDocumentos = new List<Documento>();

            if (tipo == TipoDoc.mapa)
            {
                this.locacion = Departamento.mapoteca;
            }
            else if (tipo == TipoDoc.libro)
            {
                this.locacion = Departamento.procesosTecnicos;
            }
            else
            {
                this.locacion = Departamento.nulo; // Asignar un valor predeterminado si el tipo no es mapa o libro
            }
        }

        public List<Documento> ListaDocumentos { get => listaDocumentos;}
        public Departamento Locacion { get => locacion;}
        public string Marca { get => marca;}
        public TipoDoc Tipo { get => tipo;}


        public bool CambiarEstadoDocumento(Documento d)
        {
            bool retorno = false;

            foreach (Documento docu in ListaDocumentos)
            {
                if (docu.Equals(d)) // Suponiendo que la clase Documento tiene un método Equals adecuado
                {
                    retorno = docu.AvanzarEstado(); // Cambiar el estado del documento encontrado
                    break; // Salimos del bucle una vez que encontramos y cambiamos el estado del documento
                }
            }

            return retorno;
        }
    }
}
