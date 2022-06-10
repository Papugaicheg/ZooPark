using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooPark.cmAnimalForms
{
    public partial class AddAnimalForm : Form
    {
        private int aviary;
        private string name; //50
        private double weight;
        private int height;
        private string habitat; //50
        private DateTime dateReceipt;
        public AddAnimalForm()
        {
            InitializeComponent();
        }
        private List<string> GetHabitat()
        {
            using(var db = new ZooparkModel())
            {
                var habitats = from habitat in db.Вольер
                               group habitat by habitat.Тип into g
                            select new
                            {
                                Тип_среды_обитания = g.Key
                            };
                var habitatsList = new List<String>();
                habitats.ToList().ForEach(habitat => { habitatsList.Add(habitat.Тип_среды_обитания); });
                return habitatsList;
            }
        }

        private List<string> GetAviary()
        {
            using (var db = new ZooparkModel())
            {
                // 
                var aviaries = from aviary in db.Вольер.Where(av => av.Статус == "Не занят" && av.Тип == cbHabitat.SelectedItem.ToString())
                               select new
                               {
                                   Номер = aviary.ID,
                                   Статус = aviary.Статус

                               };
                var aviaryList = new List<String>();
                aviaries.ToList().ForEach(aviary => { aviaryList.Add("№ " + aviary.Номер.ToString() + " - " + aviary.Статус); });
                return aviaryList;
            }
        }
  

        private void AddAnimalForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = "Добавление животного";
            dtpReceipt.Enabled = false;
            dtpReceipt.Value = DateTime.Today;
            if(GetHabitat().Count != 0)
            {
                cbHabitat.DataSource = GetHabitat();
            }
            else
            {
                AddAnimalButton.Enabled = false;
                MessageBox.Show("Нет существующих вольеров!", "Добавлено", MessageBoxButtons.OK);
                this.Close();
            }

            if (GetAviary().Count != 0)
            {
                cbAviary.DataSource = GetAviary();

            }
            else
            {
                AddAnimalButton.Enabled = false;
                cbAviary.Enabled = false;
            }
        }



        private void AddAnimal()
        {
            try
            {
                using (var db = new ZooparkModel())
                {
                    db.Животное.Add(new Животное
                    {
                        Вольер = this.aviary,
                        Название = this.name,
                        Возраст = Convert.ToInt32(nudAge.Value),
                        Вес = this.weight,
                        Рост = this.height,
                        Тип_среды_обитания = this.habitat,
                        Дата_поступления = dtpReceipt.Value
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

        private void AddAnimalButton_Click(object sender, EventArgs e)
        {
            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;
            if (DialogResult == DialogResult.OK)
            {
                if (cbAviary.Enabled)
                {
                    AddAnimal();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Невозможно добавить новое животное с данной средой обитания, так как нет свободных вольеров такого типа", "Уведомление", MessageBoxButtons.OK);
                    DialogResult = DialogResult.None;
                }

            }
        }

      

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            string name = tbName.Text;
            if (string.IsNullOrEmpty(name) || name.Length > 50)
            {
                errorProvider.SetError(tbName, "Ошибка!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tbName, String.Empty);
                e.Cancel = false;
            }
        }

   

    


        private void tbName_Validated(object sender, EventArgs e)
        {
            this.name = tbName.Text.Trim();
        }

        private void cbHabitat_Validated(object sender, EventArgs e)
        {
            this.habitat = cbHabitat.SelectedItem.ToString();
        }

        private void cbAviary_Validated(object sender, EventArgs e)
        {
            this.aviary = Convert.ToInt32(cbAviary.SelectedItem.ToString().Split(' ')[1]);
        }

        private void CancelAddAnimalButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            this.Close();
        }

        private void cbHabitat_SelectedValueChanged(object sender, EventArgs e)
        {
            using(var db = new ZooparkModel())
            {
                if (db.Вольер.Any(av => av.Тип == cbHabitat.SelectedItem.ToString() && av.Статус == "Не занят"))
                {
                    cbAviary.Enabled = true;
                    AddAnimalButton.Enabled = true;
                    cbAviary.DataSource = GetAviary();

                    
                }
                else
                {
                    MessageBox.Show("Невозможно добавить животное с этим типом среды обитания, так как нет для него свободных вольеров!", "Уведомление", MessageBoxButtons.OK);
                    cbAviary.Enabled = false;
                    AddAnimalButton.Enabled = false;
                }
            }
            
        }
        private void tbWeight_Validating(object sender, CancelEventArgs e)
        {
            bool isValid = Regex.IsMatch(tbWeight.Text, @"\A[0-9]{1,4}(?:[.,][0-9]{1,3})?\z");
            if (isValid)
            {

                errorProvider.SetError(tbWeight, String.Empty);
                e.Cancel = false;
            }
            else
            {
                errorProvider.SetError(tbWeight, "Ошибка!");
                e.Cancel = true;
            }
        }

        private void tbWeight_Validated(object sender, EventArgs e)
        {
            this.weight = Convert.ToDouble(tbWeight.Text);
        }

        private void tbHeight_Validating(object sender, CancelEventArgs e)
        {
            bool isValid = Regex.IsMatch(tbHeight.Text.Trim(), @"(?<=\s|^)\d+(?=\s|$)");

            if (isValid)
            {
                int value = Convert.ToInt32(tbHeight.Text.Trim());
                if (value > 0)
                {

                    errorProvider.SetError(tbHeight, String.Empty);
                    e.Cancel = false;
                }
                else
                {
                    errorProvider.SetError(tbHeight, "Ошибка!");
                    e.Cancel = true;
                }

            }
            else
            {
                errorProvider.SetError(tbHeight, "Ошибка!");
                e.Cancel = true;
            }

        }

        private void tbHeight_Validated(object sender, EventArgs e)
        {
            this.height = Convert.ToInt32(tbHeight.Text.Trim());
        }

        private void dtpReceipt_Validated(object sender, EventArgs e)
        {
            this.dateReceipt = dtpReceipt.Value;
        }


        private void nudAge_ValueChanged(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(nudAge.Value);
        
        }
    }
}
