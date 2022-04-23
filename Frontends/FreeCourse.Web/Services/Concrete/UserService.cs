using FreeCourse.Web.Models;
using FreeCourse.Web.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace FreeCourse.Web.Services.Concrete
{
    public class UserService : IUserService
    {
        private readonly HttpClient _client;

        public UserService(HttpClient client)
        {
            _client = client;
        }

        public async Task<UserVm> GetUser()
        {
            return await _client.GetFromJsonAsync<UserVm>("/api/user/getuser");
        }
    }
}
