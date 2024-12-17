using LibraryApp.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class frmToDos : Form
    {
        private StringBuilder csvContent;

        public frmToDos()
        {
            InitializeComponent();
        }

        private void refreshData()
        {
            using (var context = new ToDoAppDBContext())
            {
                var todos = context.MyTodos.ToList();

                dataGridViewTasks.DataSource = todos;

                dataGridViewTasks.Columns["Id"].Visible = false;
                dataGridViewTasks.Columns["taskText"].HeaderText = "To-Do";
                dataGridViewTasks.Columns["deadLine"].HeaderText = "Deadline";
                //dataGridViewTasks.Columns["deadlineTime"].HeaderText = "Due Time";


                dataGridViewTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void frmToDos_Load(object sender, EventArgs e)
        {
            this.refreshData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxInput.Text) || dateTimePicker.Value == null)
            {
                MessageBox.Show("Please fill in all fields before adding a To-Do.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string todoText = textBoxInput.Text;
            DateTime deadline = dateTimePicker.Value;
     

            models.MyTodo newToDo = new models.MyTodo()
            {
                taskText = todoText,
                deadLine = deadline.ToUniversalTime(),
            
            };

            using (var context = new ToDoAppDBContext())
            {
                context.MyTodos.Add(newToDo);
                context.SaveChanges();
            }

            MessageBox.Show("To-Do added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            textBoxInput.Clear();
            dateTimePicker.Value = DateTime.Now;

            this.refreshData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.SelectedRows.Count > 0)
            {
                try
                {
                    // Get the selected user details
                    int todoId = Convert.ToInt32(dataGridViewTasks.SelectedRows[0].Cells["Id"].Value);



                    DialogResult result = MessageBox.Show("Are you sure you want to delete this task?", "Confirm Deletion", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        using (var context = new ToDoAppDBContext())
                        {
                            var taskToDelete = context.MyTodos.Find(todoId);
                            if (taskToDelete != null)
                            {
                                context.MyTodos.Remove(taskToDelete);
                                context.SaveChanges();
                                refreshData();
                                MessageBox.Show("Task Deleted Successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Task Not Found.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting todo: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a task to delete.");
            }
        }

        private void buttonExportToPdf_Click(object sender, EventArgs e)
        {

            try
            {
                string csvFilePath = "C:\\Users\\Kenn\\Downloads\\Todos.csv";
                csvContent = new StringBuilder();
                foreach (DataGridViewColumn column in dataGridViewTasks.Columns)
                {
                    csvContent.Append(column.HeaderText + " ,");

                }
                csvContent.Length--;
                csvContent.AppendLine();

                foreach (DataGridViewRow row in dataGridViewTasks.Rows)
                {
                    if (row.IsNewRow) continue;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        string cellValue = cell.Value?.ToString().Replace(",", "");
                        csvContent.Append(cellValue + ", ");

                    }

                    csvContent.Length--;
                    csvContent.AppendLine();
                }
                File.WriteAllText(csvFilePath, csvContent.ToString());
                MessageBox.Show("Data saved to Excel successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
