using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SİFRELEME
{
    public  class Proje2
    {
        public static string md5(string TXT_ALINACAK)
        {
            StringBuilder sb = new StringBuilder();
            if (String.IsNullOrEmpty(TXT_ALINACAK))
            {
                MessageBox.Show("şifrelenecek bir şey ver");
            }
            else
            {
                MD5CryptoServiceProvider md5sifrele = new MD5CryptoServiceProvider();
                byte[] bt = Encoding.UTF8.GetBytes(TXT_ALINACAK);
                bt = md5sifrele.ComputeHash(bt);
                foreach (byte b in bt)
                {
                    sb.Append(b.ToString("x2").ToLower());
                }

            }
            return sb.ToString();
        }
        public static string SHA1(string TXT_ALINACAK)
        {
            StringBuilder sb = new StringBuilder();
            if (String.IsNullOrEmpty(TXT_ALINACAK))
            {
                MessageBox.Show("şifrelenecek bir şey ver");
            }
            else
            {
                SHA1CryptoServiceProvider Sha1Sifrele = new SHA1CryptoServiceProvider();
                byte[] bt = Encoding.UTF8.GetBytes(TXT_ALINACAK);
                bt = Sha1Sifrele.ComputeHash(bt);
                foreach (byte x in bt)
                {
                    sb.Append(x.ToString());
                }

            }
            return sb.ToString();
        }
        public static string SHA252(string TXT_ALINACAK)
        {
            StringBuilder sb = new StringBuilder();
            if (String.IsNullOrEmpty(TXT_ALINACAK))
            {
                MessageBox.Show("şifrelenecek bir şey ver");
            }
            else
            {
                SHA256CryptoServiceProvider Sha252Sifrele = new SHA256CryptoServiceProvider();
                byte[] bt = Encoding.UTF8.GetBytes(TXT_ALINACAK);
                bt = Sha252Sifrele.ComputeHash(bt);
                foreach (byte x in bt)
                {
                    sb.Append(x.ToString());
                }

            }
            return sb.ToString();
        }

        public static string SHA384(string TXT_ALINACAK)
        {
            StringBuilder sb = new StringBuilder();
            if (String.IsNullOrEmpty(TXT_ALINACAK))
            {
                MessageBox.Show("şifrelenecek bir şey ver");
            }
            else
            {
                SHA384CryptoServiceProvider Sha384ifrele = new SHA384CryptoServiceProvider();
                byte[] bt = Encoding.UTF8.GetBytes(TXT_ALINACAK);
                bt = Sha384ifrele.ComputeHash(bt);
                foreach (byte x in bt)
                {
                    sb.Append(x.ToString());
                }

            }
            return sb.ToString();
        }
        public static string sha512(string TXT_ALINACAK)
        {
            StringBuilder sb = new StringBuilder();
            if (String.IsNullOrEmpty(TXT_ALINACAK))
            {
                MessageBox.Show("şifrelenecek bir şey ver");
            }
            else
            {
                SHA512CryptoServiceProvider Sha512ifrele = new SHA512CryptoServiceProvider();
                byte[] bt = Encoding.UTF8.GetBytes(TXT_ALINACAK);
                bt = Sha512ifrele.ComputeHash(bt);
                foreach (byte x in bt)
                {
                    sb.Append(x.ToString());
                }

            }
            return sb.ToString();
        }
    }
}
