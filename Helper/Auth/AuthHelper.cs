using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace personalAPI.Helper.Auth
{
    public class AuthHelper
    {
        public static string GenerateJWT(List<Claim> claims)
        {
            var bytes = Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("LOGIN_SECRET_KEY"));
            var secKey = new SymmetricSecurityKey(bytes);
            var signature = new SigningCredentials(secKey, SecurityAlgorithms.HmacSha256);
            
            var tokenOpts = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddMinutes(60),
                signingCredentials: signature
            );

            return new JwtSecurityTokenHandler().WriteToken(tokenOpts);
        }
    }
}