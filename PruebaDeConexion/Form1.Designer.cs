
namespace PruebaDeConexion
{
    partial class Form1
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
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.TxtVersion = new System.Windows.Forms.Label();
            this.TxtEstadoConexion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(268, 328);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(279, 41);
            this.btnMostrarDatos.TabIndex = 0;
            this.btnMostrarDatos.Text = "MostrarDatos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // TxtVersion
            // 
            this.TxtVersion.AutoSize = true;
            this.TxtVersion.Location = new System.Drawing.Point(211, 90);
            this.TxtVersion.Name = "TxtVersion";
            this.TxtVersion.Size = new System.Drawing.Size(46, 17);
            this.TxtVersion.TabIndex = 1;
            this.TxtVersion.Text = "label1";
            // 
            // TxtEstadoConexion
            // 
            this.TxtEstadoConexion.AutoSize = true;
            this.TxtEstadoConexion.Location = new System.Drawing.Point(211, 163);
            this.TxtEstadoConexion.Name = "TxtEstadoConexion";
            this.TxtEstadoConexion.Size = new System.Drawing.Size(46, 17);
            this.TxtEstadoConexion.TabIndex = 2;
            this.TxtEstadoConexion.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtEstadoConexion);
            this.Controls.Add(this.TxtVersion);
            this.Controls.Add(this.btnMostrarDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.Label TxtVersion;
        private System.Windows.Forms.Label TxtEstadoConexion;
    }
}

