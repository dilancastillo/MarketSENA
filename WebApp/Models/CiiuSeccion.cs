using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarketSENA.Models
{
    public class CiiuSeccion
    {
        [Key]
        public int CiiuSeccionID { get; set; }
        public string Descripcion { get; set; }
        public string Codigo { get; set; }
    }
}
