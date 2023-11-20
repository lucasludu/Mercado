using Mercado.Models;
using System;

namespace Mercado.Negocio.Connection
{
    public class BLLContext : IDisposable
    {

        /// <summary>
        /// CONTEXTO PRINCIPAL
        /// </summary>
        protected SuperContainer Context;


        public BLLContext()
        {
            this.Context = new SuperContainer(EFStringConnection.StringConnection);
            this.Context.Configuration.ProxyCreationEnabled = false;
            this.Context.Configuration.LazyLoadingEnabled = false;
            this.Context.Configuration.AutoDetectChangesEnabled = false;
        }


        /// <summary>
        /// CIERRA EL CONTEXTO  
        /// </summary>
        public void Dispose()
        {
            this.Context.Dispose();
        }
    }
}
