using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Tracker_winforms
{
    public partial class Form1 : Form
    {
        List<Spending> spendings = new List<Spending>();
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.DefaultExt = "txt";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (categoriesListBox.SelectedItem == null)
                {
                    MessageBox.Show("Пожалуйста, выберите категорию товаров.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string category = categoriesListBox.SelectedItem.ToString();
                float count = float.Parse(countTextBox.Text);
                DateTime time = spendingDatePicker.Value;

                Spending spending = new Spending(category, count, time);

                spendings.Add(spending);
                trackerListBox.Items.Add(spending);
                trackerListBox.Invalidate();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Clear();

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItem = trackerListBox.SelectedItems;

            if (trackerListBox.SelectedIndex != -1)
            {
                Spending spendingToRemove = (Spending)trackerListBox.SelectedItem;

                int index = spendings.IndexOf(spendingToRemove);

                if (index != -1)
                {
                    trackerListBox.Items.RemoveAt(trackerListBox.SelectedIndex);
                    spendings.RemoveAt(index);
                }

                else
                {
                    MessageBox.Show("Ошибка удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                trackerListBox.Invalidate();
            }

            else
            {
                MessageBox.Show("Ошибка удаления элемента.", "Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    
                    var stream = new StreamWriter(saveFileDialog1.FileName, false);
                    foreach (var item in trackerListBox.Items)
                    {
                        stream.Write(item.ToString());
                    }

                    stream.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Clear()
        {
            categoriesListBox.SelectedItem = 0;
            countTextBox.Clear();
        }

        private void sortByCategoriesButton_Click(object sender, EventArgs e)
        {
            var sortedSpendings = spendings.OrderBy(s => s.Title, StringComparer.OrdinalIgnoreCase).ToList();

            trackerListBox.Items.Clear();

            foreach ( var item in sortedSpendings)
            {
                trackerListBox.Items.Add(item);
            }
        }

        private void sortByTimeButton_Click(object sender, EventArgs e)
        {
            var sortedSpendings = spendings.OrderBy(s => s.Time).ToList();

            trackerListBox.Items.Clear();

            foreach ( var item in sortedSpendings)
            {
                trackerListBox.Items.Add(item);
            }
        }


    }
}
