using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.crud.dundermifflin.Configurations.DTOs
{
    public class FuncionarioDTO : IValidatableObject
    {
        [Required(ErrorMessage = "O Nome é obrigatório."), MaxLength(128)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Sobrenome é obrigatório."), MaxLength(128)]
        public string Sobrenome { get; set; }

        [Column("data_nascimento")]
        [Required(ErrorMessage = "A Data de Nascimento é obrigatória."), DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O Endereço é obrigatório."), MaxLength(128)]
        public string Endereco { get; set; }

        [DefaultValue(0)]
        [Range(0, double.MaxValue, ErrorMessage = "O Salário deve ser maior ou igual a zero.")]
        public decimal Salario { get; set; }

        [Required(ErrorMessage = "O Cargo é obrigatório."), MaxLength(128)]
        public string Cargo { get; set; }

        [Required(ErrorMessage = "O Departamento é obrigatório."), MaxLength(128)]
        public string Departamento { get; set; }

        [Column("data_contratacao")]
        [Required(ErrorMessage = "A Data de Contratação é obrigatória."), DataType(DataType.Date)]
        public DateTime DataContratacao { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrWhiteSpace(Nome))
                yield return new ValidationResult("O Nome não pode ser vazio.", new[] { nameof(Nome) });

            if (string.IsNullOrWhiteSpace(Sobrenome))
                yield return new ValidationResult("O Sobrenome não pode ser vazio.", new[] { nameof(Sobrenome) });

            if (string.IsNullOrWhiteSpace(Endereco))
                yield return new ValidationResult("O Endereço não pode ser vazio.", new[] { nameof(Endereco) });

            if (Salario < 0)
                yield return new ValidationResult("O Salário não pode ser negativo.", new[] { nameof(Salario) });

            if (DataNascimento > DateTime.Now)
                yield return new ValidationResult("A Data de Nascimento não pode estar no futuro.", new[] { nameof(DataNascimento) });

            if (Cargo.Length < 3)
                yield return new ValidationResult("O Cargo deve ter pelo menos 3 caracteres.", new[] { nameof(Cargo) });
        }
    }
}
