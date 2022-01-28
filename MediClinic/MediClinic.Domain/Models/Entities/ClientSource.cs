using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediClinic.Domain.Models.Entities
{
    public class ClientSource
    {
        public static List<Client> Clients { get; set; } = new List<Client>();
    }
}
