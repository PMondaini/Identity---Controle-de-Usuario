﻿using System;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System.Threading.Tasks;

namespace UsuariosApi.Authorization
{
    public class IdadeAuthorization : AuthorizationHandler<IdadeMinima>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, IdadeMinima requirement)
        {
            var dataNascimentoClaim = context.User.FindFirst(claim =>
                claim.Type == ClaimTypes.DateOfBirth);

            if (dataNascimentoClaim is null)
            {
                return Task.CompletedTask;
            }

            var dataNascimento = Convert.ToDateTime(dataNascimentoClaim.Value);

            int idadeUsuario = DateTime.Today.Year - dataNascimento.Year;

            if(dataNascimento > DateTime.Today.
                AddYears(-idadeUsuario)) { idadeUsuario--; };

            if (idadeUsuario >= requirement.Idade) { context.Succeed(requirement); }

            return Task.CompletedTask;
                    

        }
    }
}
