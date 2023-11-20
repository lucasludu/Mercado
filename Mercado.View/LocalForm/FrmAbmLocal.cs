using Mercado.Models;
using Mercado.Negocio;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Mercado.View
{
    public partial class FrmAbmLocal : Form
    {
        public Local _Local { get; set; }

        public FrmAbmLocal(Local local)
        {
            InitializeComponent();

            var listaEmpresa = new EmpresaNegocio().GetAll();
            var empresaPosInicial = new Empresa(0, "< Seleccione una Empresa >");
            listaEmpresa.Add(empresaPosInicial);

            bsEmpresa.DataSource = listaEmpresa.OrderBy(a => a.IdEmpresa).ToList();

            if (local == null)
                bsLocal.DataSource = new Local();
            else
                bsLocal.DataSource = local; 
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            bsLocal.DataSource = new Local();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var localBS = (Local)bsLocal.Current;
            try
            {
                var negocio = new LocalNegocio();
                if (negocio.Get(localBS.IdEmpresa, localBS.IdLocal) == null)
                {
                    // AGREGA
                    if (negocio.Insert(localBS) > 0)
                    {
                        MessageBox.Show("Se agregó correctamente.");
                        this._Local = localBS;
                        new FrmConsultaLocal(this._Local);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el local.");
                        this.Close();
                    }
                }
                else
                {
                    // MODIFICA
                    if (negocio.Update(localBS) > 0)
                    {
                        MessageBox.Show("Se modificó correctamente.");
                        new FrmConsultaLocal(localBS);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el local.");
                        this.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }
    }
}
