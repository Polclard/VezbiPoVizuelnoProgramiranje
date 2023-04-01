namespace PotrosuvackaKosnicka
{
    partial class novProdukt
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
            nameForma2 = new TextBox();
            cateogryForma2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            priceForma2 = new TextBox();
            dodadiForma2 = new Button();
            otkaziForma2 = new Button();
            SuspendLayout();
            // 
            // nameForma2
            // 
            nameForma2.Location = new Point(12, 46);
            nameForma2.Name = "nameForma2";
            nameForma2.Size = new Size(450, 23);
            nameForma2.TabIndex = 0;
            // 
            // cateogryForma2
            // 
            cateogryForma2.Location = new Point(12, 111);
            cateogryForma2.Name = "cateogryForma2";
            cateogryForma2.Size = new Size(450, 23);
            cateogryForma2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 2;
            label1.Text = "Име:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Категорија:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 155);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "Цена:";
            // 
            // priceForma2
            // 
            priceForma2.Location = new Point(12, 173);
            priceForma2.Name = "priceForma2";
            priceForma2.Size = new Size(100, 23);
            priceForma2.TabIndex = 5;
            // 
            // dodadiForma2
            // 
            dodadiForma2.Location = new Point(375, 202);
            dodadiForma2.Name = "dodadiForma2";
            dodadiForma2.Size = new Size(75, 23);
            dodadiForma2.TabIndex = 6;
            dodadiForma2.Text = "Додади";
            dodadiForma2.UseVisualStyleBackColor = true;
            dodadiForma2.Click += dodadiForma2_Click;
            // 
            // otkaziForma2
            // 
            otkaziForma2.Location = new Point(279, 202);
            otkaziForma2.Name = "otkaziForma2";
            otkaziForma2.Size = new Size(75, 23);
            otkaziForma2.TabIndex = 7;
            otkaziForma2.Text = "Откажи";
            otkaziForma2.UseVisualStyleBackColor = true;
            otkaziForma2.Click += otkaziForma2_Click;
            // 
            // novProdukt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 237);
            Controls.Add(otkaziForma2);
            Controls.Add(dodadiForma2);
            Controls.Add(priceForma2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cateogryForma2);
            Controls.Add(nameForma2);
            Name = "novProdukt";
            Text = "novProdukt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameForma2;
        private TextBox cateogryForma2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox priceForma2;
        private Button dodadiForma2;
        private Button otkaziForma2;
    }
}