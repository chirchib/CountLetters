namespace TextAnalizer_v0._2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelInputRichTextBox = new System.Windows.Forms.Panel();
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.panelOutputRichTextBox = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonRus = new System.Windows.Forms.RadioButton();
            this.radioButtonEng = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonOpenFileDialog = new System.Windows.Forms.Button();
            this.panelInputRichTextBox.SuspendLayout();
            this.panelOutputRichTextBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panelInputRichTextBox
            // 
            this.panelInputRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInputRichTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelInputRichTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.panelInputRichTextBox.Controls.Add(this.richTextBoxInput);
            this.panelInputRichTextBox.Location = new System.Drawing.Point(12, 12);
            this.panelInputRichTextBox.Name = "panelInputRichTextBox";
            this.panelInputRichTextBox.Size = new System.Drawing.Size(508, 287);
            this.panelInputRichTextBox.TabIndex = 0;
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxInput.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(508, 287);
            this.richTextBoxInput.TabIndex = 0;
            this.richTextBoxInput.Text = "";
            // 
            // panelOutputRichTextBox
            // 
            this.panelOutputRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOutputRichTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelOutputRichTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.panelOutputRichTextBox.Controls.Add(this.dataGridView1);
            this.panelOutputRichTextBox.Location = new System.Drawing.Point(12, 341);
            this.panelOutputRichTextBox.Name = "panelOutputRichTextBox";
            this.panelOutputRichTextBox.Size = new System.Drawing.Size(508, 300);
            this.panelOutputRichTextBox.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(502, 294);
            this.dataGridView1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.radioButtonRus);
            this.flowLayoutPanel1.Controls.Add(this.radioButtonEng);
            this.flowLayoutPanel1.Controls.Add(this.checkBox1);
            this.flowLayoutPanel1.Controls.Add(this.buttonOpenFileDialog);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 305);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(508, 30);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // radioButtonRus
            // 
            this.radioButtonRus.AutoSize = true;
            this.radioButtonRus.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButtonRus.Location = new System.Drawing.Point(3, 3);
            this.radioButtonRus.Name = "radioButtonRus";
            this.radioButtonRus.Size = new System.Drawing.Size(104, 25);
            this.radioButtonRus.TabIndex = 0;
            this.radioButtonRus.Text = "Русский язык";
            this.radioButtonRus.UseVisualStyleBackColor = true;
            this.radioButtonRus.CheckedChanged += new System.EventHandler(this.radioButtonRus_CheckedChanged);
            // 
            // radioButtonEng
            // 
            this.radioButtonEng.AutoSize = true;
            this.radioButtonEng.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButtonEng.Location = new System.Drawing.Point(113, 3);
            this.radioButtonEng.Name = "radioButtonEng";
            this.radioButtonEng.Size = new System.Drawing.Size(119, 25);
            this.radioButtonEng.TabIndex = 1;
            this.radioButtonEng.Text = "Английкий язык";
            this.radioButtonEng.UseVisualStyleBackColor = true;
            this.radioButtonEng.CheckedChanged += new System.EventHandler(this.radioButtonEng_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox1.Location = new System.Drawing.Point(238, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(130, 25);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Какой-то чекбокс";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonOpenFileDialog
            // 
            this.buttonOpenFileDialog.AutoSize = true;
            this.buttonOpenFileDialog.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonOpenFileDialog.Location = new System.Drawing.Point(374, 3);
            this.buttonOpenFileDialog.Name = "buttonOpenFileDialog";
            this.buttonOpenFileDialog.Size = new System.Drawing.Size(127, 25);
            this.buttonOpenFileDialog.TabIndex = 3;
            this.buttonOpenFileDialog.Text = "Открыть из файла";
            this.buttonOpenFileDialog.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 653);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelOutputRichTextBox);
            this.Controls.Add(this.panelInputRichTextBox);
            this.MinimumSize = new System.Drawing.Size(550, 700);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelInputRichTextBox.ResumeLayout(false);
            this.panelOutputRichTextBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panelInputRichTextBox;
        private System.Windows.Forms.Panel panelOutputRichTextBox;
        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButtonRus;
        private System.Windows.Forms.RadioButton radioButtonEng;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonOpenFileDialog;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

