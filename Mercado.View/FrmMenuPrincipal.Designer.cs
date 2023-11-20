namespace Mercado.View
{
    partial class FrmMenuPrincipal
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
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.btnLocal = new System.Windows.Forms.Button();
            this.btnSector = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnArticulo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnAbm = new System.Windows.Forms.RadioButton();
            this.rbtnConsulta = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpresa.ForeColor = System.Drawing.Color.Red;
            this.btnEmpresa.Location = new System.Drawing.Point(12, 12);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(458, 40);
            this.btnEmpresa.TabIndex = 0;
            this.btnEmpresa.Text = "EMPRESA";
            this.btnEmpresa.UseVisualStyleBackColor = true;
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // btnLocal
            // 
            this.btnLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocal.ForeColor = System.Drawing.Color.Red;
            this.btnLocal.Location = new System.Drawing.Point(6, 21);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(200, 40);
            this.btnLocal.TabIndex = 1;
            this.btnLocal.Text = "LOCAL";
            this.btnLocal.UseVisualStyleBackColor = true;
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click);
            // 
            // btnSector
            // 
            this.btnSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSector.ForeColor = System.Drawing.Color.Red;
            this.btnSector.Location = new System.Drawing.Point(252, 21);
            this.btnSector.Name = "btnSector";
            this.btnSector.Size = new System.Drawing.Size(200, 40);
            this.btnSector.TabIndex = 2;
            this.btnSector.Text = "SECTOR";
            this.btnSector.UseVisualStyleBackColor = true;
            // 
            // btnVenta
            // 
            this.btnVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.ForeColor = System.Drawing.Color.Red;
            this.btnVenta.Location = new System.Drawing.Point(252, 85);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(200, 40);
            this.btnVenta.TabIndex = 4;
            this.btnVenta.Text = "VENTA";
            this.btnVenta.UseVisualStyleBackColor = true;
            // 
            // btnArticulo
            // 
            this.btnArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticulo.ForeColor = System.Drawing.Color.Red;
            this.btnArticulo.Location = new System.Drawing.Point(6, 85);
            this.btnArticulo.Name = "btnArticulo";
            this.btnArticulo.Size = new System.Drawing.Size(200, 40);
            this.btnArticulo.TabIndex = 3;
            this.btnArticulo.Text = "ARTICULO";
            this.btnArticulo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnAbm);
            this.groupBox1.Controls.Add(this.btnSector);
            this.groupBox1.Controls.Add(this.btnVenta);
            this.groupBox1.Controls.Add(this.btnLocal);
            this.groupBox1.Controls.Add(this.rbtnConsulta);
            this.groupBox1.Controls.Add(this.btnArticulo);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 183);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // rbtnAbm
            // 
            this.rbtnAbm.AutoSize = true;
            this.rbtnAbm.Location = new System.Drawing.Point(149, 144);
            this.rbtnAbm.Name = "rbtnAbm";
            this.rbtnAbm.Size = new System.Drawing.Size(57, 20);
            this.rbtnAbm.TabIndex = 6;
            this.rbtnAbm.TabStop = true;
            this.rbtnAbm.Text = "ABM";
            this.rbtnAbm.UseVisualStyleBackColor = true;
            // 
            // rbtnConsulta
            // 
            this.rbtnConsulta.AutoSize = true;
            this.rbtnConsulta.Location = new System.Drawing.Point(252, 144);
            this.rbtnConsulta.Name = "rbtnConsulta";
            this.rbtnConsulta.Size = new System.Drawing.Size(80, 20);
            this.rbtnConsulta.TabIndex = 7;
            this.rbtnConsulta.TabStop = true;
            this.rbtnConsulta.Text = "Consulta";
            this.rbtnConsulta.UseVisualStyleBackColor = true;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 253);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEmpresa);
            this.Name = "FrmMenuPrincipal";
            this.Text = "Menú Principal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.Button btnSector;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnArticulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnAbm;
        private System.Windows.Forms.RadioButton rbtnConsulta;
    }
}