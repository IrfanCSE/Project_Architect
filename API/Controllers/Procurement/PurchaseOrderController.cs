using System.Threading.Tasks;
using Core.IRepository.Procurement;
using Microsoft.AspNetCore.Mvc;

#pragma warning disable

namespace API.Controllers.Procurement
{
    [ApiController]
    [Route("procurement/[controller]")]
    public class PurchaseOrderController : ControllerBase
    {
        private readonly IPurchaseOrder _repository;
        public PurchaseOrderController(IPurchaseOrder repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("GetPurchaseOrderList")]
        public async Task<IActionResult> GetPurchaseOrderList()
        {
            return Ok(await _repository.GetPurchaseOrderList());
        }
    }
}