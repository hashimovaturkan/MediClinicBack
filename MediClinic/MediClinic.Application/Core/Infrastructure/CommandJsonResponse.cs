using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediClinic.Application.Core.Infrastructure
{
    public class CommandJsonResponse
    {
        public bool Error { get; set; }
        public string Message { get; set; }
    }
}
