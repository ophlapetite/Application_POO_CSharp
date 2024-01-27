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
    public partial class Form1 : Form
    {   private ManagerFBR mg;
        private ImageList imgList;
        public Form1()
        {
            InitializeComponent();
            imgList =new ImageList();
            mg = new ManagerFBR();
            mg.InitSkins();
            InitListeRarete();
            InitListeSkins();
            InitListePhotos();
        }

       
    public void InitListeRarete()
        {
            ListeRarete.DataSource = Enum.GetValues(typeof(categorieRarete));
        }

    public void InitListeSkins()
        {
            foreach(Skin sk in mg.Ls.Liste)
            {
                ListeSkins.Items.Add(sk.Nom);
            }
        }

    public void InitListePhotos()
        {
            foreach (Skin sk in mg.Ls.Liste)
            {
                imgList.Images.Add(sk.Photo);
            }
            
          
            imgList.ImageSize=new Size(220,100);

            foreach (Skin sk in mg.Ls.Liste)
            {
                listePhotos.Items.Add(sk.Nom);
            }
            

            listePhotos.ItemHeight=100;
            listePhotos.DrawMode=DrawMode.OwnerDrawFixed;
            
            
            
        }

   

        private void ListePhotos_DrawItem_1(object sender, DrawItemEventArgs e)
        {
            Point p = e.Bounds.Location;
            imgList.Draw(e.Graphics, p, e.Index);
        }

        private void BTSkin_Click(object sender, EventArgs e)
        {
            Edition.Text = mg.Ls.ToString();
        }

        private void BESkin_Click(object sender, EventArgs e)
        {
            Edition.Text = mg.RechSkinEvolutif().ToString();
        }

        private void ListeRarete_SelectedIndexChanged(object sender, EventArgs e)
        {
            categorieRarete cat = (categorieRarete)ListeRarete.SelectedItem;
            Edition.Text = mg.GetSkinsRarete(cat).ToString();
        }

        private void ListeSkins_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n = ListeSkins.SelectedItem.ToString();
            Skin sk = mg.Ls.GetByNom(n);
            if(sk!=null)
            {
                Edition.Text=sk.ToString();
                PhotoSkin.Image = sk.Photo.GetThumbnailImage(PhotoSkin.Width, PhotoSkin.Height, null, IntPtr.Zero);
            }
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaisieSkinDlg ssd = new SaisieSkinDlg();
            DialogResult res = ssd.ShowDialog();
            if (res == DialogResult.OK)
            {
                mg.Ls.Ajoute(ssd.LeSkin);
                InitListeSkins();
                InitListePhotos();
            }
        }

        private void lesSkinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisuSkinDlg vsd = new VisuSkinDlg(mg.Ls);
            DialogResult res = vsd.ShowDialog();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MajDlg md = new MajDlg(mg.Ls);
            DialogResult res = md.ShowDialog();
        }
    }
}
