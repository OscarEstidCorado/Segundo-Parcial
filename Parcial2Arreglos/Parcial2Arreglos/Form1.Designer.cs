
namespace Parcial2Arreglos
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxresultado = new System.Windows.Forms.TextBox();
            this.buttonnombres = new System.Windows.Forms.Button();
            this.listBoxOrdenar = new System.Windows.Forms.ListBox();
            this.buttonnombresdesor = new System.Windows.Forms.Button();
            this.listBoxNombresDesordenados = new System.Windows.Forms.ListBox();
            this.buttonparcial1 = new System.Windows.Forms.Button();
            this.buttonparcial2 = new System.Windows.Forms.Button();
            this.listBoxParcial1 = new System.Windows.Forms.ListBox();
            this.buttonparcial3 = new System.Windows.Forms.Button();
            this.listBoxParcial3 = new System.Windows.Forms.ListBox();
            this.buttonpromedio = new System.Windows.Forms.Button();
            this.listBoxParcial2 = new System.Windows.Forms.ListBox();
            this.listBoxOrdenamiento = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cargar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxresultado
            // 
            this.textBoxresultado.Location = new System.Drawing.Point(110, 12);
            this.textBoxresultado.Multiline = true;
            this.textBoxresultado.Name = "textBoxresultado";
            this.textBoxresultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxresultado.Size = new System.Drawing.Size(336, 193);
            this.textBoxresultado.TabIndex = 1;
            // 
            // buttonnombres
            // 
            this.buttonnombres.Location = new System.Drawing.Point(462, 55);
            this.buttonnombres.Name = "buttonnombres";
            this.buttonnombres.Size = new System.Drawing.Size(75, 38);
            this.buttonnombres.TabIndex = 2;
            this.buttonnombres.Text = "Nombres Ordenados";
            this.buttonnombres.UseVisualStyleBackColor = true;
            this.buttonnombres.Click += new System.EventHandler(this.buttonnombres_Click);
            // 
            // listBoxOrdenar
            // 
            this.listBoxOrdenar.FormattingEnabled = true;
            this.listBoxOrdenar.Location = new System.Drawing.Point(543, 12);
            this.listBoxOrdenar.Name = "listBoxOrdenar";
            this.listBoxOrdenar.Size = new System.Drawing.Size(284, 186);
            this.listBoxOrdenar.TabIndex = 3;
            // 
            // buttonnombresdesor
            // 
            this.buttonnombresdesor.Location = new System.Drawing.Point(55, 222);
            this.buttonnombresdesor.Name = "buttonnombresdesor";
            this.buttonnombresdesor.Size = new System.Drawing.Size(139, 23);
            this.buttonnombresdesor.TabIndex = 4;
            this.buttonnombresdesor.Text = "Nombres Desordenados";
            this.buttonnombresdesor.UseVisualStyleBackColor = true;
            this.buttonnombresdesor.Click += new System.EventHandler(this.buttonnombresdesor_Click);
            // 
            // listBoxNombresDesordenados
            // 
            this.listBoxNombresDesordenados.FormattingEnabled = true;
            this.listBoxNombresDesordenados.Location = new System.Drawing.Point(12, 256);
            this.listBoxNombresDesordenados.Name = "listBoxNombresDesordenados";
            this.listBoxNombresDesordenados.Size = new System.Drawing.Size(220, 199);
            this.listBoxNombresDesordenados.TabIndex = 5;
            // 
            // buttonparcial1
            // 
            this.buttonparcial1.Location = new System.Drawing.Point(294, 215);
            this.buttonparcial1.Name = "buttonparcial1";
            this.buttonparcial1.Size = new System.Drawing.Size(104, 36);
            this.buttonparcial1.TabIndex = 6;
            this.buttonparcial1.Text = "Datos Primer Parcial";
            this.buttonparcial1.UseVisualStyleBackColor = true;
            this.buttonparcial1.Click += new System.EventHandler(this.buttonparcial1_Click);
            // 
            // buttonparcial2
            // 
            this.buttonparcial2.Location = new System.Drawing.Point(524, 213);
            this.buttonparcial2.Name = "buttonparcial2";
            this.buttonparcial2.Size = new System.Drawing.Size(105, 38);
            this.buttonparcial2.TabIndex = 7;
            this.buttonparcial2.Text = "Datos Segundo Parcial";
            this.buttonparcial2.UseVisualStyleBackColor = true;
            this.buttonparcial2.Click += new System.EventHandler(this.buttonparcial2_Click);
            // 
            // listBoxParcial1
            // 
            this.listBoxParcial1.FormattingEnabled = true;
            this.listBoxParcial1.Location = new System.Drawing.Point(258, 256);
            this.listBoxParcial1.Name = "listBoxParcial1";
            this.listBoxParcial1.Size = new System.Drawing.Size(188, 199);
            this.listBoxParcial1.TabIndex = 8;
            // 
            // buttonparcial3
            // 
            this.buttonparcial3.Location = new System.Drawing.Point(749, 206);
            this.buttonparcial3.Name = "buttonparcial3";
            this.buttonparcial3.Size = new System.Drawing.Size(87, 41);
            this.buttonparcial3.TabIndex = 10;
            this.buttonparcial3.Text = "Datos Tercer Parcial";
            this.buttonparcial3.UseVisualStyleBackColor = true;
            this.buttonparcial3.Click += new System.EventHandler(this.buttonparcial3_Click);
            // 
            // listBoxParcial3
            // 
            this.listBoxParcial3.FormattingEnabled = true;
            this.listBoxParcial3.Location = new System.Drawing.Point(701, 256);
            this.listBoxParcial3.Name = "listBoxParcial3";
            this.listBoxParcial3.Size = new System.Drawing.Size(188, 199);
            this.listBoxParcial3.TabIndex = 11;
            // 
            // buttonpromedio
            // 
            this.buttonpromedio.Location = new System.Drawing.Point(917, 9);
            this.buttonpromedio.Name = "buttonpromedio";
            this.buttonpromedio.Size = new System.Drawing.Size(92, 25);
            this.buttonpromedio.TabIndex = 12;
            this.buttonpromedio.Text = "Promedio";
            this.buttonpromedio.UseVisualStyleBackColor = true;
            this.buttonpromedio.Click += new System.EventHandler(this.buttonpromedio_Click);
            // 
            // listBoxParcial2
            // 
            this.listBoxParcial2.FormattingEnabled = true;
            this.listBoxParcial2.Location = new System.Drawing.Point(483, 255);
            this.listBoxParcial2.Name = "listBoxParcial2";
            this.listBoxParcial2.Size = new System.Drawing.Size(188, 199);
            this.listBoxParcial2.TabIndex = 9;
            // 
            // listBoxOrdenamiento
            // 
            this.listBoxOrdenamiento.FormattingEnabled = true;
            this.listBoxOrdenamiento.Location = new System.Drawing.Point(855, 43);
            this.listBoxOrdenamiento.Name = "listBoxOrdenamiento";
            this.listBoxOrdenamiento.Size = new System.Drawing.Size(188, 199);
            this.listBoxOrdenamiento.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 512);
            this.Controls.Add(this.listBoxOrdenamiento);
            this.Controls.Add(this.buttonpromedio);
            this.Controls.Add(this.listBoxParcial3);
            this.Controls.Add(this.buttonparcial3);
            this.Controls.Add(this.listBoxParcial2);
            this.Controls.Add(this.listBoxParcial1);
            this.Controls.Add(this.buttonparcial2);
            this.Controls.Add(this.buttonparcial1);
            this.Controls.Add(this.listBoxNombresDesordenados);
            this.Controls.Add(this.buttonnombresdesor);
            this.Controls.Add(this.listBoxOrdenar);
            this.Controls.Add(this.buttonnombres);
            this.Controls.Add(this.textBoxresultado);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Programa Segundo Parcial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxresultado;
        private System.Windows.Forms.Button buttonnombres;
        private System.Windows.Forms.ListBox listBoxOrdenar;
        private System.Windows.Forms.Button buttonnombresdesor;
        private System.Windows.Forms.ListBox listBoxNombresDesordenados;
        private System.Windows.Forms.Button buttonparcial1;
        private System.Windows.Forms.Button buttonparcial2;
        private System.Windows.Forms.ListBox listBoxParcial1;
        private System.Windows.Forms.Button buttonparcial3;
        private System.Windows.Forms.ListBox listBoxParcial3;
        private System.Windows.Forms.Button buttonpromedio;
        private System.Windows.Forms.ListBox listBoxParcial2;
        private System.Windows.Forms.ListBox listBoxOrdenamiento;
    }
}

