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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="Zulfa" && textBox2.Text=="zulfa138")
            {
                new MainMenu().Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Username/Password Salah");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                textBox2.PasswordChar = '*';
            }
        }
    }
}
