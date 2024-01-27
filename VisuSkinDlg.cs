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
    public partial class VisuSkinDlg : Form
    {
        private LesSkins ls;
        public VisuSkinDlg(LesSkins l)
        {
            InitializeComponent();
            this.ls = l;
            initArbre();

        }
        public void initArbre()
        {
            foreach (categorieRarete cat in Enum.GetValues(typeof(categorieRarete)))
            {
                TreeNode nd = new TreeNode(cat.ToString());
                LesSkins li = ls.GetByRarete(cat);
                foreach(Skin sk in li.Liste)
                {
                    TreeNode na = new TreeNode(sk.Nom);
                    nd.Nodes.Add(na);
                }
                ArbreSkins.Nodes.Add(nd);
            }
        }

        private void ArbreSkins_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode nd = e.Node;
            if (nd.Level > 0)
            {
                Skin sk = this.ls.GetByNom(nd.Text);
                Edition.Text = sk.ToString();
                Photo.Image = sk.Photo.GetThumbnailImage(Photo.Width, Photo.Height, null, IntPtr.Zero);
            }


        }
    }
}
