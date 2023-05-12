using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BudgetManagement.Panels
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\BudgetManagement\Database1.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            
            if (Login.bilan == "Annuel")
            {
                GenerateAnnualChart();
            }
            else if (Login.bilan == "Hebdomadaire")
            {
                GeneratHebdoChart();
            }
            else if (Login.bilan == "Mensuel")
            {
                GenerateMonthlyChart();
            }
            void GenerateMonthlyChart()
            {
                try
                {
                    // Open the database connection
                    connection.Open();

                    // Create SQL query to retrieve data from expense table for last 30 days
                    string query = "SELECT DATEPART(week, Date) AS Week, Category, SUM(Amount) AS TotalAmount " +
                                   "FROM expense " +
                                   "WHERE Date >= DATEADD(day, -30, GETDATE()) " +
                                   "GROUP BY DATEPART(week, Date), Category";

                    // Create a command to execute the SQL query
                    SqlCommand command = new SqlCommand(query, connection);

                    // Create a data adapter to execute the command and fill a data table
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Clear any existing series from the chart
                    chartExpense.Series.Clear();

                    // Add a series for expense category data
                    chartExpense.Series.Add("Categories");

                    // Set the chart type to doughnut
                    chartExpense.Series["Categories"].ChartType = SeriesChartType.Doughnut;

                    // Bind the data to the chart
                    chartExpense.DataSource = dataTable;

                    // Set the X and Y value members for the series
                    chartExpense.Series["Categories"].XValueMember = "Category";
                    chartExpense.Series["Categories"].YValueMembers = "TotalAmount";

                    // Set the label and legend text
                    chartExpense.Series["Categories"].Label = "#PERCENT{P0}";
                    chartExpense.Series["Categories"].LegendText = "#VALX";

                    // Add a legend to the chart
                    chartExpense.Legends.Add(new Legend("Legend"));
                    chartExpense.Series["Categories"].Legend = "Legend";

                    // Set the color palette for the chart
                    chartExpense.Palette = ChartColorPalette.BrightPastel;
                    chartExpense.Titles.Add("Weekly Expense by Category");
                }

                catch (Exception ex)
                {
                    // Gérer les erreurs de connexion
                    MessageBox.Show("Une erreur est survenue lors de la connexion à la base de données : " + ex.Message);
                }
                finally
                {
                    // Fermer la connexion à la base de données
                    connection.Close();
                }
                try
                {
                    connection.Open();
                    // Open the database connection
                    string query = "SELECT Date, " +
                    "(SELECT SUM(Amount) FROM income WHERE Date = dates.Date) AS Income, " +
                    "(SELECT SUM(Amount) FROM expense WHERE Date = dates.Date) AS Expense " +
                "FROM ( " +
                    "SELECT DISTINCT Date FROM ( " +
                        "SELECT Date FROM income UNION ALL " +
                        "SELECT Date FROM expense " +
                    ") AS AllDates " +
                    "WHERE Date >= DATEADD(month, -1, GETDATE()) " +
                ") AS dates";


                    // Create a command to execute the SQL query
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);

                    chartIncome.Series.Clear();
                    chartIncome.Series.Add("Income");
                    chartIncome.Series.Add("Expense");

                    chartIncome.Series["Income"].ChartType = SeriesChartType.Column;
                    chartIncome.Series["Expense"].ChartType = SeriesChartType.Column;

                    chartIncome.Series["Income"].Color = Color.Blue;
                    chartIncome.Series["Expense"].Color = Color.Red;

                    chartIncome.DataSource = dataSet.Tables[0];

                    chartIncome.Series["Income"].XValueMember = "Date";
                    chartIncome.Series["Income"].YValueMembers = "Income";
                    chartIncome.Series["Expense"].XValueMember = "Date";
                    chartIncome.Series["Expense"].YValueMembers = "Expense";

                    chartIncome.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
                    chartIncome.ChartAreas[0].AxisX.Interval = 1;
                    chartIncome.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM/yyyy";
                    chartIncome.ChartAreas[0].AxisY.Minimum = 0;
                    chartIncome.ChartAreas[0].AxisY.LabelStyle.Format = "{0:C0}";



                }
                catch (Exception ex)
                {
                    // Handle any errors that occur
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    // Close the database connection
                    connection.Close();
                }


                try
                {
                    // Open the database connection
                    connection.Open();

                    // Create SQL query to retrieve data from income table
                    string query = "SELECT DATEPART(week, Date) AS Week, Category, SUM(Amount) AS TotalAmount " +
                       "FROM income " +
                       "WHERE Date >= DATEADD(day, -30, GETDATE()) " +
                       "GROUP BY DATEPART(week, Date), Category";


                    // Create a command to execute the SQL query
                    SqlCommand command = new SqlCommand(query, connection);

                    // Create a data adapter to execute the command and fill a data set
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);

                    // Clear any existing series from the chart
                    chartIncome_category.Series.Clear();

                    // Add a series for income category data
                    chartIncome_category.Series.Add("Categories");

                    // Set the chart type to donut
                    chartIncome_category.Series["Categories"].ChartType = SeriesChartType.Doughnut;

                    // Bind the data to the chart
                    chartIncome_category.DataSource = dataSet.Tables[0];

                    // Set the X and Y value members for the series
                    chartIncome_category.Series["Categories"].XValueMember = "Category";
                    chartIncome_category.Series["Categories"].YValueMembers = "TotalAmount";

                    // Set the label and legend text
                    chartIncome_category.Series["Categories"].Label = "#PERCENT{P0}";
                    chartIncome_category.Series["Categories"].LegendText = "#VALX";

                    // Add a legend to the chart
                    chartIncome_category.Legends.Add(new Legend("Legend"));
                    chartIncome_category.Series["Categories"].Legend = "Legend";

                    // Set the color palette for the chart
                    chartIncome_category.Palette = ChartColorPalette.BrightPastel;
                    chartIncome_category.Titles.Add("Monthly Income by Category");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    // Close the database connection
                    connection.Close();
                }

                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    using (SqlCommand sqlCommand = new SqlCommand("SELECT Date, SUM(Amount) AS TotalAmount FROM income WHERE Date >= DATEADD(day, -7, GETDATE()) GROUP BY Date", sqlConnection))
                    {
                        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                        {
                            DataTable dataTable = new DataTable();
                            sqlDataAdapter.Fill(dataTable);

                            // Plot chart
                            IncomeLine.Series.Clear();
                            IncomeLine.Series.Add("Income");
                            IncomeLine.Series["Income"].ChartType = SeriesChartType.Line;
                            IncomeLine.Series["Income"].Color = Color.Blue;
                            IncomeLine.DataSource = dataTable;
                            IncomeLine.Series["Income"].IsXValueIndexed = false;
                            IncomeLine.Series["Income"].XValueMember = "Date";
                            IncomeLine.Series["Income"].YValueMembers = "TotalAmount";
                            IncomeLine.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
                            IncomeLine.ChartAreas[0].AxisX.Interval = 1;
                            IncomeLine.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM/yyyy";
                            IncomeLine.ChartAreas[0].AxisY.Minimum = 0;
                            IncomeLine.ChartAreas[0].AxisY.LabelStyle.Format = "{0:C0}";
                        }
                    }
                }

                catch (Exception ex)
                {
                    // Handle any errors that occur
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    // Close the database connection
                    connection.Close();
                }
            }
            void GenerateAnnualChart()
            {
                try
                {
                    // Open the database connection
                    connection.Open();

                    // Create SQL query to retrieve data from expense table
                    string query = "SELECT Category, SUM(Amount) AS TotalAmount FROM expense WHERE YEAR(Date) = YEAR(GETDATE()) GROUP BY Category";

                    // Create a command to execute the SQL query
                    SqlCommand command = new SqlCommand(query, connection);

                    // Create a data adapter to execute the command and fill a data table
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Clear any existing series from the chart
                    chartExpense.Series.Clear();

                    // Add a series for expense category data
                    chartExpense.Series.Add("Categories");

                    // Set the chart type to doughnut
                    chartExpense.Series["Categories"].ChartType = SeriesChartType.Doughnut;

                    // Bind the data to the chart
                    chartExpense.DataSource = dataTable;

                    // Set the X and Y value members for the series
                    chartExpense.Series["Categories"].XValueMember = "Category";
                    chartExpense.Series["Categories"].YValueMembers = "TotalAmount";

                    // Set the label and legend text
                    chartExpense.Series["Categories"].Label = "#PERCENT{P0}";
                    chartExpense.Series["Categories"].LegendText = "#VALX";

                    // Add a legend to the chart
                    chartExpense.Legends.Add(new Legend("Legend"));
                    chartExpense.Series["Categories"].Legend = "Legend";

                    // Set the color palette for the chart
                    chartExpense.Palette = ChartColorPalette.BrightPastel;
                    chartExpense.Titles.Add("Annual Expense by Category");

                }
                               
                catch (Exception ex)
                {
                    // Gérer les erreurs de connexion
                    MessageBox.Show("Une erreur est survenue lors de la connexion à la base de données : " + ex.Message);
                }
                finally
                {
                    // Fermer la connexion à la base de données
                    connection.Close();
                }
                try
                {
                    connection.Open();
                    // Open the database connection
                    string query = "SELECT YEAR(Date) AS Year, " +
                                   "SUM(CASE WHEN Type='Income' THEN Amount ELSE 0 END) AS Income, " +
                                   "SUM(CASE WHEN Type='Expense' THEN Amount ELSE 0 END) AS Expense " +
                                   "FROM ( " +
                                   "SELECT Date, Amount, 'Income' AS Type FROM income " +
                                   "UNION ALL " +
                                   "SELECT Date, Amount, 'Expense' AS Type FROM expense " +
                                   ") AS AllData " +
                                   "WHERE Date >= DATEADD(year, -1, GETDATE()) " +
                                   "GROUP BY YEAR(Date)";


                    // Create a command to execute the SQL query
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);

                    chartIncome.Series.Clear();
                    chartIncome.Series.Add("Income");
                    chartIncome.Series.Add("Expense");

                    chartIncome.Series["Income"].ChartType = SeriesChartType.Column;
                    chartIncome.Series["Expense"].ChartType = SeriesChartType.Column;

                    chartIncome.Series["Income"].Color = Color.Blue;
                    chartIncome.Series["Expense"].Color = Color.Red;

                    chartIncome.DataSource = dataSet.Tables[0];

                    chartIncome.Series["Income"].XValueMember = "Year";
                    chartIncome.Series["Income"].YValueMembers = "Income";
                    chartIncome.Series["Expense"].XValueMember = "Year";
                    chartIncome.Series["Expense"].YValueMembers = "Expense";

                    chartIncome.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Years;
                    chartIncome.ChartAreas[0].AxisX.Interval = 1;
                    chartIncome.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy";
                    chartIncome.ChartAreas[0].AxisY.Minimum = 0;
                    chartIncome.ChartAreas[0].AxisY.LabelStyle.Format = "{0:C0}";
                }




                catch (Exception ex)
                {
                    // Handle any errors that occur
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    // Close the database connection
                    connection.Close();
                }
                try
                {
                    // Open the database connection
                    connection.Open();

                    // Create SQL query to retrieve data from income table
                    string query = "SELECT Category, SUM(Amount) AS TotalAmount FROM income WHERE YEAR(Date) = 2023 GROUP BY Category";

                    // Create a command to execute the SQL query
                    SqlCommand command = new SqlCommand(query, connection);

                    // Create a data adapter to execute the command and fill a data set
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);

                    // Clear any existing series from the chart
                    chartIncome_category.Series.Clear();

                    // Add a series for income category data
                    chartIncome_category.Series.Add("Categories");

                    // Set the chart type to donut
                    chartIncome_category.Series["Categories"].ChartType = SeriesChartType.Doughnut;

                    // Bind the data to the chart
                    chartIncome_category.DataSource = dataSet.Tables[0];

                    // Set the X and Y value members for the series
                    chartIncome_category.Series["Categories"].XValueMember = "Category";
                    chartIncome_category.Series["Categories"].YValueMembers = "TotalAmount";

                    // Set the label and legend text
                    chartIncome_category.Series["Categories"].Label = "#PERCENT{P0}";
                    chartIncome_category.Series["Categories"].LegendText = "#VALX";

                    // Add a legend to the chart
                    chartIncome_category.Legends.Add(new Legend("Legend"));
                    chartIncome_category.Series["Categories"].Legend = "Legend";

                    // Set the color palette for the chart
                    chartIncome_category.Palette = ChartColorPalette.BrightPastel;

                    // Set the chart title
                    chartIncome_category.Titles.Add("Annual Income by Category");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    // Close the database connection
                    connection.Close();
                }
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    using (SqlCommand sqlCommand = new SqlCommand("SELECT YEAR(Date) AS Year, SUM(Amount) AS TotalAmount FROM income GROUP BY YEAR(Date)", sqlConnection))
                    {
                        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                        {
                            DataTable dataTable = new DataTable();
                            sqlDataAdapter.Fill(dataTable);

                            // Plot chart
                            IncomeLine.Series.Clear();
                            IncomeLine.Series.Add("Income");
                            IncomeLine.Series["Income"].ChartType = SeriesChartType.Line;
                            IncomeLine.Series["Income"].Color = Color.Blue;
                            IncomeLine.DataSource = dataTable;
                            IncomeLine.Series["Income"].IsXValueIndexed = false;
                            IncomeLine.Series["Income"].XValueMember = "Year";
                            IncomeLine.Series["Income"].YValueMembers = "TotalAmount";
                            IncomeLine.ChartAreas[0].AxisX.Interval = 1;
                            IncomeLine.ChartAreas[0].AxisX.Minimum = dataTable.Rows[0].Field<int>("Year");
                            IncomeLine.ChartAreas[0].AxisX.Maximum = dataTable.Rows[dataTable.Rows.Count - 1].Field<int>("Year");
                            IncomeLine.ChartAreas[0].AxisY.Minimum = 0;
                            IncomeLine.ChartAreas[0].AxisY.LabelStyle.Format = "{0:C0}";
                        }
                    }
                }



                catch (Exception ex)
                {
                    // Handle any errors that occur
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    // Close the database connection
                    connection.Close();
                }

            }

            void GeneratHebdoChart()
            {
                try
                {
                    // Open the database connection
                    connection.Open();

                    // Create SQL query to retrieve data from expense table
                    string query = "SELECT DATEPART(week, Date) AS Week, Category, SUM(Amount) AS TotalAmount FROM expense WHERE YEAR(Date) = YEAR(GETDATE()) GROUP BY DATEPART(week, Date), Category";

                    // Create a command to execute the SQL query
                    SqlCommand command = new SqlCommand(query, connection);

                    // Create a data adapter to execute the command and fill a data table
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Clear any existing series from the chart
                    chartExpense.Series.Clear();

                    // Add a series for expense category data
                    chartExpense.Series.Add("Categories");

                    // Set the chart type to doughnut
                    chartExpense.Series["Categories"].ChartType = SeriesChartType.Doughnut;

                    // Bind the data to the chart
                    chartExpense.DataSource = dataTable;

                    // Set the X and Y value members for the series
                    chartExpense.Series["Categories"].XValueMember = "Category";
                    chartExpense.Series["Categories"].YValueMembers = "TotalAmount";

                    // Set the label and legend text
                    chartExpense.Series["Categories"].Label = "#PERCENT{P0}";
                    chartExpense.Series["Categories"].LegendText = "#VALX";

                    // Add a legend to the chart
                    chartExpense.Legends.Add(new Legend("Legend"));
                    chartExpense.Series["Categories"].Legend = "Legend";

                    // Set the color palette for the chart
                    chartExpense.Palette = ChartColorPalette.BrightPastel;
                    chartExpense.Titles.Add("Weekly Expense by Category");
                }


                catch (Exception ex)
                {
                    // Gérer les erreurs de connexion
                    MessageBox.Show("Une erreur est survenue lors de la connexion à la base de données : " + ex.Message);
                }
                finally
                {
                    // Fermer la connexion à la base de données
                    connection.Close();
                }
                try
                {
                    connection.Open();
                    // Open the database connection
                    string query = "SELECT DATEPART(WEEK, Date) AS WeekNumber, " +
                                   "SUM(CASE WHEN Type='Income' THEN Amount ELSE 0 END) AS Income, " +
                                   "SUM(CASE WHEN Type='Expense' THEN Amount ELSE 0 END) AS Expense " +
                                   "FROM ( " +
                                   "SELECT Date, Amount, 'Income' AS Type FROM income " +
                                   "UNION ALL " +
                                   "SELECT Date, Amount, 'Expense' AS Type FROM expense " +
                                   ") AS AllData " +
                                   "WHERE Date >= DATEADD(week, -52, GETDATE()) " +
                                   "GROUP BY DATEPART(WEEK, Date)";


                    // Create a command to execute the SQL query
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);

                    chartIncome.Series.Clear();
                    chartIncome.Series.Add("Income");
                    chartIncome.Series.Add("Expense");

                    chartIncome.Series["Income"].ChartType = SeriesChartType.Column;
                    chartIncome.Series["Expense"].ChartType = SeriesChartType.Column;

                    chartIncome.Series["Income"].Color = Color.Blue;
                    chartIncome.Series["Expense"].Color = Color.Red;

                    chartIncome.DataSource = dataSet.Tables[0];

                    chartIncome.Series["Income"].XValueMember = "WeekNumber";
                    chartIncome.Series["Income"].YValueMembers = "Income";
                    chartIncome.Series["Expense"].XValueMember = "WeekNumber";
                    chartIncome.Series["Expense"].YValueMembers = "Expense";

                    chartIncome.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Weeks;
                    chartIncome.ChartAreas[0].AxisX.Interval = 1;
                    chartIncome.ChartAreas[0].AxisY.Minimum = 0;
                    chartIncome.ChartAreas[0].AxisY.LabelStyle.Format = "{0:C0}";

                }


                catch (Exception ex)
                {
                    // gérer les erreurs de connexion
                    MessageBox.Show("Une erreur est survenue lors de la connexion à la base de données : " + ex.Message);
                }
                finally
                {
                    // Close the database connection
                    connection.Close();
                }

                try
                {
                    // Open the database connection
                    connection.Open();

                    // Create SQL query to retrieve data from income table
                    string query = "SELECT Category, SUM(Amount) AS TotalAmount FROM income WHERE DATEPART(wk, Date) = DATEPART(wk, GETDATE()) AND YEAR(Date) = YEAR(GETDATE()) GROUP BY Category";

                    // Create a command to execute the SQL query
                    SqlCommand command = new SqlCommand(query, connection);

                    // Create a data adapter to execute the command and fill a data set
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);

                    // Clear any existing series from the chart
                    chartIncome_category.Series.Clear();

                    // Add a series for income category data
                    chartIncome_category.Series.Add("Categories");

                    // Set the chart type to donut
                    chartIncome_category.Series["Categories"].ChartType = SeriesChartType.Doughnut;

                    // Bind the data to the chart
                    chartIncome_category.DataSource = dataSet.Tables[0];

                    // Set the X and Y value members for the series
                    chartIncome_category.Series["Categories"].XValueMember = "Category";
                    chartIncome_category.Series["Categories"].YValueMembers = "TotalAmount";

                    // Set the label and legend text
                    chartIncome_category.Series["Categories"].Label = "#PERCENT{P0}";
                    chartIncome_category.Series["Categories"].LegendText = "#VALX";

                    // Add a legend to the chart
                    chartIncome_category.Legends.Add(new Legend("Legend"));
                    chartIncome_category.Series["Categories"].Legend = "Legend";

                    // Set the color palette for the chart
                    chartIncome_category.Palette = ChartColorPalette.BrightPastel;
                    chartIncome_category.Titles.Add("Weekly Income by Category ");
                }


                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    // Close the database connection
                    connection.Close();
                }

                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    using (SqlCommand sqlCommand = new SqlCommand("SELECT DATEPART(wk, Date) AS WeekNumber, SUM(Amount) AS TotalAmount FROM income GROUP BY DATEPART(wk, Date)", sqlConnection))
                    {
                        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                        {
                            DataTable dataTable = new DataTable();
                            sqlDataAdapter.Fill(dataTable);

                            // Plot chart
                            IncomeLine.Series.Clear();
                            IncomeLine.Series.Add("Income");
                            IncomeLine.Series["Income"].ChartType = SeriesChartType.Line;
                            IncomeLine.Series["Income"].Color = Color.Blue;
                            IncomeLine.DataSource = dataTable;
                            IncomeLine.Series["Income"].IsXValueIndexed = false;
                            IncomeLine.Series["Income"].XValueMember = "WeekNumber";
                            IncomeLine.Series["Income"].YValueMembers = "TotalAmount";
                            IncomeLine.ChartAreas[0].AxisX.Interval = 1;
                            IncomeLine.ChartAreas[0].AxisX.Minimum = 1;
                            IncomeLine.ChartAreas[0].AxisY.Minimum = 0;
                            IncomeLine.ChartAreas[0].AxisY.LabelStyle.Format = "{0:C0}";
                        }
                    }
                }

                catch (Exception ex)
                {
                    // Handle any errors that occur
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    // Close the database connection
                    connection.Close();
                }
            }
        }

    }
}
