﻿namespace ProyectoSeries_DLL_JSVE
{
    partial class FormMainMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnColas = new System.Windows.Forms.Button();
            this.btnPilas = new System.Windows.Forms.Button();
            this.btnListas = new System.Windows.Forms.Button();
            this.btnArreglos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.btnColas);
            this.panel1.Controls.Add(this.btnPilas);
            this.panel1.Controls.Add(this.btnListas);
            this.panel1.Controls.Add(this.btnArreglos);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 478);
            this.panel1.TabIndex = 0;
            // 
            // btnColas
            // 
            this.btnColas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnColas.FlatAppearance.BorderSize = 0;
            this.btnColas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnColas.Location = new System.Drawing.Point(0, 188);
            this.btnColas.Name = "btnColas";
            this.btnColas.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnColas.Size = new System.Drawing.Size(137, 42);
            this.btnColas.TabIndex = 4;
            this.btnColas.Text = "Colas";
            this.btnColas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColas.UseVisualStyleBackColor = true;
            this.btnColas.Click += new System.EventHandler(this.btnColas_Click);
            // 
            // btnPilas
            // 
            this.btnPilas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPilas.FlatAppearance.BorderSize = 0;
            this.btnPilas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPilas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPilas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPilas.Location = new System.Drawing.Point(0, 146);
            this.btnPilas.Name = "btnPilas";
            this.btnPilas.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnPilas.Size = new System.Drawing.Size(137, 42);
            this.btnPilas.TabIndex = 3;
            this.btnPilas.Text = "Pilas";
            this.btnPilas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPilas.UseVisualStyleBackColor = true;
            this.btnPilas.Click += new System.EventHandler(this.btnPilas_Click);
            // 
            // btnListas
            // 
            this.btnListas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListas.FlatAppearance.BorderSize = 0;
            this.btnListas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnListas.Location = new System.Drawing.Point(0, 104);
            this.btnListas.Name = "btnListas";
            this.btnListas.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnListas.Size = new System.Drawing.Size(137, 42);
            this.btnListas.TabIndex = 2;
            this.btnListas.Text = "Listas";
            this.btnListas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListas.UseVisualStyleBackColor = true;
            this.btnListas.Click += new System.EventHandler(this.btnListas_Click);
            // 
            // btnArreglos
            // 
            this.btnArreglos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArreglos.FlatAppearance.BorderSize = 0;
            this.btnArreglos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArreglos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArreglos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnArreglos.Location = new System.Drawing.Point(0, 62);
            this.btnArreglos.Name = "btnArreglos";
            this.btnArreglos.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnArreglos.Size = new System.Drawing.Size(137, 42);
            this.btnArreglos.TabIndex = 1;
            this.btnArreglos.Text = "Arreglos";
            this.btnArreglos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArreglos.UseVisualStyleBackColor = true;
            this.btnArreglos.Click += new System.EventHandler(this.btnArreglos_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(137, 62);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Series";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel3.Location = new System.Drawing.Point(137, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(797, 62);
            this.panel3.TabIndex = 1;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelContenedor.Location = new System.Drawing.Point(137, 62);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(783, 416);
            this.panelContenedor.TabIndex = 2;
            // 
            // FormMainMenu
            // 
            this.ClientSize = new System.Drawing.Size(920, 478);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FormMainMenu";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnColas;
        private System.Windows.Forms.Button btnPilas;
        private System.Windows.Forms.Button btnListas;
        private System.Windows.Forms.Button btnArreglos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContenedor;
    }
}