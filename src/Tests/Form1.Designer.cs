namespace Tests
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericTextBox1 = new CustomLibrary.ComponentModel.NumericTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bevel1 = new CustomLibrary.ComponentModel.Bevel();
            this.customDataGridView1 = new Controles.Grilla.CustomDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.customDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericTextBox1
            // 
            this.numericTextBox1.Location = new System.Drawing.Point(118, 19);
            this.numericTextBox1.Name = "numericTextBox1";
            this.numericTextBox1.Size = new System.Drawing.Size(100, 20);
            this.numericTextBox1.TabIndex = 0;
            this.numericTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NumericTextBox";
            // 
            // bevel1
            // 
            this.bevel1.BevelStyle = CustomLibrary.ComponentModel.BevelStyle.Lowered;
            this.bevel1.BevelType = CustomLibrary.ComponentModel.BevelType.Box;
            this.bevel1.HighlightColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bevel1.Location = new System.Drawing.Point(12, 12);
            this.bevel1.Name = "bevel1";
            this.bevel1.ShadowColor = System.Drawing.SystemColors.ButtonShadow;
            this.bevel1.Size = new System.Drawing.Size(221, 35);
            this.bevel1.TabIndex = 2;
            this.bevel1.Text = "bevel1";
            // 
            // customDataGridView1
            // 
            this.customDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customDataGridView1.EvenRowColor = System.Drawing.Color.MistyRose;
            this.customDataGridView1.Location = new System.Drawing.Point(12, 85);
            this.customDataGridView1.Name = "customDataGridView1";
            this.customDataGridView1.OddRowColor = System.Drawing.Color.WhiteSmoke;
            this.customDataGridView1.Size = new System.Drawing.Size(477, 150);
            this.customDataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 262);
            this.Controls.Add(this.customDataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericTextBox1);
            this.Controls.Add(this.bevel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.customDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomLibrary.ComponentModel.NumericTextBox numericTextBox1;
        private System.Windows.Forms.Label label1;
        private CustomLibrary.ComponentModel.Bevel bevel1;
        private Controles.Grilla.CustomDataGridView customDataGridView1;
    }
}

