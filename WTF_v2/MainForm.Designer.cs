namespace WTF_v2
{
    partial class MainForm
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
            this.ListDisciplines_comboBox = new System.Windows.Forms.ComboBox();
            this.label_select_discipline = new System.Windows.Forms.Label();
            this.ListQuestions_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.recording_test_button = new System.Windows.Forms.Button();
            this.NameTest_textBox = new System.Windows.Forms.TextBox();
            this.NameForTest_label = new System.Windows.Forms.Label();
            this.label_questionsForTest = new System.Windows.Forms.Label();
            this.Clear_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListDisciplines_comboBox
            // 
            this.ListDisciplines_comboBox.FormattingEnabled = true;
            this.ListDisciplines_comboBox.Location = new System.Drawing.Point(13, 30);
            this.ListDisciplines_comboBox.Name = "ListDisciplines_comboBox";
            this.ListDisciplines_comboBox.Size = new System.Drawing.Size(154, 24);
            this.ListDisciplines_comboBox.TabIndex = 0;
            // 
            // label_select_discipline
            // 
            this.label_select_discipline.AutoSize = true;
            this.label_select_discipline.Location = new System.Drawing.Point(13, 8);
            this.label_select_discipline.Name = "label_select_discipline";
            this.label_select_discipline.Size = new System.Drawing.Size(154, 16);
            this.label_select_discipline.TabIndex = 1;
            this.label_select_discipline.Text = "Выберите дисциплину";
            // 
            // ListQuestions_checkedListBox
            // 
            this.ListQuestions_checkedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListQuestions_checkedListBox.FormattingEnabled = true;
            this.ListQuestions_checkedListBox.HorizontalScrollbar = true;
            this.ListQuestions_checkedListBox.Location = new System.Drawing.Point(242, 30);
            this.ListQuestions_checkedListBox.Name = "ListQuestions_checkedListBox";
            this.ListQuestions_checkedListBox.Size = new System.Drawing.Size(729, 361);
            this.ListQuestions_checkedListBox.TabIndex = 2;
            // 
            // recording_test_button
            // 
            this.recording_test_button.Location = new System.Drawing.Point(25, 213);
            this.recording_test_button.Name = "recording_test_button";
            this.recording_test_button.Size = new System.Drawing.Size(127, 44);
            this.recording_test_button.TabIndex = 3;
            this.recording_test_button.Text = "Записать тест";
            this.recording_test_button.UseVisualStyleBackColor = true;
            this.recording_test_button.Click += new System.EventHandler(this.recording_test_button_Click);
            // 
            // NameTest_textBox
            // 
            this.NameTest_textBox.Location = new System.Drawing.Point(25, 175);
            this.NameTest_textBox.Name = "NameTest_textBox";
            this.NameTest_textBox.Size = new System.Drawing.Size(127, 22);
            this.NameTest_textBox.TabIndex = 4;
            // 
            // NameForTest_label
            // 
            this.NameForTest_label.AutoSize = true;
            this.NameForTest_label.Location = new System.Drawing.Point(22, 146);
            this.NameForTest_label.Name = "NameForTest_label";
            this.NameForTest_label.Size = new System.Drawing.Size(130, 16);
            this.NameForTest_label.TabIndex = 5;
            this.NameForTest_label.Text = "Введите название";
            // 
            // label_questionsForTest
            // 
            this.label_questionsForTest.AutoSize = true;
            this.label_questionsForTest.Location = new System.Drawing.Point(239, 8);
            this.label_questionsForTest.Name = "label_questionsForTest";
            this.label_questionsForTest.Size = new System.Drawing.Size(197, 16);
            this.label_questionsForTest.TabIndex = 6;
            this.label_questionsForTest.Text = "Выберите вопросы для теста";
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(25, 331);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(127, 46);
            this.Clear_button.TabIndex = 7;
            this.Clear_button.Text = "Очистить";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 414);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.label_questionsForTest);
            this.Controls.Add(this.NameForTest_label);
            this.Controls.Add(this.NameTest_textBox);
            this.Controls.Add(this.recording_test_button);
            this.Controls.Add(this.ListQuestions_checkedListBox);
            this.Controls.Add(this.label_select_discipline);
            this.Controls.Add(this.ListDisciplines_comboBox);
            this.Name = "MainForm";
            this.Text = "Тест-Recorder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ListDisciplines_comboBox;
        private System.Windows.Forms.Label label_select_discipline;
        private System.Windows.Forms.CheckedListBox ListQuestions_checkedListBox;
        private System.Windows.Forms.Button recording_test_button;
        private System.Windows.Forms.TextBox NameTest_textBox;
        private System.Windows.Forms.Label NameForTest_label;
        private System.Windows.Forms.Label label_questionsForTest;
        private System.Windows.Forms.Button Clear_button;
    }
}

