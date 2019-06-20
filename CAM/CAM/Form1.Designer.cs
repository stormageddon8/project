namespace CAM
{
    partial class Main
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
            this.UnCryptData = new System.Windows.Forms.TextBox();
            this.LabelUncrypt = new System.Windows.Forms.Label();
            this.labelCrypt = new System.Windows.Forms.Label();
            this.CryptData = new System.Windows.Forms.TextBox();
            this.labelData = new System.Windows.Forms.Label();
            this.labelSettings = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SizeKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TypeCrypt = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UnCryptData
            // 
            this.UnCryptData.Location = new System.Drawing.Point(103, 51);
            this.UnCryptData.Name = "UnCryptData";
            this.UnCryptData.Size = new System.Drawing.Size(352, 20);
            this.UnCryptData.TabIndex = 0;
            // 
            // LabelUncrypt
            // 
            this.LabelUncrypt.AutoSize = true;
            this.LabelUncrypt.Location = new System.Drawing.Point(100, 35);
            this.LabelUncrypt.Name = "LabelUncrypt";
            this.LabelUncrypt.Size = new System.Drawing.Size(139, 13);
            this.LabelUncrypt.TabIndex = 1;
            this.LabelUncrypt.Text = "Расшифрованные данные";
            // 
            // labelCrypt
            // 
            this.labelCrypt.AutoSize = true;
            this.labelCrypt.Location = new System.Drawing.Point(106, 74);
            this.labelCrypt.Name = "labelCrypt";
            this.labelCrypt.Size = new System.Drawing.Size(133, 13);
            this.labelCrypt.TabIndex = 3;
            this.labelCrypt.Text = "Зашифрованные данные";
            // 
            // CryptData
            // 
            this.CryptData.Location = new System.Drawing.Point(103, 90);
            this.CryptData.Name = "CryptData";
            this.CryptData.Size = new System.Drawing.Size(352, 20);
            this.CryptData.TabIndex = 2;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelData.Location = new System.Drawing.Point(12, 9);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(63, 18);
            this.labelData.TabIndex = 4;
            this.labelData.Text = "Данные";
            // 
            // labelSettings
            // 
            this.labelSettings.AutoSize = true;
            this.labelSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSettings.Location = new System.Drawing.Point(12, 151);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(83, 18);
            this.labelSettings.TabIndex = 5;
            this.labelSettings.Text = "Настройки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Размер ключа";
            // 
            // SizeKey
            // 
            this.SizeKey.Location = new System.Drawing.Point(132, 195);
            this.SizeKey.Name = "SizeKey";
            this.SizeKey.Size = new System.Drawing.Size(99, 20);
            this.SizeKey.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Тип шифра";
            // 
            // TypeCrypt
            // 
            this.TypeCrypt.FormattingEnabled = true;
            this.TypeCrypt.Items.AddRange(new object[] {
            "RSA",
            "ELGamal"});
            this.TypeCrypt.Location = new System.Drawing.Point(297, 195);
            this.TypeCrypt.Name = "TypeCrypt";
            this.TypeCrypt.Size = new System.Drawing.Size(99, 21);
            this.TypeCrypt.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(212, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "данные";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 20);
            this.textBox1.TabIndex = 11;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 280);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TypeCrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SizeKey);
            this.Controls.Add(this.labelSettings);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelCrypt);
            this.Controls.Add(this.CryptData);
            this.Controls.Add(this.LabelUncrypt);
            this.Controls.Add(this.UnCryptData);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "cryptography";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UnCryptData;
        private System.Windows.Forms.Label LabelUncrypt;
        private System.Windows.Forms.Label labelCrypt;
        private System.Windows.Forms.TextBox CryptData;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SizeKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TypeCrypt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

