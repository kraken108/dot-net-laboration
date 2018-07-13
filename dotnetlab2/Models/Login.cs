using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetlab2.Models
{
    /// <summary>
    /// Contains information about logins for a user. A new row is created when a user logs in.
    /// </summary>
    public class Login
    {
        public int ID { get; set; }
        public DateTime DateTime { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
