using Rozdzial2.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rozdzial2.Services.Interfaces
{
    interface IUserService
    {
        UsersDTO GetAllUsersDTO();
        ResponseDTO EditUser(UserDTO userDTO);
        ResponseAfterAutDTO GetIdAndRoleForUserById(string mail);
    }
}
