using System;

namespace webapi.crud.dundermifflin.Exceptions;

public class FuncionarioServiceUnavailableException : Exception
{
    public FuncionarioServiceUnavailableException() : base("O serviço de funcionários está indisponível no momento.")
    {
    }

    public FuncionarioServiceUnavailableException(string message) : base(message)
    {
    }

    public FuncionarioServiceUnavailableException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
