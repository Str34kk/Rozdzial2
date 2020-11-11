using Rozdzial2.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rozdzial2.Services.Interfaces
{
    interface IBillsService
    {
        ResponseDTO AddBill(BillDTO billDTO);
        ResponseDTO EditBill(BillDTO billDTO);
        ResponseDTO DeleteBill(string mail);
        BillsDTO GetAllBillByUser(string mail);
    }
}
