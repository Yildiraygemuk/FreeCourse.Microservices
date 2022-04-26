using FreeCourse.Web.Models.Catalogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Web.Services.Abstract
{
    public interface ICatalogService
    {
        Task<List<CourseVm>> GetAllCourseAsync();
        Task<List<CategoryVm>> GetAllCategoryAsync();
        Task<List<CourseVm>> GetAllCourseByUserIdAsync(string userId);
        Task<CourseVm> GetByCourseId(string courseId);
        Task<bool> CreateCourseAsync(CourseCreateInput courseCreateInput);
        Task<bool> UpdateCourseAsync(CourseUpdateInput courseUpdateInput);
        Task<bool> DeleteCourseAsync(string courseId);
    }
}
