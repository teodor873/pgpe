namespace zadachi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("chao");
            MessageBoxButtons.YesNoCancel.Equals(button1.Text);
            MessageBoxIcon icon = MessageBoxIcon.Question;

            DialogResult dialog = MessageBox.Show("");
           
        }
    }
}
