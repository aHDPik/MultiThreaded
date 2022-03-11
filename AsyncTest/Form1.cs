using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        async Task<int> TotalUsers()
        {
            await Task.Delay(10000);
            return 100500;
        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            //counterLabel.Text = "Go!";

            for (int i = 0; i < 10; i++)
            {
                counterLabel.Text = i.ToString();
                await Task.Delay(1000);
            }
        }
    }
}
