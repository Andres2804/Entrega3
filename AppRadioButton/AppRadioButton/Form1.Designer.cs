namespace AppRadioButton
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.rbtSumar = new System.Windows.Forms.RadioButton();
            this.rbtRestar = new System.Windows.Forms.RadioButton();
            this.rbtMultiplicar = new System.Windows.Forms.RadioButton();
            this.rbtDividir = new System.Windows.Forms.RadioButton();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(33, 37);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(56, 13);
            this.lblNumero1.TabIndex = 0;
            this.lblNumero1.Text = "Numero 1:";
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Location = new System.Drawing.Point(33, 81);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(56, 13);
            this.lblNumero2.TabIndex = 1;
            this.lblNumero2.Text = "Numero 2:";
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(132, 30);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 20);
            this.txtNumero1.TabIndex = 2;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(132, 78);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 20);
            this.txtNumero2.TabIndex = 3;
            // 
            // rbtSumar
            // 
            this.rbtSumar.AutoSize = true;
            this.rbtSumar.Location = new System.Drawing.Point(36, 151);
            this.rbtSumar.Name = "rbtSumar";
            this.rbtSumar.Size = new System.Drawing.Size(55, 17);
            this.rbtSumar.TabIndex = 4;
            this.rbtSumar.TabStop = true;
            this.rbtSumar.Text = "Sumar";
            this.rbtSumar.UseVisualStyleBackColor = true;
            // 
            // rbtRestar
            // 
            this.rbtRestar.AutoSize = true;
            this.rbtRestar.Location = new System.Drawing.Point(147, 151);
            this.rbtRestar.Name = "rbtRestar";
            this.rbtRestar.Size = new System.Drawing.Size(56, 17);
            this.rbtRestar.TabIndex = 5;
            this.rbtRestar.TabStop = true;
            this.rbtRestar.Text = "Restar";
            this.rbtRestar.UseVisualStyleBackColor = true;
            // 
            // rbtMultiplicar
            // 
            this.rbtMultiplicar.AutoSize = true;
            this.rbtMultiplicar.Location = new System.Drawing.Point(36, 188);
            this.rbtMultiplicar.Name = "rbtMultiplicar";
            this.rbtMultiplicar.Size = new System.Drawing.Size(72, 17);
            this.rbtMultiplicar.TabIndex = 6;
            this.rbtMultiplicar.TabStop = true;
            this.rbtMultiplicar.Text = "Multiplicar";
            this.rbtMultiplicar.UseVisualStyleBackColor = true;
            // 
            // rbtDividir
            // 
            this.rbtDividir.AutoSize = true;
            this.rbtDividir.Location = new System.Drawing.Point(147, 188);
            this.rbtDividir.Name = "rbtDividir";
            this.rbtDividir.Size = new System.Drawing.Size(54, 17);
            this.rbtDividir.TabIndex = 7;
            this.rbtDividir.TabStop = true;
            this.rbtDividir.Text = "Dividir";
            this.rbtDividir.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(36, 121);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(132, 121);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 9;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(82, 211);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.rbtDividir);
            this.Controls.Add(this.rbtMultiplicar);
            this.Controls.Add(this.rbtRestar);
            this.Controls.Add(this.rbtSumar);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.lblNumero1);
            this.Name = "Form1";
            this.Text = "Programa Operaciones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.RadioButton rbtSumar;
        private System.Windows.Forms.RadioButton rbtRestar;
        private System.Windows.Forms.RadioButton rbtMultiplicar;
        private System.Windows.Forms.RadioButton rbtDividir;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCalcular;
    }
}

