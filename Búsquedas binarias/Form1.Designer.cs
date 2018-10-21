namespace Búsquedas_binarias
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.Location = new System.Drawing.Point(158, 108);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 26);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(80, 14);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(72, 22);
            this.txtSize.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tamaño:";
            // 
            // btnFill
            // 
            this.btnFill.AutoSize = true;
            this.btnFill.Location = new System.Drawing.Point(158, 44);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(92, 26);
            this.btnFill.TabIndex = 3;
            this.btnFill.Text = "Llenar";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnShow
            // 
            this.btnShow.AutoSize = true;
            this.btnShow.Location = new System.Drawing.Point(158, 76);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(92, 26);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Mostrar";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.AutoSize = true;
            this.btnCrear.Location = new System.Drawing.Point(158, 12);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(92, 26);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnSort
            // 
            this.btnSort.AutoSize = true;
            this.btnSort.Location = new System.Drawing.Point(12, 76);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(140, 26);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Ordenar";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(64, 46);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(88, 22);
            this.txtLimit.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Límite:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(74, 110);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(78, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número";
            // 
            // txtShow
            // 
            this.txtShow.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.txtShow.Location = new System.Drawing.Point(12, 140);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtShow.Size = new System.Drawing.Size(238, 212);
            this.txtShow.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 364);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.btnSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Búsquedas binarias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtShow;
    }
}

