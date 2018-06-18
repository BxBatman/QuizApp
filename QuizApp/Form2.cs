using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "") {
                MessageBox.Show("Wpisz login i hasło");
                return;
            }

            if (textBox1.Text == "admin" && textBox2.Text == "admin") {
                Form3 form3 = new Form3();
                form3.Show();
                this.Close();
            }
        }

    }
}
