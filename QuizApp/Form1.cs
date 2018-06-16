using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuizApp
{
    public partial class Form1 : Form
    {
        private String path;
        private XElement xElement;
        private IEnumerable<XElement> questions;


        public Form1()
        {
            InitializeComponent();
            this.path = "../../quiz.xml";
            this.xElement = XElement.Load(path);
            this.questions = xElement.Elements();
        }

        public Boolean checkAnswer(XElement xEle) {
            string check =(string)xEle.Element("answer");
            if (check.Equals("Tak"))
            {
                Console.WriteLine("tak");
                return true;
            }
            else {
                Console.WriteLine("Nie");
                return false;
            }
            
        }

        public void doQuiz(IEnumerable<XElement> list) {


            int num = 0;

            foreach (XElement xEle in list)
            {
                DialogResult answer = MessageBox.Show(xEle.Element("text").Value, "Pytanie" + num, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    if (checkAnswer(xEle))
                    {
                        num++;
                        MessageBox.Show("Odpowiedz poprawana", "Gratulacje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Odpowiedz niepoprawna", "Przykro nam", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (answer == DialogResult.No)
                {
                    if (!checkAnswer(xEle))
                    {
                        num++;
                        MessageBox.Show("Odpowiedz poprawana", "Gratulacje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Odpowiedz niepoprawna", "Przykro nam", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (list.Count() == num)
            {
                MessageBox.Show("Zdobyłeś maksymalną liczbę pkt!!", "To koniec!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Zdobyłeś " + num + " pkt", "To koniec!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        




        private void buttonHistory_Click(object sender, EventArgs e)
        {
            var historyList = from hl in xElement.Elements("question")
                              where (string)hl.Element("category") == "Historia"
                              select hl;

            doQuiz(historyList);


        }

        private void buttonSport_Click(object sender, EventArgs e)
        {

            var sportList = from hl in xElement.Elements("question")
                              where (string)hl.Element("category") == "Sport"
                              select hl;

            doQuiz(sportList);

        }

        private void buttonTechnology_Click(object sender, EventArgs e)
        {

            var technologyList = from hl in xElement.Elements("question")
                            where (string)hl.Element("category") == "Technologia"
                            select hl;

            doQuiz(technologyList);

        }

        private void buttonGeneral_Click(object sender, EventArgs e)
        {

            var generalList = from hl in xElement.Elements("question")
                            where (string)hl.Element("category") == "Ogólne"
                            select hl;

            doQuiz(generalList);

        }
    }
}
