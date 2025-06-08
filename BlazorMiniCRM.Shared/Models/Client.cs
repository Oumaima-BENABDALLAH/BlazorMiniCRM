using System.ComponentModel.DataAnnotations;

namespace BlazorMiniCRM.Shared.Models
{
    public class Client
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Le nom du client est requis.")] // Rend le champ obligatoire
        [StringLength(100, ErrorMessage = "Le nom ne peut pas dépasser 100 caractères.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "L'adresse email est requise.")]
        [EmailAddress(ErrorMessage = "Format d'adresse email invalide.")] // Valide le format email
        [StringLength(150, ErrorMessage = "L'email ne peut pas dépasser 150 caractères.")]
        public string Email { get; set; } = string.Empty;


        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }

}
