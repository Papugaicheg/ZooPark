using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooPark.cmAviaryCheck
{
    public partial class UpdateAviaryCheckForm : Form
    {
        private Проверка_вольеров check;
        private int emp;
        private int aviary;
        private DateTime date;
        private string comment;


        public UpdateAviaryCheckForm(int id, int loggedID)
        {
            InitializeComponent();
            using (var db = new ZooparkModel())
            {
               
                this.check = db.Проверка_вольеров.Where(c => c.ID == id).First();

            }
        }

        private void UpdateAviaryCheckForm_Load(object sender, EventArgs e)
        {
            this.Text = "Внесение записи о проверки вольера";
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            this.Close();
        }

        private void tbComment_Validating(object sender, CancelEventArgs e)
        {
            string input = tbComment.Text;
            if (string.IsNullOrEmpty(input) || input.Length > 250)
            {
                errorProvider.SetError(tbComment, "Ошибка");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tbComment, String.Empty);
                e.Cancel = false;
            }
        }



        private void tbComment_Validated(object sender, EventArgs e)
        {
            this.comment = tbComment.Text;
        }

        private void tbComment_TextChanged(object sender, EventArgs e)
        {
            countLb.Text = tbComment.Text.Length.ToString() + "/250";
        }

    }
}
