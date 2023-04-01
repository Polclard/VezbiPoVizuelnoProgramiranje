namespace PotrosuvackaKosnicka
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
            listPr = new ListBox();
            listCa = new ListBox();
            groupBox1 = new GroupBox();
            name = new TextBox();
            category = new TextBox();
            price = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dodadiVoKosnicka = new Button();
            izbrisiOdKosnicka = new Button();
            dodadiNovProdukt = new Button();
            izbrishiProdukt = new Button();
            isprazniJaKosnickata = new Button();
            isprazniJaListatasoProdukti = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            total = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listPr
            // 
            listPr.FormattingEnabled = true;
            listPr.ItemHeight = 15;
            listPr.Location = new Point(12, 27);
            listPr.Name = "listPr";
            listPr.Size = new Size(180, 454);
            listPr.TabIndex = 0;
            listPr.SelectedIndexChanged += listPr_SelectedIndexChanged;
            // 
            // listCa
            // 
            listCa.FormattingEnabled = true;
            listCa.ItemHeight = 15;
            listCa.Location = new Point(429, 27);
            listCa.Name = "listCa";
            listCa.Size = new Size(181, 364);
            listCa.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(name);
            groupBox1.Controls.Add(category);
            groupBox1.Controls.Add(price);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(198, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(225, 208);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Детали за продуктот";
            // 
            // name
            // 
            name.Location = new Point(18, 57);
            name.Name = "name";
            name.ReadOnly = true;
            name.Size = new Size(201, 23);
            name.TabIndex = 5;
            // 
            // category
            // 
            category.Location = new Point(18, 114);
            category.Name = "category";
            category.ReadOnly = true;
            category.Size = new Size(201, 23);
            category.TabIndex = 4;
            // 
            // price
            // 
            price.Location = new Point(18, 171);
            price.Name = "price";
            price.ReadOnly = true;
            price.Size = new Size(107, 23);
            price.TabIndex = 3;
            price.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 153);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "Цена:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 96);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Категорија:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 39);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Име:";
            // 
            // dodadiVoKosnicka
            // 
            dodadiVoKosnicka.Location = new Point(198, 248);
            dodadiVoKosnicka.Name = "dodadiVoKosnicka";
            dodadiVoKosnicka.Size = new Size(225, 23);
            dodadiVoKosnicka.TabIndex = 3;
            dodadiVoKosnicka.Text = "Додади во кошничка >>";
            dodadiVoKosnicka.UseVisualStyleBackColor = true;
            dodadiVoKosnicka.Click += dodadiVoKosnicka_Click;
            // 
            // izbrisiOdKosnicka
            // 
            izbrisiOdKosnicka.Location = new Point(198, 292);
            izbrisiOdKosnicka.Name = "izbrisiOdKosnicka";
            izbrisiOdKosnicka.Size = new Size(225, 23);
            izbrisiOdKosnicka.TabIndex = 4;
            izbrisiOdKosnicka.Text = "Избриши од кошничка";
            izbrisiOdKosnicka.UseVisualStyleBackColor = true;
            izbrisiOdKosnicka.Click += izbrisiOdKosnicka_Click;
            // 
            // dodadiNovProdukt
            // 
            dodadiNovProdukt.Location = new Point(198, 334);
            dodadiNovProdukt.Name = "dodadiNovProdukt";
            dodadiNovProdukt.Size = new Size(225, 23);
            dodadiNovProdukt.TabIndex = 5;
            dodadiNovProdukt.Text = "Додади нов продукт";
            dodadiNovProdukt.UseVisualStyleBackColor = true;
            dodadiNovProdukt.Click += dodadiNovProdukt_Click;
            // 
            // izbrishiProdukt
            // 
            izbrishiProdukt.Location = new Point(198, 377);
            izbrishiProdukt.Name = "izbrishiProdukt";
            izbrishiProdukt.Size = new Size(225, 23);
            izbrishiProdukt.TabIndex = 6;
            izbrishiProdukt.Text = "Избриши продукт";
            izbrishiProdukt.UseVisualStyleBackColor = true;
            izbrishiProdukt.Click += izbrishiProdukt_Click;
            // 
            // isprazniJaKosnickata
            // 
            isprazniJaKosnickata.Location = new Point(385, 490);
            isprazniJaKosnickata.Name = "isprazniJaKosnickata";
            isprazniJaKosnickata.Size = new Size(225, 23);
            isprazniJaKosnickata.TabIndex = 7;
            isprazniJaKosnickata.Text = "Испразни ја кошничката?";
            isprazniJaKosnickata.UseVisualStyleBackColor = true;
            isprazniJaKosnickata.Click += isprazniJaKosnickata_Click;
            // 
            // isprazniJaListatasoProdukti
            // 
            isprazniJaListatasoProdukti.Location = new Point(12, 490);
            isprazniJaListatasoProdukti.Name = "isprazniJaListatasoProdukti";
            isprazniJaListatasoProdukti.Size = new Size(225, 23);
            isprazniJaListatasoProdukti.TabIndex = 8;
            isprazniJaListatasoProdukti.Text = "Испразни ја листата со продукти?";
            isprazniJaListatasoProdukti.UseVisualStyleBackColor = true;
            isprazniJaListatasoProdukti.Click += isprazniJaListatasoProdukti_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 9;
            label4.Text = "Листа на продукти:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(429, 9);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 10;
            label5.Text = "Кошничка:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(394, 443);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 11;
            label6.Text = "Вкупно:";
            // 
            // total
            // 
            total.Location = new Point(450, 435);
            total.Name = "total";
            total.ReadOnly = true;
            total.Size = new Size(160, 23);
            total.TabIndex = 12;
            total.TextChanged += total_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 525);
            Controls.Add(total);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(isprazniJaListatasoProdukti);
            Controls.Add(isprazniJaKosnickata);
            Controls.Add(izbrishiProdukt);
            Controls.Add(dodadiNovProdukt);
            Controls.Add(izbrisiOdKosnicka);
            Controls.Add(dodadiVoKosnicka);
            Controls.Add(groupBox1);
            Controls.Add(listCa);
            Controls.Add(listPr);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listPr;
        private ListBox listCa;
        private GroupBox groupBox1;
        private TextBox category;
        private TextBox price;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox name;
        private Button dodadiVoKosnicka;
        private Button izbrisiOdKosnicka;
        private Button dodadiNovProdukt;
        private Button izbrishiProdukt;
        private Button isprazniJaKosnickata;
        private Button isprazniJaListatasoProdukti;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox total;
    }
}