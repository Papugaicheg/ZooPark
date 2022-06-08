using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooPark.cmAviaryCheck
{
    public partial class AddAviaryCheckForm : Form
    {
        private Сотрудник emp;
        private string comment;
        public AddAviaryCheckForm(int id)
        {
            
            InitializeComponent();
            using (var db = new ZooparkModel())
            {
                emp = db.Сотрудник.Where(e => e.ID == id).First();
            }

        }


        private List<string> GetAviary()
        {
            using (var db = new ZooparkModel())
            {

                var aviaries = from aviary in db.Вольер
                               select new
                               {
                                   Номер = aviary.ID,
                                   Тип = aviary.Тип
                               };
                var aviaryList = new List<String>();
                aviaries.ToList().ForEach(aviary => { aviaryList.Add("№ " + aviary.Номер.ToString() + " - " + aviary.Тип); });
                return aviaryList;
            }
        }

        private void AddAviaryCheckForm_Load(object sender, EventArgs e)
        {
            using (var db = new ZooparkModel())
            {
                tbEmployee.Text = emp.ID + " - " + emp.Фамилия + " " + emp.Имя + " " + emp.Отчество;
                DateTime dateAccept = emp.Дата_приема;
                DateTime? dateDismiss = emp.Дата_увольнения;
                dtpAviaryCheck.MaxDate = dateDismiss ?? DateTime.Today;
                dtpAviaryCheck.MinDate = dateAccept;

                if (GetAviary().Count > 0)
                {
                    cbAviary.DataSource = GetAviary();
                    cbAviary.SelectedIndex = 0;
                }
                else
                {
                    btAddAviaryCheck.Enabled = false;
                    MessageBox.Show("Нет возможности добавить запись о проверке вольера, так как отсутстуют вольеры!", "Ошибка", MessageBoxButtons.OK);
                }
                


            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            this.Close();        
        }


        private void tbComment_Validating(object sender, CancelEventArgs e)
        {
            string input = tbComment.Text;
            if (input.Length > 250)
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
            this.comment = String.IsNullOrEmpty(tbComment.Text.Trim()) ? "" : tbComment.Text.Trim();
        }

        private void tbComment_TextChanged(object sender, EventArgs e)
        {
            countLb.Text = tbComment.Text.Length.ToString() + "/250";
        }
        private void AddAviaryCheck()
        {
            try
            {
                using (var db = new ZooparkModel())
                {

                    db.Проверка_вольеров.Add(new Проверка_вольеров
                    {
                        
                        Сотрудник = Convert.ToInt32(tbEmployee.Text.Split(new string[] { " - " }, StringSplitOptions.None)[0]),
                        Вольер = Convert.ToInt32(cbAviary.SelectedItem.ToString().Split(' ')[1]),
                        Дата_проверки = dtpAviaryCheck.Value,
                        Комментарий = comment
                    }) ;



                        db.SaveChanges();


                        MessageBox.Show("Данные Добавлены!", "Добавлено", MessageBoxButtons.OK);
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка в данных!", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void btAddAviaryCheck_Click(object sender, EventArgs e)
        {
            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;
            if (DialogResult == DialogResult.OK)
            {
                AddAviaryCheck();
                this.Close();

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
