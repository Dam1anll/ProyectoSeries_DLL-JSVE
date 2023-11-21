namespace ProyectoSeries_DLL_JSVE.Forms
{
    partial class FormArreglos
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnIngresarArreglos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNombres = new System.Windows.Forms.ListBox();
            this.lbDescripcion = new System.Windows.Forms.ListBox();
            this.lbCapitulos = new System.Windows.Forms.ListBox();
            this.txtTamaño = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOrdenarCapitulos = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arreglos";
            // 
            // btnIngresarArreglos
            // 
            this.btnIngresarArreglos.Location = new System.Drawing.Point(75, 170);
            this.btnIngresarArreglos.Name = "btnIngresarArreglos";
            this.btnIngresarArreglos.Size = new System.Drawing.Size(185, 44);
            this.btnIngresarArreglos.TabIndex = 2;
            this.btnIngresarArreglos.Text = "Ingresar";
            this.btnIngresarArreglos.UseVisualStyleBackColor = true;
            this.btnIngresarArreglos.Click += new System.EventHandler(this.btnIngresarArreglos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(49, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tamaño:";
            // 
            // lbNombres
            // 
            this.lbNombres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbNombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbNombres.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbNombres.FormattingEnabled = true;
            this.lbNombres.ItemHeight = 16;
            this.lbNombres.Location = new System.Drawing.Point(366, 142);
            this.lbNombres.MultiColumn = true;
            this.lbNombres.Name = "lbNombres";
            this.lbNombres.Size = new System.Drawing.Size(123, 240);
            this.lbNombres.TabIndex = 5;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbDescripcion.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbDescripcion.FormattingEnabled = true;
            this.lbDescripcion.ItemHeight = 16;
            this.lbDescripcion.Location = new System.Drawing.Point(495, 142);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(123, 240);
            this.lbDescripcion.TabIndex = 6;
            // 
            // lbCapitulos
            // 
            this.lbCapitulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbCapitulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbCapitulos.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbCapitulos.FormattingEnabled = true;
            this.lbCapitulos.ItemHeight = 16;
            this.lbCapitulos.Location = new System.Drawing.Point(621, 142);
            this.lbCapitulos.Name = "lbCapitulos";
            this.lbCapitulos.Size = new System.Drawing.Size(123, 240);
            this.lbCapitulos.TabIndex = 7;
            // 
            // txtTamaño
            // 
            this.txtTamaño.Location = new System.Drawing.Point(116, 142);
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.Size = new System.Drawing.Size(100, 22);
            this.txtTamaño.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(388, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(493, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(624, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Capitulos";
            // 
            // btnOrdenarCapitulos
            // 
            this.btnOrdenarCapitulos.Location = new System.Drawing.Point(75, 322);
            this.btnOrdenarCapitulos.Name = "btnOrdenarCapitulos";
            this.btnOrdenarCapitulos.Size = new System.Drawing.Size(185, 45);
            this.btnOrdenarCapitulos.TabIndex = 12;
            this.btnOrdenarCapitulos.Text = "Ordenar";
            this.btnOrdenarCapitulos.UseVisualStyleBackColor = true;
            this.btnOrdenarCapitulos.Click += new System.EventHandler(this.btnOrdenarCapitulos_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(75, 220);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(185, 45);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(75, 271);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(185, 45);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FormArreglos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnOrdenarCapitulos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTamaño);
            this.Controls.Add(this.lbCapitulos);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbNombres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIngresarArreglos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormArreglos";
            this.Text = "FormArreglos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngresarArreglos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbDescripcion;
        private System.Windows.Forms.ListBox lbCapitulos;
        private System.Windows.Forms.TextBox txtTamaño;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOrdenarCapitulos;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.ListBox lbNombres;
    }
}