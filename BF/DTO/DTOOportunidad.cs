using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BF.DTO
{
    public class DTOOportunidad
    {
        public int Id { get; set; }
        public int IdSolicitudStaffing { get; set; }
        public int IdPeriodo { get; set; }
        public int IdGerente { get; set; }
        public string NomGerente { get; set; }
        public int IdSocio { get; set; }
        public int IdUsuario { get; set; }
        public int IdEa { get; set; }
        public int IdEmpresa { get; set; }
        public int IdServicio { get; set; }
        public int IdSubservicio { get; set; }
        public int IdCondicion { get; set; }
        public int IdGrpeco { get; set; }
        public int IdSector { get; set; }
        public int IdEstado { get; set; }
        public int IdFee { get; set; }
        public int IdMoneda { get; set; }
        public decimal Fee { get; set; }
        public decimal Itan { get; set; }
        public decimal TarifHoraria { get; set; }
        public decimal CantHoras { get; set; }
        public decimal TotalMonto { get; set; }
        public decimal HonorarioTotal { get; set; }
        public decimal FeeSublinea { get; set; }
        public decimal Overrun { get; set; }
        public decimal TarifHorariaSublinea { get; set; }
        public decimal CantHorasSublinea { get; set; }
        public decimal TotalSublinea { get; set; }
        public int IdGastos { get; set; }
        public int GastosFijos { get; set; }
        public int GastosDetalle { get; set; }
        public string Engagement1 { get; set; }
        public string Engagement2 { get; set; }
        public string CompetenciaRdj { get; set; }
        public string QuienGano { get; set; }
        public string Comentarios { get; set; }
        public int IdRol { get; set; }
        public int IdArea { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime FecCreacion { get; set; }
        public string UsuModificacion { get; set; }
        public DateTime? FecModificacion { get; set; }
        public int? FlgActivo { get; set; }
        public int? FlgLimpiar { get; set; }

        public int? PsmFlag { get; set; }

        public double erpPresupuesto { get; set; }
        public double rentabilidad { get; set; } //euscuvil 11-01-2023
        //Inicio nuevos campos 13-04-2023
        public string eaf { get; set; }
        public string margen { get; set; }
        public string totalHoras { get; set; }
        public string idOportunidad { get; set; }
        public string propuestaFirmada { get; set; }
        public string numeroPace { get; set; }
        public string rutaGear { get; set; }
        public string rutaWorkSpace { get; set; }
        //Fin nuevos campos 13-04-2023

        public double horasSocio { get; set; }
        public double horasManager { get; set; }
        public double horasSenior { get; set; }
        public double horasStaff { get; set; }
        public double horasTrainee { get; set; }

        public double horasLider { get; set; }
        public double horasSeniormanager { get; set; }

        public double porcentajeEjecucion { get; set; }



    }
}
