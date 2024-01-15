using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BF.DTO
{
    public class DTOUsuario
    { 
        public int Id { get; set; }
        public int? IdRol { get; set; }
        public int? IdArea { get; set; }
        public string Descripcion { get; set; }
        public string Password { get; set; }
        public string DescripcionLarga { get; set; }
        public DateTime FecCreacion { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime FecModificacion { get; set; }
        public string UsuModificacion { get; set; }
        public int? FlgActivo { get; set; }
        public int? FlgAdmin { get; set; }
        //public string IdGerente { get; set; }
        //public string Correo { get; set; }
        public List<DTORelacionGerente>  lstGerente { get; set; }
    }
}
