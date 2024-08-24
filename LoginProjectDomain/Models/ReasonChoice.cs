using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProjectDomain.Models
{
    public class ReasonChoice
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [Display(Name = "عنوان")]
        public string Title { get; set; } = string.Empty;
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [Display(Name = "توضیحات")]
        public string Description { get; set; } = string.Empty;
        public int OrderBy { get; set; }
        public string? Icon { get; set; }
    }
}
