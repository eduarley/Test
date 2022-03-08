using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public interface IRepositoryFamilia
    {
        IN05 Save(IN05 familia);
        List<IN05> List();
        IN05 Get(int codigo);
        List<IN05> GetActivos();
        bool VerificarId(int id);
    }
}
