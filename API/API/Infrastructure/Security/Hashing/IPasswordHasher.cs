﻿namespace CLERP.API.Infrastructure.Security.Hashing
{
    public interface IPasswordHasher
    {
        string HashPassword(string password);
        bool PasswordMatches(string providedPassword, string passwordHash);
    }
}
