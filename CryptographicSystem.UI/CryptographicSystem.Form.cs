
namespace CryptographicSystem.UI
{
    using System.Globalization;
    using System.IO;
    using System.Windows.Forms;

    using BLL.Abstract;
    using BLL.Ciphers;
    using BLL.Ciphers.Enum;
    using Enum;

    /// <summary>
    /// The cryptographic system form.
    /// </summary>
    public partial class CryptographicSystemForm : Form
    {
        private string showText;
        private string caption;
        private string filename;
        private VermanCipher vermanCipher;
        private NGrammarSubstitutionCipher grammarSubstitutionCipher;
        private AutoKeyCipher autoKeyCipher;

        public CryptographicSystemForm()
        {
            this.InitializeComponent();
            this.CipherTypeComboBox.SelectedIndex = 0;
            this.openFileDialog1.Title = @"Выберите файл";
            this.openFileDialog1.Filter = @"txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.saveFileDialog1.Title = @"Выберите файл";
            this.saveFileDialog1.Filter = @"txt files (*.txt)|*.txt|All files (*.*)|*.*";
        }

        private void InputTextRichTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            this.CountSymbolLabel.Text = this.InputTextRichTextBox.Text.Length.ToString();
        }

        private void EncryptButton_Click(object sender, System.EventArgs e)
        {
            switch ((CipherType)this.CipherTypeComboBox.SelectedIndex)
            {
                case CipherType.SubstitutionCipher:
                    this.OutputTextRichTextBox.Text = LogicCipher.SubstitutionCipher(
                        this.InputTextRichTextBox.Text,
                        int.Parse(this.CountSubstitutionNumericUpDown.Value.ToString(CultureInfo.InvariantCulture)),
                        CryptType.Encrypt);
                    break;

                case CipherType.TranspositionCipher:
                    this.OutputTextRichTextBox.Text = LogicCipher.TranspositionCipher(
                        this.InputTextRichTextBox.Text,
                        this.KeyTextBox.Text,
                        CryptType.Encrypt);
                    break;

                case CipherType.VigenereCipher:
                    var vigenereCipherType = VigenereCipherType.None;
                    if (this.StraightCheckBox.Checked)
                        vigenereCipherType = VigenereCipherType.Straight;
                    if (this.ReverseCheckBox.Checked)
                        vigenereCipherType = VigenereCipherType.Reverse;
                    this.OutputTextRichTextBox.Text = LogicCipher.VigenereCipher(
                        this.InputTextRichTextBox.Text,
                        this.KeyTextBox.Text,
                        vigenereCipherType,
                        CryptType.Encrypt);
                    break;

                case CipherType.VermanCipher:
                    this.vermanCipher = new VermanCipher(int.Parse(this.CountSubstitutionNumericUpDown.Value.ToString(CultureInfo.InvariantCulture)));
                    this.OutputTextRichTextBox.Text = LogicCipher.VermanCipher(
                        this.InputTextRichTextBox.Text,
                        int.Parse(this.CountSubstitutionNumericUpDown.Value.ToString(CultureInfo.InvariantCulture)),
                        out this.showText,
                        ref this.vermanCipher,
                        CryptType.Encrypt);
                    this.ShowDialogButton.Enabled = true;
                    break;

                case CipherType.RunningKeyCipher:
                    this.OutputTextRichTextBox.Text = LogicCipher.RunningKeyCipher(
                        this.InputTextRichTextBox.Text,
                        this.KeyTextBox.Text,
                        CryptType.Encrypt);
                    break;

                case CipherType.CaesarCipher:
                    this.OutputTextRichTextBox.Text = LogicCipher.CaesarCipher(
                        this.InputTextRichTextBox.Text,
                        int.Parse(this.CountSubstitutionNumericUpDown.Value.ToString(CultureInfo.InvariantCulture)),
                        CryptType.Encrypt);
                    break;

                case CipherType.NGrammarSubstitutionCipher:
                    this.grammarSubstitutionCipher = new NGrammarSubstitutionCipher();
                    this.OutputTextRichTextBox.Text = LogicCipher.NGrammarSubstitutionCipher(
                        this.InputTextRichTextBox.Text,
                        out this.showText,
                        ref this.grammarSubstitutionCipher,
                        CryptType.Encrypt);
                    this.ShowDialogButton.Enabled = true;
                    break;

                case CipherType.PlayFairCipher:
                    this.OutputTextRichTextBox.Text = LogicCipher.PlayFairCipher(
                        this.InputTextRichTextBox.Text,
                        CryptType.Encrypt);
                    break;

                case CipherType.AutoKeyCipher:
                    var keyCipherType = AutoKeyCipherType.UseText;
                    if (this.StraightCheckBox.Checked)
                        keyCipherType = AutoKeyCipherType.UseText;
                    if (this.ReverseCheckBox.Checked)
                        keyCipherType = AutoKeyCipherType.UseCryptogram;
                    this.autoKeyCipher = new AutoKeyCipher(this.KeyTextBox.Text, keyCipherType);
                    this.OutputTextRichTextBox.Text = LogicCipher.AutoKeyCipher(
                        this.InputTextRichTextBox.Text,
                        this.KeyTextBox.Text,
                        ref this.showText,
                        ref this.autoKeyCipher,
                        keyCipherType,
                        CryptType.Encrypt);
                    this.ShowDialogButton.Enabled = true;
                    break;

                case CipherType.FractionalCipher:
                    this.OutputTextRichTextBox.Text = LogicCipher.FractionalCipher(
                        this.InputTextRichTextBox.Text,
                        CryptType.Encrypt);
                    break;
            }
        }

