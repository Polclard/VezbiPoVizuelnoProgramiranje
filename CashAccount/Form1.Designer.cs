namespace CashAccount
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
            addNew = new Button();
            numericUpDownQuantity = new NumericUpDown();
            addToReceipt = new Button();
            label1 = new Label();
            listBoxProducts = new ListBox();
            groupBox2 = new GroupBox();
            numericUpDownTax = new NumericUpDown();
            listBoxReceipt = new ListBox();
            deleteRecord = new Button();
            textBoxForPay = new TextBox();
            textBoxTotal = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTax).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(addNew);
            groupBox1.Controls.Add(numericUpDownQuantity);
            groupBox1.Controls.Add(addToReceipt);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(listBoxProducts);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(329, 416);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Продукти";
            // 
            // addNew
            // 
            addNew.Location = new Point(6, 372);
            addNew.Name = "addNew";
            addNew.Size = new Size(297, 23);
            addNew.TabIndex = 3;
            addNew.Text = "Додади нов";
            addNew.UseVisualStyleBackColor = true;
            addNew.Click += addNew_Click;
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(77, 287);
            numericUpDownQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(226, 23);
            numericUpDownQuantity.TabIndex = 4;
            numericUpDownQuantity.TextAlign = HorizontalAlignment.Right;
            numericUpDownQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // addToReceipt
            // 
            addToReceipt.Location = new Point(6, 343);
            addToReceipt.Name = "addToReceipt";
            addToReceipt.Size = new Size(297, 23);
            addToReceipt.TabIndex = 2;
            addToReceipt.Text = "Додади во сметка";
            addToReceipt.UseVisualStyleBackColor = true;
            addToReceipt.Click += addToReceipt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 295);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 1;
            label1.Text = "Количина:";
            // 
            // listBoxProducts
            // 
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.ItemHeight = 15;
            listBoxProducts.Location = new Point(6, 22);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(297, 244);
            listBoxProducts.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numericUpDownTax);
            groupBox2.Controls.Add(listBoxReceipt);
            groupBox2.Controls.Add(deleteRecord);
            groupBox2.Controls.Add(textBoxForPay);
            groupBox2.Controls.Add(textBoxTotal);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(347, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(332, 416);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Сметка";
            // 
            // numericUpDownTax
            // 
            numericUpDownTax.Location = new Point(77, 320);
            numericUpDownTax.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            numericUpDownTax.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownTax.Name = "numericUpDownTax";
            numericUpDownTax.Size = new Size(238, 23);
            numericUpDownTax.TabIndex = 8;
            numericUpDownTax.TextAlign = HorizontalAlignment.Right;
            numericUpDownTax.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownTax.ValueChanged += numericUpDownTax_ValueChanged;
            // 
            // listBoxReceipt
            // 
            listBoxReceipt.FormattingEnabled = true;
            listBoxReceipt.ItemHeight = 15;
            listBoxReceipt.Location = new Point(11, 22);
            listBoxReceipt.Name = "listBoxReceipt";
            listBoxReceipt.Size = new Size(304, 214);
            listBoxReceipt.TabIndex = 7;
            // 
            // deleteRecord
            // 
            deleteRecord.Location = new Point(11, 242);
            deleteRecord.Name = "deleteRecord";
            deleteRecord.Size = new Size(304, 23);
            deleteRecord.TabIndex = 6;
            deleteRecord.Text = "Избриши ставка";
            deleteRecord.UseVisualStyleBackColor = true;
            deleteRecord.Click += deleteRecord_Click;
            // 
            // textBoxForPay
            // 
            textBoxForPay.Location = new Point(77, 364);
            textBoxForPay.Name = "textBoxForPay";
            textBoxForPay.Size = new Size(238, 23);
            textBoxForPay.TabIndex = 5;
            // 
            // textBoxTotal
            // 
            textBoxTotal.Location = new Point(77, 274);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.Size = new Size(238, 23);
            textBoxTotal.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 372);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 2;
            label4.Text = "За плаќање:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 328);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 1;
            label3.Text = "Данок (%):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-1, 282);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 0;
            label2.Text = "Вкупно:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 440);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTax).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button addNew;
        private Button addToReceipt;
        private Label label1;
        private ListBox listBoxProducts;
        private GroupBox groupBox2;
        private ListBox listBoxReceipt;
        private Button deleteRecord;
        private TextBox textBoxForPay;
        private TextBox textBoxTax;
        private TextBox textBoxTotal;
        private Label label4;
        private Label label3;
        private Label label2;
        private NumericUpDown numericUpDownQuantity;
        private NumericUpDown numericUpDownTax;
    }
}