using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooPark.cmAnimalsInspectionsForms;

namespace ZooPark
{
    partial class Zoopark
    {
        private IEnumerable GetAnimalsInspections()
        {
            using (var db = new ZooparkModel())
            {
                var animalsInspections = from animalInspection in db.Журнал_осмотров
                                select new
                                {
                                    animalInspection.ID,
                                    animalInspection.Сотрудник1.Фамилия,
                                    animalInspection.Животное1.Название,
                                    animalInspection.Дата_проверки,
                                    animalInspection.Комментарий
                                };
                return animalsInspections.ToList();
            }
        }

        private void SetAnimalsInspectionGrid()
        {
            dgAnimalsInspections.DataSource = GetAnimalsInspections();
            dgAnimalsInspections.Columns[0].HeaderText = "ID";
            //dgAnimalsInspections.Columns[0].Width = 50;
            dgAnimalsInspections.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgAnimalsInspections.Columns[1].HeaderText = "Сотрудник";
            //dgAnimalsInspections.Columns[1].Width = 167;
            dgAnimalsInspections.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgAnimalsInspections.Columns[2].HeaderText = "Животное";
            //dgAnimalsInspections.Columns[2].Width = 167;
            dgAnimalsInspections.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgAnimalsInspections.Columns[3].HeaderText = "Дата проверки";
            //dgAnimalsInspections.Columns[3].Width = 80;
            dgAnimalsInspections.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgAnimalsInspections.Columns[4].HeaderText = "Комментарий";
            //dgAnimalsInspections.Columns[4].Width = 166;
            dgAnimalsInspections.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //dgAnimalsInspections.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgAnimalsInspections.Columns[4].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

        }





        private void cmUpdate_Click(object sender, EventArgs e)
        {
            if (dgAnimalsInspections.SelectedCells.Count > 0)
            {
                

                var i = dgAnimalsInspections.SelectedCells[0].OwningRow.Index;
                int id = (int)dgAnimalsInspections[0, i].Value;
                using (var db = new ZooparkModel())
                {
                    if (db.Журнал_осмотров.Where(rec => rec.ID == id).First().Сотрудник == loggedID || db.Сотрудник.Where(em => em.ID == loggedID).First().Должность==6)
                    {

                        if (db.Журнал_осмотров.Any(rec => rec.ID == id && rec.Комментарий.Trim() != "Нарушений не выявлено"))
                        {
                            UpdateAnimalsInspectionsForm form = new UpdateAnimalsInspectionsForm(id);
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                SetAnimalsInspectionGrid();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Нельзя менять запись, если все хорошо!\nДобавьте новую запись если заметили нарушения!", "Ошибка", MessageBoxButtons.OK);
                        }


                    }
                    else
                    {
                        MessageBox.Show("Эта запись в журнале не принадлежит вам! Вы не можете ее изменить!", "Ошибка", MessageBoxButtons.OK);
                    }
                }
                    
            }
        }

        private void cmAdd_Click(object sender, EventArgs e)
        {
            using (var db = new ZooparkModel())
            {
                int[] posts = { 1, 4, 6 };
                if (db.Сотрудник.Any(emp => (posts.Contains(emp.Должность) && emp.Дата_увольнения == null))) {
                    if(db.Сотрудник.Any(emp=> emp.ID == loggedID && posts.Contains(emp.Должность))) { 
                        
                    AddAnimalsInspectionsForm form = new AddAnimalsInspectionsForm(loggedID);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        SetAnimalsInspectionGrid();
                    }
                    }
                    else
                    {
                        MessageBox.Show("Вы можете только просматривать данную таблицу!", "Ошибка", MessageBoxButtons.OK);
                        DialogResult = DialogResult.None;
                    }
                    
                }
                else
                {
                    MessageBox.Show("В нашем зоопарке нет сотрудников, которые могли бы провести осмотр!", "Ошибка", MessageBoxButtons.OK);
                    DialogResult = DialogResult.None;
                }
            }


        }

        private void cmRefresh_Click(object sender, EventArgs e)
        {
            SetAnimalsInspectionGrid();
        }

        private void cmDelete_Click(object sender, EventArgs e)
        {
            if (dgAnimalsInspections.SelectedCells.Count > 0)
            {
                using (var db = new ZooparkModel())
                {
                    var i = dgAnimalsInspections.SelectedCells[0].OwningRow.Index;
                int recordID = (int)dgAnimalsInspections[0, i].Value;
                if (db.Журнал_осмотров.Where(rec => rec.ID == recordID).First().Сотрудник == loggedID || db.Сотрудник.Where(em => em.ID == loggedID).First().Должность == 6) { 
                    DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить эту запись?",
                "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    
                        Журнал_осмотров record = db.Журнал_осмотров.Where(item => item.ID == recordID).First();
                        db.Журнал_осмотров.Remove(record);
                        db.SaveChanges();
                    }
                    }
                    else {
                        MessageBox.Show("Эта запись в журнале не принадлежит вам! Вы не можете ее удалить!", "Ошибка", MessageBoxButtons.OK);
                    }
                }
            }
            SetAnimalsInspectionGrid();

        }

        
    }
}
