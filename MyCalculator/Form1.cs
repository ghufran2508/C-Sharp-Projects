using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        string number1;
        string number2;
        char op = ' ';

        private int colorCode = 64;
        static private int formCount = 0;
        public Form1()
        {
            InitializeComponent();
            Form1.formCount++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// this will all the text on secondary or primary text feild.
        /// (will feel like new)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClr_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtPrmry.Text = "";
            this.txtScndry.Text = "0";
            this.number1 = "";
            this.number2 = "";
            this.op = ' ';
        }

        private void btn7_MouseClick(object sender, MouseEventArgs e)
        {
            if(this.txtPrmry.Text != "" && this.op == ' ')
            {
                this.txtPrmry.Text = "";
                this.number1 = "";
            }
            if (this.txtScndry.Text.Length <= 13)
            {
                if (this.txtScndry.Text != "0")
                {
                    this.txtScndry.Text += (sender as Button).Text;
                }
                else
                {
                    this.txtScndry.Text = (sender as Button).Text;
                }
            }
        }

        private void btn0_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.txtPrmry.Text != "" && this.op == ' ')
            {
                this.txtPrmry.Text = "";
                this.number1 = "";
            }
            if (this.txtScndry.Text.Length <= 13)
            {
                if (this.txtScndry.Text == "0") this.txtScndry.Text = "0";
                else this.txtScndry.Text += "0";
            }
        }

        private void btnDot_MouseClick(object sender, MouseEventArgs e)
        {
            if(this.txtPrmry.Text != "" && this.op == ' ')
            {
                this.txtPrmry.Text = "";
                this.number1 = "";
            }
            bool exist = false;
            for (int i = 0; i < this.txtScndry.Text.Length; i++)
            {
                if (this.txtScndry.Text.IndexOf('.') >= 0) exist = true;
            }
            if (!exist) this.txtScndry.Text += ".";
        }

        ///// <summary>
        ///// +/- operator to change the sign of the number
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        private void btnpm_MouseClick(object sender, MouseEventArgs e)
        {
            //if number 1 is already set but operator is not set.
            if (this.txtPrmry.Text != "" && this.op == ' ') return;

            //if number 1 is not set. and there is no text is txtScndry.
            if (this.txtScndry.Text == "" || this.txtScndry.Text == "0")
            {
                this.txtScndry.Text = "-";
            }
            else
            {
                //check if negative or positive
                if (this.txtScndry.Text[0] == '-')
                {
                    //if negative, then remove the "-" sign
                    this.txtScndry.Text = this.txtScndry.Text.Substring(1);
                }
                else
                {
                    //if positive, add the "-" sign
                    this.txtScndry.Text = "-" + this.txtScndry.Text;
                }
            }
        }

        ///// <summary>
        ///// buttons for operators. Every time you press operator. it would be evaluated in this function.
        ///// </summary>
        ///// <param name="sender">Button which is pressed...</param>
        ///// <param name="e">event type(mouse click etc...)</param>
        private void btnMultiply_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.txtPrmry.Text != "" && this.op == ' ')
            {
                this.op = (sender as Button).Text[0];

                this.txtPrmry.Text += " " + op + " ";
            }
            else if ((this.txtScndry.Text == "0" || this.txtScndry.Text == "") && (sender as Button).Text == "-")
            {
                this.txtScndry.Text = (sender as Button).Text;
            }
            else
            {
                if (this.txtScndry.Text != "" && this.txtScndry.Text != "0" && this.txtScndry.Text != "-" && this.txtScndry.Text != "." && this.txtScndry.Text != "-.")
                {
                    this.number1 = this.txtScndry.Text;
                    this.op = (sender as Button).Text[0];

                    this.txtPrmry.Text = this.number1 + " " + op + " ";
                    this.txtScndry.Text = "";
                }
            }
        }
        /// <summary>
        /// Equal operator....
        /// evaluate the current numbers given.
        /// then write the result and number in a file as a history.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEqual_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.txtScndry.Text != "" && this.number1 != "" && op != ' ')
            {
                //storing data to write in file later..
                string fileNumber1 = this.number1;
                char fileop = op;


                this.number2 = this.txtScndry.Text;
                this.txtScndry.Text = "";

                if (op == '+')
                {
                    var result = Convert.ToDouble(number1) + Convert.ToDouble(number2);

                    this.txtPrmry.Text = Convert.ToString(result);

                    this.number1 = Convert.ToString(result);
                }
                else if (op == '-')
                {
                    var result = Convert.ToDouble(number1) - Convert.ToDouble(number2);

                    this.txtPrmry.Text = Convert.ToString(result);

                    this.number1 = Convert.ToString(result);
                }
                else if (op == '*')
                {
                    var result = Convert.ToDouble(number1) * Convert.ToDouble(number2);

                    this.txtPrmry.Text = Convert.ToString(result);

                    this.number1 = Convert.ToString(result);
                }
                else if (op == '/')
                {
                    //if(Convert.ToDouble(this.number2) == 0)
                    //{
                    //    return;
                    //}
                    var result = Convert.ToDouble(number1) / Convert.ToDouble(number2);

                    this.txtPrmry.Text = Convert.ToString(result);

                    this.number1 = Convert.ToString(result);
                }

                string filenumber2 = this.number2;
                string fileResult = this.number1;

                this.number2 = "";
                this.op = ' ';


                try
                {
                    string dir = Path.GetDirectoryName(
                        System.Reflection.Assembly.GetExecutingAssembly().Location);

                    string file = dir + @"\History.txt";
                    StreamWriter streamWriter = new StreamWriter(file, true);

                    streamWriter.WriteLine("\t" + fileNumber1);
                    streamWriter.WriteLine(fileop);
                    streamWriter.WriteLine("\t" + filenumber2);
                    streamWriter.WriteLine("----------------------------");
                    streamWriter.WriteLine(fileResult);
                    streamWriter.WriteLine();

                    streamWriter.Close();
                }
                catch(Exception excp)
                {
                    MessageBox.Show(excp + "\n\n[-]Unable to locate file to store history.");

                }
                
            }
        }

        /// <summary>
        /// erase(backspace) button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnErase_MouseClick(object sender, MouseEventArgs e)
        {
            if(this.txtScndry.Text != "")
            {
                this.txtScndry.Text = this.txtScndry.Text.Substring(0, this.txtScndry.Text.Length - 1);
            }
            else if(this.txtScndry.Text == "" && this.txtPrmry.Text != "")
            {
                this.txtScndry.Text = this.number1;
                this.number1 = "";
                this.txtPrmry.Text = "";
                this.op = ' ';
            }
        }

        /// <summary>
        /// Change Screen light Mode(Dark,light).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lightModeOnOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.colorCode = this.colorCode == 64 ? 244 : 64;

            this.BackColor = Color.FromArgb(colorCode, colorCode, colorCode);
        }

        //create new instance of the Calculator.
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Form1.formCount < 2)
            {
                Form1 newCalculator = new Form1();

                newCalculator.Show();
            }
            else
            {
                MessageBox.Show("Cannot make more than 2 duplicates.");
            }
        }

        /// <summary>
        /// View History
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string dir = Path.GetDirectoryName(
                         System.Reflection.Assembly.GetExecutingAssembly().Location);

                string file = dir + @"\History.txt";

                StreamReader streamReader = new StreamReader(file);

                string content = streamReader.ReadToEnd();

                streamReader.Close();
                content = content == "" ? "No History To Show..." : content;

                //MessageBox.Show()
                //MessageBox.Show(content);

                if(Form3.historyFormCount < 1)
                {
                    Form3 historyForm = new Form3(content);
                    historyForm.Show();

                }
                else
                {
                    MessageBox.Show("History Window Already open.");
                }
            }
            catch(System.IO.IOException)
            {
                //MessageBox.Show(excp + "\n\n[-]Unable to Locate History File!!!!");

                string dir = Path.GetDirectoryName(
                         System.Reflection.Assembly.GetExecutingAssembly().Location);

                string file = dir + @"\History.txt";
                File.WriteAllText(file, String.Empty);
            }
        }

        /// <summary>
        /// clear the content of History.txt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dir = Path.GetDirectoryName(
                         System.Reflection.Assembly.GetExecutingAssembly().Location);

            string file = dir + @"\History.txt";

            File.WriteAllText(file, String.Empty);
        }

        private void reportAProblemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormReport.reportFormCount < 1)
            {
                FormReport mailForm = new FormReport();

                mailForm.Show();
            }
            else
            {
                MessageBox.Show("Report Window Already Open!");
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Form1.formCount--;
        }
    }
}
