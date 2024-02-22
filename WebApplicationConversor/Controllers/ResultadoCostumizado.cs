using System.Net;

namespace WebApplicationConversor.Controllers
{
    public class ResultadoCostumizado
    {
        public HttpStatusCode StatusCode { get; private set; }
        public DateTime data { get; set; }

        public decimal valor { get; set; }

        public String error { get; private set; }


        public ResultadoCostumizado(HttpStatusCode StatusCode, DateTime data, decimal valor, String error)
        {
            this.StatusCode = StatusCode;
            this.data = data;
            this.valor = valor;
            this.error = error;
        }
    }

    }
