using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ProjectTracker
{
    public class Project
    {
        public int ProjectID { get; private set; }
        public int UserID { get; private set; }
        public string ProjectName { get; set; }
        public int TotalTime { get; set; }
        public List<Task> Tasks { get; private set; }

        public Project(int userId, string projectName)
        {
            UserID = userId;
            ProjectName = projectName;
            Tasks = new List<Task>();
        }

        public void Save()
        {
            using (var connection = new Database().GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Projects (UserID, ProjectName, TotalTime) VALUES (@UserID, @ProjectName, @TotalTime)";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UserID", UserID);
                    cmd.Parameters.AddWithValue("@ProjectName", ProjectName);
                    cmd.Parameters.AddWithValue("@TotalTime", TotalTime);
                    cmd.ExecuteNonQuery();
                    ProjectID = (int)cmd.LastInsertedId;
                }
            }
        }

        public void AddTask(Task task)
        {
            Tasks.Add(task);
            task.Save(ProjectID);
        }

        public void Delete()
        {
            using (var connection = new Database().GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Projects WHERE ProjectID = @ProjectID";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ProjectID", ProjectID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Project> GetProjectsByUser(int userId)
        {
            List<Project> projects = new List<Project>();

            using (var connection = new Database().GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Projects WHERE UserID = @UserID";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Project project = new Project(userId, reader.GetString("ProjectName"))
                            {
                                ProjectID = reader.GetInt32("ProjectID"),
                                TotalTime = reader.GetInt32("TotalTime")
                            };
                            project.LoadTasks(); 
                            projects.Add(project);
                        }
                    }
                }
            }

            return projects;
        }

        public void LoadTasks()
        {
            Tasks.Clear();
            using (var connection = new Database().GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Tasks WHERE ProjectID = @ProjectID";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ProjectID", ProjectID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Task task = new Task(reader.GetString("TaskName"))
                            {
                                TaskID = reader.GetInt32("TaskID"),
                            };
                            Tasks.Add(task);
                        }
                    }
                }
            }
        }
        public void UpdateTotalTime(int additionalTime)
        {
            TotalTime += additionalTime;

            using (var connection = new Database().GetConnection())
            {
                connection.Open();
                string updateQuery = "UPDATE Projects SET TotalTime = @TotalTime WHERE ProjectID = @ProjectID";
                using (var cmd = new MySqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@TotalTime", TotalTime);
                    cmd.Parameters.AddWithValue("@ProjectID", ProjectID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
