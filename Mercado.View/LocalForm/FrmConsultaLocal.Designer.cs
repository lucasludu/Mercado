namespace Mercado.View
{
    partial class FrmConsultaLocal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaLocal));
            this.dgvLocal = new System.Windows.Forms.DataGridView();
            this.NombreEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColActivo = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvColEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.bsLocalesItem = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelCantidadRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbxAcciones = new System.Windows.Forms.GroupBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxFiltro = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bsEmpresa = new System.Windows.Forms.BindingSource(this.components);
            this.bsLocal = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLocalesItem)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.gbxAcciones.SuspendLayout();
            this.gbxFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLocal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLocal
            // 
            this.dgvLocal.AllowUserToAddRows = false;
            this.dgvLocal.AllowUserToDeleteRows = false;
            this.dgvLocal.AllowUserToResizeColumns = false;
            this.dgvLocal.AllowUserToResizeRows = false;
            this.dgvLocal.AutoGenerateColumns = false;
            this.dgvLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreEmpresa,
            this.nombreDataGridViewTextBoxColumn,
            this.dgvColActivo,
            this.dgvColEliminar});
            this.dgvLocal.DataSource = this.bsLocalesItem;
            this.dgvLocal.Location = new System.Drawing.Point(12, 107);
            this.dgvLocal.Name = "dgvLocal";
            this.dgvLocal.ReadOnly = true;
            this.dgvLocal.RowHeadersVisible = false;
            this.dgvLocal.RowHeadersWidth = 51;
            this.dgvLocal.RowTemplate.Height = 24;
            this.dgvLocal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocal.Size = new System.Drawing.Size(776, 314);
            this.dgvLocal.TabIndex = 0;
            this.dgvLocal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocal_CellClick);
            this.dgvLocal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocal_CellDoubleClick);
            this.dgvLocal.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLocal_CellFormatting);
            // 
            // NombreEmpresa
            // 
            this.NombreEmpresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreEmpresa.DataPropertyName = "NombreEmpresa";
            this.NombreEmpresa.HeaderText = "Empresa";
            this.NombreEmpresa.MinimumWidth = 6;
            this.NombreEmpresa.Name = "NombreEmpresa";
            this.NombreEmpresa.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dgvColActivo
            // 
            this.dgvColActivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvColActivo.HeaderText = "Activo";
            this.dgvColActivo.Image = ((System.Drawing.Image)(resources.GetObject("dgvColActivo.Image")));
            this.dgvColActivo.MinimumWidth = 6;
            this.dgvColActivo.Name = "dgvColActivo";
            this.dgvColActivo.ReadOnly = true;
            this.dgvColActivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColActivo.Width = 50;
            // 
            // dgvColEliminar
            // 
            this.dgvColEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvColEliminar.HeaderText = "";
            this.dgvColEliminar.Image = ((System.Drawing.Image)(resources.GetObject("dgvColEliminar.Image")));
            this.dgvColEliminar.MinimumWidth = 6;
            this.dgvColEliminar.Name = "dgvColEliminar";
            this.dgvColEliminar.ReadOnly = true;
            this.dgvColEliminar.Width = 6;
            // 
            // bsLocalesItem
            // 
            this.bsLocalesItem.DataSource = typeof(Mercado.Models.Items.LocalesItems);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.labelCantidadRegistros});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(170, 20);
            this.toolStripStatusLabel1.Text = "Cantidad de Registros: ";
            // 
            // labelCantidadRegistros
            // 
            this.labelCantidadRegistros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelCantidadRegistros.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelCantidadRegistros.Name = "labelCantidadRegistros";
            this.labelCantidadRegistros.Size = new System.Drawing.Size(0, 20);
            // 
            // gbxAcciones
            // 
            this.gbxAcciones.Controls.Add(this.btnRefrescar);
            this.gbxAcciones.Controls.Add(this.btnAdd);
            this.gbxAcciones.Controls.Add(this.btnSalir);
            this.gbxAcciones.Location = new System.Drawing.Point(516, 12);
            this.gbxAcciones.Name = "gbxAcciones";
            this.gbxAcciones.Size = new System.Drawing.Size(272, 89);
            this.gbxAcciones.TabIndex = 2;
            this.gbxAcciones.TabStop = false;
            this.gbxAcciones.Text = "EVENTOS";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.BackgroundImage")));
            this.btnRefrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefrescar.Location = new System.Drawing.Point(180, 32);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(40, 40);
            this.btnRefrescar.TabIndex = 5;
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.Location = new System.Drawing.Point(6, 32);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 40);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.Location = new System.Drawing.Point(226, 32);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(40, 40);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(545, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hacer Doble Click para Modificar";
            // 
            // gbxFiltro
            // 
            this.gbxFiltro.Controls.Add(this.btnBuscar);
            this.gbxFiltro.Controls.Add(this.label1);
            this.gbxFiltro.Controls.Add(this.comboBox1);
            this.gbxFiltro.Location = new System.Drawing.Point(12, 12);
            this.gbxFiltro.Name = "gbxFiltro";
            this.gbxFiltro.Size = new System.Drawing.Size(498, 89);
            this.gbxFiltro.TabIndex = 11;
            this.gbxFiltro.TabStop = false;
            this.gbxFiltro.Text = "FILTRO";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscar.Location = new System.Drawing.Point(452, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(40, 40);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empresa";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.bsEmpresa;
            this.comboBox1.DisplayMember = "Nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(274, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "IdEmpresa";
            // 
            // bsEmpresa
            // 
            this.bsEmpresa.DataSource = typeof(Mercado.Models.Empresa);
            // 
            // bsLocal
            // 
            this.bsLocal.DataSource = typeof(Mercado.Models.Local);
            // 
            // FrmConsultaLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxFiltro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbxAcciones);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvLocal);
            this.Name = "FrmConsultaLocal";
            this.Text = "ABM Local";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLocalesItem)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbxAcciones.ResumeLayout(false);
            this.gbxFiltro.ResumeLayout(false);
            this.gbxFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLocal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLocal;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel labelCantidadRegistros;
        private System.Windows.Forms.GroupBox gbxAcciones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.BindingSource bsLocalesItem;
        private System.Windows.Forms.BindingSource bsEmpresa;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource bsLocal;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn dgvColActivo;
        private System.Windows.Forms.DataGridViewImageColumn dgvColEliminar;
    }
}