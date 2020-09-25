namespace Gone.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        [Route("{*url}")]
        public IActionResult Index()
        {
            return StatusCode(410);
        }
    }
}
