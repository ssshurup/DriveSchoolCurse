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
    /// Логика взаимодействия для DrivingLessonP.xaml
    /// </summary>
    public partial class DrivingLessonP : Page
    {
        public DrivingLessonP()
        {
            InitializeComponent();
            LessonDG.ItemsSource = App.DB.drivingLesson.ToList();
        }

        private void AddBT_Click(object sender, RoutedEventArgs e)
        {
            drivingLesson les = new drivingLesson();
            NavigationService.Navigate(new AddDrivingP(les));
        }

        private void EditBT_Click(object sender, RoutedEventArgs e)
        {
            var selectedLes = LessonDG.SelectedItem as drivingLesson;
            if (selectedLes != null)
            {
                NavigationService.Navigate(new AddDrivingP(selectedLes));
            }
            else MessageBox.Show("Выберите занятие");
        }

        private void DropBT_Click(object sender, RoutedEventArgs e)
        {
            var selectedLes = LessonDG.SelectedItem as drivingLesson;
            if (selectedLes != null)
            {
                App.DB.drivingLesson.Remove(selectedLes);
                App.DB.SaveChanges();
                LessonDG.ItemsSource = App.DB.drivingLesson.ToList();
            }
            else MessageBox.Show("Выберите занятие");
        }

        private void BackBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminP());
        }
    }
}
