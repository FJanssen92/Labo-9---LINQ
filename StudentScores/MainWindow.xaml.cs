using StudentScores.Data;
using System.Collections.Generic;
using System.Windows;

namespace StudentScores
{
    public partial class MainWindow : Window
    {
        private StudentStore _store = new StudentStore();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AllStudents_Clicked(object sender, RoutedEventArgs e)
        {
           resultListBox.ItemsSource = _store.AllStudents;
        }

        private void StudentsPassed_Clicked(object sender, RoutedEventArgs e)
        {
            resultListBox.ItemsSource = _store.PassedStudents;
        }

        private void StudentsSortedByname_Clicked(object sender, RoutedEventArgs e)
        {
            resultListBox.ItemsSource = _store.SortedStudents;
        }

        private void StudentsGroupedByDepartment(object sender, RoutedEventArgs e)
        {
            resultListBox.ItemsSource = _store.DepartmentSummaries();
        }

        private void OnSummary_Clicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(_store.StudentSummary().ToString());
            resultListBox.ItemsSource = _store.HighestGradePerDepartment();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(_store.NumberOfDepartments().ToString() + " Departementen.");
        }
    }
}
