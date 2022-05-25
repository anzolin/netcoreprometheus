using Microsoft.AspNetCore.Mvc;
using NetCorePrometheus.Api.Models;
using NetCorePrometheus.Api.Repositories;

namespace NetCorePrometheus.Api.Controllers
{
    [ApiController]
    [Route("api/clientes")]
    public class ClienteController : ControllerBase
    {
        private readonly ILogger<ClienteController> _logger;
        private ClienteRepository _clienteRepository;

        public ClienteController(ILogger<ClienteController> logger)
        {
            _logger = logger;
            _clienteRepository = new ClienteRepository();
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<Cliente> Customers()
        {
            return _clienteRepository.GetClientes();
        }


        [HttpGet]
        [Route("cliente")]
        public Cliente CustomerById([FromQuery] int id)
        {
            return _clienteRepository.ClienteById(id);
        }
    }
}
