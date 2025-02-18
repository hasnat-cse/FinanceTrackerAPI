using FinanceTrackerAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace FinanceTrackerAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(ExpenseService.GetAll());
        }
    }
}
