using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ZooPark
{
    public partial class Zoopark : Form
    {
        private int post;
        private int loggedID;
        public Zoopark(int id)
        {
          
            InitializeComponent();
            tabControl.TabPages.Clear();
            this.loggedID = id;
            using (var db = new ZooparkModel())
            {
                this.post = db.Сотрудник.Where(emp => emp.ID == id).First().Должность;
            }
            switch (this.post)
            {

                //1	  Ветеринар 
                case 1:
                    tabControl.TabPages.AddRange(new TabPage[] { tabAnimals, tabAnimalsInspection, tabVaccination, tabDisease });
                    ;
                    break;

                //2   HR 
                case 2:
                    tabControl.TabPages.AddRange(new TabPage[] { tabEmployee });
                    
                    break;
                //3   Уборщик
                case 3:
                    tabControl.TabPages.AddRange(new TabPage[] { });
                    break;

                //4   Зоокипер
                case 4:
                    tabControl.TabPages.AddRange(new TabPage[] { tabAnimals, tabAnimalsInspection, tabAviaryCheck });
                    break;

                //5   Техник
                case 5:
                    tabControl.TabPages.AddRange(new TabPage[] { tabAviaryCheck });
                    break;

                //6   Директор
                case 6:
                    tabControl.TabPages.AddRange(new TabPage[] { tabEmployee, tabAnimals, tabAnimalsInspection, tabVaccination, tabDisease, tabAviaryCheck });
                    break;

            }


        }

        private void Zoopark_Load(object sender, EventArgs e)
        {

           
            
        }

        private void tabEmployee_Enter(object sender, EventArgs e)
        {
            SetEmployeesGrid();
        }
        private void tabAnimals_Enter(object sender, EventArgs e)
        {
            SetAnimalsGrid();
        }
        private void tabAnimalsInspection_Enter(object sender, EventArgs e)
        {
            SetAnimalsInspectionGrid();
        }
        private void tabVaccination_Enter(object sender, EventArgs e)
        {
            SetVaccinationGrid();
        }
        private void tabDisease_Enter(object sender, EventArgs e)
        {
            SetDiseaseGrid();
        }
        private void tabAviaryCheck_Enter(object sender, EventArgs e)
        {
            SetAviaryCheckGrid();
        }

    
    }
    }

