using FreeCourse.Shared.Dtos;
using FreeCourse.Web.Models;
using IdentityModel.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Web.Services.Abstract
{
    public interface IIdentityService
    {
        Task<Response<bool>> SingIn(SignInInputVm signInInputVm);
        Task<TokenResponse> GetAccessTokenByRefreshToken();
        Task RevokeRefreshToken();
    }
}
