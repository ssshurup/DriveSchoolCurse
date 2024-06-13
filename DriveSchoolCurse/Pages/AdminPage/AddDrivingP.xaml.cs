using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DriveSchoolCurse.Pages.AdminPage
{
    /// <summary>
    /// Логика взаимодействия для AddDrivingP.xaml
    /// </summary>
    public partial class AddDrivingP : Page
    {
        drivingLesson context;
        public AddDrivingP(drivingLesson les)
        {
            InitializeComponent();
            EmployeeCB.ItemsSource = App.DB.employee.ToList();
            StudentCB.ItemsSource = App.DB.Students.ToList();
            context = les;
            DataContext = context;
        }

        private void AddBT_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (context.id == 0)
                    App.DB.drivingLesson.Add(context);
                App.DB.SaveChanges();
                NavigationService.Navigate(new DrivingLessonP());
            }
            catch
            {
                MessageBox.Show("Что-то пошлло не так");
            }
        }

        private void BackBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrivingLessonP());
        }
    }
}
