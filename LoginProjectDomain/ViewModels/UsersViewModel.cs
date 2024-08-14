using System.ComponentModel.DataAnnotations;

namespace LoginProjectUI.Models
{
    public class UsersViewModel
    {
        public Guid UserId { get; set; }

        [Display(Name = "نام کاربری")]
        public string UserName { get; set; }
        public string? Name { get; set; }

        [Display(Name = "نام خانوادگی")]
        public string? Family { get; set; }

        [Display(Name = "تاریخ تولد")]
        public DateTime? BirthDate { get; set; }
    }
}
