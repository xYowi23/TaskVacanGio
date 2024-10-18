using Microsoft.AspNetCore.Mvc;
using VacanGio.Models;
using VacanGio.Services;

namespace VacanGio.Controllers
{
    [ApiController]
    [Route("api/destinazioni")]
    public class DestinazioneController : Controller
    {
        private readonly DestinazioneService _service;

        public DestinazioneController(DestinazioneService service)
        {
            _service = service;
        }



        [HttpGet]
        public ActionResult<IEnumerable<DestinazioneDTO>> ListaClienti()
        {
            return Ok(_service.CercaTutti());
        }
    }
}
