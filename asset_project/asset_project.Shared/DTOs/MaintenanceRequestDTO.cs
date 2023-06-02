using asset_project.Shared.Entities;
using System.ComponentModel.DataAnnotations;

namespace asset_project.Shared.DTOs
{
    public class MaintenanceRequestDTO
    {
        [Display(Name = "Fecha de registro")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public DateTime RegisterDate { get; set; }

        [Display(Name = "Usuario")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string? UserName { get; set; }

        public string? UserId { get; set; }

        [Display(Name = "Activo fijo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int AssetId { get; set; }

        [Display(Name = "Justificación")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string? Justification { get; set; }
    }
}
