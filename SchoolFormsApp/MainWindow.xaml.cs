using SummerSchoolLibrary;
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

namespace SchoolFormsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Push_To(object sender, RoutedEventArgs e)
        {
            School testSchool = new School();
            testSchool.Name = tbName.Text;
            testSchool.Address = tbAddress.Text;
            testSchool.City = tbCity.Text;
            testSchool.State = tbState.Text;
            testSchool.Zip = tbZip.Text;
            testSchool.PhoneNumber = tbPhone.Text;

            //testSchool.SetIsPrivate = "Test2";

            try
            {
                testSchool.TwitterAddress = tbTwitter.Text;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show(testSchool.ToString());
        }

        private void Button_Test_Teacher(object sender, RoutedEventArgs e)
        {
            Teacher teacher = new Teacher();
            float average = teacher.ComputeGradeAverage();
            MessageBox.Show("The teacher's grade average is " + average);
        }

        private void Button_Test_Student(object sender, RoutedEventArgs e)
        {
            Student student = new Student();
            float average = student.ComputeGradeAverage();
            MessageBox.Show("The student's grade average is " + average);
        }

        private void Button_SendMessage_Student(object sender, RoutedEventArgs e)
        {
            Student student = new Student();
            string message = student.SendMessage("For Summer School!");
            MessageBox.Show(message);
        }
    }
}
