using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.crud.dundermifflin.Entities;

public class Funcionario
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Nome { get; set; }

    [Required]
    [StringLength(100)]
    public string Sobrenome { get; set; }

    [Required]
    [Column("data_nascimento")]
    public DateTime DataNascimento { get; set; }

    [StringLength(200)]
    public string Endereco { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Salario { get; set; }

    [Required]
    [StringLength(100)]
    public string Cargo { get; set; }

    [StringLength(100)]
    public string Departamento { get; set; }

    [Required]
    [Column("data_contratacao")]
    public DateTime DataContratacao { get; set; }
}
