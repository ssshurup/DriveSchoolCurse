using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Логика взаимодействия для AdminP.xaml
    /// </summary>
    public partial class AdminP : Page
    {
        public AdminP()
        {
            InitializeComponent();
        }

        private void EmployeeBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EmployeeP());
        }

        private void CarBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new VehiclesP());
        }

        private void StudentsBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StudentsP());
        }

        private void TheoryBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TheoryLessonP());
        }

        private void BackBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LoginP());
        }

        private void DrivingBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrivingLessonP());
        }
    }
}
