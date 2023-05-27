using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arama_ağacı
{
    public partial class Form1 : Form
    {
        public class agacdugum
        {
            public int data;
            public agacdugum left;
            public agacdugum right;
        }
        public agacdugum Insert(agacdugum kök, int data)
        {
            if (kök == null)
            {
                kök = new agacdugum();
                kök.data = data;
                kök.left = kök.right = null;
            }
            else if (data <= kök.data)
                kök.left = Insert(kök.left, data);
            else
                kök.right = Insert(kök.right, data);
            return kök;
        }

        agacdugum FindMin(agacdugum kök)
        {
            while (kök.left != null) kök = kök.left;
            return kök;
        }


        public agacdugum Dlt(agacdugum kök, int data) {
            if (kök == null) return kök;
            else if (data < kök.data) kök.left = Dlt(kök.left, data);
            else if (data > kök.data) kök.right = Dlt(kök.right, data);
            else
            {
                if(kök.left == null && kök.right == null)
                {
                    kök = null;
                }
                else if(kök.left == null)
                {
                    agacdugum temp = kök;
                    kök = kök.right;
                }
                else if (kök.right == null)
                {
                    agacdugum temp = kök;
                    kök = kök.left;
                }
                else
                {
                    agacdugum temp = FindMin(kök.right);
                    kök.data = temp.data;
                    kök.right = Dlt(kök.right, temp.data);
                }
            }
            return kök;
        }
        int agacyukseklik(agacdugum root)
        {
            int left, right;
            if (root == null) return 0;
            else
            {
                left = agacyukseklik(root.left);
                right = agacyukseklik(root.right);
            }
            if (left > right) return left + 1;
            else return right + 1;
        }

        int agacdugumseviye(agacdugum kök, int degerBul)
        {
            int left =0, right=0;
            if (kök == null) return 0;
            else if (kök.data == degerBul) return 1;
            else
            {
                if (kök.left!=null && degerBul != kök.data)
                {
                    left = agacdugumseviye(kök.left, degerBul);
                }
                if (kök.right != null && degerBul != kök.data)
                {
                    right = agacdugumseviye(kök.right, degerBul);
                }
            }
            if (right == 0 && left == 0) return 0;
            else
            {
                if (left > right) return left + 1;
                else return right + 1;
            }
        }

        void Inorder(agacdugum root)
        {
            if (root == null) return;

            Inorder(root.left);       
            tb_Inorder.Text += root.data+" - ";  
            Inorder(root.right);      
        }

        void Preorder(agacdugum root)
        {
            if (root == null) return;

            tb_Preorder.Text += root.data + " - ";
            Preorder(root.left);       
            Preorder(root.right);      
        }

        void Postorder(agacdugum root)
        {
            if (root == null) return;

            Postorder(root.left);       
            Postorder(root.right);      
            tb_Postorder.Text += root.data + " - ";
        }

        void yaprakdugum(agacdugum kök,TextBox textBox)
        {
            if (kök == null) return;
            else
            {
                if (kök.left == null && kök.right == null)
                {
                    textBox.Text += kök.data + " - ";
                }

                if (kök.left != null)
                {
                    yaprakdugum(kök.left,textBox);
                }
                if (kök.right != null)
                {
                    yaprakdugum(kök.right,textBox);
                }
            }
        }

        void dugumgöster(bool lockR, agacdugum kök, RichTextBox rtb, String poz="")
        {
            if(kök != null)
            {
                if (lockR) rtb.Text = kök.data + " kök ";
                String pozSol = poz, pozSağ = poz;
                rtb.Text += "\r\n";
                if(kök.left != null)
                {
                    pozSol += " sol ";
                    rtb.Text += kök.left.data + pozSol;
                    dugumgöster(false,kök.left, rtb, pozSol);
                }
                if (kök.right != null)
                {
                    pozSağ += " sağ ";
                    rtb.Text += kök.right.data + pozSağ;
                    dugumgöster(false,kök.right, rtb, pozSağ);
                }
            }
        }

        void dugumsay(agacdugum root)
        {
            if (root == null) return;

            dugumsay(root.left);       
            if (tb_DugumSayisi.Text == "") tb_DugumSayisi.Text = "1";  
            else tb_DugumSayisi.Text = (Convert.ToInt32(tb_DugumSayisi.Text) + 1).ToString();
            dugumsay(root.right);     
        }

        agacdugum kök;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_DugumEkle_Click(object sender, EventArgs e)
        {
            kök = Insert(kök, Convert.ToInt32(tb_dugumEkle.Text));
        }

        private void btn_dugumGoster_Click(object sender, EventArgs e)
        {
            rtb_dugumGoster.Text = "";
            dugumgöster(true,kök, rtb_dugumGoster);
        }

        private void btn_DugumSil_Click(object sender, EventArgs e)
        {
            kök = Dlt(kök, Convert.ToInt32(tb_dugumSil.Text));
        }

        private void btn_agacBilgiGoster_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";
            }
            foreach (Control item in groupBox.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";
            }
            tb_AgacYuksekligi.Text = agacyukseklik(kök).ToString();
            Inorder(kök);
            Preorder(kök);
            Postorder(kök);
            yaprakdugum(kök,tb_Yapraklar);
            dugumsay(kök);
        }

        private void btn_DugumBul_Click(object sender, EventArgs e)
        {
            int deg = agacdugumseviye(kök, Convert.ToInt32(tb_dugumBul.Text));
            if (deg == 0) lb_dugumBul.Text = "Aradığın düğüm bulunamadı";
            else lb_dugumBul.Text = "Düğüm seviyesi " + deg;
        }
    }
}
