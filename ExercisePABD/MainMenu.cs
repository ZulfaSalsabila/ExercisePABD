using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercisePABD
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new DataGrid().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Data_Binding().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new DataGrid().Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            new Data_Binding().Show();
            this.Hide();
        }
    }
}
