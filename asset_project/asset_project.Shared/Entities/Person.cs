using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace asset_project.Shared.Entities
{
    public class Person
    {
        public int Id { get; set; }

        [Display(Name = "Nombres")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string FirstName { get; set; } = string.Empty;

        [Display(Name = "Apellidos")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string LastName { get; set; } = string.Empty;

        [Display(Name = "Fecha Nacimiento")]
        public DateTime? BirthDate { get; set; } = null;

        [Display(Name = "Genero")]
        public string Genre { get; set; } = string.Empty;

        [Display(Name = "Direccion")]
        public string Address { get; set; } = string.Empty;

        [Display(Name = "Correo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Email { get; set; } = string.Empty;

        [Display(Name = "Numero Teléfono")]
        [MaxLength(15, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Display(Name = "Numero Identificación")]
        [MaxLength(12, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string IdentificationNumber { get; set; } = string.Empty;

        [Display(Name = "Tipo Identificación")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public IdentificationType? IdentificationType { get; set; }

        [Display(Name = "Ciudad")]
        public City? City { get; set; }

        public int CityId { get; set; }

        public int Status { get; set; } = 0;
    }
}
