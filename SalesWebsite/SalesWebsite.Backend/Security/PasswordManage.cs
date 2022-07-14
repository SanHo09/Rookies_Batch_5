﻿using System.Security.Cryptography;

namespace SalesWebsite.Backend.Security
{
    public static class PasswordManage
    {
        public static void CreatePasswordHash(string password, 
                                                  out byte[] passwordHash,
                                                  out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        public static bool VerifiPasswordHash(string password, 
                                                    byte[] passwordHash,
                                                    byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
            return false;
        }
    }
}