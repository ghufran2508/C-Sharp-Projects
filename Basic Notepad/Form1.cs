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

namespace Basic_Notepad
{
    public partial class Form1 : Form
    {
        string currentFilePath;
        string currentFile;
        string[] dict;
        string current_word;
        string currentContent;

        private bool match(string dict_str, string str2)
        {
            dict_str = dict_str.ToLower();
            str2 = str2.ToLower();
            bool exist = false;
            for(int i = 0; i < dict_str.Length; i++)
            {
                exist = false;
                if(dict_str[i] == str2[0])
                {
                    exist = true;
                    int indx = i;
                    for(int j = 0; j < str2.Length; j++)
                    {
                        if (indx == dict_str.Length) return false;
                        if(str2[j] != dict_str[indx])
                        {
                            exist = false;
                            break;
                        }
                        indx++;
                    }

                    if (exist == true) return true;
                }
            }

            return false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void openCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog chooseFile = new OpenFileDialog();
            chooseFile.ShowDialog();

            if(chooseFile.FileName != "")
            {
                this.txtFilePath.Text = chooseFile.FileName;
                string path = this.txtFilePath.Text;
                path = path.Replace("\\", "/");
                string content = "";

                StreamReader reader = new StreamReader(path);

                content = reader.ReadToEnd();

                reader.Close();

                this.richTextBox1.Text = content;
                this.currentContent = content;

                if (txtFileSIze.Text[txtFileSIze.Text.Length - 1] == '*' && txtFileSIze.Text.Length != 0)
                {
                    this.txtFileSIze.Text = txtFileSIze.Text.Substring(0, txtFileSIze.Text.Length - 1);
                }

                this.currentFilePath = chooseFile.FileName;
                this.currentFile = chooseFile.SafeFileName;
            }
            chooseFile.Dispose();
        }

