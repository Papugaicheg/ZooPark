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

namespace ZooPark.cmEmployeeForms
{
    public partial class AddEmployeeForm : Form
    {
        
        private string surname;
        private string name;
        private string middlename;
        private DateTime dateBirth;
        private string phone;
        private string address;
        private byte exp;
        private int post;
        private DateTime acceptDate;
        private DateTime? dismissDate;
        private string passport;
        private Сотрудник NewEmp;


        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            BirthDatePicker.MaxDate = DateTime.Today.AddYears(-16);
            this.Text = "Добавление сотрудника";
            cbPost.DataSource = GetPosts();
            cbPost.SelectedItem = GetPosts()[0];
            DismissDatePicker.Enabled = false;


        }




     


        private List<String> GetPosts()
        {
            using (var db = new ZooparkModel())
            {

                var posts = from post in db.Должность
                            select new
                            {
                                Название = post.Название
                            };
                var postsList = new List<String>();
                posts.ToList().ForEach(post => { postsList.Add(post.Название); });
                return postsList;
            }

        }
        //Validating

        private void tbSurname_Validating(object sender, CancelEventArgs e)
        {
            string input = tbSurname.Text.Trim();
            if (String.IsNullOrEmpty(input) || input.Length > 20)
            {
                errorProvider.SetError(tbSurname, "Ошибка!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tbSurname, String.Empty);
                e.Cancel = false;
            }
        }



        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            string input = tbName.Text.Trim();
            if (String.IsNullOrEmpty(input) || input.Length > 20)
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


        private void tbMiddlename_Validating(object sender, CancelEventArgs e)
        {
            string input = tbMiddlename.Text.Trim();
            if (input.Length > 20)
            {
                errorProvider.SetError(tbMiddlename, "Ошибка!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tbMiddlename, String.Empty);
                e.Cancel = false;
            }
        }


        private void BirthDatePicker_ValueChanged(object sender, EventArgs e)
        {
            AcceptDatePicker.MinDate = BirthDatePicker.Value.Date.AddYears(+16);
        }


        private void tbPhone_Validating(object sender, CancelEventArgs e)
        {
            if (tbPhone.MaskCompleted)
            {
                errorProvider.SetError(tbPhone, String.Empty);
                e.Cancel = false;
            }
            else
            {
                errorProvider.SetError(tbPhone, "Ошибка!");
                e.Cancel = true;
            }
        }


        private void tbAdress_Validating(object sender, CancelEventArgs e)
        {
            string adress = tbAdress.Text;
            if (string.IsNullOrEmpty(adress) || adress.Length > 50)
            {
                errorProvider.SetError(tbAdress, "Ошибка!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tbAdress, String.Empty);
                e.Cancel = false;
            }
        }

        private void tbExp_Validating(object sender, CancelEventArgs e)
        {
            string input = tbExp.Text;
            if (Regex.IsMatch(input, @"(?<=\s|^)\d+(?=\s|$)") && input.Length < 3)
            {
                int exp = Convert.ToInt32(tbExp.Text.Trim());
                if (exp >= 0 && exp <= 75)
                {
                    errorProvider.SetError(tbExp, String.Empty);
                    e.Cancel = false;
                }
                else
                {
                    errorProvider.SetError(tbExp, "Ошибка!");
                    e.Cancel = true;
                }
            }
            else
            {
                errorProvider.SetError(tbExp, "Ошибка!");
                e.Cancel = true;
            }
        }



        private void AcceptDatePicker_ValueChanged(object sender, EventArgs e)
        {
            DismissDatePicker.MinDate = AcceptDatePicker.Value.Date.AddDays(1);
        }



        private void tbPassport_Validating(object sender, CancelEventArgs e)
        {
            using(var db = new ZooparkModel())
            {
                bool check = db.Сотрудник.Any(emp => emp.Паспорт == tbPassport.Text);
                if (tbPassport.Text.Length > 50 || check)
                {
                    errorProvider.SetError(tbPassport, "Ошибка");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(tbPassport, String.Empty);
                    e.Cancel = false;
                }
            }
         
        }
        //Validating 


        //Validated

        private void tbSurname_Validated(object sender, EventArgs e)
        {
            this.surname = tbSurname.Text.Trim();
        }
        private void tbName_Validated(object sender, EventArgs e)
        {
            this.name = tbName.Text.Trim();
        }
        private void tbMiddlename_Validated(object sender, EventArgs e)
        {
            this.middlename = tbMiddlename.Text.Trim();
        }
        private void BirthDatePicker_Validated(object sender, EventArgs e)
        {
            this.dateBirth = BirthDatePicker.Value.Date;
        }
        private void tbPhone_Validated(object sender, EventArgs e)
        {
            this.phone = tbPhone.Text.Trim();
        }
        private void tbAdress_Validated(object sender, EventArgs e)
        {
            this.address = tbAdress.Text.Trim();
        }
        private void tbExp_Validated(object sender, EventArgs e)
        {
            this.exp = Convert.ToByte(tbExp.Text.Trim());
        }
        private void tbPassport_Validated(object sender, EventArgs e)
        {
            this.passport = tbPassport.Text.Trim();
        }
        private void AcceptDatePicker_Validated(object sender, EventArgs e)
        {
            this.acceptDate = AcceptDatePicker.Value.Date;
        }
        private void DismissDatePicker_Validated(object sender, EventArgs e)
        {
            if (cbDismiss.Checked)
            {
                this.dismissDate = DismissDatePicker.Value.Date;
            }
            else
            {
                this.dismissDate = null;
            }
        }
        private void cbPost_Validated(object sender, EventArgs e)
        {
            this.post = cbPost.SelectedIndex + 1;
        }


        //Validated
        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            this.Close();
        }

        private void cbDismiss_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDismiss.Checked)
            {
                DismissDatePicker.Enabled = true;
            }
            else
            {
                DismissDatePicker.Enabled = false;
            }
        }
        private void AddEmployee()
        {
            try
            {
                using (var db = new ZooparkModel())
                {
                    db.Сотрудник.Add(new Сотрудник
                    {
                        Фамилия = this.surname,
                        Имя = this.name,
                        Отчество = this.middlename,
                        Пол = rbMale.Checked ? "Мужской" : "Женский",
                        Дата_рождения = this.dateBirth,
                        Телефон = this.phone,
                        Адрес = this.address,
                        Стаж = this.exp,
                        Должность = this.post,
                        Дата_приема = this.acceptDate,
                        Дата_увольнения = this.dismissDate,
                        Паспорт = this.passport});


                    db.SaveChanges();
                    this.NewEmp = db.Сотрудник.Where(emp => emp.ID == db.Сотрудник.Max(em => em.ID)).First();
                }

                MessageBox.Show("Данные Добавлены!", "Добавлено", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка в данных!", "Ошибка", MessageBoxButtons.OK);
            }
        }



        private void AddButton_Click(object sender, EventArgs e)
        {
            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;
            if (DialogResult == DialogResult.OK)
            {
                AddEmployee();
                string data = "Логин: " + this.NewEmp.Фамилия + this.NewEmp.ID.ToString() +
                              "\nПароль необходимо будет задать при первом входе";
                MessageBox.Show(data, "Учетные данные", MessageBoxButtons.OK);
                AddAuth();
                this.Close();
            }
        }





        private void AddAuth()
        {
            try
            {
                using (var db = new ZooparkModel())
                {
                    db.Учетные_записи.Add(new Учетные_записи
                    {
                        Login = this.NewEmp.Фамилия+this.NewEmp.ID.ToString(),
                        Password = null,
                        Employee = this.NewEmp.ID
                    });


                    db.SaveChanges();
                }

            }
            catch (Exception)
            { MessageBox.Show("Учетные данные не были созданы!", "Ошибка", MessageBoxButtons.OK); }
        }


    }
}
