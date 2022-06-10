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
        private int recordID;
        private int emp;
        private string fio;
        private int aviary;
        private string info;
        private DateTime dateAccept;
        private DateTime? dateDismiss;
        private string comment;


        public UpdateAviaryCheckForm(int id, int loggedID)
        {
            InitializeComponent();
            using (var db = new ZooparkModel())
            {
               
                this.check = db.Проверка_вольеров.Where(c => c.ID == id).First();
                this.recordID = this.check.ID;
                this.emp = this.check.Сотрудник;
                this.fio = this.emp+ " - "+this.check.Сотрудник1.Фамилия + " " + this.check.Сотрудник1.Имя + " " + this.check.Сотрудник1.Отчество;
                this.comment = this.check.Комментарий;
                this.dateAccept = this.check.Сотрудник1.Дата_приема;
                this.dateDismiss = this.check.Сотрудник1.Дата_увольнения;
                this.aviary = this.check.Вольер;
                this.info = this.check.Вольер + " - " + this.check.Вольер1.Тип;

    }
        }

        private void UpdateAviaryCheckForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = "Изменение записи о проверке вольера";
            tbEmployee.Text = this.fio;
            tbAviary.Text = this.info;
            dtpAviaryCheck.MaxDate = this.dateDismiss ?? DateTime.Today;
            dtpAviaryCheck.MinDate = this.dateAccept;
            tbComment.Text = this.comment;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            this.Close();
        }

        private void tbComment_Validating(object sender, CancelEventArgs e)
        {
            string input = tbComment.Text;
            if (input.Length > 250)
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
            this.comment = String.IsNullOrEmpty(tbComment.Text.Trim()) ?"": tbComment.Text.Trim();
        }

        private void tbComment_TextChanged(object sender, EventArgs e)
        {
            countLb.Text = tbComment.Text.Length.ToString() + "/250";
        }

        private void UpdateAviaryCheck()
        {
            try
            {

                using (var db = new ZooparkModel())
                {
                    this.check = db.Проверка_вольеров.Where(rec => rec.ID == this.recordID).First();
                    this.check.Сотрудник = this.emp;
                    this.check.Вольер = this.aviary;
                    this.check.Дата_проверки = dtpAviaryCheck.Value;
                    this.check.Комментарий = this.comment;


                    db.SaveChanges();
                }

                MessageBox.Show("Данные обновлены!", "Обновлено", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка в данных!" + ex.Message, "Ошибка", MessageBoxButtons.OK);
                DialogResult = DialogResult.None;
            }

        }
        private void btUpdateAviaryCheck_Click(object sender, EventArgs e)
        {
            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;
            if (DialogResult == DialogResult.OK)
            {
                UpdateAviaryCheck();
                this.Close();
            }
        }
    }
}
