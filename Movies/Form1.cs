namespace Movies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        { 
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            List<Movies> movie = new List<Movies>();
            string director;
            director =txt1.Text;
            string title;
            title = txt1.Text;
            string janr;
            string company;
            string answer;
            //company
            if (rb4.Checked)
            {
                company = rb4.Text;
            }
            else if (rb5.Checked)
            {
                company = rb5.Text;
            }
            else if (rb6.Checked)
            {
                company = rb6.Text;
            }
            else
            {
                return;
            }
            //janr
            if (rb7.Checked)
            {
                janr = rb7.Text;
            }
            else if (rb8.Checked)
            {
                janr = rb8.Text;
            }
            else if (rb9.Checked)
            {
                janr = rb9.Text;
            }
            else if (rb10.Checked)
            {
                janr = rb10.Text;
            }
            else if (rb11.Checked)
            {
                janr = rb11.Text;
            }
            else 
            {
                return; 
            }
            //16+
            if(chk1.Checked)
            {
                answer = chk1.Text;
            }
            else if(chk2.Checked)
            {
                answer=chk2.Text;
            }
            else
            {
                return;
            }
            if (txt1.Text.Length < 3 || txt2.Text.Length < 3)
            {
                MessageBox.Show("Invaid");
            }

            DialogResult ans = MessageBox.Show($"Вие въведохте: {title},с режисьор: {director}," +
                $"{janr}, {company}, 16+ : {answer}, " +
                " Потвърждавате ли?"+
                MessageBoxButtons.YesNo);

            if (ans == DialogResult.Yes)
            {
                MessageBox.Show("Въведено");
                Application.Restart();
            }
            else if (ans == DialogResult.No)
            {
                return;
            }


        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
