using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BF.Objeto
{
    //Objetivo: la Clase 'RespondSearchObject' agrega al DTO(objeto refrenciado en el controlador) data segun los parametros obetnidos del modelo(models)
    //y 'RespondSearchObject' Permite agregar los campos CodRef,Mensaje y Flag al objeto.
    public class RespondSearchObject <T> //Cuando se crea la clase 'RespondSearchObject' se agrega <T> como referencia para heredar al Objeto de turno(nombre y tipo de campos) cuando se invoca  en el controlador
    {
            public T Objeto { get; set; }//contiene los nombre de campos y tipo de datos del objeto
            public string CodigoRef { get; set; } //Nueva referencia creada a mano para devolver 
            public string Mensaje { get; set; }//Nueva referencia creada a mano para devolver 
            public bool Flag { get; set; }//Nueva referencia creada a mano para devolver 

            public RespondSearchObject()
            {
            }
            public RespondSearchObject(T objeto, string mensaje, bool flag)
            {
                Objeto = objeto;
                Mensaje = mensaje;
                Flag = flag;
            }
    }

}
