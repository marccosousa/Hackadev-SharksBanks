﻿using Microsoft.IdentityModel.Tokens;
using SharkBank.API.Domain.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SharkBank.API.Domain.Services
{
    public class TokenService
    {
        public string GerarToken(Usuario usuario)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Settings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(type: ClaimTypes.Name, value: usuario.Nome),
                    new Claim(type: ClaimTypes.DateOfBirth, value: usuario.DataNascimento.ToString()),
                    new Claim(type: ClaimTypes.Email, value: usuario.Email),
                }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey (key), algorithm:SecurityAlgorithms.HmacSha256Signature),

            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
