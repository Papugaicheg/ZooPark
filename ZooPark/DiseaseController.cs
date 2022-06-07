using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooPark.cmDiseaseForm;

namespace ZooPark
{
    partial class Zoopark
    {
        private IEnumerable GetDiseases()
        {
            using (var db = new ZooparkModel())
            {
               
                var diseases = from disease in db.Болезнь
                                select new
                                {
                                    disease.ID,
                                    disease.Животное1.Название,
                                    Заболевание = disease.Заболевание.Название
                                };
                return diseases.ToList();
            }
        }

        private void SetDiseaseGrid()
        {
            dgDisease.DataSource = GetDiseases();
            dgDisease.Columns[0].HeaderText = "ID";
            dgDisease.Columns[0].Width = 50;
            dgDisease.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgDisease.Columns[1].HeaderText = "Название";
            dgDisease.Columns[1].Width = 312;
            dgDisease.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgDisease.Columns[2].HeaderText = "Заболевания";
            dgDisease.Columns[2].Width = 312;
        }


        private void cmUpdateDisease_Click(object sender, EventArgs e)
        {
            if (dgDisease.SelectedCells.Count > 0)
            {
                var i = dgDisease.SelectedCells[0].OwningRow.Index;
                int id = (int)dgDisease[0, i].Value;
                using (var db = new ZooparkModel())
                {
                    int[] posts = { 1, 2 };
                    if (posts.Contains(loggedID))
                    {
                        UpdateDiseaseForm form = new UpdateDiseaseForm(id);
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            SetDiseaseGrid();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Эта запись в журнале не принадлежит вам! Вы не можете ее изменить!", "Ошибка", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void cmAddDisease_Click(object sender, EventArgs e)
        {
            using (var db = new ZooparkModel())
            {
                int[] posts = { 1, 6 };
                if (db.Сотрудник.Any(emp => (posts.Contains(emp.Должность) && emp.Дата_увольнения == null)))
                {
                    if (db.Сотрудник.Any(emp => emp.ID == loggedID && posts.Contains(emp.Должность)))
                    {
                        AddDiseaseForm form = new AddDiseaseForm();
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            SetDiseaseGrid();
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

        private void cmRefreshDisease_Click(object sender, EventArgs e)
        {
            SetDiseaseGrid();
        }

        private void cmDeleteDisease_Click(object sender, EventArgs e)
        {
            if (dgDisease.SelectedCells.Count > 0)
            {
                var i = dgDisease.SelectedCells[0].OwningRow.Index;
                int recordID = (int)dgDisease[0, i].Value;
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить эту запись?",
                    "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {


                    using (var db = new ZooparkModel())
                    {
                        Болезнь record = db.Болезнь.Where(item => item.ID == recordID).First();
                        db.Болезнь.Remove(record);

                        db.SaveChanges();



                    }
                }
            }
            SetDiseaseGrid();
        }

    }
}
