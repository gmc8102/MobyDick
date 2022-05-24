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
        Dictionary<string, int> GoWords = new Dictionary<string, int>();

        public MobyDickWordCount()
        {
            InitializeComponent();
            GetStopWords();
            GetGoWords();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetStopWords()
        {
            System.Console.WriteLine("Stop Words...");
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

        private void GetGoWords()
        {
            System.Console.WriteLine("Go Words...");
            Boolean bProcessing = false;
            //char[] charsToTrim = { '*', ',', '.', ' ', '\'' };
            char[] splitchars = { ' ', ',', '.', '-', '—' };   
            int ctLines = 0;
            int ctWords = 0;
            foreach (string line in System.IO.File.ReadLines(@"C:\temp\mobydick.txt"))
            {
                if (line != "")
                {
                    if (line.Length >= 10)
                    {
                        if (line.Substring(0, 10) == "CHAPTER 1.")
                            bProcessing = true;
                        if (line.Substring(0, 10) == "End of Pro")
                            break;
                    }
                    if (bProcessing)
                    {
                        ctLines++;
                        string[] words = line.Split(splitchars, StringSplitOptions.RemoveEmptyEntries);  // ;
                        foreach (var word in words)
                        { 
                            // if word is not in the dictionary,
                            if (!GoWords.ContainsKey(word))
                                // add it to the dictionary
                                GoWords.Add(word, 1);
                            else
                            {
                                // update the entry by by adding 1 to the int.
                                GoWords[word] += 1;
                            };
                            ctWords++;
                        }
                    }
                }
            }
            System.Console.WriteLine("There are {0} lines.", ctLines);
            System.Console.WriteLine("There are {0} words.", ctWords);
            System.Console.WriteLine("There are {0} entries.", GoWords.Count);
        }
    }
}
