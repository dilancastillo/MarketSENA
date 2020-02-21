using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarketSENA.Models
{
    public class CiiuClase
    {
        [Key]
        public int CiiuClaseID { get; set; }
        public int CiiuGrupoID { get; set; }
        public CiiuGrupo CiiuGrupo { get; set; }
        public string Descripcion { get; set; }
        public string Codigo { get; set; }
    }
}