        private void saveCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.currentFilePath != "" && this.currentFilePath != null)
            {
                string path = this.currentFilePath;
                path = path.Replace("\\", "/");

                StreamWriter writer = new StreamWriter(path);

                writer.WriteLine(this.richTextBox1.Text);

                writer.Close();

                if(txtFileSIze.Text[txtFileSIze.Text.Length-1] == '*' && txtFileSIze.Text.Length != 0)
                {
                    this.txtFileSIze.Text = txtFileSIze.Text.Substring(0, txtFileSIze.Text.Length - 1);
                }

                this.currentContent = this.richTextBox1.Text;
            }
            else if(this.richTextBox1.Text == "")
            {

            }
            else
            {
                SaveFileDialog saveFile = new SaveFileDialog();

                saveFile.ShowDialog();

                if(saveFile.FileName != "" && saveFile.FileName != null) 
                {
                    this.currentFilePath = saveFile.FileName;
                    this.txtFilePath.Text = this.currentFilePath;
                    int index = this.currentFilePath.LastIndexOf('\\');
                    this.currentFile = this.currentFilePath.Substring(index + 1);

                    StreamWriter writer = new StreamWriter(this.currentFilePath.Replace("\\", "/"));

                    writer.Write(this.richTextBox1.Text);

                    writer.Close();

                    if (txtFileSIze.Text[txtFileSIze.Text.Length - 1] == '*' && txtFileSIze.Text.Length != 0)
                    {
                        this.txtFileSIze.Text = txtFileSIze.Text.Substring(0, txtFileSIze.Text.Length - 1);
                    }

                    this.currentContent = this.richTextBox1.Text;
                }

                saveFile.Dispose();
            }
        }

        private void newCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.currentFilePath = this.currentFile = "";

            this.txtFilePath.Text = this.richTextBox1.Text = "";

            this.txtFileSIze.Text = "";

            this.currentContent = "";

            this.current_word = "";
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void saveASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.txtFilePath.Text == "" && this.richTextBox1.Text == "")
            {

            }
            else
            {
                SaveFileDialog saveFile = new SaveFileDialog();

                saveFile.ShowDialog();

                if (saveFile.FileName != "" && saveFile.FileName != null)
                {
                    this.currentFilePath = saveFile.FileName;
                    this.txtFilePath.Text = this.currentFilePath;
                    int index = this.currentFilePath.LastIndexOf('\\');
                    this.currentFile = this.currentFilePath.Substring(index + 1);

                    StreamWriter writer = new StreamWriter(this.currentFilePath.Replace("\\", "/"));

                    writer.Write(this.richTextBox1.Text);

                    writer.Close();

                    if (txtFileSIze.Text[txtFileSIze.Text.Length - 1] == '*' && txtFileSIze.Text.Length != 0)
                    {
                        this.txtFileSIze.Text = txtFileSIze.Text.Substring(0, txtFileSIze.Text.Length - 1);
                    }

                    this.currentContent = this.richTextBox1.Text;
                }

                saveFile.Dispose();
            }
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == (Keys.Control | Keys.S))
            {
                if (this.currentFilePath != "" && this.currentFilePath != null)
                {
                    string path = this.currentFilePath;
                    path = path.Replace("\\", "/");

                    StreamWriter writer = new StreamWriter(path);

                    writer.WriteLine(this.richTextBox1.Text);

                    writer.Close();

                    if (txtFileSIze.Text[txtFileSIze.Text.Length - 1] == '*' && txtFileSIze.Text.Length != 0)
                    {
                        this.txtFileSIze.Text = txtFileSIze.Text.Substring(0, txtFileSIze.Text.Length - 1);
                    }

                    this.currentContent = this.richTextBox1.Text;
                }
                else if (this.richTextBox1.Text == "")
                {

                }
                else
                {
                    SaveFileDialog saveFile = new SaveFileDialog();

                    saveFile.ShowDialog();

                    if (saveFile.FileName != "" && saveFile.FileName != null)
                    {
                        this.currentFilePath = saveFile.FileName;
                        this.txtFilePath.Text = this.currentFilePath;
                        int index = this.currentFilePath.LastIndexOf('\\');
                        this.currentFile = this.currentFilePath.Substring(index + 1);

                        StreamWriter writer = new StreamWriter(this.currentFilePath.Replace("\\", "/"));

                        writer.Write(this.richTextBox1.Text);

                        writer.Close();

                        if (txtFileSIze.Text[txtFileSIze.Text.Length - 1] == '*' && txtFileSIze.Text.Length != 0)
                        {
                            this.txtFileSIze.Text = txtFileSIze.Text.Substring(0, txtFileSIze.Text.Length - 1);
                        }

                        this.currentContent = this.richTextBox1.Text;
                    }

                    saveFile.Dispose();
                }
            }
            else if(e.KeyData == (Keys.Control | Keys.O))
            {
                OpenFileDialog chooseFile = new OpenFileDialog();
                chooseFile.ShowDialog();

                if (chooseFile.FileName != "")
                {
                    this.txtFilePath.Text = chooseFile.FileName;
                    string path = this.txtFilePath.Text;
                    path = path.Replace("\\", "/");
                    string content = "";

                    StreamReader reader = new StreamReader(path);

                    content = reader.ReadToEnd();

                    reader.Close();

                    this.richTextBox1.Text = content;
                    this.currentContent = content;


                    if (txtFileSIze.Text[txtFileSIze.Text.Length - 1] == '*' && txtFileSIze.Text.Length != 0)
                    {
                        this.txtFileSIze.Text = txtFileSIze.Text.Substring(0, txtFileSIze.Text.Length - 1);
                    }

                    this.currentFilePath = chooseFile.FileName;
                    this.currentFile = chooseFile.SafeFileName;
                }
                chooseFile.Dispose();
            }
            else if(e.KeyData == (Keys.Control | Keys.N))
            {
                this.currentFilePath = this.currentFile = "";

                this.txtFilePath.Text = this.richTextBox1.Text = "";

                this.txtFileSIze.Text = "";

                this.current_word = "";

                this.currentContent = "";
            }
            else if(e.KeyData == (Keys.Control | Keys.B))
            {
                if(richTextBox1.Font.Bold == false)
                {
                    richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Bold);
                }
                else
                {
                    richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Regular);
                }
            }
            else if(e.KeyData == (Keys.Control | Keys.I))
            {
                if (richTextBox1.Font.Italic == false)
                {
                    richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Italic);
                }
                else
                {
                    richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Regular);
                }
            }
            else
            {
                if(e.KeyData == Keys.Space)
                {
                    current_word = "";
                    this.rtxtSuggestion.Text = "";
                }
                else if(e.KeyData == Keys.Back)
                {
                    if (richTextBox1.Text == "")
                    {
                        this.current_word = "";
                        return;
                    }
                    if(current_word == "" || current_word == null) { }
                    else
                    {
                        current_word = current_word.Substring(0, current_word.Length - 1);
                        if (current_word == "") return;
                        string data = "";

                        for (int i = 0; i < dict.Length; i++)
                        {
                            if (match(dict[i], current_word))
                            {
                                data += dict[i] + "\n";
                            }
                        }

                        this.rtxtSuggestion.Text = data;
                    }
                }
                else
                {
                    current_word += e.KeyData;

                    string data = "";

                    for(int i = 0; i < dict.Length; i++)
                    {
                        if(match(dict[i],current_word))
                        {
                            data += dict[i] + "\n";
                        }
                    }

                    this.rtxtSuggestion.Text = data;
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.txtFileSIze.Text = Convert.ToString(this.richTextBox1.Text.Length)+"*";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string dir = Path.GetDirectoryName(
                         System.Reflection.Assembly.GetExecutingAssembly().Location);

                string file = dir + @"\Word List.txt";
                string content = "";

                StreamReader reader = new StreamReader(file);
                content = reader.ReadToEnd();

                reader.Close();


                var list = content.Split('\n');
                dict = new string[10000];
                for (int i = 0; i < 10000; i++)
                {
                    dict[i] = Convert.ToString(list[i]);
                }
            }
            catch
            {
                dict = new string[1];
                dict[0] = "";
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = this.currentContent;

            if (txtFileSIze.Text[txtFileSIze.Text.Length - 1] == '*' && txtFileSIze.Text.Length != 0)
            {
                this.txtFileSIze.Text = txtFileSIze.Text.Substring(0, txtFileSIze.Text.Length - 1);
            }
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Font.Bold == false)
            {
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Bold);
            }
            else
            {
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Regular);
            }
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Font.Italic == false)
            {
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Italic);
            }
            else
            {
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Regular);
            }
        }

        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.BackColor == Color.MidnightBlue)
            {
                this.BackColor = Color.White;
                this.txtFilePath.BackColor = Color.White;
                this.txtFileSIze.BackColor = Color.White;
                this.rtxtSuggestion.BackColor = Color.White;
                this.richTextBox1.BackColor = Color.White;

                this.ForeColor = Color.Black;
                this.txtFilePath.ForeColor = Color.Black;
                this.txtFileSIze.ForeColor = Color.Black;
                this.rtxtSuggestion.ForeColor = Color.Black;
                this.richTextBox1.ForeColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.MidnightBlue;
                this.txtFilePath.BackColor = Color.DimGray;
                this.txtFileSIze.BackColor = Color.DimGray;
                this.rtxtSuggestion.BackColor = Color.DimGray;
                this.richTextBox1.BackColor = Color.DimGray;

                this.ForeColor = Color.White;
                this.txtFilePath.ForeColor = Color.White;
                this.txtFileSIze.ForeColor = Color.White;
                this.rtxtSuggestion.ForeColor = Color.White;
                this.richTextBox1.ForeColor = Color.White;
            }
        }
    }
}
