using MySql.Data.MySqlClient;
using System;

namespace ProjectTracker
{
    public class TimeEntry
    {
        public int TimeEntryID { get; private set; }
        public int UserID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Duration => (int)(EndTime - StartTime).TotalSeconds; 
        public int ProjectID { get; set; }
        public DateTime EntryDate { get; set; }

        public TimeEntry(int userId, int projectId, DateTime startTime, DateTime endTime)
        {
            UserID = userId;
            ProjectID = projectId;
            StartTime = startTime;
            EndTime = endTime;
            EntryDate = StartTime.Date;
        }

        public void Save()
        {
            using (var connection = new Database().GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO timeentries (UserID, StartTime, EndTime, Duration, ProjectID, EntryDate) " +
                               "VALUES (@UserID, @StartTime, @EndTime, @Duration, @ProjectID, @EntryDate)";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UserID", UserID);
                    cmd.Parameters.AddWithValue("@StartTime", StartTime);
                    cmd.Parameters.AddWithValue("@EndTime", EndTime);
                    cmd.Parameters.AddWithValue("@Duration", Duration);
                    cmd.Parameters.AddWithValue("@ProjectID", ProjectID);
                    cmd.Parameters.AddWithValue("@EntryDate", EntryDate);
                    cmd.ExecuteNonQuery();
                    TimeEntryID = (int)cmd.LastInsertedId;
                }
            }
        }
    }
}
