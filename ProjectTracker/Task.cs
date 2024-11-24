using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace ProjectTracker
{
    public class Task
    {
        public int TaskID { get; internal set; }
        public string TaskName { get; set; }

        public Task(string taskName)
        {
            TaskName = taskName;
        }

        public void Save(int projectId)
        {
            using (var connection = new Database().GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Tasks (ProjectID, TaskName) VALUES (@ProjectID, @TaskName)";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ProjectID", projectId);
                    cmd.Parameters.AddWithValue("@TaskName", TaskName);
                    cmd.ExecuteNonQuery();
                    TaskID = (int)cmd.LastInsertedId;
                }
            }
        }

        public void Delete()
        {
            using (var connection = new Database().GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Tasks WHERE TaskID = @TaskID";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@TaskID", TaskID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Task> GetTasksByProjectId(int projectId)
        {
            List<Task> tasks = new List<Task>();
            using (var connection = new Database().GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Tasks WHERE ProjectID = @ProjectID";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ProjectID", projectId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Task task = new Task(reader.GetString("TaskName"))
                            {
                                TaskID = reader.GetInt32("TaskID"),
                            };
                            tasks.Add(task);
                        }
                    }
                }
            }
            return tasks;
        }

        public override string ToString()
        {
            return TaskName; 
        }
    }
}
