using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public interface IRepositoryProducto
    {
        IN04 Save(IN04 producto);
        List<IN04> List();
        IN04 Get(String codigo);
    }
}
