﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarketSENA.Models
{
    public class CiiuGrupo
    {
        [Key]
        public int CiiuGrupoID { get; set; }
        public int CiiuDivisionID { get; set; }
        public CiiuDivision CiiuDivision { get; set; }
        public string Descripcion { get; set; }
        public string Codigo { get; set; }
    }
}
