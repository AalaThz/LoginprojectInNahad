using System.ComponentModel.DataAnnotations;

namespace LoginProjectDomain.Models
{
    public class LatestNewsBlog
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "عنوان")]
        public string Title { get; set; }

        [Display(Name = "دسته بندی")]
        public string Category { get; set; }

        [Display(Name = "توضیحات")]
        public string Description { get; set; }

        public string? Image { get; set; }
    }
}
