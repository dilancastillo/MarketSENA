using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarketSENA.Models
{
    public class ModeloNegocio
    {
        [Key]
        public int ModeloNegocioID { get; set; }
        public string Descripcion { get; set; }
    }
}
