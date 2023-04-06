namespace CashAccount
{
    partial class newProduct
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
            textBoxName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            numericUpDownPrice = new NumericUpDown();
            numericUpDownCode = new NumericUpDown();
            enter = new Button();
            cancel = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCode).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numericUpDownPrice);
            groupBox1.Controls.Add(numericUpDownCode);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(573, 235);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Податоци за продуктот";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(0, 121);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(520, 23);
            textBoxName.TabIndex = 5;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 171);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "Цена:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 103);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 3;
            label2.Text = "Име:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 33);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 2;
            label1.Text = "Код:";
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Location = new Point(0, 189);
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(120, 23);
            numericUpDownPrice.TabIndex = 1;
            // 
            // numericUpDownCode
            // 
            numericUpDownCode.Location = new Point(0, 51);
            numericUpDownCode.Name = "numericUpDownCode";
            numericUpDownCode.Size = new Size(120, 23);
            numericUpDownCode.TabIndex = 0;
            numericUpDownCode.ValueChanged += numericUpDownCode_ValueChanged;
            // 
            // enter
            // 
            enter.Location = new Point(382, 266);
            enter.Name = "enter";
            enter.Size = new Size(75, 23);
            enter.TabIndex = 1;
            enter.Text = "Внеси";
            enter.UseVisualStyleBackColor = true;
            enter.Click += enter_Click;
            // 
            // cancel
            // 
            cancel.Location = new Point(510, 266);
            cancel.Name = "cancel";
            cancel.Size = new Size(75, 23);
            cancel.TabIndex = 2;
            cancel.Text = "Откажи";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // newProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 301);
            Controls.Add(cancel);
            Controls.Add(enter);
            Controls.Add(groupBox1);
            Name = "newProduct";
            Text = "Нов продукт";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxName;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numericUpDownPrice;
        private NumericUpDown numericUpDownCode;
        private Button enter;
        private Button cancel;
    }
}