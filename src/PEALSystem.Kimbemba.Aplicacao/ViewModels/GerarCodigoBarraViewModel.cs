﻿using System;
using System.ComponentModel.DataAnnotations;

namespace PEALSystem.Kimbemba.Aplicacao.ViewModels
{
    public class GerarCodigoBarraViewModel
    {
        [Required]
        public int Quantidade { get; set; }
        [Required]
        public DateTime Data { get; set; }
    }
}
