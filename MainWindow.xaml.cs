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

        public MainWindow()
        {
            InitializeComponent();

            Schedule mySchedule = new Schedule("Will");

            // How to add a class from a "class program instance" to our schedule
            Course progCourse = programs.ProgrammingCourses[0];
            mySchedule.Courses.Add(progCourse);
            mySchedule.Courses.Add(programs.FrontEndCourses[0]);

            previousSchedules.Add(mySchedule);

            cmbChooseSchedule.ItemsSource = previousSchedules;
        }

        private void cmbChooseSchedule_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // 1. Create a list in MainWindow for List<Schedule>
            // Call it - previousSchedules
            // 2. Add the list to the cmbChooseSchedule.ItemsSource
            // 3. Inside of the ComboBox Click event, get the selected intem
            Schedule selectedSchedule = (Schedule)cmbChooseSchedule.SelectedItem;

            // 4. Assign the selectedItems.FormattedSchedule() to the rtbPreviousSchedule
            rtbPreviousSchedule.Text = selectedSchedule.FormatSchedule();

        }

        private void btnAddProgramming_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDatabase_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnFrontEnd_Click(object sender, RoutedEventArgs e)
        {

        }

        // Add a combo box
        // Add another rich text box ( named rtbPreviousSchedule )

    }
}