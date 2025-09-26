using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brain_Crown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int questionNumber = 0, dogru = 0, yanlis =0;

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            btnNext.Enabled = true;

            label8.Text = btnB.Text;

            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            btnNext.Enabled = true;

            label8.Text = btnC.Text;

            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            btnNext.Enabled = true;

            label8.Text = btnD.Text;

            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            btnNext.Enabled = true;

            label8.Text = btnA.Text;

            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;

            btnNext.Enabled = false;

            pictureBox1.Visible= false;
            pictureBox2.Visible= false;
            
            questionNumber++;
            label4.Text = questionNumber.ToString();

            if (questionNumber == 1)
            {
                richTextBox1.Text = "In which year was the Republice of Turkey declared?";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1923";

                label7.Text = "1923";
            }
            if (questionNumber == 2)
            {
                richTextBox1.Text = "Which city is not in the Agean region?";
                btnA.Text = "İzmir";
                btnB.Text = "Balıkesir";
                btnC.Text = "Aydın";
                btnD.Text = "Manisa";

                label7.Text = "Balıkesir";
            }
            if (questionNumber == 3)
            {
                richTextBox1.Text = "Which author does the Last Birds belong to?";
                btnA.Text = "Sait Faik Abasıyanık";
                btnB.Text = "Cemal Süreyya";
                btnC.Text = "Reşat Nuri Güntekin";
                btnD.Text = "Atilla İlhan";

                label7.Text = "Sait Faik Abasıyanık";

                btnNext.Text = "Result";
            }
            if (questionNumber == 4)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;

                btnNext.Enabled = false;

                MessageBox.Show("True: " + dogru + "\n" + "False: " + yanlis);
            }
        }
    }
}
