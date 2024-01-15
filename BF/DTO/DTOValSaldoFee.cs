using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BF.DTO
{
    public class DTOValSaldoFee
    {
        public int id { get; set; }
        public decimal valorActual { get; set; } 
        public decimal? valorAnterior { get; set; }
        public int tipo { get; set; }
    }
}
