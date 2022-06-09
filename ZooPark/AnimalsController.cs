using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooPark.cmAnimalForms;

namespace ZooPark
{
    partial class Zoopark
    {
        private IEnumerable GetAnimals()
        {
            using (var db = new ZooparkModel())
            {
               
                var animals = from animal in db.Животное
                                select new
                                {
                                    animal.ID,
                                    animal.Название,
                                    animal.Тип_среды_обитания
                                };
                return animals.ToList();
            }
        }

        private void SetAnimalsGrid()
        {
            dgAnimals.DataSource = GetAnimals();
            dgAnimals.Columns[0].HeaderText = "ID";
            dgAnimals.Columns[0].Width = 50;
            dgAnimals.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgAnimals.Columns[1].HeaderText = "Название";
            dgAnimals.Columns[1].Width = 312;
            dgAnimals.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgAnimals.Columns[2].HeaderText = "Тип среды обитания";
            dgAnimals.Columns[2].Width = 312;
        }


        private void cmUpdateAnimal_Click(object sender, EventArgs e)
        {
            if (dgEmployee.SelectedCells.Count > 0)
            {

                var i = dgAnimals.SelectedCells[0].OwningRow.Index;
                int id = (int)dgAnimals[0, i].Value;
                UpdateAnimalForm form = new UpdateAnimalForm(id);
            if (form.ShowDialog() == DialogResult.OK)
            {
                SetAnimalsGrid();
            }
            }
        }

        private void cmAddAnimal_Click(object sender, EventArgs e)
        {
            using(var db = new ZooparkModel())
            {
                if (db.Вольер.Any(av => av.Статус == "Не занят"))
                {
                    AddAnimalForm form = new AddAnimalForm();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        SetAnimalsGrid();
                    }
                }
                else
                {
                    MessageBox.Show("Невозможно добавить новое животное, так как нет свободных вольеров", "Уведомление", MessageBoxButtons.OK);
                }
            }
           
            
        }

        private void cmRefreshAnimal_Click(object sender, EventArgs e)
        {
                SetAnimalsGrid();
        }

        private void cmDeleteAnimal_Click(object sender, EventArgs e)
        {
            if (dgEmployee.SelectedCells.Count > 0)
            {
                string nameA = "";
                var i = dgAnimals.SelectedCells[0].OwningRow.Index;
                int animalID = (int)dgAnimals[0, i].Value;
                using (var db = new ZooparkModel())
                {
                    Животное animal = db.Животное.Where(an => an.ID == animalID).First();
                    nameA = animal.Название;
                }





                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить это животное?\n" + nameA,
                "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {


                    using (var db = new ZooparkModel())
                    {
                        Животное animal = db.Животное.Where(item => item.ID == animalID).First();
                        if (db.Журнал_прививок.Any(item => item.Животное == animalID)) {
                           var list = db.Журнал_прививок.Where(item => item.Животное == animalID);
                            db.Журнал_прививок.RemoveRange(list);
                        }
                        if (db.Журнал_болезней.Any(item => item.Животное == animalID)) {
                            var list = db.Журнал_болезней.Where(item => item.Животное == animalID);
                            db.Журнал_болезней.RemoveRange(list);
                        }
                        if (db.Журнал_осмотров.Any(item => item.Животное == animalID)) {
                            var list = db.Журнал_осмотров.Where(item => item.Животное == animalID);
                            db.Журнал_осмотров.RemoveRange(list);
                        }
                        db.Животное.Remove(animal);
                        var aviaryObject = db.Вольер.Where(avID => avID.ID == animal.Вольер).First();
                        aviaryObject.Статус = "Не занят";
                        db.SaveChanges();
                        


                    }
                }
            }
            SetAnimalsGrid();
        }
    

        private void cmInfoAnimal_Click(object sender, EventArgs e)
        {
            if (dgAnimals.SelectedCells.Count > 0)
            {
                var i = dgAnimals.SelectedCells[0].OwningRow.Index;
                int animalID = (int)dgAnimals[0, i].Value;
                using (var db = new ZooparkModel())
                {
                    Животное animal = db.Животное.Where(an => an.ID == animalID).First();
                    int age = animal.Возраст;
                    string suffix = (11 <= age && age <= 19)? age.ToString() + " лет" : age % 10 == 1 ? age.ToString()+" год" : 2 <= age % 10 && age % 10 <= 4 ? age.ToString() + " года" : age.ToString() + " лет";


                    string info = "Название: " + animal.Название +
                                  "\nВольер: № " + animal.Вольер +
                                  "\nВозраст: " + suffix +
                                  "\nВес: " + animal.Вес + " кг" +
                                  "\nРост: " + animal.Рост + " см" +
                                  "\nТип среды обитания: " + animal.Тип_среды_обитания+
                                  "\nДата поступления: " + animal.Дата_поступления.ToShortDateString(); 
                    MessageBox.Show(info, "Дополнительная информация", MessageBoxButtons.OK);

                }

            }
        }
    }
}
