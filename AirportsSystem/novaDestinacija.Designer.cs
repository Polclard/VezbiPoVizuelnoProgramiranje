namespace AirportsSystem
{
    partial class novaDestinacija
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
            groupBox1 = new GroupBox();
            numericUpDownPrice = new NumericUpDown();
            numericUpDownLength = new NumericUpDown();
            cancel = new Button();
            add = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxName = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLength).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDownPrice);
            groupBox1.Controls.Add(numericUpDownLength);
            groupBox1.Controls.Add(cancel);
            groupBox1.Controls.Add(add);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 262);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Додади дестинација";
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Location = new Point(6, 170);
            numericUpDownPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(120, 23);
            numericUpDownPrice.TabIndex = 9;
            numericUpDownPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownPrice.ValueChanged += numericUpDownPrice_ValueChanged;
            // 
            // numericUpDownLength
            // 
            numericUpDownLength.Location = new Point(6, 99);
            numericUpDownLength.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownLength.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownLength.Name = "numericUpDownLength";
            numericUpDownLength.Size = new Size(120, 23);
            numericUpDownLength.TabIndex = 8;
            numericUpDownLength.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownLength.ValueChanged += numericUpDownLength_ValueChanged;
            // 
            // cancel
            // 
            cancel.Location = new Point(245, 215);
            cancel.Name = "cancel";
            cancel.Size = new Size(75, 23);
            cancel.TabIndex = 7;
            cancel.Text = "Откажи";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // add
            // 
            add.Location = new Point(6, 215);
            add.Name = "add";
            add.Size = new Size(75, 23);
            add.TabIndex = 6;
            add.Text = "Додади";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 5;
            label3.Text = "Име:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 81);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 4;
            label2.Text = "Должина:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 152);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "Цена:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(6, 37);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(337, 23);
            textBoxName.TabIndex = 2;
            textBoxName.TextChanged += textBoxTownName_TextChanged;
            // 
            // novaDestinacija
            // 
            AcceptButton = add;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancel;
            ClientSize = new Size(394, 286);
            Controls.Add(groupBox1);
            Name = "novaDestinacija";
            Text = "Нова дестинација";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLength).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button cancel;
        private Button add;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxName;
        private NumericUpDown numericUpDownPrice;
        private NumericUpDown numericUpDownLength;
    }
}