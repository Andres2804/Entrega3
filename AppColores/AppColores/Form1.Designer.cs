namespace AppColores
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
            this.chkColor1 = new System.Windows.Forms.CheckBox();
            this.chkColor2 = new System.Windows.Forms.CheckBox();
            this.chkColor3 = new System.Windows.Forms.CheckBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkColor1
            // 
            this.chkColor1.AutoSize = true;
            this.chkColor1.Location = new System.Drawing.Point(75, 42);
            this.chkColor1.Name = "chkColor1";
            this.chkColor1.Size = new System.Drawing.Size(62, 17);
            this.chkColor1.TabIndex = 0;
            this.chkColor1.Text = "Amarillo";
            this.chkColor1.UseVisualStyleBackColor = true;
            // 
            // chkColor2
            // 
            this.chkColor2.AutoSize = true;
            this.chkColor2.Location = new System.Drawing.Point(75, 78);
            this.chkColor2.Name = "chkColor2";
            this.chkColor2.Size = new System.Drawing.Size(46, 17);
            this.chkColor2.TabIndex = 1;
            this.chkColor2.Text = "Azul";
            this.chkColor2.UseVisualStyleBackColor = true;
            // 
            // chkColor3
            // 
            this.chkColor3.AutoSize = true;
            this.chkColor3.Location = new System.Drawing.Point(75, 115);
            this.chkColor3.Name = "chkColor3";
            this.chkColor3.Size = new System.Drawing.Size(48, 17);
            this.chkColor3.TabIndex = 2;
            this.chkColor3.Text = "Rojo";
            this.chkColor3.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(75, 157);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 3;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.chkColor3);
            this.Controls.Add(this.chkColor2);
            this.Controls.Add(this.chkColor1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkColor1;
        private System.Windows.Forms.CheckBox chkColor2;
        private System.Windows.Forms.CheckBox chkColor3;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}

