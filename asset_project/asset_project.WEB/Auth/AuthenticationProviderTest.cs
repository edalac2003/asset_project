﻿using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace asset_project.WEB.Auth
{
    public class AuthenticationProviderTest : AuthenticationStateProvider
    {
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var anonimous = new ClaimsIdentity();
            var adminUser = new ClaimsIdentity(new List<Claim>
        {
            new Claim("FirstName", "Administrador"),
            new Claim("LastName", "administrador"),
            new Claim(ClaimTypes.Name, "admin@yopmail.com"),
            new Claim(ClaimTypes.Role, "Administrador")
        },
        authenticationType: "test");
            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(adminUser)));
        }
    }
}
