namespace ExamProblems
{
    partial class ExamForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numericUpDownYear = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            comboBox1Month = new ComboBox();
            buttonCancel = new Button();
            buttonAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownYear
            // 
            numericUpDownYear.Location = new Point(21, 27);
            numericUpDownYear.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            numericUpDownYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            numericUpDownYear.Name = "numericUpDownYear";
            numericUpDownYear.Size = new Size(327, 23);
            numericUpDownYear.TabIndex = 0;
            numericUpDownYear.Value = new decimal(new int[] { 1900, 0, 0, 0 });
            numericUpDownYear.ValueChanged += numericUpDownYear_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Година";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 87);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 2;
            label2.Text = "Месец:";
            // 
            // comboBox1Month
            // 
            comboBox1Month.FormattingEnabled = true;
            comboBox1Month.Items.AddRange(new object[] { "Јануари", "Февруари", "Март", "Април", "Мај", "Јуни", "Јули", "Август", "Септември", "Октомври", "Ноември", "Декември" });
            comboBox1Month.Location = new Point(21, 105);
            comboBox1Month.Name = "comboBox1Month";
            comboBox1Month.Size = new Size(327, 23);
            comboBox1Month.TabIndex = 3;
            comboBox1Month.SelectedIndexChanged += comboBox1Month_SelectedIndexChanged;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(112, 136);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Откажи";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(208, 136);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Додади";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // ExamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 171);
            Controls.Add(buttonAdd);
            Controls.Add(buttonCancel);
            Controls.Add(comboBox1Month);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDownYear);
            Name = "ExamForm";
            Text = "ExamForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownYear;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1Month;
        private Button buttonCancel;
        private Button buttonAdd;
    }
}