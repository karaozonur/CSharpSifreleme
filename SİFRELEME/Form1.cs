using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SİFRELEME
{
    public partial class Form1 : Form
    {

        // HASH 
        //MD5
        //SHA1
        //SHA256
        //SHA384
        //SHA512
        //SİMETRİK
        //   DES
        //   TRİBLE DES
        //   RC2
        //   RİJNDAEL
        //ASİMETRİK
        //   DSA
        //   RSA

        StringBuilder sb = new StringBuilder();
        MD5CryptoServiceProvider md5sifrele = new MD5CryptoServiceProvider();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if(comboBox1.SelectedIndex==0)
            //{ label1.Text = Proje2.md5(textBox1.Text); }
            //else if(comboBox1.SelectedIndex==1)
            //{
            //    label2.Text = Proje2.SHA1(textBox1.Text);
            //}
            //else if(comboBox1.SelectedIndex==2)
            //{
            //    label3.Text = Proje2.SHA252(textBox1.Text);
            //}
            //else if(comboBox1.SelectedIndex==3)
            //{
            //    label6.Text = Proje2.SHA384(textBox1.Text);
            //}
            //else if (comboBox1.SelectedIndex == 4)
            //{
            //    label7.Text = Proje2.sha512(textBox1.Text);
            //}
            //else
            //{
            //    MessageBox.Show("ŞİFRELEME YÖNTEMİ SEÇİNİZ");
            //}
            int x = comboBox1.SelectedIndex;
            switch (x)
            {
                case 1:
                label1.Text = Proje2.md5(textBox1.Text);
                break;
                case 2:
                    label2.Text = Proje2.SHA1(textBox1.Text);
                    break;
                case 3:
                    label3.Text = Proje2.SHA252(textBox1.Text);
                    break;
                case 4:
                    label7.Text = Proje2.SHA384(textBox1.Text);
                    break;
                case 5:
                    label7.Text = Proje2.sha512(textBox1.Text);
                    break;
                default:
                    MessageBox.Show("ŞİFRELEME YÖNTEMİ SEÇİNİZ");
                    break;
            }




            //label1.Text = "";
            //sb.Clear();
            //if (String.IsNullOrEmpty(textBox1.Text))
            //if (String.IsNullOrEmpty(textBox1.Text))
            //if (String.IsNullOrEmpty(textBox1.Text))
            //if (String.IsNullOrEmpty(textBox1.Text))
            //{
            //    MessageBox.Show("şifrelenecek bir şey ver");
            //}
            //else
            //{
            //    byte[] bt = Encoding.UTF8.GetBytes(textBox1.Text);
            //    bt = md5sifrele.ComputeHash(bt);
            //    foreach (byte b in bt)
            //    {
            //        sb.Append(b.ToString("x2").ToLower());
            //    }

            //    label1.Text = sb.ToString();
            //}

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
