using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public interface IServiceFamilia
    {
        IN05 Save(IN05 familia);
        List<IN05> List();
        IN05 Get(int codigo);
        List<IN05> GetActivos();
        bool VerificarId(int id);
    }
}
