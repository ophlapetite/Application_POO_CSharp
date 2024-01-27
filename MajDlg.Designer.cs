namespace ProjetFBRWF
{
    partial class MajDlg
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Grille = new System.Windows.Forms.DataGridView();
            this.Valider = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grille)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Grille, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Valider, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.37548F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.62452F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(854, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Grille
            // 
            this.Grille.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grille.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grille.Location = new System.Drawing.Point(3, 3);
            this.Grille.Name = "Grille";
            this.Grille.Size = new System.Drawing.Size(848, 209);
            this.Grille.TabIndex = 0;
            this.Grille.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grille_CellEndEdit);
            // 
            // Valider
            // 
            this.Valider.BackColor = System.Drawing.Color.LightGreen;
            this.Valider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Valider.Location = new System.Drawing.Point(3, 218);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(848, 40);
            this.Valider.TabIndex = 1;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = false;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // MajDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MajDlg";
            this.Text = "MajDlg";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grille)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView Grille;
        private System.Windows.Forms.Button Valider;
    }
}