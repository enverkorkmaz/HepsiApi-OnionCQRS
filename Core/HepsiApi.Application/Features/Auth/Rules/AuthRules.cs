﻿using HepsiApi.Application.Bases;
using HepsiApi.Application.Features.Auth.Exceptions;
using HepsiApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HepsiApi.Application.Features.Auth.Rules
{
    public class AuthRules : BaseRules
    {
        public Task UserShouldNotBeExist(User? user)
        {
            if (user is not null) throw new UserAlreadyExistException();
            return Task.CompletedTask;
        }

        public Task EmailOrPasswordShouldNotBeInvalid(User? user,bool checkPassword)
        {
            if (user is null || !checkPassword) throw new EmailOrPasswordShouldNotBeInvalidException();
            return Task.CompletedTask;
        }

        public Task RefreshTokenShouldNotBeExpired(DateTime? expireDate)
        {
            if (expireDate <= DateTime.Now) throw new RefreshTokenShouldNotBeExpired();
            return Task.CompletedTask;
        }

        internal Task EmailAddressShouldbeValid(User? user)
        {
            if (user is null) throw new EmailAddressShouldbeValidException();
            return Task.CompletedTask;
        }
    }
}
