using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Rozdzial2.Data
{
    public class ApplicationUser : IdentityUser
    {
        public bool IdPaid { get; set; }
        public IEnumerable<Bill> Bills { get; set; }
        public IEnumerable<Information> Informations { get; set; }
    }


}
