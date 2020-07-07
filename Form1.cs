using CountLetters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextAnalizer_v0._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAnalizeText_Click(object sender, EventArgs e)
        {
            string inputText = richTextBoxInput.Text;
            Analyzer analyzer = new Analyzer(inputText);

            string temp = "";
            foreach (var item in analyzer.DisplayEuDictionary())
            {
                temp += item.Key;
                temp += " - ";
                temp += item.Value;
                temp += "\n";
            }
            richTextBoxOutput.Text = temp;

        }
    }
}
