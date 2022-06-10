﻿using System;
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
        private DateTime receiptDate;
        private DateTime acceptDate;
        public AddAnimalsInspectionsForm(int id)
        {
            InitializeComponent();
            this.idEmp = id;
        }

        private void AddAnimalsInspectionsForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            using (var db = new ZooparkModel())
            {
                
                InspectionDatePicker.MaxDate = db.Сотрудник.Where(rec=>rec.ID==idEmp).First().Дата_увольнения ?? DateTime.Today;
                this.acceptDate = db.Сотрудник.Where(rec => rec.ID == idEmp).First().Дата_приема;
                InspectionDatePicker.MinDate = this.acceptDate;
                
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
                    int an = Convert.ToInt32(cbAnimal.SelectedItem.ToString().Split(new string[] { " - " }, StringSplitOptions.None)[0]);

                    bool check = db.Журнал_осмотров.Any(rec => rec.Комментарий == "Нарушений не выявлено" && rec.Животное == an && System.Data.Entity.DbFunctions.TruncateTime(rec.Дата_проверки) == InspectionDatePicker.Value);

                    if (check)
                    {
                        var range = db.Журнал_осмотров.Where(rec => rec.Комментарий == "Нарушений не выявлено" && rec.Животное == an && System.Data.Entity.DbFunctions.TruncateTime(rec.Дата_проверки) == InspectionDatePicker.Value);
                        try { db.Журнал_осмотров.RemoveRange(range); }
                        catch (Exception ex) { MessageBox.Show(ex.Message, "Добавлено", MessageBoxButtons.OK); }
                    }
                
                    db.Журнал_осмотров.Add(new Журнал_осмотров
                    {
                        Сотрудник = idEmp,
                        Животное = an,
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

        private void cbAnimal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int animalID = Convert.ToInt32(cbAnimal.SelectedItem.ToString().Split(new string[] { " - " }, StringSplitOptions.None)[0]);
            
            using(var db = new ZooparkModel())
            {
                this.receiptDate = db.Животное.Where(an => an.ID == animalID).First().Дата_поступления;
                InspectionDatePicker.MinDate = this.receiptDate > this.acceptDate ? this.receiptDate : this.acceptDate;

            }
        }

        private void cbEx_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEx.Checked)
            {
                tbComment.Enabled = false;
                tbComment.Text = "Нарушений не выявлено";
            }
            else
            {
                tbComment.Enabled = true;
                tbComment.Text = "";
            }
        }
    }
}
