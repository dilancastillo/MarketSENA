using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarketSENA.Models
{
    public class SectorEconomico
    {
        [Key]
        public int SectorEconomicoID { get; set; }
        public int CiiuClaseID { get; set; }
        public CiiuClase CiiuClase { get; set; }
        public string Codigo { get; set; }
        public string Tipo { get; set; }
    }
}
