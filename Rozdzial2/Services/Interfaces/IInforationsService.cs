using Rozdzial2.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rozdzial2.Services.Interfaces
{
    interface IInforationsService
    {
        ResponseDTO AddInformaiton(InformationDTO informationDTO);
        ResponseDTO EditInformation(InformationDTO informationDTO);
        ResponseDTO DeleteInformation(string mail);
        InformationsDTO GetAllByUser(string userId);
    }
}
