using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooPark.cmEmployeeForms;

namespace ZooPark
{
    partial class Zoopark
    {
        private IEnumerable GetEmployees()
        {
            using (var db = new ZooparkModel())
            {
                var employees = from employee in db.Сотрудник
                                select new
                                {
                                    employee.ID,
                                    employee.Фамилия,
                                    employee.Имя,
                                    employee.Отчество,
                                };

                return employees.ToList();
            }
        }

        private void SetEmployeesGrid()
        {
            dgEmployee.DataSource = GetEmployees();
            dgEmployee.Columns[0].HeaderText = "ID";
            dgEmployee.Columns[0].Width = 50;
            dgEmployee.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgEmployee.Columns[1].HeaderText = "Фамилия";
            dgEmployee.Columns[1].Width = 208;
            dgEmployee.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgEmployee.Columns[2].HeaderText = "Имя";
            dgEmployee.Columns[2].Width = 208;
            dgEmployee.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgEmployee.Columns[3].HeaderText = "Отчество";
            dgEmployee.Columns[3].Width = 208;
            dgEmployee.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }



        private void cmUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (dgEmployee.SelectedCells.Count > 0)
            {
                var i = dgEmployee.SelectedCells[0].OwningRow.Index;
                int id = (int)dgEmployee[0, i].Value;
                UpdateEmployeeForm form = new UpdateEmployeeForm(id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SetEmployeesGrid();
                }
            }

        }

        private void cmAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm form = new AddEmployeeForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                SetEmployeesGrid();
            }
        }

        private void cmRefreshEmployee_Click(object sender, EventArgs e)
        {
            SetEmployeesGrid();
        }

        private void cmDeleteEmployee_Click(object sender, EventArgs e)
        {
            string fio = String.Empty;
            if (dgEmployee.SelectedCells.Count > 0)
            {
                var i = dgEmployee.SelectedCells[0].OwningRow.Index;
                int empID = (int)dgEmployee[0, i].Value;
                using (var db = new ZooparkModel())
                {
                    Сотрудник employee = db.Сотрудник.Where(emp => emp.ID == empID).First();
                    fio = employee.Фамилия + " " + employee.Имя + (String.IsNullOrEmpty(employee.Отчество) ? String.Empty : " " + employee.Отчество);
                }

           



            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этого сотрудника?\n" + fio,
            "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                
                   
                    using (var db = new ZooparkModel())
                    {
                        if (db.Журнал_прививок.Any(item => item.Сотрудник == empID) ||
                            db.Проверка_вольеров.Any(item => item.Сотрудник == empID) ||
                            db.Журнал_осмотров.Any(item => item.Сотрудник == empID))
                        {
                            var emp = db.Сотрудник.Where(item => item.ID == empID).First();
                            string empFio = emp.Фамилия + ' ' + emp.Имя  + (String.IsNullOrEmpty(emp.Отчество)?"": ' '+emp.Отчество);
                            MessageBox.Show("Сотрудник " + empFio + " \n не может быть удалён, так как он имеется в журнальных записях!", "Ошибка", MessageBoxButtons.OK);
                            
                        }
                        else
                        {
                            Учетные_записи record = db.Учетные_записи.Where(emp => emp.Сотрудник.ID == empID).First();
                            Сотрудник employee = db.Сотрудник.Where(emp => emp.ID == empID).First();
                            db.Учетные_записи.Remove(record);
                            db.Сотрудник.Remove(employee);
                            db.SaveChanges();
                        }
                    
                       
                    }
                }
            }
            SetEmployeesGrid();
        }

        private void cmInfo_Click(object sender, EventArgs e)
        {
            if (dgEmployee.SelectedCells.Count > 0)
            {
                var i = dgEmployee.SelectedCells[0].OwningRow.Index;
                int empID = (int)dgEmployee[0, i].Value;
                using (var db = new ZooparkModel())
                {
                    Сотрудник employee = db.Сотрудник.Where(emp => emp.ID == empID).First();
                    string info = "Фамилия: " + employee.Фамилия +
                                  "\nИмя: " + employee.Имя +
                                  "\nОтчество: " + employee.Отчество +
                                  "\nПол: " + employee.Пол +
                                  "\nДата рождения: " + employee.Дата_рождения.ToShortDateString() +
                                  "\nАдрес " + employee.Адрес +
                                  "\nСтаж: " + employee.Стаж +
                                  "\nДолжность: " + employee.Должность1.Название +
                                  "\nДата приема: " + employee.Дата_приема.ToShortDateString() +
                                  "\nДата увольнения: " + (employee.Дата_увольнения == null ? "" : employee.Дата_увольнения.ToString().Split(' ')[0]) +
                                  "\nПаспорт: " + employee.Паспорт;
                    MessageBox.Show(info, "Дополнительная информация", MessageBoxButtons.OK);

                }

            }
        }

       

        
    }
}
