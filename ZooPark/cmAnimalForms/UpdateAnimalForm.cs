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
    public partial class UpdateAnimalForm : Form
    {
        private Животное animal;
        private int id;
        private int aviary;
        private string name; //50
        private double weight;
        private int height;
        private string habitat; //50
        private DateTime dateReceipt;

        public UpdateAnimalForm(int id)
        {
            using(var db = new ZooparkModel())
            {
                animal = db.Животное.Where(an =>an.ID == id ).First();
                this.id = animal.ID;
                this.aviary = animal.Вольер;
                this.name = animal.Название;
                this.habitat = animal.Тип_среды_обитания;
                this.dateReceipt = animal.Дата_поступления;
            }
            InitializeComponent();
        }

        
        private void UpdateAnimalForm_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = "Изменение животного - " + animal.Название;
            tbName.Text = this.name;
            tbCurrentAviary.Text = "№ " + this.aviary.ToString();
            cbChangeAviary.Checked = false;
            cbAviary.Enabled = false;
            cbChangeAviary.Enabled = false;
            dtpReceipt.Value = this.dateReceipt;
            using(var db = new ZooparkModel())
            {
                if (db.Вольер.Any(av => av.Тип == this.habitat && av.Статус == "Не занят"))
                {
                    cbChangeAviary.Enabled = true;
                }
                else
                {
                    cbChangeAviary.Text += " (нет свободных вольеров с этим типом среды обитания)";
                }
            }
            nudAge.Value = animal.Возраст;
            tbHeight.Text = animal.Рост.ToString();
            tbWeight.Text = animal.Вес.ToString();
            

            cbAviary.DataSource = GetAviary();
            tbHabitat.Text = this.habitat;

        }
        private List<string> GetAviary()
        {
            using (var db = new ZooparkModel())
            {
                
                var aviaries = from aviary in db.Вольер.Where(av => av.Статус == "Не занят" && av.Тип == animal.Тип_среды_обитания)
                            select new
                                {
                                    Номер = aviary.ID,
                                    Тип = aviary.Тип,
                                    Статус = aviary.Статус

                                };
                var aviaryList = new List<String>();
                aviaries.ToList().ForEach(aviary => {aviaryList.Add("№ "+aviary.Номер.ToString()+" - "+aviary.Статус); });
                return aviaryList;
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

        



        private void UpdateAnimalButton_Click(object sender, EventArgs e)
        {
            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;
            if (DialogResult == DialogResult.OK)
            {
                UpdateAnimal();
                this.Close();
            }
        }

        private void UpdateAnimal()
        {
            try
            {
                using (var db = new ZooparkModel())
                {
                    this.animal = db.Животное.Where(an => an.ID == this.id).First();
                    this.animal.Название = this.name;
                    this.animal.Вольер = cbChangeAviary.Checked ? Convert.ToInt32(cbAviary.SelectedItem.ToString().Split(' ')[1]) :
                                                   Convert.ToInt32(tbCurrentAviary.Text.Split(' ')[1]);

                    this.animal.Возраст = Convert.ToInt32(nudAge.Value);
                    this.animal.Вес = this.weight;
                    this.animal.Рост = this.height;
                    this.animal.Тип_среды_обитания = this.habitat;



                    db.SaveChanges();
                }

                MessageBox.Show("Данные обновлены!", "Обновлено", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка в данных!", "Ошибка", MessageBoxButtons.OK);
            }

        }
        private void CancelUpdateAnimalButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            this.Close();
        }

        private void cbChangeAviary_CheckedStateChanged(object sender, EventArgs e)
        {
            if (cbChangeAviary.Checked)
            {
                cbAviary.Enabled = true;
            }
            else
            {
                cbAviary.Enabled = false;
            }
        }

    

        private void nudAge_ValueChanged(object sender, EventArgs e)
        {
            if (animal.Возраст > nudAge.Value )
            {
                nudAge.Value = animal.Возраст;
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
            
            if (isValid) {
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

      
    }
}
