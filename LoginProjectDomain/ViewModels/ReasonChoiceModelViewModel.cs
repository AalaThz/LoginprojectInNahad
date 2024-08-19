using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProjectDomain.ViewModels
{
    public class ReasonChoiceModelViewModel
    {
        public ReasonChoiceViewModel ReasonChoice { get; set; }
        public List<ReasonChoiceViewModel> ReasonChoiceList { get; set; }
    }

    public class ReasonChoiceViewModel
    {
        public int Id { get; set; }
        public string? Icon { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int OrderBy { get; set; }
    }
}
