using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public interface IServiceProducto
    {
        IN04 Save(IN04 producto);
        List<IN04> List();
        IN04 Get(String codigo);
    }
}
