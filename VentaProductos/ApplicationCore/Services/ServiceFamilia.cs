using Infraestructure.Models;
using Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServiceFamilia : IServiceFamilia
    {
        IRepositoryFamilia _repository = new RepositoryFamilia();
        public IN05 Get(int codigo)
        {
            return _repository.Get(codigo);
        }

        public List<IN05> GetActivos()
        {
            return _repository.GetActivos();
        }

        public List<IN05> List()
        {
            return _repository.List();
        }

        public IN05 Save(IN05 familia)
        {
            return _repository.Save(familia);
        }

        public bool VerificarId(int id)
        {
            return _repository.VerificarId(id);
        }
    }
}
