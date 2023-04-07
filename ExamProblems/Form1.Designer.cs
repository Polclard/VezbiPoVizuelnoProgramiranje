namespace ExamProblems
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            listBoxExams = new ListBox();
            buttonDeleteExam = new Button();
            buttonAddExam = new Button();
            groupBox2 = new GroupBox();
            textBoxExercise2 = new TextBox();
            label4 = new Label();
            buttonSave2 = new Button();
            numericUpDownPoints2 = new NumericUpDown();
            label2 = new Label();
            groupBox3 = new GroupBox();
            buttonSave1 = new Button();
            textBoxExercise1 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            numericUpDownPoints1 = new NumericUpDown();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPoints2).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPoints1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBoxExams);
            groupBox1.Controls.Add(buttonDeleteExam);
            groupBox1.Controls.Add(buttonAddExam);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(295, 483);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Испити";
            // 
            // listBoxExams
            // 
            listBoxExams.FormattingEnabled = true;
            listBoxExams.ItemHeight = 15;
            listBoxExams.Location = new Point(6, 22);
            listBoxExams.Name = "listBoxExams";
            listBoxExams.Size = new Size(283, 379);
            listBoxExams.TabIndex = 5;
            listBoxExams.SelectedIndexChanged += listBoxExams_SelectedIndexChanged;
            // 
            // buttonDeleteExam
            // 
            buttonDeleteExam.Location = new Point(6, 454);
            buttonDeleteExam.Name = "buttonDeleteExam";
            buttonDeleteExam.Size = new Size(283, 23);
            buttonDeleteExam.TabIndex = 4;
            buttonDeleteExam.Text = "Избриши испит";
            buttonDeleteExam.UseVisualStyleBackColor = true;
            buttonDeleteExam.Click += button2_Click;
            // 
            // buttonAddExam
            // 
            buttonAddExam.Location = new Point(6, 425);
            buttonAddExam.Name = "buttonAddExam";
            buttonAddExam.Size = new Size(283, 23);
            buttonAddExam.TabIndex = 3;
            buttonAddExam.Text = "Додади испит";
            buttonAddExam.UseVisualStyleBackColor = true;
            buttonAddExam.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxExercise2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(buttonSave2);
            groupBox2.Controls.Add(numericUpDownPoints2);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(345, 249);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(349, 246);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Задача 2";
            // 
            // textBoxExercise2
            // 
            textBoxExercise2.Location = new Point(6, 40);
            textBoxExercise2.Multiline = true;
            textBoxExercise2.Name = "textBoxExercise2";
            textBoxExercise2.Size = new Size(337, 124);
            textBoxExercise2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 22);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 11;
            label4.Text = "Опис:";
            // 
            // buttonSave2
            // 
            buttonSave2.Location = new Point(268, 217);
            buttonSave2.Name = "buttonSave2";
            buttonSave2.Size = new Size(75, 23);
            buttonSave2.TabIndex = 11;
            buttonSave2.Text = "Зачувај";
            buttonSave2.UseVisualStyleBackColor = true;
            buttonSave2.Click += buttonSave2_Click;
            // 
            // numericUpDownPoints2
            // 
            numericUpDownPoints2.Location = new Point(6, 185);
            numericUpDownPoints2.Name = "numericUpDownPoints2";
            numericUpDownPoints2.Size = new Size(120, 23);
            numericUpDownPoints2.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 167);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 0;
            label2.Text = "Поени:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonSave1);
            groupBox3.Controls.Add(textBoxExercise1);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(numericUpDownPoints1);
            groupBox3.Location = new Point(345, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(349, 231);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Задача 1";
            // 
            // buttonSave1
            // 
            buttonSave1.Location = new Point(268, 202);
            buttonSave1.Name = "buttonSave1";
            buttonSave1.Size = new Size(75, 23);
            buttonSave1.TabIndex = 10;
            buttonSave1.Text = "Зачувај";
            buttonSave1.UseVisualStyleBackColor = true;
            buttonSave1.Click += buttonSave1_Click;
            // 
            // textBoxExercise1
            // 
            textBoxExercise1.Location = new Point(6, 37);
            textBoxExercise1.Multiline = true;
            textBoxExercise1.Name = "textBoxExercise1";
            textBoxExercise1.Size = new Size(337, 128);
            textBoxExercise1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 9;
            label3.Text = "Опис:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 168);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 8;
            label1.Text = "Поени:";
            // 
            // numericUpDownPoints1
            // 
            numericUpDownPoints1.Location = new Point(6, 186);
            numericUpDownPoints1.Name = "numericUpDownPoints1";
            numericUpDownPoints1.Size = new Size(120, 23);
            numericUpDownPoints1.TabIndex = 7;
            // 
            // Form1
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 507);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPoints2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPoints1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox listBoxExams;
        private Button buttonDeleteExam;
        private Button buttonAddExam;
        private GroupBox groupBox2;
        private Label label2;
        private GroupBox groupBox3;
        private Label label3;
        private Label label1;
        private NumericUpDown numericUpDownPoints1;
        private Button buttonSave2;
        private NumericUpDown numericUpDownPoints2;
        private Button buttonSave1;
        private Label label4;
        private TextBox textBoxExercise2;
        private TextBox textBoxExercise1;
    }
}