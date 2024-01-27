namespace ProjetFBRWF
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
   
        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listePhotos = new System.Windows.Forms.ListBox();
            this.Edition = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BTSkin = new System.Windows.Forms.Button();
            this.BESkin = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LRarete = new System.Windows.Forms.Label();
            this.ListeRarete = new System.Windows.Forms.ComboBox();
            this.ListeSkins = new System.Windows.Forms.ListBox();
            this.PhotoSkin = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gérerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesSkinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoSkin)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 426);
            this.splitContainer1.SplitterDistance = 544;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listePhotos);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.Edition);
            this.splitContainer2.Size = new System.Drawing.Size(544, 426);
            this.splitContainer2.SplitterDistance = 179;
            this.splitContainer2.TabIndex = 0;
            // 
            // listePhotos
            // 
            this.listePhotos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listePhotos.FormattingEnabled = true;
            this.listePhotos.Location = new System.Drawing.Point(0, 0);
            this.listePhotos.Name = "listePhotos";
            this.listePhotos.Size = new System.Drawing.Size(179, 426);
            this.listePhotos.TabIndex = 0;
            this.listePhotos.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListePhotos_DrawItem_1);
            // 
            // Edition
            // 
            this.Edition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Edition.Location = new System.Drawing.Point(0, 0);
            this.Edition.Name = "Edition";
            this.Edition.Size = new System.Drawing.Size(361, 426);
            this.Edition.TabIndex = 0;
            this.Edition.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BTSkin, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BESkin, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ListeSkins, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.PhotoSkin, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(252, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BTSkin
            // 
            this.BTSkin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTSkin.Location = new System.Drawing.Point(3, 3);
            this.BTSkin.Name = "BTSkin";
            this.BTSkin.Size = new System.Drawing.Size(246, 68);
            this.BTSkin.TabIndex = 0;
            this.BTSkin.Text = "Tous les Skins";
            this.BTSkin.UseVisualStyleBackColor = true;
            this.BTSkin.Click += new System.EventHandler(this.BTSkin_Click);
            // 
            // BESkin
            // 
            this.BESkin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BESkin.Location = new System.Drawing.Point(3, 77);
            this.BESkin.Name = "BESkin";
            this.BESkin.Size = new System.Drawing.Size(246, 68);
            this.BESkin.TabIndex = 1;
            this.BESkin.Text = "Skins evolutifs";
            this.BESkin.UseVisualStyleBackColor = true;
            this.BESkin.Click += new System.EventHandler(this.BESkin_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.LRarete, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ListeRarete, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 151);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(246, 112);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // LRarete
            // 
            this.LRarete.AutoSize = true;
            this.LRarete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LRarete.Location = new System.Drawing.Point(3, 0);
            this.LRarete.Name = "LRarete";
            this.LRarete.Size = new System.Drawing.Size(240, 56);
            this.LRarete.TabIndex = 0;
            this.LRarete.Text = "Sélectionner Rareté ?";
            this.LRarete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListeRarete
            // 
            this.ListeRarete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListeRarete.FormattingEnabled = true;
            this.ListeRarete.Location = new System.Drawing.Point(3, 59);
            this.ListeRarete.Name = "ListeRarete";
            this.ListeRarete.Size = new System.Drawing.Size(240, 21);
            this.ListeRarete.TabIndex = 1;
            this.ListeRarete.SelectedIndexChanged += new System.EventHandler(this.ListeRarete_SelectedIndexChanged);
            // 
            // ListeSkins
            // 
            this.ListeSkins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListeSkins.FormattingEnabled = true;
            this.ListeSkins.Location = new System.Drawing.Point(3, 269);
            this.ListeSkins.Name = "ListeSkins";
            this.ListeSkins.Size = new System.Drawing.Size(246, 68);
            this.ListeSkins.TabIndex = 3;
            this.ListeSkins.SelectedIndexChanged += new System.EventHandler(this.ListeSkins_SelectedIndexChanged);
            // 
            // PhotoSkin
            // 
            this.PhotoSkin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhotoSkin.Location = new System.Drawing.Point(3, 343);
            this.PhotoSkin.Name = "PhotoSkin";
            this.PhotoSkin.Size = new System.Drawing.Size(246, 80);
            this.PhotoSkin.TabIndex = 4;
            this.PhotoSkin.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerToolStripMenuItem,
            this.visualiserToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gérerToolStripMenuItem
            // 
            this.gérerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.supprimerToolStripMenuItem,
            this.modifierToolStripMenuItem});
            this.gérerToolStripMenuItem.Name = "gérerToolStripMenuItem";
            this.gérerToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.gérerToolStripMenuItem.Text = "gérer";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.ajouterToolStripMenuItem.Text = "ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.supprimerToolStripMenuItem.Text = "supprimer";
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.modifierToolStripMenuItem.Text = "modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // visualiserToolStripMenuItem
            // 
            this.visualiserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lesSkinsToolStripMenuItem});
            this.visualiserToolStripMenuItem.Name = "visualiserToolStripMenuItem";
            this.visualiserToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.visualiserToolStripMenuItem.Text = "visualiser";
            // 
            // lesSkinsToolStripMenuItem
            // 
            this.lesSkinsToolStripMenuItem.Name = "lesSkinsToolStripMenuItem";
            this.lesSkinsToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.lesSkinsToolStripMenuItem.Text = "LesSkins";
            this.lesSkinsToolStripMenuItem.Click += new System.EventHandler(this.lesSkinsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoSkin)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox listePhotos;
        private System.Windows.Forms.RichTextBox Edition;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BTSkin;
        private System.Windows.Forms.Button BESkin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LRarete;
        private System.Windows.Forms.ComboBox ListeRarete;
        private System.Windows.Forms.ListBox ListeSkins;
        private System.Windows.Forms.PictureBox PhotoSkin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gérerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualiserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesSkinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
    }
}

