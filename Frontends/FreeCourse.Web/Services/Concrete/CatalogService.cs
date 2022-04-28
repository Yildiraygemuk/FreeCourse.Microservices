using FreeCourse.Shared.Dtos;
using FreeCourse.Web.Models.Catalogs;
using FreeCourse.Web.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace FreeCourse.Web.Services.Concrete
{
    public class CatalogService : ICatalogService
    {
        private readonly HttpClient _client;

        public CatalogService(HttpClient client)
        {
            _client = client;
        }

        public async Task<bool> CreateCourseAsync(CourseCreateInput courseCreateInput)
        {
            var response = await _client.PostAsJsonAsync<CourseCreateInput>("course", courseCreateInput);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteCourseAsync(string courseId)
        {
            var response = await _client.DeleteAsync($"course/{courseId}");
            return response.IsSuccessStatusCode;
        }

        public async Task<List<CategoryVm>> GetAllCategoryAsync()
        {
            var response = await _client.GetAsync("category");
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            var responseSuccess = await response.Content.ReadFromJsonAsync<Response<List<CategoryVm>>>();
            return responseSuccess.Data;
        }

        public async Task<List<CourseVm>> GetAllCourseAsync()
        {
            var response = await _client.GetAsync("course");
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            var responseSuccess = await response.Content.ReadFromJsonAsync<Response<List<CourseVm>>>();
            return responseSuccess.Data;
        }

        public async Task<List<CourseVm>> GetAllCourseByUserIdAsync(string userId)
        {
            var response = await _client.GetAsync($"course/GetAllByUserId/{userId}");
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            var responseSuccess = await response.Content.ReadFromJsonAsync<Response<List<CourseVm>>>();
            return responseSuccess.Data;
        }

        public async Task<CourseVm> GetByCourseId(string courseId)
        {
            var response = await _client.GetAsync($"course//{courseId}");
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            var responseSuccess = await response.Content.ReadFromJsonAsync<Response<CourseVm>>();
            return responseSuccess.Data;
        }

        public async Task<bool> UpdateCourseAsync(CourseUpdateInput courseUpdateInput)
        {
            var response = await _client.PutAsJsonAsync<CourseUpdateInput>("course", courseUpdateInput);
            return response.IsSuccessStatusCode;
        }
    }
}
