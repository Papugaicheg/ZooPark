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
    public partial class AddAnimalsInspectionsForm : Form
    {
        private int idEmp;
        private string comment;
        public AddAnimalsInspectionsForm(int id)
        {
            InitializeComponent();
            this.idEmp = id;
        }

        private void AddAnimalsInspectionsForm_Load(object sender, EventArgs e)
        {
            using (var db = new ZooparkModel())
            {

                InspectionDatePicker.MaxDate = db.Сотрудник.Where(rec=>rec.ID==idEmp).First().Дата_увольнения ?? DateTime.Today;
                InspectionDatePicker.MinDate = db.Сотрудник.Where(rec => rec.ID == idEmp).First().Дата_приема;

                var emp = db.Сотрудник.Where(em => em.ID == idEmp).First();
                tbEmployee.Text =  emp.ID + " " + emp.Фамилия + ' ' + emp.Имя + ' ' + emp.Отчество;
                if (db.Животное.Any()) { 


                cbAnimal.DataSource = GetAnimals();
                }
                else
                {
                    cbAnimal.Enabled=false;
                    btAddInspection.Enabled=false;
                    MessageBox.Show("В зоопарке нет животных!", "Ошибка", MessageBoxButtons.OK);
                }
            } }
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


      
        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            this.Close();
        }

        private void btAddInspection_Click(object sender, EventArgs e)
        {
            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;
            if (DialogResult == DialogResult.OK)
            {
                AddInspection();
                this.Close();

            }
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






        private void AddInspection()
        {
            try
            {
                using (var db = new ZooparkModel())
                {
                    db.Журнал_осмотров.Add(new Журнал_осмотров
                    {
                        Сотрудник = idEmp,
                        Животное = Convert.ToInt32(cbAnimal.SelectedItem.ToString().Split(new string[] { " - " }, StringSplitOptions.None)[0]),
                        Дата_проверки = InspectionDatePicker.Value,
                        Комментарий = this.comment
                    }) ;



                    db.SaveChanges();
                }

                MessageBox.Show("Данные Добавлены!", "Добавлено", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка в данных!", "Ошибка", MessageBoxButtons.OK);
            }
        }
      


    }
}
