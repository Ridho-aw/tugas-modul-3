using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasModul3_103082400024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Boolean jawaban;
        private void logic()
        {
            if (jawaban)
            {
                labelJawaban.Text = "Jawaban Benar";
            }
            if (jawaban != true)
            {
                labelJawaban.Text = "Jawaban Salah";

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            jawaban = true;
            logic();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            jawaban = false;
            logic();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            jawaban = false;
            logic();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jawaban = false;
            logic();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
