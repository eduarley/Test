using Infraestructure.Models;
using Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServiceProducto: IServiceProducto
    {
        private IRepositoryProducto _repository = new RepositoryProducto();

        public IN04 Get(string codigo)
        {
            return _repository.Get(codigo);
        }

        public List<IN04> List()
        {
            return _repository.List();
        }

        public IN04 Save(IN04 producto)
        {
            return _repository.Save(producto);
        }
    }
}
