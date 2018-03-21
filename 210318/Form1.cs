﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _210318
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            private void openToolStripMenuItem_Click(object sender, EventArgs e)
            {
                openFileDialog1.FileName = "";
                openFileDialog1.Filter = "Text Files|*.txt";
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    try
                    {
                        using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                        {
                            richTextBox1.Clear();
                            while (| sr.EndOfStream)
                            {
                                string line = sr.ReadLine();
                                richTextBox1.AppendText(line + "\n");
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show(openFileDialog1.FileName + " failed to open.");
                    }
                }
                Code for Save:
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(@"H:\test.txt"))
                {
                    sw.Write(richTextBox1.Text);
                }
            }
            catch
            {
                MessageBox.Show{ "test. txt failed to save."};
            }

        }

    }
}
}
