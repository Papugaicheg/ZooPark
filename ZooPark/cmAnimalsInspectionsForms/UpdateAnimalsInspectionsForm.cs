using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooPark.cmAnimalsInspectionsForms
{
    public partial class UpdateAnimalsInspectionsForm : Form
    {
        private Журнал_осмотров record;
        private int id;
        private int employee;
        private string fio;
        private int animal;
        private string animalName;
        private DateTime animalDate;
        private DateTime employeeAcceptDate;
        private DateTime? employeeDismissDate;
        private DateTime date;//1955 01 01
        private string comment; //250
        public UpdateAnimalsInspectionsForm(int id)
        {
           
            using (var db = new ZooparkModel())
            {
                record = db.Журнал_осмотров.Where(rec => rec.ID == id).First();
                this.id = record.ID;
                this.employee = record.Сотрудник;
                this.fio = record.Сотрудник1.Фамилия + ' ' + record.Сотрудник1.Имя + ' ' + record.Сотрудник1.Отчество;
                this.animal = record.Животное;
                this.animalName = this.animal.ToString() + " - " + record.Животное1.Название;
                this.animalDate = record.Животное1.Дата_поступления;
                this.employeeAcceptDate = record.Сотрудник1.Дата_приема;
                this.employeeDismissDate = record.Сотрудник1.Дата_увольнения;
                this.date = record.Дата_проверки;
                this.comment = record.Комментарий;
            }
                InitializeComponent();
        }

        private void UpdateAnimalsInspectionsForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = "Изменение записи об осмотре";

            tbEmployee.Text = this.fio;

            tbAnimal.Text = this.animalName;
        
            InspectionDatePicker.MaxDate = this.employeeDismissDate ?? DateTime.Today;
            InspectionDatePicker.MinDate = this.employeeAcceptDate>this.animalDate?this.employeeAcceptDate : this.animalDate;
            InspectionDatePicker.Value = this.date;

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


        private void InspectionDatePicker_Validated(object sender, EventArgs e)
        {
            this.date = InspectionDatePicker.Value.Date;
        }





        private void btUpdateInspection_Click(object sender, EventArgs e)
        {
            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;
            if (DialogResult == DialogResult.OK)
            {
                UpdateInspection();
                this.Close();
            }
        }

        private void UpdateInspection()
        {
            
            try
            {
                    
                using (var db = new ZooparkModel())
                {
                    this.record = db.Журнал_осмотров.Where(rec => rec.ID == this.id).First();
                    this.record.Сотрудник = this.employee;
                    this.record.Животное = this.animal;
                    this.record.Дата_проверки = this.date;
                    this.record.Комментарий = this.comment;



                    db.SaveChanges();
                }

                MessageBox.Show("Данные обновлены!", "Обновлено", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка в данных!", "Ошибка", MessageBoxButtons.OK);
                    DialogResult = DialogResult.None;
                }
           
           
        }

    
    }
}
