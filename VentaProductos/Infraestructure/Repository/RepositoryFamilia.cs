using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class RepositoryFamilia : IRepositoryFamilia
    {
        public IN05 Get(int codigo)
        {
            IN05 prod = new IN05();
            try
            {
                using (MyContext ctx = new MyContext())
                {
                    //ctx.Configuration.LazyLoadingEnabled = false;
                    prod = ctx.IN05.Where(p => p.IDFamilia == codigo).FirstOrDefault();

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return prod;
        }

        public List<IN05> List()
        {
            List<IN05> lista = new List<IN05>();
            try
            {
                using (MyContext ctx = new MyContext())
                {
                    //ctx.Configuration.LazyLoadingEnabled = false;
                    lista = ctx.IN05.ToList();

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return lista;
        }

        public List<IN05> GetActivos()
        {
            List<IN05> lista = new List<IN05>();
            try
            {
                using (MyContext ctx = new MyContext())
                {
                    //ctx.Configuration.LazyLoadingEnabled = false;
                    lista = ctx.IN05.Where(p => p.Estado == 1).ToList();

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return lista;
        }

        public IN05 Save(IN05 familia)
        {
            try
            {
                using (MyContext ctx = new MyContext())
                {
                    ctx.IN05.Add(familia);
                    int retorno = ctx.SaveChanges();

                    if (retorno > 0)
                        return ctx.IN05.Find(familia.IDFamilia);
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool VerificarId(int id)
        {
            try
            {
                using (MyContext ctx = new MyContext())
                {
                    IN05 familia = ctx.IN05.Find(id);
                    if(familia != null)
                    {
                        return false;
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
