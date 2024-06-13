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
    /// Логика взаимодействия для AddStudentP.xaml
    /// </summary>
    public partial class AddStudentP : Page
    {
        Students context;
        public AddStudentP()
        {
            InitializeComponent();
            CategoryCB.ItemsSource = App.DB.category.ToList();
            DiscountCB.ItemsSource = App.DB.discount.ToList();
            GroupCB.ItemsSource = App.DB.studGroup.ToList();
            context = new Students();
            DataContext = context;
        }

        private void AddBT_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                context.isExam = false;
                context.isTheory = false;
                context.idDiscount = 1;
                App.DB.Students.Add(context);
                StudentAndGroup sag = new StudentAndGroup();
                var selectedGroup = GroupCB.SelectedItem as studGroup;
                sag.idGroup = selectedGroup.id;
                sag.idStudent = context.id;
                App.DB.StudentAndGroup.Add(sag);
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
