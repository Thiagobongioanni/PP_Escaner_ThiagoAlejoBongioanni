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

            if (tipo == TipoDoc.mapa)
            {
                this.locacion = Departamento.mapoteca;
            }
            else if (tipo == TipoDoc.libro)
            {
                this.locacion = Departamento.procesosTecnicos;
            }
        }

        public List<Documento> ListaDocumentos { get => listaDocumentos;}
        public Departamento Locacion { get => locacion;}
        public string Marca { get => marca;}
        public TipoDoc Tipo { get => tipo;}

        public static bool operator ==(Escaner e, Documento d)
        {
            bool retorno = false;

            // Verificar si cualquiera de los objetos es null
            

            if (d != null && e.ListaDocumentos != null)
            {
                foreach (Documento doc in e.ListaDocumentos)
                {
                    // nunca sobrecarge equals no funcionaba correctamente en la version anterior
                    if (doc.Titulo == d.Titulo && doc.Autor == d.Autor && doc.Anio == d.Anio && doc.Barcode == d.Barcode)
                    {
                        retorno = true;
                    }
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

            if (ReferenceEquals(e, null) || ReferenceEquals(d, null))
            {
                retorno =  false;
            }
            else
            {
                if (e.ListaDocumentos != null)
                {
                    if (e != d && d.Estado == Documento.Paso.Inicio)
                    {
                        d.AvanzarEstado();
                        e.ListaDocumentos.Add(d);

                        retorno = true;
                    }
                }
            }
            return retorno;
        }

        public bool CambiarEstadoDocumento(Documento d)
        {
            bool retorno = false;

            if (d == null)
            {
                retorno = false;
            }
            else
            {

                foreach (Documento docu in ListaDocumentos)
                {
                    if (this.ListaDocumentos.Contains(d))
                    {
                        docu.AvanzarEstado(); // Cambiar el estado del documento encontrado en ListaDocumentos
                        retorno = true; // Documento encontrado y estado cambiado
                    }

                }
            }
            return retorno;
        }
    }
}
