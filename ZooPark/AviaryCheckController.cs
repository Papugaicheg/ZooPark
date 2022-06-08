using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooPark.cmAviaryCheck;

namespace ZooPark
{
    partial class Zoopark
    {
        private IEnumerable GetAviaryCheck()
        {
            using (var db = new ZooparkModel())
            {
               
                var acs = from ac in db.Проверка_вольеров
                                select new
                                {
                                    ac.ID,
                                    ac.Сотрудник1.Фамилия,
                                    ac.Вольер,
                                    ac.Дата_проверки,
                                    ac.Комментарий
                                };
                return acs.ToList();
            }
        }

        private void SetAviaryCheckGrid()
        {
            dgAviaryCheck.DataSource = GetAviaryCheck();
            dgAviaryCheck.Columns[0].HeaderText = "ID";
            dgAviaryCheck.Columns[0].Width = 50;
            dgAviaryCheck.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgAviaryCheck.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgAviaryCheck.Columns[1].HeaderText = "Сотрудник";
            dgAviaryCheck.Columns[1].Width = 167;
            dgAviaryCheck.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgAviaryCheck.Columns[2].HeaderText = "Вольер";
            dgAviaryCheck.Columns[2].Width = 80;
            dgAviaryCheck.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgAviaryCheck.Columns[3].HeaderText = "Дата проверки";
            dgAviaryCheck.Columns[3].Width = 120;
            dgAviaryCheck.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgAviaryCheck.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgAviaryCheck.Columns[4].HeaderText = "Комментарий";
            dgAviaryCheck.Columns[4].Width = 218;
            dgAviaryCheck.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgAviaryCheck.Columns[4].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }


        private void cmUpdateAviaryCheck_Click(object sender, EventArgs e)
        {

            if (dgAviaryCheck.SelectedCells.Count > 0)
            {
                var i = dgAviaryCheck.SelectedCells[0].OwningRow.Index;
                int id = (int)dgAviaryCheck[0, i].Value;
                using (var db = new ZooparkModel())
                {
                    int[] posts = { 4, 2 };
                    if (posts.Contains(loggedID))
                    {
                        UpdateAviaryCheckForm form = new UpdateAviaryCheckForm(id,loggedID);
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            SetAviaryCheckGrid();
                        }
                    }
                    else
                    {
                        MessageBox.Show("У вас недостаточно прав для изменения данной таблицы!", "Ошибка", MessageBoxButtons.OK);
                    }
                }
            }
        }


        private void cmAddAviaryCheck_Click(object sender, EventArgs e)
        {
            using (var db = new ZooparkModel())
            {
                int[] posts = { 4, 6 };
                if (db.Сотрудник.Any(emp => (posts.Contains(emp.Должность) && emp.Дата_увольнения == null)))
                {
                    if (db.Сотрудник.Any(emp => emp.ID == loggedID && posts.Contains(emp.Должность)))
                    {
                        AddAviaryCheckForm form = new AddAviaryCheckForm(loggedID);
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            SetAviaryCheckGrid();
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

       

        private void cmRefreshAviaryCheck_Click(object sender, EventArgs e)
        {
            SetAviaryCheckGrid();
        }

        private void cmDeleteAviaryCheck_Click(object sender, EventArgs e)
        {
            if (dgAviaryCheck.SelectedCells.Count > 0)
            {
                var i = dgAviaryCheck.SelectedCells[0].OwningRow.Index;
                int recordID = (int)dgAviaryCheck[0, i].Value;
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить эту запись?",
                    "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {


                    using (var db = new ZooparkModel())
                    {
                         Проверка_вольеров record = db.Проверка_вольеров.Where(item => item.ID == recordID).First();
                        db.Проверка_вольеров.Remove(record);

                        db.SaveChanges();



                    }
                }
            }
            SetAviaryCheckGrid();
        }

    }
}
