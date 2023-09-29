﻿using Core.Security.Entities;
using Core.Security.JWT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SecurityServices
{
    public interface IAuthsService
    {
        public Task<AccessToken> CreateAccessToken(User user);
        public Task<RefreshToken> CreateRefreshToken(User user);
        public Task<RefreshToken> AddRefreshToken(RefreshToken refreshToken);
        public Task<UserOperationClaim> CreateAndAddUserClaim(User user);
    }
}
