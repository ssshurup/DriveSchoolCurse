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
    /// Логика взаимодействия для StudentsP.xaml
    /// </summary>
    public partial class StudentsP : Page
    {
        public StudentsP()
        {
            InitializeComponent();
            StudentsDG.ItemsSource = App.DB.Students.ToList();
        }

        private void AddBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddStudentP());
        }

        private void EditBT_Click(object sender, RoutedEventArgs e)
        {
            var selectedStud = StudentsDG.SelectedItem as Students;
            if (selectedStud != null)
            {
                NavigationService.Navigate(new EditStudentP(selectedStud));
            }
        }

        private void DropBT_Click(object sender, RoutedEventArgs e)
        {
            var selectedStud = StudentsDG.SelectedItem as Students;
            if(selectedStud != null)
            {
                App.DB.Students.Remove(selectedStud);
                App.DB.SaveChanges();
                StudentsDG.ItemsSource = App.DB.Students.ToList();
            }
        }

        private void BackBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminP());
        }
    }
}
