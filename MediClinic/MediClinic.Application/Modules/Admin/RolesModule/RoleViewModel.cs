using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.RolesModule
{
    public class RoleViewModel
    {
        public int? Id { get; set; }
        public int? CreatedUserId { get; set; }
        public string Name { get; set; }
        public List<string> Claims { get; set; }
    }
}
