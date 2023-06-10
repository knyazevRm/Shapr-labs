namespace Task6_5
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
            this.dllButton = new System.Windows.Forms.Button();
            this.smartButton = new System.Windows.Forms.Button();
            this.methodButton = new System.Windows.Forms.Button();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.methodComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dllButton
            // 
            this.dllButton.Location = new System.Drawing.Point(186, 32);
            this.dllButton.Name = "dllButton";
            this.dllButton.Size = new System.Drawing.Size(229, 77);
            this.dllButton.TabIndex = 0;
            this.dllButton.Text = "Выберите библиотеку";
            this.dllButton.UseVisualStyleBackColor = true;
            this.dllButton.Click += new System.EventHandler(this.OpenLibrary);
            // 
            // smartButton
            // 
            this.smartButton.Location = new System.Drawing.Point(186, 132);
            this.smartButton.Name = "smartButton";
            this.smartButton.Size = new System.Drawing.Size(229, 77);
            this.smartButton.TabIndex = 1;
            this.smartButton.Text = "Выберите Класс";
            this.smartButton.UseVisualStyleBackColor = true;
            this.smartButton.Click += new System.EventHandler(this.smartButton_Click);
            // 
            // methodButton
            // 
            this.methodButton.Location = new System.Drawing.Point(186, 227);
            this.methodButton.Name = "methodButton";
            this.methodButton.Size = new System.Drawing.Size(229, 77);
            this.methodButton.TabIndex = 2;
            this.methodButton.Text = "Выберите метод";
            this.methodButton.UseVisualStyleBackColor = true;
            this.methodButton.Click += new System.EventHandler(this.methodButton_Click);
            // 
            // classComboBox
            // 
            this.classComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(544, 46);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(155, 24);
            this.classComboBox.TabIndex = 4;
            this.classComboBox.Visible = false;
            // 
            // methodComboBox
            // 
            this.methodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.methodComboBox.FormattingEnabled = true;
            this.methodComboBox.Location = new System.Drawing.Point(544, 115);
            this.methodComboBox.Name = "methodComboBox";
            this.methodComboBox.Size = new System.Drawing.Size(155, 24);
            this.methodComboBox.TabIndex = 5;
            this.methodComboBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.methodComboBox);
            this.Controls.Add(this.classComboBox);
            this.Controls.Add(this.methodButton);
            this.Controls.Add(this.smartButton);
            this.Controls.Add(this.dllButton);
            this.Name = "Form1";
            this.Text = "Task6_5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dllButton;
        private System.Windows.Forms.Button smartButton;
        private System.Windows.Forms.Button methodButton;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.ComboBox methodComboBox;
    }
}

