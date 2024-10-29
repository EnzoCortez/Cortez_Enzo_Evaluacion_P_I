﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Cortez_Enzo_Evaluacion_P_I.Models
{
    public class ECortez
    {
        [Required]
        [Key]
        public int Cedula { get; set; }

        [StringLength(200)]
        public string Nombre {  get; set; }

        [AllowNull]
        [Range(0,100)]
        public decimal Mesada { get; set; }

        [AllowNull]
        public Boolean? Estudiante { get; set; }
        public DateOnly? Cummpleaños { get; set; }

        public Celular Celular { get; set; }

        [ForeignKey("Celular")]
        public int CelularId { get; set; }

    }
}
