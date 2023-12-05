using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Z.ZClasses
{
    internal class DatabaseClass
    {
        // Connection
        static string databaseConnection = ConfigurationManager.ConnectionStrings["databaseConnection"].ConnectionString;

        // Insert Method
        public int InsertTaskNameAndGetId(string taskName)
        {
            int taskId = -1; // Default value indicating no task ID found

            try
            {
                string query = "INSERT INTO Tasks (TaskName) VALUES (@TaskName); SELECT SCOPE_IDENTITY();";

                using (SqlConnection sqlConnection = new SqlConnection(databaseConnection))
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    // Adding a parameter to the SQL command for the task name
                    command.Parameters.Add("@TaskName", SqlDbType.VarChar, 50).Value = taskName;

                    sqlConnection.Open();
                    // Executing the SQL query and retrieving the generated TaskId
                    taskId = Convert.ToInt32(command.ExecuteScalar()); // Retrieve the generated TaskId
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return taskId; // Returning the generated TaskId or default value (-1) if an error occurred
        }

        public void InsertToTimeRecords(int taskId, DateTime currentDate, TimeSpan startTime, TimeSpan finishTime, TimeSpan spentTime)
        {
            try
            {
                string query = "INSERT INTO TimeRecords (TaskId, CurrentDate, StartTime, FinishTime, SpentTime) " +
                               "VALUES (@TaskId, @CurrentDate, @StartTime, @FinishTime, @SpentTime)";

                using (SqlConnection sqlConnection = new SqlConnection(databaseConnection))
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.Add("@TaskId", SqlDbType.Int).Value = taskId;
                    command.Parameters.Add("@CurrentDate", SqlDbType.Date).Value = currentDate.Date;
                    command.Parameters.Add("@StartTime", SqlDbType.Time).Value = startTime;
                    command.Parameters.Add("@FinishTime", SqlDbType.Time).Value = finishTime;
                    command.Parameters.Add("@SpentTime", SqlDbType.Time).Value = spentTime;

                    sqlConnection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InsertToPomodoroSessions(int taskId, int pomodoroCount)
        {
            try
            {
                string query = "INSERT INTO PomodoroSessions (TaskId, PomodoroCount) " +
                               "VALUES (@TaskId, @PomodoroCount)";

                using (SqlConnection sqlConnection = new SqlConnection(databaseConnection))
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.Add("@TaskId", SqlDbType.Int).Value = taskId;
                    command.Parameters.Add("@PomodoroCount", SqlDbType.Int).Value = pomodoroCount;

                    sqlConnection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Grid Table Method 
        public DataTable LoadDataGridTable()
        {
            DataTable dataTable = new DataTable();

            try
            {
                //T is an alias for the Tasks table.
                //TR is an alias for the TimeRecords table.
                //PS is an alias for the PomodoroSessions table.

                string query = "SELECT T.TaskName AS 'Task Name', " +
                               "TR.CurrentDate AS 'Date Done', " +
                               "TR.StartTime AS 'Start Time', " +
                               "TR.FinishTime AS 'Finish Time', " +
                               "TR.SpentTime AS 'Spent Time', " +
                               "PS.PomodoroCount AS 'Z-Pomodoro' " +
                               "FROM Tasks T " +
                               "INNER JOIN TimeRecords TR ON T.TaskId = TR.TaskId " +
                               "INNER JOIN PomodoroSessions PS ON T.TaskId = PS.TaskId " +
                               "ORDER BY TR.RecordId DESC";

                using (SqlConnection sqlConnection = new SqlConnection(databaseConnection))
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    sqlConnection.Open();
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }

        // Search Method
        public DataTable SearchData(string valueToSearch)
        {
            DataTable dataTable = new DataTable();

            try
            {
                string query = "SELECT T.TaskName AS 'Task Name', " +
                               "TR.CurrentDate AS 'Date Done', " +
                               "TR.StartTime AS 'Start Time', " +
                               "TR.FinishTime AS 'Finish Time', " +
                               "TR.SpentTime AS 'Spent Time', " +
                               "PS.PomodoroCount AS 'Z-Pomodoro' " +
                               "FROM Tasks T " +
                               "INNER JOIN TimeRecords TR ON T.TaskId = TR.TaskId " +
                               "INNER JOIN PomodoroSessions PS ON T.TaskId = PS.TaskId " +
                               "WHERE T.TaskName LIKE @SearchValue " +
                               "OR TR.CurrentDate LIKE @SearchValue " +
                               "OR TR.StartTime LIKE @SearchValue " +
                               "OR TR.FinishTime LIKE @SearchValue " +
                               "OR TR.SpentTime LIKE @SearchValue " +
                               "OR PS.PomodoroCount LIKE @SearchValue " +
                               "ORDER BY T.TaskId DESC"; // Assuming TaskId is the primary key

                using (SqlConnection sqlConnection = new SqlConnection(databaseConnection))
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@SearchValue", "%" + valueToSearch + "%");
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        sqlConnection.Open();
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }
        
        // For Demonstration
        public DataTable ChartDataPerDay()
        {
            DataTable dataTable = new DataTable();
            try
            {
                // Query for pomodoros per day
                string query = "SELECT TR.CurrentDate, COUNT(T.TaskId) AS TotalTasks, " +
                               "SUM(PS.PomodoroCount) AS TotalPomodoroCount " +
                               "FROM Tasks T " +
                               "INNER JOIN TimeRecords TR ON T.TaskId = TR.TaskId " +
                               "INNER JOIN PomodoroSessions PS ON T.TaskId = PS.TaskId " +
                               "GROUP BY TR.CurrentDate " +
                               "ORDER BY TR.CurrentDate DESC";

                using (SqlConnection sqlConnection = new SqlConnection(databaseConnection))
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    sqlConnection.Open();
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }

        // Real Code
        public DataTable ChartDataPerYear()
        {
            DataTable dataTable = new DataTable();
            try
            {
                // Query for pomodoros per year
                string query = "SELECT YEAR(TR.CurrentDate) AS Year, " +
                               "COUNT(T.TaskId) AS TotalTasks, " +
                               "SUM(PS.PomodoroCount) AS TotalPomodoroCount " +
                               "FROM Tasks T " +
                               "INNER JOIN TimeRecords TR ON T.TaskId = TR.TaskId " +
                               "INNER JOIN PomodoroSessions PS ON T.TaskId = PS.TaskId " +
                               "GROUP BY YEAR(TR.CurrentDate) " +
                               "ORDER BY Year DESC";

                using (SqlConnection sqlConnection = new SqlConnection(databaseConnection))
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    sqlConnection.Open();
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }
    }
}