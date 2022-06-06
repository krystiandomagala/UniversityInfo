namespace UniversityInfo
{
    using System.Data;
    using System.Data.SqlClient;
    using System.Text.RegularExpressions;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;

    /// <summary>
    /// Logika interakcji dla klasy Positions.xaml.
    /// </summary>
    public partial class Positions : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Positions"/> class.
        /// </summary>
        public Positions()
        {
            InitializeComponent();
            LoadGrid();
        }

        /// <summary>
        /// Defines the conn.
        /// </summary>
        internal SqlConnection conn = new SqlConnection(@"Data Source=K-KRYSTIAN\SQLEXPRESS;Initial Catalog=university;Integrated Security=True");

        /// <summary>
        /// The LoadGrid.
        /// </summary>
        public void LoadGrid()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM acad_positions", conn);
            DataTable dataTable = new DataTable();
            conn.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            dataTable.Load(dataReader);
            conn.Close();
            StudentsTable.ItemsSource = dataTable.DefaultView;
        }

        /// <summary>
        /// The ClearData.
        /// </summary>
        public void ClearData()
        {
            overtimeRate.Clear();
        }

        /// <summary>
        /// The PositionsOvertimeRateValidation.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="TextCompositionEventArgs"/>.</param>
        private void PositionsOvertimeRateValidation(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        /// <summary>
        /// The UpdatePositions.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="RoutedEventArgs"/>.</param>
        private void UpdatePositions(object sender, RoutedEventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand($"UPDATE acad_positions SET " +
                $"overtime_rate = '{overtimeRate.Text}'" +
                $"WHERE acad_position like '{academicPosition.Text}'", conn);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Record has been updated successfully", "Updated", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                ClearData();
                LoadGrid();
            }
        }
    }
}
