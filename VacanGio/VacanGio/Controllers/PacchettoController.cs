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


        [HttpGet ("{varCodice}")]
        public ActionResult<PacchettoDTO> VisualizzaPacchetto(string varCodice)
        {
            if (string.IsNullOrWhiteSpace(varCodice))
                return BadRequest();
            PacchettoDTO? risultato = _service.CercaPerCodice(varCodice);
            if (risultato is not null)
                return Ok(risultato);
            return NotFound();
        }

        [HttpPost]
        public IActionResult IserisciPacchetto(PacchettoDTO pacDto)
        {

            if (string.IsNullOrWhiteSpace(pacDto.Nom))
                return BadRequest();
            if (_service.Inserisci(pacDto))
                return Ok();

            return BadRequest();
        }

    }
}
