using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Cryptography;

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
            try
            {
                Encryptor.EncryptFile(textBox_FileFrom.Text, textBox_FileTo.Text, textBox_Pass.Text);
                MessageBox.Show($"Plik zaszyfrowany:\n{textBox_FileFrom.Text} -> {textBox_FileTo.Text}");
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Nie udało się odczytać pliku.\n\nSzczegóły: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd\n\nSzczegóły: {ex.Message}\n\n{ex.StackTrace}");
            }
        }
        private void button_Decryption_Click(object sender, EventArgs e)
        {
            if (!areAllFieldsFilledIn())
            {
                MessageBox.Show("Wypełnij wszystkie pola.");
                return;
            }
            try
            {
                Encryptor.DecryptFile(textBox_FileFrom.Text, textBox_FileTo.Text, textBox_Pass.Text);
                MessageBox.Show($"Plik odszyfrowany:\n{textBox_FileFrom.Text} -> {textBox_FileTo.Text}");
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Nie udało się odczytać pliku.\n\nSzczegóły: {ex.Message}");
            }
            catch (Exception ex) when (ex is CryptographicException || ex is ArgumentOutOfRangeException)
            {
                MessageBox.Show($"Błąd dekryptarzu.\n\nSzczegóły: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd dekryptarzu.\n\nSzczegóły: {ex.Message}\n\n{ex.StackTrace}");
            }
        }

        private void button_Pass_Click(object sender, EventArgs e)
        {
            if (textBox_Pass.PasswordChar == '\0')
            {
                textBox_Pass.PasswordChar = '*';
                button_Pass.Text = "🙈";
            }
            else
            {
                textBox_Pass.PasswordChar = '\0';
                button_Pass.Text = "👁";
            }
        }

        private void textBox_Pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
