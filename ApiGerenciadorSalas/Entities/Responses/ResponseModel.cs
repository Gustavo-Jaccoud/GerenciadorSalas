﻿namespace ApiGerenciadorSalas.Entities.Responses;

public class ResponseModel<T>
{
    public T? Data { get; set; }
    public string Message { get; set; } = string.Empty;
    public int StatusCode { get; set; }
}