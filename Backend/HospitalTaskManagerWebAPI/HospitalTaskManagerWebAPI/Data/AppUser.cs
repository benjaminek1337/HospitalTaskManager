using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalTaskManagerWebAPI.Data
{
    public class AppUser : IdentityUser
    {
        //Här kan IdentityUsern anpassas med fler props

        //[Column(Kolumnens namn = "typ av data, nvarchar, int osv")]
    }
}
