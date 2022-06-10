using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooPark.cmVaccination;

namespace ZooPark
{
    partial class Zoopark
    {
        private IEnumerable GetVaccination()
        {
            using (var db = new ZooparkModel())
            {
               
                var vaccinations = from vaccination in db.Журнал_прививок
                                select new
                                {
                                    vaccination.ID,
                                    vaccination.Сотрудник1.Фамилия,
                                    vaccination.Животное1.Название,
                                    vaccination.Дата_прививки,
                                    Прививка = vaccination.Прививка1.Название
                                };
                return vaccinations.ToList();
            }
        }

        private void SetVaccinationGrid()
        {
            dgVaccinations.DataSource = GetVaccination();
            dgVaccinations.Columns[0].HeaderText = "ID";
            dgVaccinations.Columns[0].Width = 50;
            dgVaccinations.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgVaccinations.Columns[1].HeaderText = "Сотрудник";
            dgVaccinations.Columns[1].Width = 167;
            dgVaccinations.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgVaccinations.Columns[2].HeaderText = "Животное";
            dgVaccinations.Columns[2].Width = 167;
            dgVaccinations.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgVaccinations.Columns[3].HeaderText = "Дата";
            dgVaccinations.Columns[3].Width = 80;
            dgVaccinations.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgVaccinations.Columns[4].HeaderText = "Прививка";
            dgVaccinations.Columns[4].Width = 200;

            dgVaccinations.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //dgVaccinations.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgVaccinations.Columns[4].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }


        private void cmUpdateVaccination_Click(object sender, EventArgs e)
        {
            if (dgVaccinations.SelectedCells.Count > 0)
            {
                var i = dgVaccinations.SelectedCells[0].OwningRow.Index;
                int id = (int)dgVaccinations[0, i].Value;
                using (var db = new ZooparkModel())
                {
                    if (db.Журнал_прививок.Where(rec => rec.ID == id).First().Сотрудник == loggedID || loggedID == 2)
                    {
                        UpdateVaccinationForm form = new UpdateVaccinationForm(id);
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            SetVaccinationGrid();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Эта запись в журнале не принадлежит вам! Вы не можете ее изменить!", "Ошибка", MessageBoxButtons.OK);
                    }
                }
            }
            }

        private void cmAddVaccination_Click(object sender, EventArgs e)
        {
            using (var db = new ZooparkModel())
            {
                int[] posts = { 1, 6 };
                if (db.Сотрудник.Any(emp => (posts.Contains(emp.Должность) && emp.Дата_увольнения == null)))
                {
                    if (db.Сотрудник.Any(emp => emp.ID == loggedID && posts.Contains(emp.Должность)))
                    {
                        AddVaccinationForm form = new AddVaccinationForm(loggedID);
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            SetVaccinationGrid();
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

        private void cmRefreshVaccination_Click(object sender, EventArgs e)
        {
            SetVaccinationGrid();
        }

        private void cmRemoveVaccination_Click(object sender, EventArgs e)
        {
            if (dgVaccinations.SelectedCells.Count > 0)
            {
                var i = dgVaccinations.SelectedCells[0].OwningRow.Index;
                int recordID = (int)dgVaccinations[0, i].Value;
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить эту запись?",
                    "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {


                    using (var db = new ZooparkModel())
                    {
                        Журнал_прививок record = db.Журнал_прививок.Where(item => item.ID == recordID).First();
                        db.Журнал_прививок.Remove(record);
                      
                        db.SaveChanges();



                    }
                }
            }
            SetVaccinationGrid();
        }

       
    }
}
