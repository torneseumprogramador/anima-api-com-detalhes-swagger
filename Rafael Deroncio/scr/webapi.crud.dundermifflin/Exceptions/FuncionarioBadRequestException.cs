using System;

namespace webapi.crud.dundermifflin.Exceptions;

public class FuncionarioBadRequestException : Exception
{
    public FuncionarioBadRequestException() : base("Requisição inválida para o funcionário.")
    {
    }

    public FuncionarioBadRequestException(string message) : base(message)
    {
    }

    public FuncionarioBadRequestException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
