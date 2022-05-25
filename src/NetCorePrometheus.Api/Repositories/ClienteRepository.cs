using NetCorePrometheus.Api.Models;

namespace NetCorePrometheus.Api.Repositories
{
    public class ClienteRepository
    {
        private List<Cliente> _clientes;

        public ClienteRepository()
        {
            _clientes = new List<Cliente>
            {
                new Cliente(1, "Douglas Modesto", "d.modesto@teste.com.br", "045.213.920-16"),
                new Cliente(1, "Martin Diogo Filipe Anthony Jesus", "martindiogojuanjesus__martindiogojuanjesus@urbam.com.br", "980.725.820-03"),
                new Cliente(1, "Diogo Nicolas Carvalho", "diogonicolascarvalho-74@saa.com.br", "406.244.580-83"),
                new Cliente(1, "Ericka Sebastião Silveira", "eerickantoniosilveira@transtelli.com.br", "705.559.730-77"),
                new Cliente(1, "Laura Jaqueline Aline Silva", "laurajaquelinealinesilva__laurajaquelinealinesilva@me.com", "711.605.230-53")
            };
        }

        public Cliente ClienteById(int idCliente)
        {
            return _clientes.FirstOrDefault(x => x.Id == idCliente);
        }

        public IEnumerable<Cliente> GetClientes()
        {
            return _clientes;
        }

        public bool Save(Cliente cliente)
        {
            return true;
        }
    }
}