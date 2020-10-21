namespace Ejercicio2
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
            this.Num1 = new System.Windows.Forms.TextBox();
            this.Sumar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Num2 = new System.Windows.Forms.TextBox();
            this.Res = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Limpiar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Num1
            // 
            this.Num1.Location = new System.Drawing.Point(306, 64);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(95, 26);
            this.Num1.TabIndex = 0;
            this.Num1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Sumar
            // 
            this.Sumar.Location = new System.Drawing.Point(306, 184);
            this.Sumar.Name = "Sumar";
            this.Sumar.Size = new System.Drawing.Size(81, 53);
            this.Sumar.TabIndex = 1;
            this.Sumar.Text = "Sumar";
            this.Sumar.UseVisualStyleBackColor = true;
            this.Sumar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Primer Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Segundo Numero";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Num2
            // 
            this.Num2.Location = new System.Drawing.Point(306, 128);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(100, 26);
            this.Num2.TabIndex = 4;
            this.Num2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Res
            // 
            this.Res.Location = new System.Drawing.Point(306, 264);
            this.Res.Name = "Res";
            this.Res.Size = new System.Drawing.Size(100, 26);
            this.Res.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultado";
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(124, 358);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(81, 53);
            this.Limpiar.TabIndex = 7;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(603, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 53);
            this.button3.TabIndex = 8;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Res);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sumar);
            this.Controls.Add(this.Num1);
            this.Name = "Form1";
            this.Text = "suma de dos numeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Num1;
        private System.Windows.Forms.Button Sumar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Num2;
        private System.Windows.Forms.TextBox Res;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button button3;
    }
}

