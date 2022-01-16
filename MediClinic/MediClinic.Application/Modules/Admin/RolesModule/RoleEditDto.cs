using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.RolesModule
{
    public class RoleEditDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> ClaimType { get; set; }
    }
    
}
