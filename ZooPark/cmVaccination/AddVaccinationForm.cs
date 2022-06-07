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
    public partial class AddVaccinationForm : Form
    {
        private int id;
        private string fio;
        private DateTime acceptDate;
        private DateTime? dismissDate;
        public AddVaccinationForm(int empID)
        {
            InitializeComponent();

            this.Text = "Добавление записи о прививке";


            using (var db = new ZooparkModel())
            {
                var employee = db.Сотрудник.Where(rec => rec.ID == empID).First();
                this.id = employee.ID;
                this.fio = this.id + " - " + employee.Фамилия + ' ' + employee.Имя + ' ' + employee.Отчество;
               
                this.acceptDate = employee.Дата_приема;
                this.dismissDate = employee.Дата_увольнения;
            }
            tbEmployee.Text = fio;

            VaccinationDatePicker.MinDate = this.acceptDate;
            VaccinationDatePicker.MaxDate = this.dismissDate ?? DateTime.Today;


            if (GetTypes().Count > 0)
            {
                cbType.DataSource = GetTypes();
                cbType.SelectedIndex = 0;
            }
            else
            {
                btAddVaccination.Enabled = false;
                MessageBox.Show("Нет возможности добавить запись о прививке, так как отсутстуют типы имеющихся вакцин!", "Ошибка", MessageBoxButtons.OK);
            }

            if (GetAnimals().Count > 0)
            {
                cbAnimal.DataSource = GetAnimals();
                cbAnimal.SelectedIndex = 0;
            }
            else
            {
                btAddVaccination.Enabled = false;
                MessageBox.Show("Нет возможности добавить запись о прививке, так как отсутстуют животные!", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private List<string> GetAnimals()
        {
            using (var db = new ZooparkModel())
            {

                var animals = from animal in db.Животное
                              select new
                              {
                                  ID = animal.ID,
                                  Название = animal.Название
                              };
                var animalsList = new List<String>();
                animals.ToList().ForEach(animal => { animalsList.Add(animal.ID + " - " + animal.Название); });
                return animalsList;
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
                types.ToList().ForEach(type => { typesList.Add(type.ID + " - " + type.Код + " " + type.Название); });
                return typesList;
            }

        }

        private void btAddVaccination_Click(object sender, EventArgs e)
        {
            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;
            if (DialogResult == DialogResult.OK)
            {
                AddVaccination();
                this.Close();

            }

        }
        private void AddVaccination()
        {
            try
            {
                using (var db = new ZooparkModel())
                {
                    db.Журнал_прививок.Add(new Журнал_прививок
                    {
                        Сотрудник = this.id,
                        Животное = Convert.ToInt32(cbAnimal.SelectedItem.ToString().Split(new string[] { " - " }, StringSplitOptions.None)[0]),
                        Дата_прививки = VaccinationDatePicker.Value,
                        Тип = Convert.ToInt32(cbType.SelectedItem.ToString().Split(new string[] { " - " }, StringSplitOptions.None)[0])
                    });



                    db.SaveChanges();
                }

                MessageBox.Show("Данные Добавлены!", "Добавлено", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка в данных!", "Ошибка", MessageBoxButtons.OK);
            }
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            this.Close();
        }
    }
}
