using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobyDick
{
    public partial class MobyDickWordCount : Form
    {
        Dictionary<string, int> StopWords = new Dictionary<string, int>();

        public MobyDickWordCount()
        {
            InitializeComponent();
            GetStopWords();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetStopWords()
        {
            int ctLines = 0;
            int ctBlanks = 0;
            int ctDups = 0;
            foreach (string line in System.IO.File.ReadLines(@"C:\temp\stop-words.txt"))
            {
                if (line == "")
                    ctBlanks++;
                else
                {
                    try
                    {
                        StopWords.Add(line, 0);
                    }
                    catch (Exception)
                    {
                        ctDups++;
                    }
                }
                ctLines++;
            }
            System.Console.WriteLine("There are {0} lines.", ctLines);
            System.Console.WriteLine("There are {0} blanks.", ctBlanks);
            System.Console.WriteLine("There are {0} duplicates.", ctDups);
            System.Console.WriteLine("There are {0} entries.", StopWords.Count);
        }
    }
}
