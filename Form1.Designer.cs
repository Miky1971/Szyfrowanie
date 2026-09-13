namespace Szyfrowanie
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
            button_Encryption = new Button();
            button_Decryption = new Button();
            openFileDialog_FileFrom = new OpenFileDialog();
            textBox_FileFrom = new TextBox();
            label_FileFrom = new Label();
            textBox_FileTo = new TextBox();
            textBox_Pass = new TextBox();
            label_FileTo = new Label();
            label_Pass = new Label();
            button_FileFrom = new Button();
            button_FileTo = new Button();
            saveFileDialog_FileTo = new SaveFileDialog();
            button_Pass = new Button();
            SuspendLayout();
            // 
            // button_Encryption
            // 
            button_Encryption.Location = new Point(9, 99);
            button_Encryption.Name = "button_Encryption";
            button_Encryption.Size = new Size(111, 26);
            button_Encryption.TabIndex = 0;
            button_Encryption.Text = "Szyfrowanie";
            button_Encryption.UseVisualStyleBackColor = true;
            button_Encryption.Click += button_Encryption_Click;
            // 
            // button_Decryption
            // 
            button_Decryption.Location = new Point(339, 99);
            button_Decryption.Name = "button_Decryption";
            button_Decryption.Size = new Size(111, 26);
            button_Decryption.TabIndex = 1;
            button_Decryption.Text = "Deszyfrowanie";
            button_Decryption.UseVisualStyleBackColor = true;
            button_Decryption.Click += button_Decryption_Click;
            // 
            // openFileDialog_FileFrom
            // 
            openFileDialog_FileFrom.FileName = "openFileDialog_FileFrom";
            openFileDialog_FileFrom.FileOk += openFileDialog_FileFrom_FileOk;
            // 
            // textBox_FileFrom
            // 
            textBox_FileFrom.Location = new Point(100, 12);
            textBox_FileFrom.Name = "textBox_FileFrom";
            textBox_FileFrom.Size = new Size(330, 23);
            textBox_FileFrom.TabIndex = 2;
            textBox_FileFrom.TextChanged += textBox_FileFrom_TextChanged;
            // 
            // label_FileFrom
            // 
            label_FileFrom.AutoSize = true;
            label_FileFrom.Location = new Point(54, 15);
            label_FileFrom.Name = "label_FileFrom";
            label_FileFrom.Size = new Size(29, 15);
            label_FileFrom.TabIndex = 3;
            label_FileFrom.Text = "Plik:";
            label_FileFrom.Click += label_FileFrom_Click;
            // 
            // textBox_FileTo
            // 
            textBox_FileTo.Location = new Point(100, 41);
            textBox_FileTo.Name = "textBox_FileTo";
            textBox_FileTo.Size = new Size(330, 23);
            textBox_FileTo.TabIndex = 4;
            // 
            // textBox_Pass
            // 
            textBox_Pass.Location = new Point(100, 70);
            textBox_Pass.Name = "textBox_Pass";
            textBox_Pass.PasswordChar = '*';
            textBox_Pass.Size = new Size(328, 23);
            textBox_Pass.TabIndex = 5;
            textBox_Pass.TextChanged += textBox_Pass_TextChanged;
            // 
            // label_FileTo
            // 
            label_FileTo.AutoSize = true;
            label_FileTo.Location = new Point(9, 45);
            label_FileTo.Name = "label_FileTo";
            label_FileTo.Size = new Size(85, 15);
            label_FileTo.TabIndex = 6;
            label_FileTo.Text = "Plik wynikowy:";
            label_FileTo.Click += label_FileTo_Click;
            // 
            // label_Pass
            // 
            label_Pass.AutoSize = true;
            label_Pass.Location = new Point(54, 73);
            label_Pass.Name = "label_Pass";
            label_Pass.Size = new Size(40, 15);
            label_Pass.TabIndex = 7;
            label_Pass.Text = "Hasło:";
            // 
            // button_FileFrom
            // 
            button_FileFrom.Location = new Point(427, 12);
            button_FileFrom.Name = "button_FileFrom";
            button_FileFrom.Size = new Size(23, 23);
            button_FileFrom.TabIndex = 8;
            button_FileFrom.Text = "...";
            button_FileFrom.UseVisualStyleBackColor = true;
            button_FileFrom.Click += button_FileFrom_Click;
            // 
            // button_FileTo
            // 
            button_FileTo.Location = new Point(427, 41);
            button_FileTo.Name = "button_FileTo";
            button_FileTo.Size = new Size(23, 23);
            button_FileTo.TabIndex = 9;
            button_FileTo.Text = "...";
            button_FileTo.UseVisualStyleBackColor = true;
            button_FileTo.Click += button_FileTo_Click;
            // 
            // button_Pass
            // 
            button_Pass.Location = new Point(427, 70);
            button_Pass.Name = "button_Pass";
            button_Pass.Size = new Size(23, 23);
            button_Pass.TabIndex = 10;
            button_Pass.Text = "👁";
            button_Pass.UseVisualStyleBackColor = true;
            button_Pass.Click += button_Pass_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 141);
            Controls.Add(button_Pass);
            Controls.Add(button_FileTo);
            Controls.Add(button_FileFrom);
            Controls.Add(label_Pass);
            Controls.Add(label_FileTo);
            Controls.Add(textBox_Pass);
            Controls.Add(textBox_FileTo);
            Controls.Add(label_FileFrom);
            Controls.Add(textBox_FileFrom);
            Controls.Add(button_Decryption);
            Controls.Add(button_Encryption);
            Name = "Form1";
            Text = "Szyfrowanie / Deszyfrowanie plików";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Encryption;
        private Button button_Decryption;
        private OpenFileDialog openFileDialog_FileFrom;
        private TextBox textBox_FileFrom;
        private Label label_FileFrom;
        private TextBox textBox_FileTo;
        private TextBox textBox_Pass;
        private Label label_FileTo;
        private Label label_Pass;
        private Button button_FileFrom;
        private Button button_FileTo;
        private SaveFileDialog saveFileDialog_FileTo;
        private Button button_Pass;
    }
}
