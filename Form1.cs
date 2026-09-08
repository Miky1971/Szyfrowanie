namespace Szyfrowanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog_FileFrom_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button_Decryption_Click(object sender, EventArgs e)
        {
            if (!areAllFieldsFilledIn())
            {
                MessageBox.Show("Wypełnij wszystkie pola.");
                return;
            }
        }

        private void textBox_FileFrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_FileTo_Click(object sender, EventArgs e)
        {

        }

        private void button_FileFrom_Click(object sender, EventArgs e)
        {
            if (openFileDialog_FileFrom.ShowDialog() == DialogResult.OK)
            {
                textBox_FileFrom.Text = openFileDialog_FileFrom.FileName;
            }
        }

        private void label_FileFrom_Click(object sender, EventArgs e)
        {

        }

        private void button_FileTo_Click(object sender, EventArgs e)
        {
            if (saveFileDialog_FileTo.ShowDialog() == DialogResult.OK)
            {
                textBox_FileTo.Text = saveFileDialog_FileTo.FileName;
            }
        }

        private bool areAllFieldsFilledIn()
        {
            if (textBox_FileFrom.Text == string.Empty || textBox_FileTo.Text == string.Empty || textBox_Pass.Text == string.Empty) return false;
            else return true;
        }

        private void button_Encryption_Click(object sender, EventArgs e)
        {
            if (!areAllFieldsFilledIn())
            {
                MessageBox.Show("Wypełnij wszystkie pola.");
                return;
            }
        }
    }
}