        private void DecryptButton_Click(object sender, System.EventArgs e)
        {
            switch ((CipherType)this.CipherTypeComboBox.SelectedIndex)
            {
                case CipherType.SubstitutionCipher:
                    this.OutputTextRichTextBox.Text = LogicCipher.SubstitutionCipher(
                        this.InputTextRichTextBox.Text,
                        int.Parse(this.CountSubstitutionNumericUpDown.Value.ToString(CultureInfo.InvariantCulture)),
                        CryptType.Decrypt);
                    break;

                case CipherType.TranspositionCipher:
                    this.OutputTextRichTextBox.Text = LogicCipher.TranspositionCipher(
                        this.InputTextRichTextBox.Text,
                        this.KeyTextBox.Text,
                        CryptType.Decrypt);
                    break;

                case CipherType.VigenereCipher:
                    var vigenereCipherType = VigenereCipherType.None;
                    if (this.StraightCheckBox.Checked)
                        vigenereCipherType = VigenereCipherType.Straight;
                    if (this.ReverseCheckBox.Checked)
                        vigenereCipherType = VigenereCipherType.Reverse;
                    this.OutputTextRichTextBox.Text = LogicCipher.VigenereCipher(
                        this.InputTextRichTextBox.Text,
                        this.KeyTextBox.Text,
                        vigenereCipherType,
                        CryptType.Decrypt);
                    break;

                case CipherType.VermanCipher:
                    this.OutputTextRichTextBox.Text = LogicCipher.VermanCipher(
                        this.InputTextRichTextBox.Text,
                        int.Parse(this.CountSubstitutionNumericUpDown.Value.ToString(CultureInfo.InvariantCulture)),
                        out this.showText,
                        ref this.vermanCipher,
                        CryptType.Decrypt);
                    this.ShowDialogButton.Enabled = true;
                    break;

                case CipherType.RunningKeyCipher:
                    this.OutputTextRichTextBox.Text = LogicCipher.RunningKeyCipher(
                        this.InputTextRichTextBox.Text,
                        this.KeyTextBox.Text,
                        CryptType.Decrypt);
                    break;

                case CipherType.CaesarCipher:
                    this.OutputTextRichTextBox.Text = LogicCipher.CaesarCipher(
                        this.InputTextRichTextBox.Text,
                        int.Parse(this.CountSubstitutionNumericUpDown.Value.ToString(CultureInfo.InvariantCulture)),
                        CryptType.Decrypt);
                    break;

                case CipherType.NGrammarSubstitutionCipher:
                    this.OutputTextRichTextBox.Text = LogicCipher.NGrammarSubstitutionCipher(
                        this.InputTextRichTextBox.Text,
                        out this.showText,
                        ref this.grammarSubstitutionCipher,
                        CryptType.Decrypt);
                    this.ShowDialogButton.Enabled = true;
                    break;

                case CipherType.PlayFairCipher:
                    this.OutputTextRichTextBox.Text = LogicCipher.PlayFairCipher(
                        this.InputTextRichTextBox.Text,
                        CryptType.Decrypt);
                    break;

                case CipherType.AutoKeyCipher:
                    var autoKeyCipher = AutoKeyCipherType.UseText;
                    if (this.StraightCheckBox.Checked)
                        autoKeyCipher = AutoKeyCipherType.UseText;
                    if (this.ReverseCheckBox.Checked)
                        autoKeyCipher = AutoKeyCipherType.UseCryptogram;
                    this.OutputTextRichTextBox.Text = LogicCipher.AutoKeyCipher(
                        this.InputTextRichTextBox.Text,
                        this.KeyTextBox.Text,
                        ref this.showText,
                        ref this.autoKeyCipher,
                        autoKeyCipher,
                        CryptType.Decrypt);
                    this.ShowDialogButton.Enabled = true;
                    break;

                case CipherType.FractionalCipher:
                    this.OutputTextRichTextBox.Text = LogicCipher.FractionalCipher(
                        this.InputTextRichTextBox.Text,
                        CryptType.Decrypt);
                    break;
            }
        }

