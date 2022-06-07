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

namespace ZooPark
{
    
    public partial class AuthForm : Form
    {
        

        public AuthForm()
        {
            InitializeComponent();
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            var tmpPassword = ASCIIEncoding.ASCII.GetBytes(tbPassword.Text);

            var hash = new MD5CryptoServiceProvider().ComputeHash(tmpPassword);
            using (var db = new ZooparkModel())
            {
                if (db.Учетные_записи.Any(record => record.Login == tbLogin.Text))
                {
                    var user = db.Учетные_записи.Where(record => record.Login == tbLogin.Text).First();
                    if (ByteArrayToString(hash)==user.Password)
                    {
                        if (db.Сотрудник.Any(emp => emp.ID == user.Сотрудник.ID && user.Сотрудник.Дата_увольнения != null))
                        {
                            Zoopark form = new Zoopark(user.Сотрудник.ID);
                            if (form.ShowDialog() == DialogResult.OK)
                            {

                            }

                        }
                        else
                        {
                            MessageBox.Show("(: !Вы уволены! :)", "Ошибка аутентификации", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль!", "Ошибка аутентификации", MessageBoxButtons.OK);
                    }
                }   
                else
                {
                    MessageBox.Show("Неверно указаны логин или пароль", "Ошибка аутентификации", MessageBoxButtons.OK);
                }

            }
        }
        private static string ByteArrayToString(byte[] arrInput)
        {
            int i;
            StringBuilder sOutput = new StringBuilder(arrInput.Length);
            for (i = 0; i < arrInput.Length - 1; i++)
            {
                sOutput.Append(arrInput[i].ToString("X2"));
            }
            return sOutput.ToString();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {

        }
    }
}
