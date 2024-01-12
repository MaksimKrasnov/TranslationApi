namespace WindowsFormsApp2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inputText = new System.Windows.Forms.TextBox();
            this.targetText = new System.Windows.Forms.TextBox();
            this.inputLanguage = new System.Windows.Forms.ComboBox();
            this.changeLanguage = new System.Windows.Forms.Button();
            this.targetLanguage = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(12, 84);
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(418, 380);
            this.inputText.TabIndex = 1;
            this.inputText.TextChanged += new System.EventHandler(this.inputText_TextChanged);
            // 
            // targetText
            // 
            this.targetText.Location = new System.Drawing.Point(505, 84);
            this.targetText.Multiline = true;
            this.targetText.Name = "targetText";
            this.targetText.ReadOnly = true;
            this.targetText.Size = new System.Drawing.Size(419, 380);
            this.targetText.TabIndex = 2;
            // 
            // inputLanguage
            // 
            this.inputLanguage.FormattingEnabled = true;
            this.inputLanguage.Location = new System.Drawing.Point(12, 39);
            this.inputLanguage.Name = "inputLanguage";
            this.inputLanguage.Size = new System.Drawing.Size(278, 24);
            this.inputLanguage.TabIndex = 3;
            // 
            // changeLanguage
            // 
            this.changeLanguage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.changeLanguage.Image = ((System.Drawing.Image)(resources.GetObject("changeLanguage.Image")));
            this.changeLanguage.Location = new System.Drawing.Point(438, 22);
            this.changeLanguage.Name = "changeLanguage";
            this.changeLanguage.Size = new System.Drawing.Size(64, 41);
            this.changeLanguage.TabIndex = 5;
            this.changeLanguage.UseVisualStyleBackColor = false;
            this.changeLanguage.Click += new System.EventHandler(this.button2_Click);
            // 
            // targetLanguage
            // 
            this.targetLanguage.FormattingEnabled = true;
            this.targetLanguage.Location = new System.Drawing.Point(646, 39);
            this.targetLanguage.Name = "targetLanguage";
            this.targetLanguage.Size = new System.Drawing.Size(278, 24);
            this.targetLanguage.TabIndex = 8;
            this.targetLanguage.SelectedIndexChanged += new System.EventHandler(this.targetLanguage_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(936, 501);
            this.Controls.Add(this.targetLanguage);
            this.Controls.Add(this.changeLanguage);
            this.Controls.Add(this.inputLanguage);
            this.Controls.Add(this.targetText);
            this.Controls.Add(this.inputText);
            this.MaximumSize = new System.Drawing.Size(954, 548);
            this.Name = "Form1";
            this.Text = "Переводчик";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.TextBox targetText;
        private System.Windows.Forms.ComboBox inputLanguage;
        private System.Windows.Forms.Button changeLanguage;
        private System.Windows.Forms.ComboBox targetLanguage;
    }
}

