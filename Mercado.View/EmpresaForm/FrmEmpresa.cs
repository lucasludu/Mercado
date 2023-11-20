using Mercado.Models;
using Mercado.Negocio;
using System;
using System.Windows.Forms;

namespace Mercado.View
{
    public partial class FrmEmpresa : Form
    {

        #region Propiedades y Constructores

        public FrmEmpresa()
        {
            InitializeComponent();
        }

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {
            bsEmpresa.DataSource = new Empresa();
            bsEmpresas.DataSource = new EmpresaNegocio().GetAll();
            labelCantidadRegistros.Text = bsEmpresas.List.Count.ToString();
            gbxDatos.Enabled = false;
            btnGuardar.Visible = false;
        }

        #endregion

        #region Eventos

        #region Botones

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            bsEmpresa.DataSource = new Empresa();
            gbxDatos.Enabled = false;
            btnGuardar.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            gbxDatos.Enabled = true;
            var empresa = (Empresa)bsEmpresa.Current;

            try
            {
                var negocio = new EmpresaNegocio();

                if (negocio.Get(empresa.IdEmpresa) == null)
                {
                    // AGREGAR
                    if (negocio.Insert(empresa) > 0)
                    {
                        bsEmpresas.Add(empresa);
                        bsEmpresas.ResetBindings(false);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar la empresa", "Insertar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                }
                else
                {
                    // MODIFICAR
                    if (negocio.Update(empresa) > 0)
                    {
                        bsEmpresas.ResetBindings(false);
                        dgvEmpresa.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar la empresa", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            gbxDatos.Enabled = true;
            btnGuardar.Visible = true;
        }

        #endregion

        #region Grillas

        private void dgvEmpresa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                gbxDatos.Enabled = true;
                btnGuardar.Visible = true;
                bsEmpresa.DataSource = (Empresa)bsEmpresas.Current;
            }
        }

        private void dgvEmpresa_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (bsEmpresas.Count > e.RowIndex)
            {
                var empresas = (Empresa)dgvEmpresa.Rows[e.RowIndex].DataBoundItem;

                if (e.ColumnIndex == dgvColActivo.Index && !empresas.Activo)
                {
                    e.Value = null;
                    e.CellStyle.NullValue = null;
                }
            }
        }

        private void dgvEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvColDesactivar.Index)
                {
                    var empresaBs = (Empresa)bsEmpresas.Current;

                    if (empresaBs.Activo)
                    {
                        if (MessageBox.Show("¿Desea eliminar lo seleccionado?", "Desactivar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            empresaBs.Activo = false;
                            if (new EmpresaNegocio().Update(empresaBs) > 0)
                            {
                                MessageBox.Show("Se ha desactivado correctamente");
                                bsEmpresas.ResetBindings(false);
                                dgvEmpresa.Refresh();
                            }
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("¿Desea volver activar lo seleccionado?", "Activar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            empresaBs.Activo = true;
                            if (new EmpresaNegocio().Update(empresaBs) > 0)
                            {
                                MessageBox.Show("Se ha activado correctamente");
                                bsEmpresas.ResetBindings(false);
                                dgvEmpresa.Refresh();
                            }
                        }
                    }
                }
            }
        }

        #endregion

        #endregion

    }
}