        private void CipherTypeComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch ((CipherType)this.CipherTypeComboBox.SelectedIndex)
            {
                case CipherType.SubstitutionCipher:
                    this.MyCaption.Text = @"Количество подстановок:";
                    this.CountSubstitutionNumericUpDown.Visible = true;
                    this.KeyTextBox.Visible = false;
                    this.VigenereTypeGroupBox.Visible = false;
                    this.ShowDialogButton.Visible = false;
                    break;
                case CipherType.TranspositionCipher:
                    this.CountSubstitutionNumericUpDown.Visible = false;
                    this.MyCaption.Text = @"Ключ:";
                    this.KeyTextBox.Visible = true;
                    this.VigenereTypeGroupBox.Visible = false;
                    this.ShowDialogButton.Visible = false;
                    break;
                case CipherType.VigenereCipher:
                    this.CountSubstitutionNumericUpDown.Visible = false;
                    this.VigenereTypeGroupBox.Visible = true;
                    this.MyCaption.Text = @"Ключ:";
                    this.KeyTextBox.Visible = true;
                    this.ShowDialogButton.Visible = false;
                    this.VigenereTypeGroupBox.Text = @"Тип шифра Виженера";
                    this.StraightCheckBox.Text = @"Прямой вариант";
                    this.ReverseCheckBox.Text = @"Обратный вариант";
                    break;
                case CipherType.VermanCipher:
                    this.CountSubstitutionNumericUpDown.Visible = true;
                    this.VigenereTypeGroupBox.Visible = false;
                    this.MyCaption.Text = @"Длина ключа:";
                    this.KeyTextBox.Visible = false;
                    this.ShowDialogButton.Visible = true;
                    this.ShowDialogButton.Enabled = false;
                    this.ShowDialogButton.Text = @"Показать сгенерированный ключ";
                    this.caption = @"Сгеренированый ключ";
                    break;
                case CipherType.RunningKeyCipher:
                    this.CountSubstitutionNumericUpDown.Visible = false;
                    this.VigenereTypeGroupBox.Visible = false;
                    this.MyCaption.Text = @"Осмысленный текст:";
                    this.KeyTextBox.Visible = true;
                    this.ShowDialogButton.Visible = false;
                    break;
                case CipherType.CaesarCipher:
                    this.CountSubstitutionNumericUpDown.Visible = true;
                    this.VigenereTypeGroupBox.Visible = false;
                    this.MyCaption.Text = @"Длина сдвига:";
                    this.KeyTextBox.Visible = false;
                    this.ShowDialogButton.Visible = false;
                    break;
                case CipherType.NGrammarSubstitutionCipher:
                    this.CountSubstitutionNumericUpDown.Visible = false;
                    this.VigenereTypeGroupBox.Visible = false;
                    this.caption = @"Cформировання таблица подстановки";
                    this.MyCaption.Text = string.Empty;
                    this.KeyTextBox.Visible = false;
                    this.ShowDialogButton.Visible = true;
                    this.ShowDialogButton.Text = @"Показать таблицу подстановки";
                    this.ShowDialogButton.Enabled = false;
                    break;
                case CipherType.PlayFairCipher:
                    this.CountSubstitutionNumericUpDown.Visible = false;
                    this.VigenereTypeGroupBox.Visible = false;
                    this.MyCaption.Text = string.Empty;
                    this.KeyTextBox.Visible = false;
                    this.ShowDialogButton.Visible = true;
                    this.ShowDialogButton.Enabled = true;
                    this.showText = Cipher.GetMatrixAlphabetic();
                    this.ShowDialogButton.Text = @"Показать матрицу";
                    this.caption = "Матрица подастановки";
                    break;
                case CipherType.AutoKeyCipher:
                    this.CountSubstitutionNumericUpDown.Visible = false;
                    this.VigenereTypeGroupBox.Visible = true;
                    this.MyCaption.Text = @"Ключ:";
                    this.KeyTextBox.Visible = true;
                    this.ShowDialogButton.Visible = true;
                    this.ShowDialogButton.Enabled = false;
                    this.ShowDialogButton.Text = @"Показать значение ключа";
                    this.VigenereTypeGroupBox.Text = @"Тип ключа";
                    this.StraightCheckBox.Text = @"Текста";
                    this.ReverseCheckBox.Text = @"Криптограмма";
                    this.StraightCheckBox.Checked = true;
                    this.caption = @"Значение ключа";
                    break;
                case CipherType.FractionalCipher:
                    this.CountSubstitutionNumericUpDown.Visible = false;
                    this.VigenereTypeGroupBox.Visible = false;
                    this.MyCaption.Text = string.Empty;
                    this.ShowDialogButton.Visible = true;
                    this.ShowDialogButton.Enabled = true;
                    this.showText = Cipher.GetMatrixAlphabetic();
                    this.ShowDialogButton.Text = @"Показать матрицу";
                    this.caption = "Матрица подастановки";
                    break;
            }
        }

        private void StraightCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            this.ReverseCheckBox.Checked = false;
        }

        private void ReverseCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            this.StraightCheckBox.Checked = false;
        }

        private void ShowDialogButton_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(this.showText, this.caption, MessageBoxButtons.OK);
        }

        private void создатьToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.InputTextRichTextBox.Text = string.Empty;
            this.OutputTextRichTextBox.Text = string.Empty;
            this.CipherTypeComboBox.SelectedIndex = 0;
        }

        private void открытьToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            this.filename = this.openFileDialog1.FileName;
            using (var stream = new StreamReader(this.filename))
            {
                this.InputTextRichTextBox.Text = stream.ReadToEnd();
            }

        }

        private void сохранитьToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (this.filename != null)
            {
                using (var stream = new StreamWriter(this.filename, false))
                {
                    stream.WriteLine("Обычный текст:");
                    stream.WriteLine(this.InputTextRichTextBox.Text);
                    stream.WriteLine("_");
                    stream.WriteLine("Зашифрованый текст:");
                    stream.Write(this.OutputTextRichTextBox.Text);
                }
            }
            else
                this.сохранитькакToolStripMenuItem_Click(sender, e);
        }

        private void сохранитькакToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (this.saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            this.filename = this.saveFileDialog1.FileName;
            using (var stream = new StreamWriter(this.filename, false))
            {
                stream.WriteLine("Обычный текст:");
                stream.WriteLine(this.InputTextRichTextBox.Text);
                stream.WriteLine("Зашифрованый текст:");
                stream.Write(this.OutputTextRichTextBox.Text);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var result = MessageBox.Show(@"Вы действительно хотите выйти?", @"Выход", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) Application.Exit();
        }

        private void опрограммеToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            // MessageBox.Show("Криптографические системы.\nВерсия 1.0", @"О программе", MessageBoxButtons.OK);
            var about = new AboutBox();
            about.Show();
        }

        private void ReverveTextButton_Click(object sender, System.EventArgs e)
        {
            var text = this.InputTextRichTextBox.Text;
            this.InputTextRichTextBox.Text = this.OutputTextRichTextBox.Text;
            this.OutputTextRichTextBox.Text = text;
        }

        private void ClearInputButton_Click(object sender, System.EventArgs e)
        {
            this.InputTextRichTextBox.Clear();
        }

        private void ClearOutputButton_Click(object sender, System.EventArgs e)
        {
            this.OutputTextRichTextBox.Clear();
        }

        private void ClearAllButton_Click(object sender, System.EventArgs e)
        {
            this.InputTextRichTextBox.Clear();
            this.OutputTextRichTextBox.Clear();
        }
    }
}