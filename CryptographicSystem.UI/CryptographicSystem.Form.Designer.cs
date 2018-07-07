namespace CryptographicSystem.UI
{
    partial class CryptographicSystemForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CryptographicSystemForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.CountSymbolLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитькакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.опрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CipherTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InputTextRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OutputTextRichTextBox = new System.Windows.Forms.RichTextBox();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.CountSubstitutionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MyCaption = new System.Windows.Forms.Label();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.VigenereTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.ReverseCheckBox = new System.Windows.Forms.CheckBox();
            this.StraightCheckBox = new System.Windows.Forms.CheckBox();
            this.ShowDialogButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ReverveTextButton = new System.Windows.Forms.Button();
            this.ClearInputButton = new System.Windows.Forms.Button();
            this.ClearOutputButton = new System.Windows.Forms.Button();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountSubstitutionNumericUpDown)).BeginInit();
            this.VigenereTypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.CountSymbolLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 394);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(612, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(133, 17);
            this.toolStripStatusLabel1.Text = "Количество символов:";
            // 
            // CountSymbolLabel
            // 
            this.CountSymbolLabel.Name = "CountSymbolLabel";
            this.CountSymbolLabel.Size = new System.Drawing.Size(13, 17);
            this.CountSymbolLabel.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(612, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.toolStripSeparator,
            this.сохранитьToolStripMenuItem,
            this.сохранитькакToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("создатьToolStripMenuItem.Image")));
            this.создатьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.создатьToolStripMenuItem.Text = "&Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripMenuItem.Image")));
            this.открытьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.открытьToolStripMenuItem.Text = "&Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(169, 6);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripMenuItem.Image")));
            this.сохранитьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.сохранитьToolStripMenuItem.Text = "&Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитькакToolStripMenuItem
            // 
            this.сохранитькакToolStripMenuItem.Name = "сохранитькакToolStripMenuItem";
            this.сохранитькакToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.сохранитькакToolStripMenuItem.Text = "Сохранить &как";
            this.сохранитькакToolStripMenuItem.Click += new System.EventHandler(this.сохранитькакToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.выходToolStripMenuItem.Text = "Вы&ход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.опрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Спра&вка";
            // 
            // опрограммеToolStripMenuItem
            // 
            this.опрограммеToolStripMenuItem.Name = "опрограммеToolStripMenuItem";
            this.опрограммеToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.опрограммеToolStripMenuItem.Text = "&О программе...";
            this.опрограммеToolStripMenuItem.Click += new System.EventHandler(this.опрограммеToolStripMenuItem_Click);
            // 
            // CipherTypeComboBox
            // 
            this.CipherTypeComboBox.DisplayMember = "1";
            this.CipherTypeComboBox.FormattingEnabled = true;
            this.CipherTypeComboBox.Items.AddRange(new object[] {
            "1. Шифр подстановки",
            "2. Шифр перестановки",
            "3. Шифр Виженера",
            "4. Шифр Вернама",
            "5. Шифр бегущего ключа",
            "6. Шифр Цезаря",
            "7. Диграммные подстановки",
            "8. Шифр “Плейфер” ",
            "9. Шифр с автоключом",
            "10. Дробный шифр"});
            this.CipherTypeComboBox.Location = new System.Drawing.Point(85, 31);
            this.CipherTypeComboBox.Name = "CipherTypeComboBox";
            this.CipherTypeComboBox.Size = new System.Drawing.Size(180, 21);
            this.CipherTypeComboBox.TabIndex = 1;
            this.CipherTypeComboBox.Tag = "0";
            this.CipherTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.CipherTypeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Тип шифра:";
            // 
            // InputTextRichTextBox
            // 
            this.InputTextRichTextBox.Font = new System.Drawing.Font("Microsoft MHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputTextRichTextBox.Location = new System.Drawing.Point(85, 92);
            this.InputTextRichTextBox.Name = "InputTextRichTextBox";
            this.InputTextRichTextBox.Size = new System.Drawing.Size(514, 124);
            this.InputTextRichTextBox.TabIndex = 2;
            this.InputTextRichTextBox.Text = "";
            this.InputTextRichTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InputTextRichTextBox_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(30, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Текст:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(4, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Результат:";
            // 
            // OutputTextRichTextBox
            // 
            this.OutputTextRichTextBox.Font = new System.Drawing.Font("Microsoft MHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputTextRichTextBox.Location = new System.Drawing.Point(85, 255);
            this.OutputTextRichTextBox.Name = "OutputTextRichTextBox";
            this.OutputTextRichTextBox.Size = new System.Drawing.Size(514, 124);
            this.OutputTextRichTextBox.TabIndex = 5;
            this.OutputTextRichTextBox.Text = "";
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(185, 222);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(102, 27);
            this.EncryptButton.TabIndex = 3;
            this.EncryptButton.Text = "Шифровать";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(497, 222);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(102, 27);
            this.DecryptButton.TabIndex = 4;
            this.DecryptButton.Text = "Дешифровать";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // CountSubstitutionNumericUpDown
            // 
            this.CountSubstitutionNumericUpDown.Location = new System.Drawing.Point(430, 31);
            this.CountSubstitutionNumericUpDown.Name = "CountSubstitutionNumericUpDown";
            this.CountSubstitutionNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.CountSubstitutionNumericUpDown.TabIndex = 8;
            this.CountSubstitutionNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MyCaption
            // 
            this.MyCaption.AutoSize = true;
            this.MyCaption.BackColor = System.Drawing.Color.Transparent;
            this.MyCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MyCaption.Location = new System.Drawing.Point(290, 34);
            this.MyCaption.Name = "MyCaption";
            this.MyCaption.Size = new System.Drawing.Size(137, 13);
            this.MyCaption.TabIndex = 9;
            this.MyCaption.Text = "Количество подстановок:";
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(293, 57);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(306, 20);
            this.KeyTextBox.TabIndex = 10;
            // 
            // VigenereTypeGroupBox
            // 
            this.VigenereTypeGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.VigenereTypeGroupBox.Controls.Add(this.ReverseCheckBox);
            this.VigenereTypeGroupBox.Controls.Add(this.StraightCheckBox);
            this.VigenereTypeGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.VigenereTypeGroupBox.Location = new System.Drawing.Point(16, 54);
            this.VigenereTypeGroupBox.Name = "VigenereTypeGroupBox";
            this.VigenereTypeGroupBox.Size = new System.Drawing.Size(271, 35);
            this.VigenereTypeGroupBox.TabIndex = 11;
            this.VigenereTypeGroupBox.TabStop = false;
            this.VigenereTypeGroupBox.Text = "Тип шифра Виженера";
            // 
            // ReverseCheckBox
            // 
            this.ReverseCheckBox.AutoSize = true;
            this.ReverseCheckBox.Location = new System.Drawing.Point(139, 15);
            this.ReverseCheckBox.Name = "ReverseCheckBox";
            this.ReverseCheckBox.Size = new System.Drawing.Size(121, 17);
            this.ReverseCheckBox.TabIndex = 1;
            this.ReverseCheckBox.Text = "Обратный вариант";
            this.ReverseCheckBox.UseVisualStyleBackColor = true;
            this.ReverseCheckBox.CheckedChanged += new System.EventHandler(this.ReverseCheckBox_CheckedChanged);
            // 
            // StraightCheckBox
            // 
            this.StraightCheckBox.AutoSize = true;
            this.StraightCheckBox.Location = new System.Drawing.Point(12, 15);
            this.StraightCheckBox.Name = "StraightCheckBox";
            this.StraightCheckBox.Size = new System.Drawing.Size(110, 17);
            this.StraightCheckBox.TabIndex = 0;
            this.StraightCheckBox.Text = "Прямой вариант";
            this.StraightCheckBox.UseVisualStyleBackColor = true;
            this.StraightCheckBox.CheckedChanged += new System.EventHandler(this.StraightCheckBox_CheckedChanged);
            // 
            // ShowDialogButton
            // 
            this.ShowDialogButton.Location = new System.Drawing.Point(326, 218);
            this.ShowDialogButton.Name = "ShowDialogButton";
            this.ShowDialogButton.Size = new System.Drawing.Size(129, 35);
            this.ShowDialogButton.TabIndex = 12;
            this.ShowDialogButton.Text = "Показать сгенерированный ключ";
            this.ShowDialogButton.UseVisualStyleBackColor = true;
            this.ShowDialogButton.Click += new System.EventHandler(this.ShowDialogButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ReverveTextButton
            // 
            this.ReverveTextButton.BackgroundImage = global::CryptographicSystem.UI.Properties.Resources.arrow;
            this.ReverveTextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReverveTextButton.Location = new System.Drawing.Point(16, 200);
            this.ReverveTextButton.Name = "ReverveTextButton";
            this.ReverveTextButton.Size = new System.Drawing.Size(59, 70);
            this.ReverveTextButton.TabIndex = 13;
            this.ReverveTextButton.UseVisualStyleBackColor = true;
            this.ReverveTextButton.Click += new System.EventHandler(this.ReverveTextButton_Click);
            // 
            // ClearInputButton
            // 
            this.ClearInputButton.BackgroundImage = global::CryptographicSystem.UI.Properties.Resources.clear;
            this.ClearInputButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearInputButton.Location = new System.Drawing.Point(85, 217);
            this.ClearInputButton.Name = "ClearInputButton";
            this.ClearInputButton.Size = new System.Drawing.Size(38, 36);
            this.ClearInputButton.TabIndex = 14;
            this.ClearInputButton.Text = "in";
            this.ClearInputButton.UseVisualStyleBackColor = true;
            this.ClearInputButton.Click += new System.EventHandler(this.ClearInputButton_Click);
            // 
            // ClearOutputButton
            // 
            this.ClearOutputButton.BackgroundImage = global::CryptographicSystem.UI.Properties.Resources.clear;
            this.ClearOutputButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearOutputButton.Location = new System.Drawing.Point(129, 217);
            this.ClearOutputButton.Name = "ClearOutputButton";
            this.ClearOutputButton.Size = new System.Drawing.Size(38, 36);
            this.ClearOutputButton.TabIndex = 15;
            this.ClearOutputButton.Text = "out";
            this.ClearOutputButton.UseVisualStyleBackColor = true;
            this.ClearOutputButton.Click += new System.EventHandler(this.ClearOutputButton_Click);
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.BackgroundImage = global::CryptographicSystem.UI.Properties.Resources.clear;
            this.ClearAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearAllButton.ForeColor = System.Drawing.Color.Black;
            this.ClearAllButton.Location = new System.Drawing.Point(41, 355);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(38, 36);
            this.ClearAllButton.TabIndex = 16;
            this.ClearAllButton.Text = "all";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // CryptographicSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CryptographicSystem.UI.Properties.Resources.backgroung;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(612, 416);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.ClearOutputButton);
            this.Controls.Add(this.ClearInputButton);
            this.Controls.Add(this.ReverveTextButton);
            this.Controls.Add(this.ShowDialogButton);
            this.Controls.Add(this.VigenereTypeGroupBox);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.MyCaption);
            this.Controls.Add(this.CountSubstitutionNumericUpDown);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OutputTextRichTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputTextRichTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CipherTypeComboBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CryptographicSystemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №1.  Исследование простых криптографических систем";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountSubstitutionNumericUpDown)).EndInit();
            this.VigenereTypeGroupBox.ResumeLayout(false);
            this.VigenereTypeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel CountSymbolLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox CipherTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox InputTextRichTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox OutputTextRichTextBox;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.NumericUpDown CountSubstitutionNumericUpDown;
        private System.Windows.Forms.Label MyCaption;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитькакToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem опрограммеToolStripMenuItem;
        private System.Windows.Forms.GroupBox VigenereTypeGroupBox;
        private System.Windows.Forms.CheckBox ReverseCheckBox;
        private System.Windows.Forms.CheckBox StraightCheckBox;
        private System.Windows.Forms.Button ShowDialogButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button ReverveTextButton;
        private System.Windows.Forms.Button ClearInputButton;
        private System.Windows.Forms.Button ClearOutputButton;
        private System.Windows.Forms.Button ClearAllButton;
    }
}