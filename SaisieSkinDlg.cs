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
    public partial class SaisieSkinDlg : Form
    {
        private Skin sk; // skin à saisir 
        private SkinEvolutif ske;
        private Image ph; //photo du skin
        private Image tempEvol;
        private DateTime dp; //date création skin
        public SaisieSkinDlg()
        {
            InitializeComponent();
            
            this.sk = new Skin();
            ske = new SkinEvolutif();
            this.ph = null;
            this.tempEvol = null;
            this.dp = DateTime.Now;
            Date.Text = this.dp.ToString("dd-MM-yyyy");

            InitListeRarete();
            InitListeRareteE();
        }

        public Skin LeSkin
        {
            get { return this.sk; }                             //Propriété en lecture
        }
        public void InitListeRarete()
        {
            LRarete.Text="Rareté?";
            ListeRarete.DataSource = Enum.GetValues(typeof(categorieRarete));
        }

        private void BAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void BValider_Click(object sender, EventArgs e)
        {
            sk.Photo = ph;
            sk.DateParution = dp;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void BParcourir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            DialogResult res = dlg.ShowDialog();
            if(res==DialogResult.OK)
            {
                string fich = dlg.FileName;
                NomFich.Text = fich;
                this.ph = Image.FromFile(fich);
                PBPhoto.Image = this.ph.GetThumbnailImage(PBPhoto.Width, PBPhoto.Height, null, IntPtr.Zero);
            }
        }

        private void ListeRarete_SelectedIndexChanged(object sender, EventArgs e)
        {
            sk.Rarete = (categorieRarete)ListeRarete.SelectedItem;
        }

        private void Nom_TextChanged(object sender, EventArgs e)
        {
            sk.Nom = Nom.Text;
        }

        private void Description_TextChanged(object sender, EventArgs e)
        {
            sk.Description = Description.Text;
        }

        private void Prix_TextChanged(object sender, EventArgs e)
        {
            sk.Prix = int.Parse(Prix.Text);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Date.Text = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            this.dp= dateTimePicker1.Value;
        }

        //**************************************************************************************************************
        //partie saisie skin évolutif 
        
        public void InitListeRareteE()
        {
            ListeRareteE.DataSource = Enum.GetValues(typeof(categorieRarete));
        }

        private void BParcourirE_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            DialogResult res = dlg.ShowDialog();
            if (res == DialogResult.OK)
            {
                string fich = dlg.FileName;
                TBPhoto.Text = fich;
                this.ph = Image.FromFile(fich);
                PBPhotoE.Image = this.ph.GetThumbnailImage(PBPhoto.Width, PBPhoto.Height, null, IntPtr.Zero);
            }
        }

        private void BAnnulerE_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void BValiderE_Click(object sender, EventArgs e)
        {
            sk = ske;
            sk.Photo = ph;
            sk.DateParution = dp;
            this.DialogResult = DialogResult.OK;
        }

        private void BParcourirEvol_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            DialogResult res = dlg.ShowDialog();
            if (res == DialogResult.OK)
            {
                string fich = dlg.FileName;
                this.tempEvol = Image.FromFile(fich);
                PBPhotoEvol.Image = this.tempEvol.GetThumbnailImage(PBPhoto.Width, PBPhoto.Height, null, IntPtr.Zero);
            }
        }

        private void BAjouter_Click(object sender, EventArgs e)
        {
            ske.AjoutEvolution(NomEvol.Text, tempEvol);
            ListeEvol.Items.Add(NomEvol.Text);
        }

        private void BEvolution_Click(object sender, EventArgs e)
        {
            NomEvol.Text = null;
            tempEvol = null;
            PBPhotoEvol.Image = null;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateCreation.Text = dateTimePicker2.Value.ToString("dd-MM-yyyy");
            this.dp = dateTimePicker2.Value;
        }

        private void NomE_TextChanged(object sender, EventArgs e)
        {
            ske.Nom = NomE.Text;
        }

        private void DescriptionE_TextChanged(object sender, EventArgs e)
        {
            ske.Description = DescriptionE.Text;
        }

        private void PrixE_TextChanged(object sender, EventArgs e)
        {
            ske.Prix= int.Parse(PrixE.Text);
        }

        private void ListeRareteE_SelectedIndexChanged(object sender, EventArgs e)
        {
            ske.Rarete = (categorieRarete)ListeRareteE.SelectedItem;
        }
    }
}
