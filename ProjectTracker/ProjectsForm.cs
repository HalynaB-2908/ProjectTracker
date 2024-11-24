using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectTracker
{
    public partial class ProjectsForm : MaterialForm
    {
        private int userId;
        private List<Project> projects;
        private int projectCardY = 80;
        private int hours = 0, minutes = 0, seconds = 0;
        private Project currentProject;
        private DateTime? startTime;

        public ProjectsForm(int userId, string username)
        {
            InitializeComponent();
            InitializeMaterialDesign();
            this.userId = userId;
            projects = new List<Project>();
            userLabel.Text = $"{username}";

            projectTimer.Tick += ProjectTimer_Tick;
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

        private void addProjectButton_Click(object sender, EventArgs e)
        {
            var addProjectForm = new AddProjectForm();
            if (addProjectForm.ShowDialog() == DialogResult.OK)
            {
                Project newProject = new Project(userId, addProjectForm.ProjectName);
                newProject.Save();
                projects.Add(newProject);
                DisplayProject(newProject);
            }
        }

        private void DisplayProject(Project project)
        {
            MaterialCard projectCard = new MaterialCard
            {
                Width = 400,
                Height = 220,
                Margin = new Padding(10),
                Padding = new Padding(10),
                Location = new Point(20, projectCardY)
            };

            MaterialLabel projectNameLabel = new MaterialLabel
            {
                Text = project.ProjectName,
                Font = new Font("Roboto", 14, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };

            MaterialComboBox taskComboBox = new MaterialComboBox
            {
                Width = 300,
                Location = new Point(10, 40),
                Hint = "Tasks"
            };
            UpdateTaskComboBox(project, taskComboBox);

            MaterialLabel projectTimeLabel = new MaterialLabel
            {
                Text = $"Total Time: {FormatTime(project.TotalTime)}",
                Location = new Point(10, 90),
                AutoSize = true
            };

            MaterialButton addTaskButton = new MaterialButton
            {
                Text = "Tasks",
                Location = new Point(10, 130),
                Width = 80
            };
            addTaskButton.Click += (s, e) => OpenAddTaskForm(project, taskComboBox);

            MaterialButton startButton = new MaterialButton
            {
                Text = "Start",
                Location = new Point(100, 130),
                Width = 80
            };
            startButton.Click += (s, e) => StartTimer(project);

            MaterialButton stopButton = new MaterialButton
            {
                Text = "Stop",
                Location = new Point(190, 130),
                Width = 80
            };
            stopButton.Click += (s, e) => StopTimer(project, projectTimeLabel);

            MaterialButton deleteButton = new MaterialButton
            {
                Text = "Delete",
                Location = new Point(280, 130),
                Width = 80,
                HighEmphasis = true,
                UseAccentColor = true
            };
            deleteButton.Click += (s, e) => DeleteProject(project, projectCard);

            projectCard.Controls.Add(projectNameLabel);
            projectCard.Controls.Add(taskComboBox);
            projectCard.Controls.Add(projectTimeLabel);
            projectCard.Controls.Add(addTaskButton);
            projectCard.Controls.Add(startButton);
            projectCard.Controls.Add(stopButton);
            projectCard.Controls.Add(deleteButton);

            Controls.Add(projectCard);
            projectCardY += projectCard.Height + 20;
        }


        private void OpenAddTaskForm(Project project, MaterialComboBox taskComboBox)
        {
            var addTaskForm = new AddTaskForm(project.ProjectID);
            var result = addTaskForm.ShowDialog();

            if (result == DialogResult.OK || result == DialogResult.Cancel)
            {
                project.LoadTasks();
                UpdateTaskComboBox(project, taskComboBox); 
            }
        }

        private void UpdateTaskComboBox(Project project, MaterialComboBox taskComboBox)
        {
            taskComboBox.Items.Clear();
            project.LoadTasks(); 
            foreach (var task in project.Tasks)
            {
                taskComboBox.Items.Add(task);
            }

            if (taskComboBox.Items.Count > 0)
            {
                taskComboBox.SelectedIndex = 0;
            }
        }

        private void StartTimer(Project project)
        {
            currentProject = project;
            startTime = DateTime.Now;
            hours = minutes = seconds = 0;
            projectTimer.Start();
        }

        private void StopTimer(Project project, MaterialLabel projectTimeLabel)
        {
            projectTimer.Stop();
            DateTime endTime = DateTime.Now; 
            int elapsedTime = hours * 3600 + minutes * 60 + seconds;

            project.UpdateTotalTime(elapsedTime); 
            projectTimeLabel.Text = $"Total Time: {FormatTime(project.TotalTime)}"; 

            if (startTime.HasValue) 
            {
                TimeEntry timeEntry = new TimeEntry(userId, project.ProjectID, startTime.Value, endTime);
                timeEntry.Save();
            }

            timerDisplayLabel.Text = "00:00:00"; 
            startTime = null;
            currentProject = null;
        }

        private void ProjectTimer_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds >= 60)
            {
                seconds = 0;
                minutes++;
            }
            if (minutes >= 60)
            {
                minutes = 0;
                hours++;
            }

            timerDisplayLabel.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
        }

        private string FormatTime(int totalSeconds)
        {
            int hours = totalSeconds / 3600;
            int minutes = (totalSeconds % 3600) / 60;
            int seconds = totalSeconds % 60;
            return $"{hours:D2}:{minutes:D2}:{seconds:D2}";
        }

        private void DeleteProject(Project project, MaterialCard projectCard)
        {
            project.Delete();
            Controls.Remove(projectCard);
            projects.Remove(project);
            UpdateProjectCardPositions();
        }

        private void showStatisticsButton_Click(object sender, EventArgs e)
        {
            var statisticsForm = new StatisticsForm(userId);
            statisticsForm.Show();
        }

        private void UpdateProjectCardPositions()
        {
            projectCardY = 80;
            foreach (Control control in Controls)
            {
                if (control is MaterialCard)
                {
                    control.Location = new Point(20, projectCardY);
                    projectCardY += control.Height + 20;
                }
            }
        }

        private void ProjectsForm_Load(object sender, EventArgs e)
        {
            projects = Project.GetProjectsByUser(userId);

            foreach (var project in projects)
            {
                DisplayProject(project);
            }
        }
    }
}
