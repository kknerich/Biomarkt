using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Biomarkt
{
    public partial class LoadingScreen : Form
    {

        private int loadingBarValue;

        public LoadingScreen()
        {
            InitializeComponent();
        }
        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void Loading_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            loadingBarValue += 1;

            label1.Text = loadingBarValue.ToString() + "%";

            progressBar1.Value = loadingBarValue;

            if (loadingBarValue>= 100)
            {
                timer1.Stop();
            }
        }


    }
}
