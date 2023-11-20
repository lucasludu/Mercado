using Mercado.Models;
using Mercado.Negocio.Connection;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Mercado.Negocio
{
    public class EmpresaNegocio : BLLContext
    {
        /// <summary>
        /// Devuelve la lista entera de empresa
        /// </summary>
        /// <returns></returns>
        public List<Empresa> GetAll()
        {
            return this.Context.Empresas.ToList();
        }

        /// <summary>
        /// Devuelve la empresa segun ID
        /// </summary>
        /// <param name="id">Id de la Empresa</param>
        /// <returns></returns>
        public Empresa Get(int id)
        {
            return this.Context.Empresas.FirstOrDefault(a => a.IdEmpresa == id);
        }

        public Empresa GetByParams(Expression<Func<Empresa, bool>> expression)
        {
            return this.Context.Empresas.Where(expression).FirstOrDefault();
        }

        /// <summary>
        /// Guarda los cambios que se realizan
        /// </summary>
        /// <param name="empresa">Empresa</param>
        /// <param name="state">Describe el estado de la operación</param>
        /// <returns>Devuelve los cambios realizados</returns>
        public int SaveChanges(Empresa empresa, EntityState state)
        {
            var existingEmpresa = this.Get(empresa.IdEmpresa);

            if (existingEmpresa != null)
            {
                this.Context.Entry(existingEmpresa).CurrentValues.SetValues(empresa);
                this.Context.Entry(existingEmpresa).State = state;
            }
            else
            {
                this.Context.Entry(existingEmpresa).State = state;
            }

            return this.Context.SaveChanges();
        }

        /// <summary>
        /// Inserta una nueva empresa
        /// </summary>
        /// <param name="empresa">Empresa</param>
        /// <returns>Empresa</returns>
        public int Insert(Empresa empresa)
        {
            return this.SaveChanges(empresa, EntityState.Added);
        }

        /// <summary>
        /// Modifica la empresa
        /// </summary>
        /// <param name="empresa">Empresa</param>
        /// <returns>Empresa modificada</returns>
        public int Update(Empresa empresa)
        {
            return this.SaveChanges(empresa, EntityState.Modified);
        }

        /// <summary>
        /// Da de baja la empresa
        /// </summary>
        /// <param name="empresa">Empresa</param>
        /// <returns>Baja de la empresa</returns>
        public int Delete(Empresa empresa)
        {
            empresa.Activo = false;
            return this.SaveChanges(empresa, EntityState.Modified);
        }

    }
}
