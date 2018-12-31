namespace Ejemplo2
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
            this.lbPrimerNumero = new System.Windows.Forms.Label();
            this.lbSegundoNumero = new System.Windows.Forms.Label();
            this.tBxPrimerNumero = new System.Windows.Forms.TextBox();
            this.tBxSegundoNumero = new System.Windows.Forms.TextBox();
            this.lBResultado = new System.Windows.Forms.Label();
            this.tBxResultado = new System.Windows.Forms.TextBox();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPrimerNumero
            // 
            this.lbPrimerNumero.AutoSize = true;
            this.lbPrimerNumero.Location = new System.Drawing.Point(12, 9);
            this.lbPrimerNumero.Name = "lbPrimerNumero";
            this.lbPrimerNumero.Size = new System.Drawing.Size(17, 17);
            this.lbPrimerNumero.TabIndex = 0;
            this.lbPrimerNumero.Text = "X";
            // 
            // lbSegundoNumero
            // 
            this.lbSegundoNumero.AutoSize = true;
            this.lbSegundoNumero.Location = new System.Drawing.Point(12, 45);
            this.lbSegundoNumero.Name = "lbSegundoNumero";
            this.lbSegundoNumero.Size = new System.Drawing.Size(17, 17);
            this.lbSegundoNumero.TabIndex = 1;
            this.lbSegundoNumero.Text = "Y";
            // 
            // tBxPrimerNumero
            // 
            this.tBxPrimerNumero.Location = new System.Drawing.Point(48, 9);
            this.tBxPrimerNumero.Name = "tBxPrimerNumero";
            this.tBxPrimerNumero.Size = new System.Drawing.Size(100, 22);
            this.tBxPrimerNumero.TabIndex = 2;
            // 
            // tBxSegundoNumero
            // 
            this.tBxSegundoNumero.Location = new System.Drawing.Point(48, 40);
            this.tBxSegundoNumero.Name = "tBxSegundoNumero";
            this.tBxSegundoNumero.Size = new System.Drawing.Size(100, 22);
            this.tBxSegundoNumero.TabIndex = 3;
            // 
            // lBResultado
            // 
            this.lBResultado.AutoSize = true;
            this.lBResultado.Location = new System.Drawing.Point(12, 80);
            this.lBResultado.Name = "lBResultado";
            this.lBResultado.Size = new System.Drawing.Size(16, 17);
            this.lBResultado.TabIndex = 4;
            this.lBResultado.Text = "=";
            // 
            // tBxResultado
            // 
            this.tBxResultado.Location = new System.Drawing.Point(48, 77);
            this.tBxResultado.Name = "tBxResultado";
            this.tBxResultado.Size = new System.Drawing.Size(100, 22);
            this.tBxResultado.TabIndex = 5;
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(15, 121);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(40, 23);
            this.btnSuma.TabIndex = 6;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(68, 121);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(40, 23);
            this.btnResta.TabIndex = 7;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.Location = new System.Drawing.Point(123, 121);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(40, 23);
            this.btnMultiplicacion.TabIndex = 8;
            this.btnMultiplicacion.Text = "*";
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(175, 121);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(40, 23);
            this.btnDivision.TabIndex = 9;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1023, 646);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.tBxResultado);
            this.Controls.Add(this.lBResultado);
            this.Controls.Add(this.tBxSegundoNumero);
            this.Controls.Add(this.tBxPrimerNumero);
            this.Controls.Add(this.lbSegundoNumero);
            this.Controls.Add(this.lbPrimerNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPrimerNumero;
        private System.Windows.Forms.Label lbSegundoNumero;
        private System.Windows.Forms.TextBox tBxPrimerNumero;
        private System.Windows.Forms.TextBox tBxSegundoNumero;
        private System.Windows.Forms.Label lBResultado;
        private System.Windows.Forms.TextBox tBxResultado;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnDivision;
    }
}