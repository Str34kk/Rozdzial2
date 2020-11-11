using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rozdzial2.ModelsDTO
{
    public class ResponseAfterAutDTO : ResponseDTO
    {
        public bool IsAdmin { get; set; }
        public string IsUser { get; set; }
        public string Mail { get; set; }

    }
}
