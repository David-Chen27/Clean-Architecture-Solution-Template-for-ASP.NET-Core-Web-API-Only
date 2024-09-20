﻿namespace Clean_Architecture.Application.Common.Interfaces;

public interface IUser
{
    string? Id { get; }
    string? IpAddress { get; }
    string? UserAgent { get; }
    string? TraceId { get; }
}
