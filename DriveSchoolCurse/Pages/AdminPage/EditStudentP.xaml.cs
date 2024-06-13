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
    /// Логика взаимодействия для EditStudentP.xaml
    /// </summary>
    public partial class EditStudentP : Page
    {
        Students context;
        public EditStudentP(Students stud)
        {
            InitializeComponent();
            CategoryCB.ItemsSource = App.DB.category.ToList();
            DiscountCB.ItemsSource = App.DB.discount.ToList();
            GroupCB.ItemsSource = App.DB.studGroup.ToList();
            context = stud;
            DataContext = context; 
        }

        private void AddBT_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var selectedGroup = GroupCB.SelectedItem as studGroup;
                var editedGroup = App.DB.StudentAndGroup.Where(a => a.idStudent == context.id).ToList();
                editedGroup.First().idGroup = selectedGroup.id;
                App.DB.SaveChanges();
                NavigationService.Navigate(new StudentsP());
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так");
            }
        }

        private void BackBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StudentsP());
        }
    }
}
