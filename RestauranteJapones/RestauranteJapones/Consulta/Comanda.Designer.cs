namespace RestauranteJapones
{
    partial class Comanda
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
            this.btnCom = new System.Windows.Forms.Button();
            this.dgvCom = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCom)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCom
            // 
            this.btnCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnCom.Location = new System.Drawing.Point(53, 35);
            this.btnCom.Name = "btnCom";
            this.btnCom.Size = new System.Drawing.Size(122, 51);
            this.btnCom.TabIndex = 0;
            this.btnCom.Text = "CONSULTAR";
            this.btnCom.UseVisualStyleBackColor = true;
            this.btnCom.Click += new System.EventHandler(this.btnCom_Click);
            // 
            // dgvCom
            // 
            this.dgvCom.AllowUserToAddRows = false;
            this.dgvCom.AllowUserToDeleteRows = false;
            this.dgvCom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCom.Location = new System.Drawing.Point(53, 132);
            this.dgvCom.Name = "dgvCom";
            this.dgvCom.ReadOnly = true;
            this.dgvCom.Size = new System.Drawing.Size(685, 280);
            this.dgvCom.TabIndex = 1;
            // 
            // Comanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCom);
            this.Controls.Add(this.btnCom);
            this.Name = "Comanda";
            this.Text = "Comanda";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCom;
        private System.Windows.Forms.DataGridView dgvCom;
    }
}