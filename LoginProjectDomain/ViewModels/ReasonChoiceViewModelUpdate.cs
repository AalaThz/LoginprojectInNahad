
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProjectDomain.ViewModels
{
    public class ReasonChoiceViewModelUpdate
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int OrderBy { get; set; }
        public string? Icon { get; set; }
    }
}
