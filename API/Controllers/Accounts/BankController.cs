using Core.IRepository.Accounts;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Accounts
{
    [ApiController]
    [Route("acc/[controller]")]
    public class BankController : ControllerBase
    {
        private readonly IBank _bankRepo;
        public BankController(IBank bankRepo)
        {
            _bankRepo = bankRepo;
        }

        [HttpGet]
        [Route("Get")]
        public IActionResult Get(bool def)
        {
            return Ok(_bankRepo.GetBankList(def));
        }

    }
}