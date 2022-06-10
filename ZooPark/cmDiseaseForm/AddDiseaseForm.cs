using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooPark.cmDiseaseForm
{
    public partial class AddDiseaseForm : Form
    {
        public AddDiseaseForm()
        {
            InitializeComponent();
        }



        private List<string> GetDiseas()
        {
            using (var db = new ZooparkModel())
            {
                var diseases = from disease in db.Заболевание
                               select new
                               {
                                   ID = disease.ID,
                                   Название = disease.Название
                               };
                var diseasesList = new List<String>();
                diseases.ToList().ForEach(disease => { diseasesList.Add(disease.ID + " - " + disease.Название); });
                return diseasesList;
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

        private void AddDisease()
        {
            try
            {
                using (var db = new ZooparkModel())
                {
                    int animal = Convert.ToInt32(cbAnimal.SelectedItem.ToString().Split(new string[] { " - " }, StringSplitOptions.None)[0]);
                    int disease = Convert.ToInt32(cbDisease.SelectedItem.ToString().Split(new string[] { " - " }, StringSplitOptions.None)[0]);
                    if (!db.Журнал_болезней.Any(d => d.Заболевание == disease && d.Животное == animal))
                    {
                        db.Журнал_болезней.Add(new Журнал_болезней
                        {

                            Животное = animal,
                            Заболевание = disease
                        });



                        db.SaveChanges();
                    

                    MessageBox.Show("Данные Добавлены!", "Добавлено", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Это заболевание у этого животного уже указано!", "Ошибка", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка в данных!", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void AddDiseaseButton_Click(object sender, EventArgs e)
        {
            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;
            if (DialogResult == DialogResult.OK)
            {
                AddDisease();
                this.Close();

            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            this.Close();
        }

        private void AddDiseaseForm_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = "Добавление заболевания";
            if (GetDiseas().Count > 0)
            {
                cbDisease.DataSource = GetDiseas();
                cbDisease.SelectedIndex = 0;
            }
            else
            {
                AddDiseaseButton.Enabled = false;
                MessageBox.Show("Нет возможности добавить запись о прививке, так как отсутстуют типы имеющихся вакцин!", "Ошибка", MessageBoxButtons.OK);
            }

            if (GetAnimals().Count > 0)
            {
                cbAnimal.DataSource = GetAnimals();
                cbAnimal.SelectedIndex = 0;
            }
            else
            {
                AddDiseaseButton.Enabled = false;
                MessageBox.Show("Нет возможности добавить запись о прививке, так как отсутстуют животные!", "Ошибка", MessageBoxButtons.OK);
            }
        }
    }
}
