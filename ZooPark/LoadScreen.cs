using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooPark
{
    public partial class LoadScreen : Form
    {
        private Timer timer;
        public LoadScreen()
        {
            InitializeComponent();
        }

        private void LoadScreen_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            timer = new Timer();
            timer.Interval = (3000);
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }
       
           
            private void Timer_Tick(object sender, EventArgs e)
            {
                timer.Stop();
                Hide();
                AuthForm f = new AuthForm();
                f.ShowDialog();
                Close();
            }
        }
    }

