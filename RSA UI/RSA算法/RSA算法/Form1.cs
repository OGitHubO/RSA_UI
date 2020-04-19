using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace RSA算法
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CrypeBtn_Click(object sender, EventArgs e)
        {
            //创建RSA加密算法服务提供者
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            //显示公钥和私钥
            PubKeyBox.Text = RSA.ToXmlString(false);
            PrvKeyBox.Text = RSA.ToXmlString(true);
            //执行加密
            byte[] EncrypeBytes = RSA.Encrypt(Encoding.UTF8.GetBytes(StrBox.Text), true);
            EncrypeBox.Text = Encoding.UTF8.GetString(EncrypeBytes);
            //执行解密
            byte[] DecrypeBytes = RSA.Decrypt(EncrypeBytes, true);
            Str2Box.Text = Encoding.UTF8.GetString(DecrypeBytes);
        }
    }
}
