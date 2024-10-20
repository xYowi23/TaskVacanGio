using Microsoft.AspNetCore.Mvc;
using VacanGio.Models;
using VacanGio.Services;

namespace VacanGio.Controllers
{
    [ApiController]
    [Route("api/recensione")]
    public class RecensioneController : Controller
    {
        private readonly RecensioneService _service;
        public RecensioneController(RecensioneService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<RecensioneDTO>>ListaRecensioni()
        {
            return Ok(_service.CercaTutti());
        }
        [HttpGet("{varCodice}")]
        public ActionResult<RecensioneDTO> VisulaizzaRecensione(string varCodice)
        {
            if (string.IsNullOrWhiteSpace(varCodice))
                return BadRequest();
            RecensioneDTO? risultato = _service.CercaPerCodice(varCodice);
            if (risultato is not null)
                return Ok(risultato);
            return NotFound();
        }
    }
}
