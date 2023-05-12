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

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Omar Bnh\source\repos\BudgetManagement\Database1.mdf;Integrated Security=True";
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
                    // Ouvrir la connexion à la base de données
                    connection.Open();

                    // Requête SQL pour récupérer les données de votre table expense
                    string query = "SELECT DATEPART(week, Date) AS Week, Category, SUM(Amount) AS TotalAmount FROM expense GROUP BY DATEPART(week, Date), Category";


                    // Créer une commande pour exécuter la requête SQL
                    SqlCommand command = new SqlCommand(query, connection);

                    // Créer un adaptateur de données pour exécuter la commande et remplir un DataSet
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Lier les données à votre chartExpense
                    chartExpense.DataSource = dataTable;
                    chartExpense.Series[0].XValueMember = "Category";
                    chartExpense.Series[0].YValueMembers = "TotalAmount";

                    // Configurer le type de chart
                    chartExpense.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
                    chartExpense.Series[0].IsValueShownAsLabel = true;
                    chartExpense.Legends[0].Enabled = true;
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
                    // Open the database connection
                    connection.Open();

                    // Create SQL query to retrieve data from income and expense tables for the last 4 weeks
                    string query = "SELECT CAST(Date AS DATE) AS WeekStart, SUM(Amount) AS TotalAmount, 'Income' AS Category " +
                                    "FROM income " +
                                    "WHERE Date >= DATEADD(week, -4, GETDATE()) " +
                                    "GROUP BY CAST(Date AS DATE) " +
                                    "UNION ALL " +
                                    "SELECT CAST(Date AS DATE) AS WeekStart, SUM(Amount) AS TotalAmount, 'Expense' AS Category " +
                                    "FROM expense " +
                                    "WHERE Date >= DATEADD(week, -4, GETDATE()) " +
                                    "GROUP BY CAST(Date AS DATE)";

                    // Create a command to execute the SQL query
                    SqlCommand command = new SqlCommand(query, connection);

                    // Create a data adapter to execute the command and fill a data set
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);

                    // Clear any existing series from the chart
                    chartIncome.Series.Clear();

                    // Add a series for income and expense data
                    chartIncome.Series.Add("Income");
                    chartIncome.Series.Add("Expense");

                    // Set the chart type to column
                    chartIncome.Series["Income"].ChartType = SeriesChartType.Column;
                    chartIncome.Series["Expense"].ChartType = SeriesChartType.Column;

                    // Set the colors of the columns
                    chartIncome.Series["Income"].Color = Color.Blue;
                    chartIncome.Series["Expense"].Color = Color.Red;

                    // Bind the data to the chart
                    chartIncome.DataSource = dataSet.Tables[0];

                    // Set the X and Y value members for each series
                    chartIncome.Series["Income"].XValueMember = "WeekStart";
                    chartIncome.Series["Income"].YValueMembers = "TotalAmount";
                    chartIncome.Series["Expense"].XValueMember = "WeekStart";
                    chartIncome.Series["Expense"].YValueMembers = "TotalAmount";

                    // Add a legend to distinguish the series
                    chartIncome.Legends.Add(new Legend("Legend"));
                    chartIncome.Series["Income"].Legend = "Legend";
                    chartIncome.Series["Expense"].Legend = "Legend";

                    // Set the axis labels and formatting
                    chartIncome.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Weeks;
                    chartIncome.ChartAreas[0].AxisX.Interval = 1;
                    chartIncome.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM/yyyy";

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
                    string query = "SELECT DATEPART(week, Date) AS Week, Category, SUM(Amount) AS TotalAmount FROM income GROUP BY DATEPART(week, Date), Category";


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
                    // Ouvrir la connexion à la base de données
                    connection.Open();

                    // Requête SQL pour récupérer les données de votre table expense
                    string query = "SELECT Category, SUM(Amount) AS TotalAmount FROM expense WHERE YEAR(Date) = 2023 GROUP BY Category";

                    // Créer une commande pour exécuter la requête SQL
                    SqlCommand command = new SqlCommand(query, connection);

                    // Créer un adaptateur de données pour exécuter la commande et remplir un DataSet
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Lier les données à votre chartExpense
                    chartExpense.DataSource = dataTable;
                    chartExpense.Series[0].XValueMember = "Category";
                    chartExpense.Series[0].YValueMembers = "TotalAmount";

                    // Configurer le type de chart
                    chartExpense.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
                    chartExpense.Series[0].IsValueShownAsLabel = true;
                    chartExpense.Legends[0].Enabled = true;
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
                    // Open the database connection
                    connection.Open();

                    // Create SQL query to retrieve income for the given year
                    string query = "SELECT YEAR(Date) AS Year, SUM(Amount) AS TotalAmount, 'Income' AS Category FROM income GROUP BY YEAR(Date) " +
                "UNION ALL " +
                "SELECT YEAR(Date) AS Year, SUM(Amount) AS TotalAmount, 'Expense' AS Category FROM expense GROUP BY YEAR(Date)";


                    // Create a command to execute the SQL query
                    SqlCommand command = new SqlCommand(query, connection);

                    // Add a parameter for the year
                    command.Parameters.AddWithValue("@year", 2022); // Replace 2022 with the desired year

                    // Create a data adapter to execute the command and fill a data set
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);

                    // Clear any existing series from the chart
                    chartIncome.Series.Clear();

                    // Add a series for income data
                    chartIncome.Series.Add("Income");

                    // Set the chart type to column
                    chartIncome.Series["Income"].ChartType = SeriesChartType.Column;

                    // Set the color of the column
                    chartIncome.Series["Income"].Color = Color.Blue;

                    // Bind the data to the chart
                    chartIncome.DataSource = dataSet.Tables[0];

                    // Set the X and Y value members for the series
                    chartIncome.Series["Income"].XValueMember = "Year";
                    chartIncome.Series["Income"].YValueMembers = "TotalAmount";

                    // Set the axis labels and formatting
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
                    using (SqlCommand sqlCommand = new SqlCommand("SELECT Date, SUM(Amount) AS TotalAmount FROM income GROUP BY Date", sqlConnection))
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
                            IncomeLine.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Years;
                            IncomeLine.ChartAreas[0].AxisX.Interval = 1;
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
                    // Ouvrir la connexion à la base de données
                    connection.Open();

                    // Requête SQL pour récupérer les données de votre table expense
                    string query = "SELECT Category, SUM(Amount) as TotalAmount FROM expense GROUP BY Category";

                    // Créer une commande pour exécuter la requête SQL
                    SqlCommand command = new SqlCommand(query, connection);

                    // Créer un adaptateur de données pour exécuter la commande et remplir un DataSet
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Lier les données à votre chartExpense
                    chartExpense.DataSource = dataTable;
                    chartExpense.Series[0].XValueMember = "Category";
                    chartExpense.Series[0].YValueMembers = "TotalAmount";

                    // Configurer le type de chart
                    chartExpense.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
                    chartExpense.Series[0].IsValueShownAsLabel = true;
                    chartExpense.Legends[0].Enabled = true;
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
                    // Open the database connection
                    connection.Open();

                    // Create SQL query to retrieve data from income and expense tables for the last month
                    string query = "SELECT Date, SUM(Amount) AS TotalAmount, 'Income' AS Category FROM income WHERE Date >= DATEADD(month, -1, GETDATE()) GROUP BY Date " +
                                   "UNION ALL " +
                                   "SELECT Date, SUM(Amount) AS TotalAmount, 'Expense' AS Category FROM expense WHERE Date >= DATEADD(month, -1, GETDATE()) GROUP BY Date";

                    // Create a command to execute the SQL query
                    SqlCommand command = new SqlCommand(query, connection);

                    // Create a data adapter to execute the command and fill a data set
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);

                    // Clear any existing series from the chart
                    chartIncome.Series.Clear();

                    // Add a series for income and expense data
                    chartIncome.Series.Add("Income");
                    chartIncome.Series.Add("Expense");

                    // Set the chart type to column
                    chartIncome.Series["Income"].ChartType = SeriesChartType.Column;
                    chartIncome.Series["Expense"].ChartType = SeriesChartType.Column;

                    // Set the colors of the columns
                    chartIncome.Series["Income"].Color = Color.Blue;
                    chartIncome.Series["Expense"].Color = Color.Red;

                    // Bind the data to the chart
                    chartIncome.DataSource = dataSet.Tables[0];

                    // Set the X and Y value members for each series
                    chartIncome.Series["Income"].XValueMember = "Date";
                    chartIncome.Series["Income"].YValueMembers = "TotalAmount";
                    chartIncome.Series["Expense"].XValueMember = "Date";
                    chartIncome.Series["Expense"].YValueMembers = "TotalAmount";

                    // Add a legend to distinguish the series
                    chartIncome.Legends.Add(new Legend("Legend"));
                    chartIncome.Series["Income"].Legend = "Legend";
                    chartIncome.Series["Expense"].Legend = "Legend";

                    // Set the axis labels and formatting
                    chartIncome.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
                    chartIncome.ChartAreas[0].AxisX.Interval = 1;
                    chartIncome.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM/yyyy";

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
                    string query = "SELECT Category, SUM(Amount) AS TotalAmount FROM income GROUP BY Category";


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
                    using (SqlCommand sqlCommand = new SqlCommand("SELECT Date, SUM(Amount) AS TotalAmount FROM income GROUP BY Date", sqlConnection))
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
        }

    }
}
