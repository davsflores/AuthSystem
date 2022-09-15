using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AuthSystem.Areas.Identity.Data;

// Add profile data for application users by adding properties to the AuthSystemUser class
public class AuthSystemUser : IdentityUser
{
    [ProtectedPersonalData]
    [Column(TypeName = "nvarchar(100)")]
    public string FirstName { get; set; }

    [ProtectedPersonalData]
    [Column(TypeName = "nvarchar(100)")]
    public string LastName { get; set; }
}

