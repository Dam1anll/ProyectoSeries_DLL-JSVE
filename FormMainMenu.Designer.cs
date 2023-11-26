namespace ProyectoSeries_DLL_JSVE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnColas = new System.Windows.Forms.Button();
            this.btnPilas = new System.Windows.Forms.Button();
            this.btnListas = new System.Windows.Forms.Button();
            this.btnArreglos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBoxSeries = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSeries)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(41)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.btnColas);
            this.panel1.Controls.Add(this.btnPilas);
            this.panel1.Controls.Add(this.btnListas);
            this.panel1.Controls.Add(this.btnArreglos);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 471);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnColas
            // 
            this.btnColas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnColas.FlatAppearance.BorderSize = 0;
            this.btnColas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnColas.Location = new System.Drawing.Point(0, 284);
            this.btnColas.Name = "btnColas";
            this.btnColas.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnColas.Size = new System.Drawing.Size(179, 73);
            this.btnColas.TabIndex = 4;
            this.btnColas.Text = "Colas";
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
            this.btnPilas.Location = new System.Drawing.Point(0, 206);
            this.btnPilas.Name = "btnPilas";
            this.btnPilas.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnPilas.Size = new System.Drawing.Size(179, 78);
            this.btnPilas.TabIndex = 3;
            this.btnPilas.Text = "Pilas";
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
            this.btnListas.Location = new System.Drawing.Point(0, 134);
            this.btnListas.Name = "btnListas";
            this.btnListas.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnListas.Size = new System.Drawing.Size(179, 72);
            this.btnListas.TabIndex = 2;
            this.btnListas.Text = "Listas";
            this.btnListas.UseVisualStyleBackColor = true;
            this.btnListas.Click += new System.EventHandler(this.btnListas_Click);
            // 
            // btnArreglos
            // 
            this.btnArreglos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArreglos.FlatAppearance.BorderSize = 0;
            this.btnArreglos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArreglos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnArreglos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnArreglos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArreglos.Location = new System.Drawing.Point(0, 62);
            this.btnArreglos.Name = "btnArreglos";
            this.btnArreglos.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnArreglos.Size = new System.Drawing.Size(179, 72);
            this.btnArreglos.TabIndex = 1;
            this.btnArreglos.Text = "Arreglos";
            this.btnArreglos.UseVisualStyleBackColor = true;
            this.btnArreglos.Click += new System.EventHandler(this.btnArreglos_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(41)))), ((int)(((byte)(81)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 62);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Series";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(41)))), ((int)(((byte)(81)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(179, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(789, 62);
            this.panel3.TabIndex = 1;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.panelContenedor.Controls.Add(this.pictureBoxSeries);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(179, 62);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(789, 409);
            this.panelContenedor.TabIndex = 2;
            // 
            // pictureBoxSeries
            // 
            this.pictureBoxSeries.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSeries.Image")));
            this.pictureBoxSeries.Location = new System.Drawing.Point(262, 72);
            this.pictureBoxSeries.Name = "pictureBoxSeries";
            this.pictureBoxSeries.Size = new System.Drawing.Size(253, 223);
            this.pictureBoxSeries.TabIndex = 0;
            this.pictureBoxSeries.TabStop = false;
            // 
            // FormMainMenu
            // 
            this.ClientSize = new System.Drawing.Size(968, 471);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FormMainMenu";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSeries)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBoxSeries;
    }
}
