﻿namespace Todo.API.Services
{
    public class JwtOptions
    {
        public string Key { get; init; } = string.Empty;
        public string Issuer { get; init; } = string.Empty;
        public string Audience { get; init; } = string.Empty;
        public int ExpireMinutes { get; init; } = 60;
    }
}
