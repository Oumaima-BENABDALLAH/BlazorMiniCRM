using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorMiniCRM.Shared.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La date de la commande est requise.")]
        public DateTime DateOrder { get; set; }

        [Required(ErrorMessage = "Le montant est requis.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Le montant doit être positif.")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Montant { get; set; }

        [Required(ErrorMessage = "Veuillez sélectionner un client.")]
        [Range(1, int.MaxValue, ErrorMessage = "Veuillez sélectionner un client valide.")]
        public int ClientId { get; set; }

        public Client? Client { get; set; }
    }
}