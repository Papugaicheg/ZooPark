using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooPark.cmVaccination
{
    public partial class UpdateVaccinationForm : Form
    {
        private Журнал_прививок record;
        private int id;
        private int employee;
        private string fio;
        private int animal;
        private string animalName;
        private DateTime date;
        private DateTime acceptDate;
        private DateTime receiptDate;
        private DateTime? dismissDate;
        private int type;
        public UpdateVaccinationForm(int id)
        {
            InitializeComponent();
            using(var db = new ZooparkModel())
            {
                this.record = db.Журнал_прививок.Where(rec => rec.ID == id).First();
                this.id = record.ID;
                this.employee = record.Сотрудник;
                this.fio = this.id + " - " + record.Сотрудник1.Фамилия + ' ' + record.Сотрудник1.Имя + ' ' + record.Сотрудник1.Отчество;
                this.animal = record.Животное;
                this.animalName = this.animal + " - " + record.Животное1.Название;
                this.receiptDate = this.record.Животное1.Дата_поступления;
                this.date = record.Дата_прививки;
                this.acceptDate = record.Сотрудник1.Дата_приема;
                this.dismissDate = record.Сотрудник1.Дата_увольнения;
                this.type = record.Тип;
            }
        }

        private void UpdateVaccinationForm_Load(object sender, EventArgs e)
        {
            this.Text = "Изменение записи о прививке";
            tbEmployee.Text = this.fio;
            tbAnimal.Text = this.animalName;
            VaccinationDatePicker.MinDate = this.acceptDate;
            VaccinationDatePicker.MaxDate = this.dismissDate ?? DateTime.Today;
            VaccinationDatePicker.Value = this.date;
            if (GetTypes().Count > 0)
            {
                cbType.DataSource = GetTypes();
                cbType.SelectedIndex = this.type-1;
            }
            else
            {
                btUpdateVaccination.Enabled = false;
                MessageBox.Show("Нет возможности добавить запись о прививке, так как отсутстуют типы имеющихся вакцин!","Ошибка", MessageBoxButtons.OK);
            }
            using (var db = new ZooparkModel())
            {
                
                this.receiptDate = db.Животное.Where(an => an.ID == animal).First().Дата_поступления;
                VaccinationDatePicker.MinDate = this.receiptDate > this.acceptDate ? this.receiptDate : this.acceptDate;
            }


        }
        private List<string> GetTypes()
        {
            using (var db = new ZooparkModel())
            {

                var types = from type in db.Тип
                            select new
                            {
                                ID = type.ID,
                                Код = type.Код,
                                Название = type.Название
                            };
                var typesList = new List<string>();
                types.ToList().ForEach(type => { typesList.Add(type.ID+" - "+type.Код + " " + type.Название); });
                return typesList;
            }

        }

       

       

        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            this.Close();
        }

        private void btUpdateVaccination_Click(object sender, EventArgs e)
        {
            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;
            if (DialogResult == DialogResult.OK)
            {
                UpdateVaccination();
                this.Close();
            }
        }

        private void UpdateVaccination()
        {

            try
            {

                using (var db = new ZooparkModel())
                {
                    this.record = db.Журнал_прививок.Where(rec => rec.ID == id).First();
                    this.record.Сотрудник = this.employee;
                    this.record.Животное = this.animal;
                    this.record.Дата_прививки = VaccinationDatePicker.Value;
                    this.record.Тип = Convert.ToInt32(cbType.SelectedItem.ToString().Split(new string[] { " - " }, StringSplitOptions.None)[0]);



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
