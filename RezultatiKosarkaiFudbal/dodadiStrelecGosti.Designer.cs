namespace RezultatiKosarkaiFudbal
{
    partial class dodadiStrelecGosti
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
            panel1 = new Panel();
            otkaziVtoraForma = new Button();
            dodadiStrelecVtoraForma = new Button();
            poeniMinutaVtoraForma = new TextBox();
            igracVtoraForma = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(otkaziVtoraForma);
            panel1.Controls.Add(dodadiStrelecVtoraForma);
            panel1.Controls.Add(poeniMinutaVtoraForma);
            panel1.Controls.Add(igracVtoraForma);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 131);
            panel1.TabIndex = 1;
            // 
            // otkaziVtoraForma
            // 
            otkaziVtoraForma.Location = new Point(187, 105);
            otkaziVtoraForma.Name = "otkaziVtoraForma";
            otkaziVtoraForma.Size = new Size(75, 23);
            otkaziVtoraForma.TabIndex = 6;
            otkaziVtoraForma.Text = "Откажи";
            otkaziVtoraForma.UseVisualStyleBackColor = true;
            otkaziVtoraForma.Click += otkaziVtoraForma_Click;
            // 
            // dodadiStrelecVtoraForma
            // 
            dodadiStrelecVtoraForma.Location = new Point(15, 105);
            dodadiStrelecVtoraForma.Name = "dodadiStrelecVtoraForma";
            dodadiStrelecVtoraForma.Size = new Size(75, 23);
            dodadiStrelecVtoraForma.TabIndex = 5;
            dodadiStrelecVtoraForma.Text = "Додади";
            dodadiStrelecVtoraForma.UseVisualStyleBackColor = true;
            dodadiStrelecVtoraForma.Click += dodadiStrelecVtoraForma_Click;
            // 
            // poeniMinutaVtoraForma
            // 
            poeniMinutaVtoraForma.Location = new Point(114, 66);
            poeniMinutaVtoraForma.Name = "poeniMinutaVtoraForma";
            poeniMinutaVtoraForma.Size = new Size(115, 23);
            poeniMinutaVtoraForma.TabIndex = 4;
            // 
            // igracVtoraForma
            // 
            igracVtoraForma.Location = new Point(114, 26);
            igracVtoraForma.Name = "igracVtoraForma";
            igracVtoraForma.Size = new Size(115, 23);
            igracVtoraForma.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 74);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 2;
            label1.Text = "Поени/Минута:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 29);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Играч:";
            // 
            // dodadiStrelecGosti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 155);
            Controls.Add(panel1);
            Name = "dodadiStrelecGosti";
            Text = " ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button otkaziVtoraForma;
        private Button dodadiStrelecVtoraForma;
        private TextBox poeniMinutaVtoraForma;
        private TextBox igracVtoraForma;
        private Label label1;
        private Label label2;
    }
}