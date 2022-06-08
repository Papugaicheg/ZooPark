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
    public partial class AddPassForm : Form
    {
        private string pass;
        private int id;
        public AddPassForm(Учетные_записи user)
        {
            InitializeComponent();
            this.id = user.ID;
        }

        private void AddPassForm_Load(object sender, EventArgs e)
        {
            this.Text = "Добавление пароля";

        }

       

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                tbPass1.UseSystemPasswordChar = false;
            }
            else
            {
                tbPass1.UseSystemPasswordChar = true;
            }
        }

        private void tbPass2_Validating(object sender, CancelEventArgs e)
        {
            if(tbPass2.Text != tbPass1.Text)
            {
                tbPass2.BorderStyle = BorderStyle.None;
                Pen p = new Pen(Color.Red);
                Graphics g = this.CreateGraphics();
                int variance = 3;
                g.DrawRectangle(p, new Rectangle(tbPass2.Location.X - variance, tbPass2.Location.Y - variance, tbPass2.Width + variance, tbPass2.Height + variance));
                errorProvider.SetError(tbPass2, "Пароли не совпадают!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tbPass2, String.Empty);
                tbPass2.BorderStyle = BorderStyle.FixedSingle;
                e.Cancel = false;
            }


        }

        private void tbPass2_Validated(object sender, EventArgs e)
        {
            this.pass = tbPass2.Text;
        }

        private void btAddPass_Click(object sender, EventArgs e)
        {
            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    using (var db = new ZooparkModel())
                    {
                        var tmpPassword = ASCIIEncoding.ASCII.GetBytes(this.pass);

                        var hash = new MD5CryptoServiceProvider().ComputeHash(tmpPassword);

                        var record = db.Учетные_записи.Where(rec => rec.ID == this.id).First();
                        record.Password = ByteArrayToString(hash);

                        db.SaveChanges();
                    }

                    MessageBox.Show("Данные обновлены!", "Обновлено", MessageBoxButtons.OK);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка добавления пароля", "Обновлено", MessageBoxButtons.OK);
                    DialogResult = DialogResult.None;
                    this.Close();
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


        private void tbPass1_Validating(object sender, CancelEventArgs e)
        {
            string input = tbPass1.Text;
            if (input.Length <= 50 && input.Length >= 1)
            {
                errorProvider.SetError(tbPass1, String.Empty);
                e.Cancel = false;
            }
            else
            {
                errorProvider.SetError(tbPass1, "Не соответствие длины пароля!");
                e.Cancel = true;
            }
        }
    }
}
