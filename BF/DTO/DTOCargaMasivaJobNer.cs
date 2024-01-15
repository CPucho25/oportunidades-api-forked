using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BF.DTO
{
    public class DTOCargaMasivaJobNer { 
        public List<DTOJobNer> cargaMasivas { get;set; } //Es una lista q contiene el tempDataBase
        public string usuCreacion { get; set; } //Viene junto al request
        public string usuModificacion { get; set; } //Viene junto al request
    }
}
