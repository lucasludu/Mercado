using Mercado.Models;
using Mercado.Models.Items;
using Mercado.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Mercado.View
{
    public partial class FrmConsultaLocal : Form
    {

        #region Propiedades y Constructor
       
        public Local _Local { get; set; }

        public FrmConsultaLocal(Local local = null)
        {
            InitializeComponent();

            var listaEmpresas = new EmpresaNegocio().GetAll();
            var empresaInicial = new Empresa(0, "TODOS");
            listaEmpresas.Add(empresaInicial);
            listaEmpresas = listaEmpresas.OrderBy(a => a.IdEmpresa).ToList();

            bsEmpresa.DataSource = listaEmpresas;

            _Local = local;
        }

        #endregion

        #region Eventos

        #region Botones

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmAbm = new FrmAbmLocal(_Local);
            frmAbm.ShowDialog();
            var localItem = frmAbm._Local;

            if(localItem != null)
            {
                var empresa = new EmpresaNegocio().Get(localItem.IdEmpresa);
                bsLocalesItem.DataSource = new LocalesItems(empresa.IdEmpresa, localItem.IdLocal, empresa.Nombre, localItem.Nombre, localItem.Activo);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            try
            {
                var idEmpresa = ((Empresa)bsEmpresa.Current).IdEmpresa;

                var lista = new LocalNegocio().GetByIdEmpresa(idEmpresa);

                if (lista.Count > 0)
                {
                    bsLocalesItem.DataSource = lista;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Cursor = Cursors.Default;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            bsLocalesItem.DataSource = new List<LocalesItems>();
        }

        #endregion

        #region Grilla

        private void dgvLocal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var localBs = (LocalesItems)dgvLocal.Rows[e.RowIndex].DataBoundItem;
                var empresa = new EmpresaNegocio().GetByParams(a => a.Nombre.ToLower().Trim().Equals(localBs.NombreEmpresa));
                var local = new LocalNegocio()
                    .GetByParams(a => a.IdEmpresa == empresa.IdEmpresa && a.IdLocal == localBs.IdLocal);
                var frmAbmLocal = new FrmAbmLocal(local);
                frmAbmLocal.ShowDialog();

                bsLocalesItem.DataSource = new LocalNegocio().GetByIdEmpresa(localBs.IdEmpresa);
            }
        }

        private void dgvLocal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(bsLocalesItem.Count > e.RowIndex)
            {
                var local = (LocalesItems)dgvLocal.Rows[e.RowIndex].DataBoundItem;
                if(e.ColumnIndex == dgvColActivo.Index && !local.Activo)
                {
                    e.Value = null;
                    e.CellStyle.NullValue = null;
                }
            }
        }

        private void dgvLocal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvColEliminar.Index)
                {
                    Cursor = Cursors.Hand;

                    var localBs = (LocalesItems)bsLocalesItem.Current;
                    var copia = localBs;

                    var negocioLocal = new LocalNegocio();
                    var empresa = new EmpresaNegocio().GetByParams(a => a.Nombre.Trim().ToLower().Equals(localBs.NombreEmpresa.Trim().ToLower()));
                    var local = negocioLocal.Get(empresa.IdEmpresa, localBs.IdLocal);

                    if (local.Activo)
                    {
                        if (MessageBox.Show("¿Desea desactivar lo seleccionado?", "Desactivar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            local.Activo = false;

                            if (new LocalNegocio().Update(local) > 0)
                            {
                                MessageBox.Show("Se ha desactivado correctamente");
                            }
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("¿Desea volver activar lo seleccionado?", "Activar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            local.Activo = true;

                            if (new LocalNegocio().Update(local) > 0)
                            {
                                MessageBox.Show("Se ha activado correctamente");
                            }
                        }
                    }

                    bsLocalesItem.Remove(localBs);
                    copia = new LocalesItems(empresa.IdEmpresa, local.IdLocal, empresa.Nombre, local.Nombre, local.Activo);
                    bsLocalesItem.Add(copia);

                }
            }
        }

        #endregion

        #endregion

    }
}
