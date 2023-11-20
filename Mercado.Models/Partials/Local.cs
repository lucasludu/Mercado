using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado.Models
{
    public partial class Local
    {
        public Local()
        {
            this.Activo = true;
        }

        public Local(int idEmpresa, string nombre) : this()
        {
            this.IdEmpresa = idEmpresa;
            this.Nombre = nombre;
            this.Activo = true;
        }
    }
}
