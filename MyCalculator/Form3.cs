using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form3 : Form
    {
        static public int historyFormCount = 0;
        public Form3()
        {
            historyFormCount++;
            InitializeComponent();
        }

        public Form3(string textHistory)
        {
            historyFormCount++;
            InitializeComponent();
            this.richTextBox1.Text = textHistory;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            historyFormCount--;
        }
    }
}
