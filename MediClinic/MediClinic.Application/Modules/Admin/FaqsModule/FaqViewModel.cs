using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.FaqsModule
{
    public class FaqViewModel
    {
        public int? Id { get; set; }
        public int? CreatedUserId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
