using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using webapi.crud.dundermifflin.Configurations.DTOs;

namespace webapi.crud.dundermifflin.Entities;

public class Funcionario : FuncionarioDTO
{
    [Key]
    public int Id { get; set; }
}
