using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProjectDomain.Models
{
    public class LastNews
    {
        public int Id { get; set; }
        [Display(Name ="تاریخ خیر")]
        public DateTime NewsDate{ get; set; }
        [Display(Name ="نام کاربری")]
        public string UserName{ get; set; } = string.Empty;
        [Display(Name ="تیتر خبر")]
        public string Title { get; set; } = string.Empty;
        [Display(Name ="متن خبر")]
        public string NewsText { get; set; } = string.Empty ;
        public string? Image { get; set; }
    }
}
