using System;
using System.Collections.Generic;

namespace BF.Models.Staffing
{
    public partial class StMSolicitudStaffing
    {
        public int Id { get; set; }
        public int? IdOportunidad { get; set; }
        public double? HrsAcumuladoLider { get; set; }
        public double? HrsAcumuladoSocio { get; set; }
        public double? HrsAcumuladoSeniorManager { get; set; }
        public double? HrsAcumuladoManager { get; set; }
        public double? HrsAcumuladoSenior { get; set; }
        public double? HrsAcumuladoStaff { get; set; }
        public double? HrsAcumuladoTrainee { get; set; }
        public double? TnrProyectado { get; set; }
        public double? TnrYtd { get; set; }
        public double? DesviacionPresupuesto { get; set; }
        public double? TnrProyectadoPercent { get; set; }
        public double? TnrYtdPercent { get; set; }
        public double? DesvHorasLider { get; set; }
        public double? DesvHorasSocio { get; set; }
        public double? DesvHorasSeniorManager { get; set; }
        public double? DesvHorasManager { get; set; }
        public double? DesvHorasSenior { get; set; }
        public double? DesvHorasStaff { get; set; }
        public double? DesvHorasTrainee { get; set; }
        public string Comentario { get; set; }
        public int? FlgAprobado { get; set; }
        public DateTime? FecAprobado { get; set; }
        public DateTime? FecCreacion { get; set; }
        public string UsuCreacion { get; set; }
        public string UsuModificacion { get; set; }
        public DateTime? FecModificacion { get; set; }
        public int? FlgActivo { get; set; }
    }
}
