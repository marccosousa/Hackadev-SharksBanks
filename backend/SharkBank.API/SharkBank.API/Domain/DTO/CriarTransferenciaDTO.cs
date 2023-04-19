﻿using SharkBank.API.Domain.Models.Enums;

namespace SharkBank.API.Domain.DTO
{
    public class CriarTransferenciaDTO
    {
        public double Valor { get; set; }
        public TipoTransacao Tipo { get; set; }
        public int ContaId { get; set; }
    }
}
