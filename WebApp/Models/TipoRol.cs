using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarketSENA.Models
{
    public class TipoRol
    {
        [Key]
        public int TipoRolID { get; set; }
        public int RolID { get; set; }
        public Rol Rol { get; set; }
        public int UsuarioID { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime FechaInicio { get; set; }
    }
}
