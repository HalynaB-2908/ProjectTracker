using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace ProjectTracker
{
    public partial class AddTaskForm : MaterialForm
    {
        public Task CreatedTask { get; private set; }
        private int projectId;

        public AddTaskForm(int projectId)
        {
            InitializeComponent();
            this.projectId = projectId;
            InitializeMaterialDesign();
            LoadTasks();
        }

        private void InitializeMaterialDesign()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey600,
                Primary.Grey800,
                Primary.Grey200,
                Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void LoadTasks()
        {

            taskComboBox.Items.Clear();

            var tasks = Task.GetTasksByProjectId(projectId);
            foreach (var task in tasks)
            {
                taskComboBox.Items.Add(task);
            }

            if (taskComboBox.Items.Count > 0)
            {
                taskComboBox.SelectedIndex = 0;
            }
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(taskNameTextBox.Text))
            {
                CreatedTask = new Task(taskNameTextBox.Text);
                CreatedTask.Save(projectId);
                taskComboBox.Items.Add(CreatedTask); 
                taskNameTextBox.Clear(); 
            }
            else
            {
                MessageBox.Show("Please enter a task name.");
            }
        }

        private void deleteTaskButton_Click(object sender, EventArgs e)
        {
            if (taskComboBox.SelectedItem is Task selectedTask)
            {
                selectedTask.Delete();
                taskComboBox.Items.Remove(selectedTask); 
            }
            else
            {
                MessageBox.Show("Please select a task to delete.");
            }
        }
    }
}
