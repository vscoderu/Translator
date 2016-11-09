namespace Translator
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.translateButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ruEnRadioButton = new System.Windows.Forms.RadioButton();
            this.enRuRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.inputTextBox.Location = new System.Drawing.Point(12, 12);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputTextBox.Size = new System.Drawing.Size(400, 100);
            this.inputTextBox.TabIndex = 0;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.outputTextBox.Location = new System.Drawing.Point(12, 199);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.Size = new System.Drawing.Size(400, 100);
            this.outputTextBox.TabIndex = 1;
            // 
            // translateButton
            // 
            this.translateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.translateButton.Location = new System.Drawing.Point(12, 136);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(155, 39);
            this.translateButton.TabIndex = 2;
            this.translateButton.Text = "ПЕРЕВЕСТИ";
            this.translateButton.UseVisualStyleBackColor = true;
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enRuRadioButton);
            this.groupBox1.Controls.Add(this.ruEnRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox1.Location = new System.Drawing.Point(431, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 113);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Направление перевода";
            // 
            // ruEnRadioButton
            // 
            this.ruEnRadioButton.AutoSize = true;
            this.ruEnRadioButton.Checked = true;
            this.ruEnRadioButton.Location = new System.Drawing.Point(33, 34);
            this.ruEnRadioButton.Name = "ruEnRadioButton";
            this.ruEnRadioButton.Size = new System.Drawing.Size(84, 22);
            this.ruEnRadioButton.TabIndex = 0;
            this.ruEnRadioButton.TabStop = true;
            this.ruEnRadioButton.Text = "Rus-Eng";
            this.ruEnRadioButton.UseVisualStyleBackColor = true;
            // 
            // enRuRadioButton
            // 
            this.enRuRadioButton.AutoSize = true;
            this.enRuRadioButton.Location = new System.Drawing.Point(33, 68);
            this.enRuRadioButton.Name = "enRuRadioButton";
            this.enRuRadioButton.Size = new System.Drawing.Size(84, 22);
            this.enRuRadioButton.TabIndex = 1;
            this.enRuRadioButton.Text = "Eng-Rus";
            this.enRuRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 308);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.translateButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Name = "Form1";
            this.Text = "Переводчик VSCODE.RU";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button translateButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton enRuRadioButton;
        private System.Windows.Forms.RadioButton ruEnRadioButton;
    }
}

