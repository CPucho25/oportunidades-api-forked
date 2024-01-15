using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BF.Models
{
    public partial class VWListarOportunidadXempresaPT
    {
        [Key]
        public int IdPeriodo { get; set; }
        public string DetPeriodo { get; set; }
        public int IdEmpresa { get; set; }
        public string Ruc { get; set; }
        public string RazonSocial { get; set; }
        public int IdCondicion { get; set; }
        public string DetCondicion { get; set; }
        public int IdGrpeco { get; set; }
        public string DetGrpeco { get; set; }
        public int IdSector { get; set; }
        public string DetSector { get; set; }
        public int TotOportEmp { get; set; }
        public int IdArea { get; set; }

    }
}
