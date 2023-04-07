namespace ExamProblems
{
    public partial class Form1 : Form
    {
        public static Exam exam { get; set; }
        public Form1()
        {
            InitializeComponent();
            Exam exam1 = new Exam("January", 2023, new Exercise("Опис задача 1", 70), new Exercise("Опис задача 2", 30));
            Exam exam2 = new Exam("June", 2023, new Exercise("Опис задача 1аб", 90), new Exercise("Опис задача 2аб", 100));
            listBoxExams.Items.Add(exam1);
            listBoxExams.Items.Add(exam2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBoxExams.SelectedItem != null)
            {
                listBoxExams.Items.Remove(listBoxExams.SelectedItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExamForm eF = new ExamForm();
            eF.ShowDialog();
            if (exam != null)
            {
                listBoxExams.Items.Add(exam);
            }
        }

        private void listBoxExams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxExams.SelectedItems.Count <= 0)
            {
                buttonDeleteExam.Enabled = false;
            }
            else
            {
                buttonDeleteExam.Enabled = true;

                Exam? selectedExam = listBoxExams.SelectedItem as Exam;

                if (selectedExam != null)
                {

                    textBoxExercise1.Text = selectedExam.exercise1.ToString();
                    textBoxExercise1.Text = selectedExam.exercise1.ToString();
                    numericUpDownPoints1.Value = selectedExam.exercise1.Points;

                    textBoxExercise2.Text = selectedExam.exercise2.ToString();
                    textBoxExercise2.Text = selectedExam.exercise2.ToString();
                    numericUpDownPoints2.Value = selectedExam.exercise2.Points;
                }


            }
        }

        private void buttonSave1_Click(object sender, EventArgs e)
        {
            Exam? selectedExam = listBoxExams.SelectedItem as Exam;
            if (selectedExam != null)
            {
                selectedExam.exercise1.Description = textBoxExercise1.Text;
                selectedExam.exercise1.Points = (int)numericUpDownPoints1.Value;
            }
        }

        private void buttonSave2_Click(object sender, EventArgs e)
        {
            Exam? selectedExam = listBoxExams.SelectedItem as Exam;
            if (selectedExam != null)
            {
                selectedExam.exercise2.Description = textBoxExercise2.Text;
                selectedExam.exercise2.Points = (int)numericUpDownPoints2.Value;
            }
        }
    }
}