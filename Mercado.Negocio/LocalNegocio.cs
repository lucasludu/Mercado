using Mercado.Models;
using Mercado.Models.Items;
using Mercado.Negocio.Connection;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Mercado.Negocio
{
    public class LocalNegocio : BLLContext
    {
        /// <summary>
        /// Devuelve la lista entera de locales
        /// </summary>
        /// <returns>Locales</returns>
        public List<Local> GetAll()
        {
            return this.Context.Locales.ToList();
        }

        /// <summary>
        /// Devuelve el local segun IDEmpresa y IDLocal
        /// </summary>
        /// <param name="idEmpresa">Id de la Empresa</param>
        /// <param name="idLocal">Id del Local</param>
        /// <returns>Local</returns>
        public Local Get(int idEmpresa, int idLocal)
        {
            return this.Context.Locales.FirstOrDefault(a => a.IdEmpresa == idEmpresa && a.IdLocal == idLocal);
        }


        public List<LocalesItems> GetByIdEmpresa(int idEmpresa)
        {
            var query = (from l in Context.Locales select l);
            query = idEmpresa == 0 ? query : query.Where(a => a.IdEmpresa == idEmpresa);
            return (from q in query
                    join e in Context.Empresas on q.IdEmpresa equals e.IdEmpresa
                    select new LocalesItems
                    {
                        Activo = q.Activo,
                        IdLocal = q.IdLocal,
                        Nombre = q.Nombre,
                        NombreEmpresa = e.Nombre
                    }).ToList();
        }

        public Local GetByParams(Expression<Func<Local, bool>> expression)
        {
            return this.Context.Locales.Where(expression).FirstOrDefault();
        }



        /// <summary>
        /// Guarda los cambios que se realizan
        /// </summary>
        /// <param name="local">Local</param>
        /// <param name="state">Describe el estado de la operación</param>
        /// <returns>Devuelve los cambios realizados</returns>
        public int SaveChanges(Local local, EntityState state)
        {
            var existingLocal = this.Get(local.IdEmpresa, local.IdLocal);

            if (existingLocal != null)
            {
                this.Context.Entry(existingLocal).CurrentValues.SetValues(local);
                this.Context.Entry(existingLocal).State = state;
            }
            else
            {
                this.Context.Entry(local).State = state;
            }

            return this.Context.SaveChanges();
        }

        /// <summary>
        /// Inserta un nuevo local
        /// </summary>
        /// <param name="local">Local</param>
        /// <returns>Local</returns>
        public int Insert(Local local)
        {
            return this.SaveChanges(local, EntityState.Added);
        }

        /// <summary>
        /// Modifica el local
        /// </summary>
        /// <param name="local">Local</param>
        /// <returns>Local modificado</returns>
        public int Update(Local local)
        {
            return this.SaveChanges(local, EntityState.Modified);
        }

        /// <summary>
        /// Da de baja el local
        /// </summary>
        /// <param name="local">Local</param>
        /// <returns>Baja del local</returns>
        public int Delete(Local local)
        {
            local.Activo = false;
            return this.SaveChanges(local, EntityState.Modified);
        }

    }
}
