﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace asset_project.Shared.Entities
{
    public class Persona
    {
        public int Id { get; set; }

        [Display(Name = "Nombres")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Nombres { get; set; } = string.Empty;

        [Display(Name = "Apellidos")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Apellidos { get; set; } = string.Empty;

        [Display(Name = "Fecha Nacimiento")]
        public DateTime? FechaNacimiento { get; set; } = null;

        [Display(Name = "Genero")]
        public string Genero { get; set; } = string.Empty;

        [Display(Name = "Direccion")]
        public string Direccion { get; set; } = string.Empty;

        [Display(Name = "Correo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Correo { get; set; } = string.Empty;

        [Display(Name = "Numero Teléfono")]
        [MaxLength(15, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string NumeroTelefono { get; set; } = string.Empty;

        [Display(Name = "Numero Identificación")]
        [MaxLength(12, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string NumeroIdentificacion { get; set; } = string.Empty;

        [Display(Name = "Tipo Identificación")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public TipoIdentificacion? TipoIdentificacion { get; set; }

        [Display(Name = "Ciudad")]
        public string? Ciudad { get; set; }


    }
}
