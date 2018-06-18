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
    public partial class Form3 : Form
    {
        private String path = "../../quiz.xml";
        DataSet dataSet;
        public Form3()
        {
            InitializeComponent();
            dataSet =new DataSet();
            dataSet.ReadXml(@path);
            dataGridView1.DataSource = dataSet.Tables["question"];
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            dataSet.WriteXml(@path);
            Form1.reloadXml();
        }
    }
}
