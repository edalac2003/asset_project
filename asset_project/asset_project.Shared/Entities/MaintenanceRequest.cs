using System.ComponentModel.DataAnnotations;

namespace asset_project.Shared.Entities
{
    public class MaintenanceRequest
    {
        public int Id { get; set; }

        [Display(Name = "Fecha de registro")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public DateTime? RegisterDate { get; set; } = null!;

        public DateTime? ClousureDate { get; set; } = null!;

        [Display(Name = "Justificación")]
        [MaxLength(300, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string? Justification { get; set; }

        public string? UserName { get; set; }

        [Display(Name = "Observaciones")]
        [MaxLength(300, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string? Notes { get; set; }
                
        public StatusType? StatusType { get; set; } = null!;

        public int StatusTypeId { get; set; }

        public Asset? Asset { get; set; } = null!;

        public int AssetId { get; set; }
    }
}
