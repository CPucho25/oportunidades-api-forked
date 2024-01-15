using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BF.DTO
{
    public class DTOActualizarProgramacionFact2
    {  
        public string engagement { get; set; }//Se usa para filtrar
        public string ruc { get; set; }
        public int? id_oportunidad { get; set; }
        public string rzFacturarDif { get; set; }
        public string rucFacturarDif { get; set; }
        public int? nroCompraOc { get; set; }
        public int? hes { get; set; }
        public int? otroDocumento { get; set; }
        public string datosContacto { get; set; }
        public string condicionesProce { get; set; }
        
        

    }
}
