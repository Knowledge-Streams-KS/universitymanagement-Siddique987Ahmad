using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using System.Runtime.CompilerServices;
using ManagementStructure.Enums;
using System.Reflection;

namespace ManagementStructure.Models
{
    public class person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public Gender Gender { get; set; }
        public University University { get; set; }

    }
}