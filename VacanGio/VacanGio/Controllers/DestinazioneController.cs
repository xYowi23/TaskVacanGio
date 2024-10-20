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

        [HttpGet("{varCodice}")]
        public ActionResult<DestinazioneDTO?> VisualizzaCliente(string varCodice)
        {

            if (string.IsNullOrWhiteSpace(varCodice))
                return BadRequest();

            DestinazioneDTO? risultato = _service.CercaPerCodice(varCodice);
            if (risultato is not null)
                return Ok(risultato);

            return NotFound();
        }
        [HttpPost]

        public IActionResult InserisciDestinazione(DestinazioneDTO destDTO)
        {
            if (string.IsNullOrWhiteSpace(destDTO.Nom) || string.IsNullOrWhiteSpace(destDTO.Pae))
                return BadRequest();
            if (_service.Inserisci(destDTO))
                return Ok();
            return BadRequest();
        }

    }
}
