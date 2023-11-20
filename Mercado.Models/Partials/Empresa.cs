using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado.Models
{
    public partial class Empresa
    {
        public Empresa()
        {
            this.Activo = true;
        }

        public Empresa(int id, string nombre)
        {
            this.IdEmpresa = id;
            this.Nombre = nombre;
        }

        public Empresa(string nombre, string cuit) : this()
        {
            this.Nombre = nombre;
            this.Cuit = cuit;
            this.Activo = true;
        }
    }
}
