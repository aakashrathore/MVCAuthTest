using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAuthTest.Models
{
    public class AppUser: IdentityUser
    {
        public String Country { get; set; }        
    }
}