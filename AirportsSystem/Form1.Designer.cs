namespace AirportsSystem
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
            label1 = new Label();
            label2 = new Label();
            listAirports = new ListBox();
            listDestinations = new ListBox();
            addAirport = new Button();
            deleteAirport = new Button();
            addDestination = new Button();
            groupBox1 = new GroupBox();
            textBoxMostExpensiveDestination = new TextBox();
            textBoxAverageLengthOfDestinations = new TextBox();
            label4 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Аеродроми";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(408, 9);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 1;
            label2.Text = "Дестинации";
            // 
            // listAirports
            // 
            listAirports.FormattingEnabled = true;
            listAirports.ItemHeight = 15;
            listAirports.Location = new Point(12, 27);
            listAirports.Name = "listAirports";
            listAirports.Size = new Size(315, 304);
            listAirports.TabIndex = 2;
            listAirports.SelectedIndexChanged += listAirports_SelectedIndexChanged;
            // 
            // listDestinations
            // 
            listDestinations.FormattingEnabled = true;
            listDestinations.ItemHeight = 15;
            listDestinations.Location = new Point(408, 27);
            listDestinations.Name = "listDestinations";
            listDestinations.Size = new Size(315, 304);
            listDestinations.TabIndex = 3;
            // 
            // addAirport
            // 
            addAirport.Location = new Point(12, 349);
            addAirport.Name = "addAirport";
            addAirport.Size = new Size(282, 23);
            addAirport.TabIndex = 4;
            addAirport.Text = "Додади аеродром";
            addAirport.UseVisualStyleBackColor = true;
            addAirport.Click += addAirport_Click;
            // 
            // deleteAirport
            // 
            deleteAirport.Location = new Point(12, 406);
            deleteAirport.Name = "deleteAirport";
            deleteAirport.Size = new Size(282, 23);
            deleteAirport.TabIndex = 5;
            deleteAirport.Text = "Избриши аеродром";
            deleteAirport.UseVisualStyleBackColor = true;
            deleteAirport.Click += deleteAirport_Click;
            // 
            // addDestination
            // 
            addDestination.Location = new Point(12, 461);
            addDestination.Name = "addDestination";
            addDestination.Size = new Size(282, 23);
            addDestination.TabIndex = 6;
            addDestination.Text = "Додади дестинација";
            addDestination.UseVisualStyleBackColor = true;
            addDestination.Click += addDestination_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxMostExpensiveDestination);
            groupBox1.Controls.Add(textBoxAverageLengthOfDestinations);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(408, 337);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(315, 147);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Дестинации";
            // 
            // textBoxMostExpensiveDestination
            // 
            textBoxMostExpensiveDestination.Location = new Point(6, 50);
            textBoxMostExpensiveDestination.Name = "textBoxMostExpensiveDestination";
            textBoxMostExpensiveDestination.ReadOnly = true;
            textBoxMostExpensiveDestination.Size = new Size(303, 23);
            textBoxMostExpensiveDestination.TabIndex = 3;
            // 
            // textBoxAverageLengthOfDestinations
            // 
            textBoxAverageLengthOfDestinations.Location = new Point(6, 118);
            textBoxAverageLengthOfDestinations.Name = "textBoxAverageLengthOfDestinations";
            textBoxAverageLengthOfDestinations.ReadOnly = true;
            textBoxAverageLengthOfDestinations.Size = new Size(303, 23);
            textBoxAverageLengthOfDestinations.TabIndex = 2;
            textBoxAverageLengthOfDestinations.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 87);
            label4.Name = "label4";
            label4.Size = new Size(208, 15);
            label4.TabIndex = 1;
            label4.Text = "Просечна должина на дестинациите";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 32);
            label3.Name = "label3";
            label3.Size = new Size(125, 15);
            label3.TabIndex = 0;
            label3.Text = "Најскапа дестинација";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 496);
            Controls.Add(groupBox1);
            Controls.Add(addDestination);
            Controls.Add(deleteAirport);
            Controls.Add(addAirport);
            Controls.Add(listDestinations);
            Controls.Add(listAirports);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox listAirports;
        private ListBox listDestinations;
        private Button addAirport;
        private Button deleteAirport;
        private Button addDestination;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private TextBox textBoxMostExpensiveDestination;
        private TextBox textBoxAverageLengthOfDestinations;
    }
}