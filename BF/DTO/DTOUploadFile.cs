using BF.Objeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BF.DTO
{
    public class DTOUploadFile
    {
        public List<UploadFile> ListaFactura { get; set; }  
        public string UsuCreacion { get; set; }
        public string FecCreacion { get; set; }
        public string FlgActivo { get; set; }
    }

}
