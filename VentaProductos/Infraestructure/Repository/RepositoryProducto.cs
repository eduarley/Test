using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class RepositoryProducto : IRepositoryProducto
    {
        public IN04 Get(string codigo)
        {
            IN04 prod = new IN04();
            try
            {
                using (MyContext ctx = new MyContext())
                {
                    //ctx.Configuration.LazyLoadingEnabled = false;
                    prod = ctx.IN04.Where(p => p.CodigoProducto == codigo).FirstOrDefault();

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return prod;
        }

        public List<IN04> List()
        {
            List<IN04> lista = new List<IN04>();
            try
            {
                using (MyContext ctx = new MyContext())
                {
                    //ctx.Configuration.LazyLoadingEnabled = false;
                    lista = ctx.IN04.Include("IN05").ToList();

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return lista;
        }

        public IN04 Save(IN04 producto)
        {
            try
            {
                using (MyContext ctx = new MyContext())
                {
                    ctx.IN04.Add(producto);
                    int retorno = ctx.SaveChanges();

                    if (retorno > 0)
                        return ctx.IN04.Find(producto.CodigoProducto);
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
