using System.ComponentModel.DataAnnotations;

namespace LoginProjectDomain.ViewModels
{
    public class LatestNewsViewModelWeblog
    {
        public int Id { get; set; }
        [Display(Name = "تیتر خبر")]
        public string Title { get; set; } = string.Empty;
        [Display(Name = "خلاصه خبر")]
        public string NewsTextSummary { get; set; } = string.Empty;
        public string? Image { get; set; }

    }
}
