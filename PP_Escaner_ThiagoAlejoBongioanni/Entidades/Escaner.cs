using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
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

            //no va aca encontrar otro lugar
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

        public static bool operator ==(Escaner e, Documento d)
        {
            bool retorno = false;

            foreach (Documento doc in e.ListaDocumentos)
            {
                // nunca sobre carge equals no funcionaba correctamente en la version anterior
                if (doc.Titulo == d.Titulo && doc.Autor == d.Autor && doc.Anio == d.Anio && doc.Barcode == d.Barcode)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Escaner e, Documento d)
        { 
            return  !(e == d);
        }

        public static bool operator +(Escaner e, Documento d)
        {
           
            bool retorno = false;

            if(e != d && d.Estado == Documento.Paso.Inicio)
            {
                //solucionar al cambiar primero el estado nunca modifica el estado del primer dato
       
                e.ListaDocumentos.Add(d);
                e.CambiarEstadoDocumento(d);
                retorno = true;
            }
           
            return retorno;
        }

        public bool CambiarEstadoDocumento(Documento d)
        {
            bool retorno = false;

            foreach (Documento docu in ListaDocumentos)
            {
                    retorno = true;
                    d.AvanzarEstado(); // Cambiar el estado del documento encontrado
                    break; // Salimos del bucle una vez que encontramos y cambiamos el estado del documento

            }

            return retorno;
        }
    }
}
