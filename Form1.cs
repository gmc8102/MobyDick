using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobyDick
{
    public partial class MobyDickWordCount : Form
    {
        Dictionary<string, int> StopWords = new Dictionary<string, int>();
        Dictionary<string, int> BookWords = new Dictionary<string, int>();
        DataTable dtStopWords = new DataTable();
        DataTable dtBookWords = new DataTable();

        public MobyDickWordCount()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmdExecute_Click(object sender, EventArgs e)
        {
            if (!GetStopWords())
            {
                tsMessage.Text = "Stop Words file not found.";
                return;
            }
            if (!GetBookWords())
            {
                tsMessage.Text = "Book file not found.";
                return;
            }
            tsMessage.Text = "";
            BuildTables();
            SwitchTables("Book");
        }

        private void CmdSwitch_Click(object sender, EventArgs e)
        {
            if (CmdSwitch.Text == "Book Words")
                SwitchTables("Stop");
            else
                SwitchTables("Book");
        }




        private bool GetStopWords()
        {
            if (!File.Exists(tbStopWords.Text))
                return false;
            StopWords = new Dictionary<string, int>();
            foreach (string line in System.IO.File.ReadLines(tbStopWords.Text))
            {
                if (line.Trim() == "")
                    continue;
                if (!StopWords.ContainsKey(line.Trim().ToLower()))
                    StopWords.Add(line.Trim().ToLower(), 0);
            }
            return true;
        }

        private bool GetBookWords()
        {
            Boolean bProcessing = false;
            char[] splitchars = { ' ', ',', '.', '/', '<', '>', '?', ';', '\'', ':', '"', '[', ']', '\\', '{', '}', '|', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+', '—', '-', '=', '‘', '’', '“', '”' };
            string sWord;

            if (!File.Exists(tbBook.Text))
                return false;
            BookWords = new Dictionary<string, int>();
            foreach (string line in System.IO.File.ReadLines(tbBook.Text))
            {
                if (line.Trim() == "")
                    continue;
                if (line.Length >= 10)
                {
                    if (line.Substring(0, 10) == "CHAPTER 1.")
                        bProcessing = true;
                    if (line.Substring(0, 10) == "End of Pro")
                        break;
                }
                if (!bProcessing)
                    continue;
                string[] words = line.Split(splitchars, StringSplitOptions.RemoveEmptyEntries);
                foreach (var word in words)
                {
                    sWord = word;
                    if (!(cbCase.Checked))
                        sWord = word.ToLower();
                    // Stop Words are never case sensitive, they are always handled in lower case. 
                    if (StopWords.ContainsKey(word.ToLower()))
                        StopWords[word.ToLower()] += 1;
                    else
                    {
                        if (!BookWords.ContainsKey(sWord))
                            BookWords.Add(sWord, 1);
                        else
                            BookWords[sWord] += 1;
                    }
                }
            }
            return true;
        }

        private void BuildTables()
        {
            DataRow dr;
            int iTake;

            dtStopWords = new DataTable();
            dtBookWords = new DataTable();

            // Stop Word Table
            dtStopWords.Columns.Add("StopWord", typeof(string));
            dtStopWords.Columns.Add("Count", typeof(int));
            foreach (var entry in StopWords)
            {
                dr = dtStopWords.NewRow();
                dr["StopWord"] = entry.Key;
                dr["Count"] = entry.Value;
                dtStopWords.Rows.Add(dr);
                dr.CancelEdit();
            }

            // Book Word Table
            dtBookWords.Columns.Add("BookWord", typeof(string));
            dtBookWords.Columns.Add("Count", typeof(int));
            if (cbTop100.Checked)
                iTake = 100;
            else
                iTake = BookWords.Count;
            foreach (var entry in BookWords.OrderByDescending(e => e.Value).Take(iTake))
            {
                dr = dtBookWords.NewRow();
                dr["BookWord"] = entry.Key;
                dr["Count"] = entry.Value;
                dtBookWords.Rows.Add(dr);
                dr.CancelEdit();
            }
        }

        private void SwitchTables(string sTable)
        {
            if (sTable == "Book")
            {
                dataGridView1.DataSource = dtBookWords;
                CmdSwitch.Text = "Book Words";
                tsMessage.Text = "Word Count: " + dtBookWords.Rows.Count;
            }
            else
            {
                dataGridView1.DataSource = dtStopWords;
                CmdSwitch.Text = "Stop Words";
                tsMessage.Text = "Word Count: " + dtStopWords.Rows.Count;
            }
        }

    }
}

