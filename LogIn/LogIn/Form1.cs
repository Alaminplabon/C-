namespace LogIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr= MessageBox.Show("Plabon is the Best Option For you","Confirm"
                ,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Exit";
        }
    }
}