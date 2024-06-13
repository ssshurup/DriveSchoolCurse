﻿using System;
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
    /// Логика взаимодействия для EmployeeP.xaml
    /// </summary>
    public partial class EmployeeP : Page
    {
        public EmployeeP()
        {
            InitializeComponent();
            EmployeeDG.ItemsSource = App.DB.employee.ToList();
        }

        private void BackBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminP()) ;
        }
        private void AddBT_Click(object sender, RoutedEventArgs e)
        {
            employee emp = new employee();
            NavigationService.Navigate(new AddEmployeeP(emp));
        }

        private void EditBT_Click(object sender, RoutedEventArgs e)
        {
            var selectedEmp = EmployeeDG.SelectedItem as employee;
            if (selectedEmp != null)
            {
                NavigationService.Navigate(new AddEmployeeP(selectedEmp));
            }
            else MessageBox.Show("Выберите сотрудника");
        }

        private void DropBT_Click(object sender, RoutedEventArgs e)
        {
            var selectedEmp = EmployeeDG.SelectedItem as employee;
            if (selectedEmp != null)
            {
                App.DB.employee.Remove(selectedEmp);
                App.DB.SaveChanges();
                EmployeeDG.ItemsSource = App.DB.employee.ToList();
            }
            else MessageBox.Show("Выберите сотрудника");
        }
    }
}
