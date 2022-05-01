using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Web.Models.Catalogs
{
    public class CourseUpdateInput
    {
        public string Id { get; set; }
        [Display(Name = "Kurs ismi")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Açıklama")]
        [Required]
        public string Description { get; set; }
        [Display(Name = "Fiyat")]
        [Required]
        public decimal Price { get; set; }
        public string UserId { get; set; }
        public string Picture { get; set; }
        public FeatureVm Feature { get; set; }
        [Display(Name = "Kategori")]
        [Required]
        public string CategoryId { get; set; }
        [Display(Name = "Kurs fotoğraf")]
        public IFormFile PhotoFormFile { get; set; }
    }
}
