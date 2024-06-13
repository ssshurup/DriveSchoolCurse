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
    /// Логика взаимодействия для TheoryLessonP.xaml
    /// </summary>
    public partial class TheoryLessonP : Page
    {
        public TheoryLessonP()
        {
            InitializeComponent();
            LessonDG.ItemsSource = App.DB.theoryLesson.ToList();
        }

        private void AddBT_Click(object sender, RoutedEventArgs e)
        {
            theoryLesson les = new theoryLesson();
            NavigationService.Navigate(new AddTheoryP(les));
        }

        private void EditBT_Click(object sender, RoutedEventArgs e)
        {
            var selectedLesson = LessonDG.SelectedItem as theoryLesson;
            if (selectedLesson != null)
            {
                NavigationService.Navigate(new AddTheoryP(selectedLesson));
            }
            else MessageBox.Show("Выберите занятие");
        }

        private void DropBT_Click(object sender, RoutedEventArgs e)
        {
            var selectedLesson = LessonDG.SelectedItem as theoryLesson;
            if (selectedLesson != null)
            {
                App.DB.theoryLesson.Remove(selectedLesson);
                App.DB.SaveChanges();
                LessonDG.ItemsSource = App.DB.theoryLesson.ToList();
            }
            else MessageBox.Show("Выберите занятие");
        }

        private void BackBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminP());
        }
    }
}
