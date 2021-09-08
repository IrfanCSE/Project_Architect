using System.Collections.Generic;
using System.Threading.Tasks;
using Core.DTO.Procurement;

namespace Core.IRepository.Procurement
{
    public interface IPurchaseOrder
    {
         public Task<List<GetPurchaseOrderDTO>> GetPurchaseOrderList();
    }
}