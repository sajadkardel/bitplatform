﻿namespace BlazorDual.Shared.Exceptions;
public class ServerConnectionException : UnknownException
{
    public ServerConnectionException()
        : base(nameof(AppStrings.ServerConnectionException))
    {
    }

    public ServerConnectionException(string message)
        : base(message)
    {
    }

    public ServerConnectionException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
