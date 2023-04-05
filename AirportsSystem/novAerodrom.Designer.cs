namespace AirportsSystem
{
    partial class novAerodrom
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
            cancel = new Button();
            save = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxTownName = new TextBox();
            textBoxAirportName = new TextBox();
            textBoxShortName = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cancel);
            groupBox1.Controls.Add(save);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxTownName);
            groupBox1.Controls.Add(textBoxAirportName);
            groupBox1.Controls.Add(textBoxShortName);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 273);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Додади аеродром";
            // 
            // cancel
            // 
            cancel.Location = new Point(271, 215);
            cancel.Name = "cancel";
            cancel.Size = new Size(75, 23);
            cancel.TabIndex = 7;
            cancel.Text = "Откажи";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // save
            // 
            save.Location = new Point(6, 215);
            save.Name = "save";
            save.Size = new Size(75, 23);
            save.TabIndex = 6;
            save.Text = "Зачувај";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 79);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 5;
            label3.Text = "Име:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 4;
            label2.Text = "Град";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 147);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 3;
            label1.Text = "Кратенка:";
            // 
            // textBoxTownName
            // 
            textBoxTownName.Location = new Point(6, 37);
            textBoxTownName.Name = "textBoxTownName";
            textBoxTownName.Size = new Size(340, 23);
            textBoxTownName.TabIndex = 2;
            textBoxTownName.TextChanged += textBoxTownName_TextChanged;
            // 
            // textBoxAirportName
            // 
            textBoxAirportName.Location = new Point(6, 97);
            textBoxAirportName.Name = "textBoxAirportName";
            textBoxAirportName.Size = new Size(340, 23);
            textBoxAirportName.TabIndex = 1;
            textBoxAirportName.TextChanged += textBoxAirportName_TextChanged;
            // 
            // textBoxShortName
            // 
            textBoxShortName.Location = new Point(6, 165);
            textBoxShortName.Name = "textBoxShortName";
            textBoxShortName.Size = new Size(100, 23);
            textBoxShortName.TabIndex = 0;
            textBoxShortName.TextChanged += textBoxShortName_TextChanged;
            // 
            // novAerodrom
            // 
            AcceptButton = save;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancel;
            ClientSize = new Size(394, 297);
            Controls.Add(groupBox1);
            Name = "novAerodrom";
            Text = "Нов аеродром";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button cancel;
        private Button save;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxTownName;
        private TextBox textBoxAirportName;
        private TextBox textBoxShortName;
    }
}