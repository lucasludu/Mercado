namespace Mercado.Models.Items
{
    public class LocalesItems
    {

        public int IdEmpresa { get; set; }
        public int IdLocal { get; set; }
        public string NombreEmpresa { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }

        public LocalesItems()
        {
            
        }

        public LocalesItems(int idEmpresa, int idLocal, string empresa, string nombre, bool activo) : this()
        {
            this.IdEmpresa = idEmpresa;
            this.IdLocal = idLocal;
            this.NombreEmpresa = empresa;
            this.Nombre = nombre;
            this.Activo = activo;
        }
    }
}
