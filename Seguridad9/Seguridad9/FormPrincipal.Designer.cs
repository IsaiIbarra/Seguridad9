
namespace Seguridad9
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblProducto = new System.Windows.Forms.Label();
            this.TxtProducto = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.BtnCrearMandadoNuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Location = new System.Drawing.Point(96, 107);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(117, 13);
            this.LblProducto.TabIndex = 0;
            this.LblProducto.Text = "Introduzca un producto";
            // 
            // TxtProducto
            // 
            this.TxtProducto.Location = new System.Drawing.Point(219, 100);
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.Size = new System.Drawing.Size(100, 20);
            this.TxtProducto.TabIndex = 1;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(511, 104);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(100, 20);
            this.TxtCantidad.TabIndex = 5;
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Location = new System.Drawing.Point(340, 107);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(165, 13);
            this.LblCantidad.TabIndex = 4;
            this.LblCantidad.Text = "Introduzca una cantidad y unidad";
            // 
            // BtnCrearMandadoNuevo
            // 
            this.BtnCrearMandadoNuevo.Location = new System.Drawing.Point(303, 168);
            this.BtnCrearMandadoNuevo.Name = "BtnCrearMandadoNuevo";
            this.BtnCrearMandadoNuevo.Size = new System.Drawing.Size(118, 23);
            this.BtnCrearMandadoNuevo.TabIndex = 8;
            this.BtnCrearMandadoNuevo.Text = "Agregar al mandado";
            this.BtnCrearMandadoNuevo.UseVisualStyleBackColor = true;
            this.BtnCrearMandadoNuevo.Click += new System.EventHandler(this.BtnCrearMandadoNuevo_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCrearMandadoNuevo);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.TxtProducto);
            this.Controls.Add(this.LblProducto);
            this.Name = "FormPrincipal";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblProducto;
        private System.Windows.Forms.TextBox TxtProducto;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Button BtnCrearMandadoNuevo;
    }
}

