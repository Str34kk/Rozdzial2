using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rozdzial2.ModelsDTO
{
    public class UserDTO
    {
        public virtual string TelNumber { get; set; }
        public virtual string Password { get; set; }
        public virtual string Mail { get; set; }
        public virtual string Name { get; set; }
        public virtual string Id { get; set; }
        public virtual string IsPaid { get; set; }
    }
}
