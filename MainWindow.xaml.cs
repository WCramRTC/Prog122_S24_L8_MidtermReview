using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog122_S24_L8_MidtermReview
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Schedule> previousSchedules = new List<Schedule>();
        ClassProgram programs = new ClassProgram();
        Schedule currentSchedule; // No need to initialize here, constructor does it

        public MainWindow()
        {
            InitializeComponent();
            currentSchedule = new Schedule(); // Initialize currentSchedule 
            cmbChooseSchedule.ItemsSource = previousSchedules;
        }

        // ... (rest of your code)

        private void btnAddProgramming_Click(object sender, RoutedEventArgs e)
        {
            // Ensure there are programming courses available
         
                currentSchedule.Courses.Add(programs.ProgrammingCourses[0]); // Add first programming course
                rtbDisplaySchedule.Text = currentSchedule.FormatSchedule();


        }

        private void btnDatabase_Click(object sender, RoutedEventArgs e)
        {

                currentSchedule.AddCourse(programs.DatabaseCourses[0]); // Add first database course
                rtbDisplaySchedule.Text = currentSchedule.FormatSchedule();
        }

        private void btnFrontEnd_Click(object sender, RoutedEventArgs e)
        {
                currentSchedule.Courses.Add(programs.FrontEndCourses[0]); // Add first front-end course
                rtbDisplaySchedule.Text = currentSchedule.FormatSchedule();
        }

        private void btnFinalizeSchedule_Click(object sender, RoutedEventArgs e)
        {
            string studentName = txtName.Text.Trim();
            if (!string.IsNullOrEmpty(studentName))
            {
                currentSchedule.StudentName = studentName; // Assign the name
                previousSchedules.Add(currentSchedule);    // Add to previous schedules
                cmbChooseSchedule.ItemsSource = previousSchedules; // Reset with updated list
                cmbChooseSchedule.Items.Refresh();

                txtName.Clear();       // Clear the name textbox
                currentSchedule = new Schedule(); // Create a new current schedule 
            }
            else
            {
                MessageBox.Show("Enter a name");
            }
        }

        private void cmbChooseSchedule_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Schedule selectedSchedule = cmbChooseSchedule.SelectedItem as Schedule;

            rtbPreviousSchedule.Text = selectedSchedule.FormatSchedule();
        }
    }
}
