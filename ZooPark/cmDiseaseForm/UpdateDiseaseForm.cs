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
    public partial class UpdateDiseaseForm : Form
    {
        private Болезнь disease;
        private int dID;
        private int recordID;
        private int animal;
        private string animalName;
        public UpdateDiseaseForm(int id)
        {
            InitializeComponent();
            this.recordID = id;
            using (var db = new ZooparkModel())
            {
                this.disease = db.Болезнь.Where(x => x.ID == id).First();
                this.dID = disease.Заболевание;
                this.animal = disease.Животное;
                this.animalName = disease.Животное.ToString() + " " + disease.Животное1.Название;
            }

        }

        private void UpdateDiseaseForm_Load(object sender, EventArgs e)
        {
            this.Text = "Изменение болезни животного";
            using (var db = new ZooparkModel())
            {

            }
            if (GetDiseas().Count > 0)
            {
                cbDisease.DataSource = GetDiseas();
                cbDisease.SelectedIndex = this.dID-1;
            }
            else
            {
                UpdateDiseaseButton.Enabled = false;
                MessageBox.Show("Нет возможности добавить запись в медицинскую карточку животного, так как отсутстуют типы болезней!", "Ошибка", MessageBoxButtons.OK);
            }
            tbAnimal.Text = this.animalName;

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

        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            this.Close();
        }

        private void UpdateDiseaseButton_Click(object sender, EventArgs e)
        {
            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;
            if (DialogResult == DialogResult.OK)
            {
                UpdateDisease();
                this.Close();
            }
        }

        private void UpdateDisease()
        {
            try
            {

                using (var db = new ZooparkModel())
                {
                    Console.WriteLine(recordID);
                    this.disease = db.Болезнь.Where(rec => rec.ID == recordID).First();
                    this.disease.Животное = this.animal;
                    this.disease.Заболевание = Convert.ToInt32(cbDisease.SelectedItem.ToString().Split(new string[] { " - " }, StringSplitOptions.None)[0]);
                    

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
    }
}
