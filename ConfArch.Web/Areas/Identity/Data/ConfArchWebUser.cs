using Microsoft.AspNetCore.Identity;
using System;

namespace ConfArch.Web.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ConfArchWebUser class
    public class ConfArchWebUser : IdentityUser
    {
        public DateTime CareerStartedDate { get; set; }
        public string FullName { get; set; }
    }
}
