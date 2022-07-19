namespace Venda
{
    partial class FormVenda
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
            this.exibirVendasGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.exibirVendasGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // exibirVendasGridView1
            // 
            this.exibirVendasGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exibirVendasGridView1.Location = new System.Drawing.Point(12, 12);
            this.exibirVendasGridView1.Name = "exibirVendasGridView1";
            this.exibirVendasGridView1.Size = new System.Drawing.Size(472, 286);
            this.exibirVendasGridView1.TabIndex = 0;
            this.exibirVendasGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.exibirVendasGridView1_CellContentClick);
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 310);
            this.Controls.Add(this.exibirVendasGridView1);
            this.Name = "FormVenda";
            this.Text = "Venda";
            ((System.ComponentModel.ISupportInitialize)(this.exibirVendasGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView exibirVendasGridView1;
    }
}