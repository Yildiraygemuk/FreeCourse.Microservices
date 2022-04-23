using FreeCourse.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Web.Services.Abstract
{
    public interface IUserService
    {
        Task<UserVm> GetUser();
    }
}
