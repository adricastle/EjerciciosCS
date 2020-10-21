namespace Ejercicio4
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
            this.email = new System.Windows.Forms.CheckBox();
            this.telephone = new System.Windows.Forms.CheckBox();
            this.fax = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelRes = new System.Windows.Forms.Label();
            this.correo = new System.Windows.Forms.RadioButton();
            this.normal = new System.Windows.Forms.RadioButton();
            this.urgente = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(603, 91);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(128, 24);
            this.email.TabIndex = 3;
            this.email.Text = "Email (0.75€)";
            this.email.UseVisualStyleBackColor = true;
            this.email.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // telephone
            // 
            this.telephone.AutoSize = true;
            this.telephone.Location = new System.Drawing.Point(603, 177);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(151, 24);
            this.telephone.TabIndex = 4;
            this.telephone.Text = "Teléfono (1.25€)";
            this.telephone.UseVisualStyleBackColor = true;
            this.telephone.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // fax
            // 
            this.fax.AutoSize = true;
            this.fax.Location = new System.Drawing.Point(603, 266);
            this.fax.Name = "fax";
            this.fax.Size = new System.Drawing.Size(115, 24);
            this.fax.TabIndex = 5;
            this.fax.Text = "Fax (0.50€)";
            this.fax.UseVisualStyleBackColor = true;
            this.fax.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Location = new System.Drawing.Point(354, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular Coste";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Enabled = false;
            this.labelRes.Location = new System.Drawing.Point(599, 392);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(63, 20);
            this.labelRes.TabIndex = 7;
            this.labelRes.Text = "Coste...";
            // 
            // correo
            // 
            this.correo.AutoSize = true;
            this.correo.Location = new System.Drawing.Point(115, 91);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(181, 24);
            this.correo.TabIndex = 8;
            this.correo.TabStop = true;
            this.correo.Text = "Correo Normal (3.5€)";
            this.correo.UseVisualStyleBackColor = true;
            this.correo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // normal
            // 
            this.normal.AutoSize = true;
            this.normal.Location = new System.Drawing.Point(115, 177);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(197, 24);
            this.normal.TabIndex = 9;
            this.normal.TabStop = true;
            this.normal.Text = "Paquetería Normal (4€)";
            this.normal.UseVisualStyleBackColor = true;
            this.normal.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // urgente
            // 
            this.urgente.AutoSize = true;
            this.urgente.Location = new System.Drawing.Point(115, 265);
            this.urgente.Name = "urgente";
            this.urgente.Size = new System.Drawing.Size(227, 24);
            this.urgente.TabIndex = 10;
            this.urgente.TabStop = true;
            this.urgente.Text = "Paquetería Urgente (6.75€)";
            this.urgente.UseVisualStyleBackColor = true;
            this.urgente.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 474);
            this.Controls.Add(this.urgente);
            this.Controls.Add(this.normal);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fax);
            this.Controls.Add(this.telephone);
            this.Controls.Add(this.email);
            this.Name = "Form1";
            this.Text = "Costes de Envío";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox email;
        private System.Windows.Forms.CheckBox telephone;
        private System.Windows.Forms.CheckBox fax;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.RadioButton correo;
        private System.Windows.Forms.RadioButton normal;
        private System.Windows.Forms.RadioButton urgente;
    }
}

