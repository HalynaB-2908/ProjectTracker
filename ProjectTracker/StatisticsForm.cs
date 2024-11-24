using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ProjectTracker
{
    public partial class StatisticsForm : MaterialForm
    {
        private int userId; 

        public StatisticsForm(int userId)
        {
            InitializeComponent();
            InitializeMaterialDesign();
            this.userId = userId; 
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

        private void weeklyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LoadStatistics("weekly");
        }

        private void monthlyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LoadStatistics("monthly");
        }

        private void LoadStatistics(string period)
        {
            using (var connection = new Database().GetConnection())
            {
                connection.Open();
                string query = period == "weekly"
                    ? @"SELECT ProjectName, SUM(Duration) AS TotalTime
                     FROM timeentries
                    JOIN projects ON timeentries.ProjectID = projects.ProjectID
                    WHERE timeentries.UserID = @UserID AND EntryDate >= DATE_SUB(CURDATE(), INTERVAL 1 WEEK)
                    GROUP BY ProjectName"
                    : @"SELECT ProjectName, SUM(Duration) AS TotalTime
                    FROM timeentries
                    JOIN projects ON timeentries.ProjectID = projects.ProjectID
                    WHERE timeentries.UserID = @UserID AND EntryDate >= DATE_SUB(CURDATE(), INTERVAL 1 MONTH)
                    GROUP BY ProjectName";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    var dataTable = new DataTable();
                    var adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                    DisplayChart(dataTable);
                }
            }
        }

        private void DisplayChart(DataTable dataTable)
        {
            statisticsChart.Series["Project Time"].Points.Clear();

            foreach (DataRow row in dataTable.Rows)
            {
                statisticsChart.Series["Project Time"].Points.AddXY(row["ProjectName"], row["TotalTime"]);
            }
        }
    }
}
