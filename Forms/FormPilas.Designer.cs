namespace ProyectoSeries_DLL_JSVE.Forms
{
    partial class FormPilas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNroCapitulos = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregarCola = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.GridListas = new System.Windows.Forms.DataGridView();
            this.NombreSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroCapitulosSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridListas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(41)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.txtNroCapitulos);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.btnAgregarCola);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 471);
            this.panel1.TabIndex = 21;
            // 
            // txtNroCapitulos
            // 
            this.txtNroCapitulos.Location = new System.Drawing.Point(119, 186);
            this.txtNroCapitulos.Name = "txtNroCapitulos";
            this.txtNroCapitulos.Size = new System.Drawing.Size(100, 22);
            this.txtNroCapitulos.TabIndex = 23;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(109, 140);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(110, 22);
            this.txtDescripcion.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nro. capitulos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Descripcion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(86, 94);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(133, 22);
            this.txtNombre.TabIndex = 18;
            // 
            // btnAgregarCola
            // 
            this.btnAgregarCola.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAgregarCola.FlatAppearance.BorderSize = 0;
            this.btnAgregarCola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCola.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCola.Location = new System.Drawing.Point(24, 224);
            this.btnAgregarCola.Name = "btnAgregarCola";
            this.btnAgregarCola.Size = new System.Drawing.Size(195, 35);
            this.btnAgregarCola.TabIndex = 17;
            this.btnAgregarCola.Text = "Agregar";
            this.btnAgregarCola.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(41)))), ((int)(((byte)(81)))));
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.GridListas);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnOrdenar);
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(259, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 471);
            this.panel2.TabIndex = 22;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(408, 334);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(195, 35);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // GridListas
            // 
            this.GridListas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridListas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.GridListas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridListas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridListas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridListas.ColumnHeadersHeight = 20;
            this.GridListas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridListas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreSerie,
            this.DescripcionSerie,
            this.NroCapitulosSerie});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridListas.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridListas.EnableHeadersVisualStyles = false;
            this.GridListas.GridColor = System.Drawing.Color.SteelBlue;
            this.GridListas.Location = new System.Drawing.Point(6, 94);
            this.GridListas.Name = "GridListas";
            this.GridListas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridListas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridListas.RowHeadersWidth = 51;
            this.GridListas.RowTemplate.Height = 24;
            this.GridListas.Size = new System.Drawing.Size(691, 234);
            this.GridListas.TabIndex = 16;
            // 
            // NombreSerie
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.NombreSerie.DefaultCellStyle = dataGridViewCellStyle2;
            this.NombreSerie.HeaderText = "Nombre";
            this.NombreSerie.MinimumWidth = 6;
            this.NombreSerie.Name = "NombreSerie";
            // 
            // DescripcionSerie
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DescripcionSerie.DefaultCellStyle = dataGridViewCellStyle3;
            this.DescripcionSerie.HeaderText = "Descripcion";
            this.DescripcionSerie.MinimumWidth = 6;
            this.DescripcionSerie.Name = "DescripcionSerie";
            // 
            // NroCapitulosSerie
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.NroCapitulosSerie.DefaultCellStyle = dataGridViewCellStyle4;
            this.NroCapitulosSerie.HeaderText = "Nro.Capitulos";
            this.NroCapitulosSerie.MinimumWidth = 6;
            this.NroCapitulosSerie.Name = "NroCapitulosSerie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(321, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pilas";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnOrdenar.FlatAppearance.BorderSize = 0;
            this.btnOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenar.ForeColor = System.Drawing.Color.White;
            this.btnOrdenar.Location = new System.Drawing.Point(6, 334);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(195, 35);
            this.btnOrdenar.TabIndex = 6;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(207, 334);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(195, 35);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // FormPilas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 471);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPilas";
            this.Text = "FormPilas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridListas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNroCapitulos;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregarCola;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView GridListas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroCapitulosSerie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnEditar;
    }
}