namespace Tracker_winforms
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
            this.trackerListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sortByTimeButton = new System.Windows.Forms.Button();
            this.sortByCategoriesButton = new System.Windows.Forms.Button();
            this.spendingDatePicker = new System.Windows.Forms.DateTimePicker();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.categoriesListBox = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackerListBox
            // 
            this.trackerListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackerListBox.FormattingEnabled = true;
            this.trackerListBox.Location = new System.Drawing.Point(0, 0);
            this.trackerListBox.Name = "trackerListBox";
            this.trackerListBox.Size = new System.Drawing.Size(800, 450);
            this.trackerListBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sortByTimeButton);
            this.panel1.Controls.Add(this.sortByCategoriesButton);
            this.panel1.Controls.Add(this.spendingDatePicker);
            this.panel1.Controls.Add(this.countTextBox);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.removeButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.categoriesListBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(600, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 1;
            // 
            // sortByTimeButton
            // 
            this.sortByTimeButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sortByTimeButton.Location = new System.Drawing.Point(0, 190);
            this.sortByTimeButton.Name = "sortByTimeButton";
            this.sortByTimeButton.Size = new System.Drawing.Size(200, 52);
            this.sortByTimeButton.TabIndex = 6;
            this.sortByTimeButton.Text = "Сортировать по времени";
            this.sortByTimeButton.UseVisualStyleBackColor = true;
            this.sortByTimeButton.Click += new System.EventHandler(this.sortByTimeButton_Click);
            // 
            // sortByCategoriesButton
            // 
            this.sortByCategoriesButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sortByCategoriesButton.Location = new System.Drawing.Point(0, 242);
            this.sortByCategoriesButton.Name = "sortByCategoriesButton";
            this.sortByCategoriesButton.Size = new System.Drawing.Size(200, 52);
            this.sortByCategoriesButton.TabIndex = 5;
            this.sortByCategoriesButton.Text = "Сортировать по категориям";
            this.sortByCategoriesButton.UseVisualStyleBackColor = true;
            this.sortByCategoriesButton.Click += new System.EventHandler(this.sortByCategoriesButton_Click);
            // 
            // spendingDatePicker
            // 
            this.spendingDatePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spendingDatePicker.Location = new System.Drawing.Point(0, 41);
            this.spendingDatePicker.Name = "spendingDatePicker";
            this.spendingDatePicker.Size = new System.Drawing.Size(200, 20);
            this.spendingDatePicker.TabIndex = 4;
            // 
            // countTextBox
            // 
            this.countTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.countTextBox.Location = new System.Drawing.Point(0, 21);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(200, 20);
            this.countTextBox.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addButton.Location = new System.Drawing.Point(0, 294);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(200, 52);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.removeButton.Location = new System.Drawing.Point(0, 346);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(200, 52);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveButton.Location = new System.Drawing.Point(0, 398);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(200, 52);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Сохранить как";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // categoriesListBox
            // 
            this.categoriesListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoriesListBox.FormattingEnabled = true;
            this.categoriesListBox.Items.AddRange(new object[] {
            "Еда",
            "Транспорт",
            "Развлечения",
            "Образование",
            "Рестораны",
            "Другое"});
            this.categoriesListBox.Location = new System.Drawing.Point(0, 0);
            this.categoriesListBox.Name = "categoriesListBox";
            this.categoriesListBox.Size = new System.Drawing.Size(200, 21);
            this.categoriesListBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.trackerListBox);
            this.Name = "Form1";
            this.Text = "Трекер расходов";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox trackerListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox categoriesListBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.DateTimePicker spendingDatePicker;
        private System.Windows.Forms.Button sortByCategoriesButton;
        private System.Windows.Forms.Button sortByTimeButton;
    }
}

