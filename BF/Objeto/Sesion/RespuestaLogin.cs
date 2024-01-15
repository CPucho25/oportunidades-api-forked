using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BF.Objeto.Sesion
{
    public class RespuestaLogin
    {
        public bool IsAuth { get; set; }
        public string Mensaje { get; set; }
        public string token { get; set; }

        
       // public virtual DTO.DTOTransfDirecta DTOTransfDirecta_ { get; set; }
        
        public int Idioma { get; set; }
        #region Listas
        //public virtual DTO.DTODatosGenBen DTODatosGenBen_ { get; set; }
        //public virtual List<DTO.DTOUsuMTpoDoc> lstDTOUsuMTpoDoc_ { get; set; }
        //public virtual List<DTO.DTOBfMPais> lstDTOBfMPais_ { get; set; }
        //public virtual List<DTO.DTOBfMEstadoCivil> lstDTOBfMEstadoCivil_ { get; set; }
        //public virtual List<DTO.DTOBfMRegPatrimonial> lstDTOBfMRegPatrimonial_ { get; set; }
        #endregion
        //public virtual DTO.DTOEtiquetaIdioma Etiquetaidioma_ { get; set; }

    }
}
