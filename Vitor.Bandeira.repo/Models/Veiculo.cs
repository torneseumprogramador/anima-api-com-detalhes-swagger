using System.ComponentModel.DataAnnotations;

namespace Vitor.Bandeira.Models
{
    public class Veiculo
    {
        [Key]
        public int VeiculoId { get; set; }
        [MaxLength(100), Required]
        public string? Nome { get; set; }
        [MaxLength(20), Required]
        public string? Marca { get; set; }
        [MaxLength(50)]
        public string? Modelo { get; set; }
        [MaxLength(10)]
        public string? Placa { get; set; }
    }
}