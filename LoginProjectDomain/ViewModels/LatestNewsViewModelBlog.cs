using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProjectDomain.ViewModels
{
    public class LatestNewsViewModelBlog
    {
        public int Id { get; set; }
        
        
        [Display(Name = "عنوان خبر")]
        public string Title { get; set; } = string.Empty;
        [Display(Name = "متن خبر")]
        public string NewsText { get; set; } = string.Empty;
        [Display(Name = "خلاصه خبر")]
        public string NewsTextSummary { get; set; }
        public string? Image { get; set; } 
    }
}
