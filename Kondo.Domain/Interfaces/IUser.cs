﻿using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace Kondo.Domain.Interfaces
{
    public interface IUser
    {
        Guid GetUserId();
        string Name { get; }
        bool IsAuthenticated();
        IEnumerable<Claim> GetClaimsIdentity();
    }
}
