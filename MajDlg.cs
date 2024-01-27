using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFBRWF
{
    public partial class MajDlg : Form
    {
        private LesSkins ls;
        public MajDlg(LesSkins l)
        {
            InitializeComponent();
            this.ls = l;
            initGrille();
        }
        public void initGrille()
        {   // création des colonnes
            DataGridViewTextBoxColumn Description = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Nom = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Prix = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn DateParution = new DataGridViewTextBoxColumn();
            DataGridViewComboBoxColumn Rarete = new DataGridViewComboBoxColumn();
            DataGridViewComboBoxColumn Evolutions = new DataGridViewComboBoxColumn();
            DataGridViewCheckBoxColumn Evolutif = new DataGridViewCheckBoxColumn();
            DataGridViewImageColumn Image = new DataGridViewImageColumn();

            //paramétrage des colonnes
            Description.HeaderText = "Description"; // texte de la colonne 
            Description.Name = "Description"; // nom interne
            Description.ReadOnly = true; // non modifiable

            Nom.HeaderText = "Nom";
            Nom.Name = "Nom";
            Nom.ReadOnly = true;

            Prix.HeaderText = "Prix";
            Prix.Name = "Prix";
            Prix.ReadOnly = false; // modifiable

            DateParution.HeaderText = "Date de Parution";
            DateParution.Name = "DateParution";
            DateParution.ReadOnly = true;

            Evolutif.HeaderText = "Evolutif ?";
            Evolutif.Name = "Evolutif";
            Evolutif.ReadOnly = true;

            Image.HeaderText = "Photo";
            Image.Name = "Image";
            Image.ReadOnly = true;

            Evolutions.HeaderText = "Evolutions";
            Evolutions.Name = "Evolutions";

            Rarete.HeaderText = "Rareté";
            Rarete.Name = "Rarete";
            Rarete.DataSource = Enum.GetValues(typeof(categorieRarete));
            Rarete.ReadOnly=false;


            Grille.Columns.AddRange(new DataGridViewColumn[] { Nom, Description, Prix, DateParution, Rarete, Evolutif, Evolutions, Image });
            Grille.Rows.Add(ls.Liste.Count);
            int i = 0;
            foreach (Skin sk in ls.Liste)
            {
                Grille.Rows[i].Cells["Description"].Value = sk.Description;
                Grille.Rows[i].Cells["Nom"].Value = sk.Nom;
                Grille.Rows[i].Cells["Prix"].Value = sk.Prix;
                Grille.Rows[i].Cells["DateParution"].Value = sk.DateParution.ToString("dd/MM/yyyy");
                Grille.Rows[i].Cells["Rarete"].Value = sk.Rarete;
                Grille.Rows[i].Cells["Image"].Value = sk.Photo.GetThumbnailImage(40,30,null,IntPtr.Zero);
                if (sk is SkinEvolutif)
                {
                    Grille.Rows[i].Cells["Evolutif"].Value = true;
                    DataGridViewComboBoxCell cc = new DataGridViewComboBoxCell();
                    cc.DataSource = ((SkinEvolutif)sk).LNoms;
                    Grille.Rows[i].Cells["Evolutions"] = cc;
                }
                else
                {
                    Grille.Rows[i].Cells["Evolutif"].Value = false;
                }
                i++;
            }
        }

        
        private void Valider_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Grille_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int lig = e.RowIndex;
            int col = e.ColumnIndex;
            //récupération du skin à modifier
            Skin sk = ls.Liste[lig];
            switch (col)
            {
                case 2:
                    sk.Prix = Int32.Parse(Grille.Rows[lig].Cells[col].Value.ToString());
                    break;
                case 3:
                    
                    sk.RareteS = Grille.Rows[lig].Cells[col].Value.ToString();
                    break;
            }

        }



    }
}
