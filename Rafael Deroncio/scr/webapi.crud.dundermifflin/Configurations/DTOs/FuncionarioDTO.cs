using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.crud.dundermifflin.Configurations.DTOs;

public class FuncionarioDTO
{
    [Required, MaxLength(128)]
    public string Nome { get; set; }

    [Required, MaxLength(128)]
    public string Sobrenome { get; set; }

    [Column("data_nascimento")]
    [Required, DataType(DataType.Date)]
    public DateTime DataNascimento { get; set; }

    [Required, MaxLength(128)]
    public string Endereco { get; set; }

    [DefaultValue(0)]
    public decimal Salario { get; set; }

    [Required, MaxLength(128)]
    public string Cargo { get; set; }

    [Required, MaxLength(128)]
    public string Departamento { get; set; }

    [Column("data_contratacao")]
    [Required, DataType(DataType.Date)]
    public DateTime DataContratacao { get; set; }
}
