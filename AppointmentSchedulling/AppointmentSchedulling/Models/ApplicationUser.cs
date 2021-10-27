using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentSchedulling.Models
{
    public class ApplicationUser : IdentityUser     
    {
        public string Ńame { get; set; }
    }
}
