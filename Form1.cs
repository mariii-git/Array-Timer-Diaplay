namespace arrayyyy
{
    public partial class Form1 : Form
    {
        string[] array1 = { "m", "g", "r", "p" };
        int index;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = 0;
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(index<array1.Length)
            {
                label1.Text = array1[index];
                index++;
            }
        }
    }
}
