using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using System.Drawing;

namespace WebApplicationConversor.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ConversorController : Controller
    {
      
        [HttpGet("{valor}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<float> ConverterValor(String valor)
        {
            ResultadoCostumizado resultadoCostumizado = null;

            decimal valorfloat = 0;
          
            if (!decimal.TryParse(valor, out valorfloat))

            {
                resultadoCostumizado = new ResultadoCostumizado(System.Net.HttpStatusCode.BadRequest, DateTime.Now, 0, "Valor Invalido");
                return BadRequest(new JsonResult(resultadoCostumizado) { StatusCode = (int)resultadoCostumizado.StatusCode });
            }
            else
            {
                valorfloat = decimal.Parse(valor);
            }

            if (valorfloat < 1)
            {
                resultadoCostumizado = new ResultadoCostumizado(System.Net.HttpStatusCode.BadRequest, DateTime.Now, 0, "Valor Invalido");

                return BadRequest(new JsonResult(resultadoCostumizado) { StatusCode = (int)resultadoCostumizado.StatusCode });
            }
            else
            {
                valorfloat = valorfloat * 9500000000000;
                resultadoCostumizado = new ResultadoCostumizado(System.Net.HttpStatusCode.OK, DateTime.Now, valorfloat,"Processado com sucesso");


                return Ok(new JsonResult(resultadoCostumizado) { StatusCode = (int)resultadoCostumizado.StatusCode });
            }
            
        }



    }
}
