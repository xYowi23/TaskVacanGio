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
        [HttpPost]

        public IActionResult? InserisciDestinazione(DestinazioneDTO destDTO)
        {
            if (string.IsNullOrWhiteSpace(destDTO.Nom) || string.IsNullOrWhiteSpace(destDTO.Pae))
                return BadRequest();
            if (_service.Inserisci(destDTO))
                return Ok();
            return BadRequest();
        }

    }
}
