using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SİFRELEME
{
   public class Proje
    {
        //MD5
        public static string MD5(string TXTALINANVERI)
        {
            StringBuilder sb = new StringBuilder();
            if (String.IsNullOrEmpty(TXTALINANVERI))
            {
                MessageBox.Show("TEXTBOX İÇİNE ŞİFRELENECEK VERİ YAZINIZ");
            }
            else
            {
                MD5CryptoServiceProvider MD5SIFRELE = new MD5CryptoServiceProvider();
                byte[] Bt = Encoding.UTF8.GetBytes(TXTALINANVERI);
                Bt = MD5SIFRELE.ComputeHash(Bt);

                foreach (byte b in Bt)
                {
                    sb.Append(b.ToString("x2").ToLower());
                }

            }
            return sb.ToString();


        }
    }
}
