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
    public partial class DataGrid : Form
    {
        public DataGrid()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

        }

        internal class Show
        {
            public Show()
            {
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            new Data_Binding().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new MainMenu().Show();
            this.Hide();
        }
    }
}
