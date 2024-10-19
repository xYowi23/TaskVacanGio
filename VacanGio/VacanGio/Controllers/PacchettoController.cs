using Microsoft.AspNetCore.Mvc;
using VacanGio.Models;
using VacanGio.Services;

namespace VacanGio.Controllers
{
    [ApiController]
    [Route("api/pacchetti")]

    public class PacchettoController : Controller
    {
        private readonly PacchettoService _service;
        public PacchettoController(PacchettoService service)
        {
            _service =service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PacchettoDTO>> ListaPaccheti()
        {
            return Ok(_service.CercaTutti());
        }
    }
}
