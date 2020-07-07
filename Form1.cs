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

    enum Language
    {
        None = 0,
        Russian = 1,
        English = 2
    }


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupInputText();
            SetupDataGridView(Language.None);
            
        }



        private void SetupInputText()
        {
            richTextBoxInput.Text = "Политика Александра 1 была направлена на защиту и расширение территории государства, усовершенствование аппарата государственного управления и повышение" +
                " авторитета страны на международной арене.По данной реформе крестьяне получали личную свободу (без выкупа) и наделялись общегражданскими правами. Крестьяне получали землю " +
                "в собственность не безвозмездно, а должны были выкупать у помещиков. Городская контрреформа. С 1892 года число избирателей из-за увеличения имущественного ценза сокращается, " +
                "а все постановления думы одобрялись губернским начальством. Также было ограничено количество заседаний думы. Городское управление, таким образом, осуществлялось правительством." +
                "Судебная контрреформа. С 1887 года повысился образовательный и имущественный ценз для присяжных заседателей.Это смогло увеличить количество дворян в суде.Были ограничены гласность " +
                "и публичность, а из судебного ведения были изъяты политические дела.Контрреформы печати и образования. Был существенно ужесточён контроль над учебными заведениями.Университетским" +
                " уставом от 1884 года упразднялась вся автономия университетов.Профессора и сам ректор назначались правительством, а плата за обучение была поднята в два раза. Кроме того, была " +
                "сформирована специальная инспекция, которая осуществляла надзор за учащимися.";
        }

        private void SetupDataGridViewNone()
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            dataGridView1.GridColor = Color.Black;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ReadOnly = true;


            dataGridView1.Columns[0].Name = "Буква";
            dataGridView1.Columns[1].Name = "Количество";
            dataGridView1.Columns[2].Name = "Частота";
        }

        private void SetupDataGridViewRussian()
        {


            dataGridView1.Name = "Английский алфавит";


            string inputText = richTextBoxInput.Text;
            Analyzer analyzer = new Analyzer(inputText);

            dataGridView1.Rows.Clear();
            foreach (var item in analyzer.DisplayRuDictionary())
            {
                string[] row = { string.Concat(item.Key), string.Concat(item.Value) };
                dataGridView1.Rows.Add(row);
            }
            int index = 0;
            foreach (var item in analyzer.DisplayProbabilityRuSymbols())
            {
                
                string prop = string.Concat(item.Value);
                dataGridView1.Rows[index].Cells[2].Value = prop;
                index++;
            }




        }

        private void SetupDataGridViewEnglish()
        {

            dataGridView1.Name = "Английский алфавит";

            string inputText = richTextBoxInput.Text;
            Analyzer analyzer = new Analyzer(inputText);

            dataGridView1.Rows.Clear();


            foreach (var item in analyzer.DisplayEuDictionary())
            {
                string[] row = { string.Concat(item.Key), string.Concat(item.Value)};
                
                dataGridView1.Rows.Add(row);
            }

            int index = 0;
            foreach (var item in analyzer.DisplayProbabilityEuSymbols())
            {

                string prop = string.Concat(item.Value);
                dataGridView1.Rows[index].Cells[2].Value = prop;
                index++;
            }
        }



        private void SetupDataGridView(Language language)
        {
            switch (language)
            {
                case Language.None:
                    SetupDataGridViewNone();
                    break;
                case Language.Russian:
                    SetupDataGridViewRussian();
                    break;
                case Language.English:
                    SetupDataGridViewEnglish();
                    break;
                default:
                    SetupDataGridViewNone();
                    break;
            }

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





        }

        private void radioButtonRus_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEng.Checked) SetupDataGridView(Language.English);
            else if (radioButtonRus.Checked) SetupDataGridView(Language.Russian);
        }

        private void radioButtonEng_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEng.Checked) SetupDataGridView(Language.English);
            else if (radioButtonRus.Checked) SetupDataGridView(Language.Russian);
        }
    }
}
