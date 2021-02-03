using MVVMDemo.ViewModel;
using System.Windows;

namespace MVVMDemo
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

        //private void StudentViewControl_Loaded(object sender, RoutedEventArgs e)
        //{
        //    ViewModel.StudentViewModel studentViewModelObject = new ViewModel.StudentViewModel();
        //    studentViewModelObject.LoadStudents();
        //    StudentViewControl.DataContext = studentViewModelObject;
        //}



        private void TeacherViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            ViewModel.TeacherViewModel teacherViewModelObject = new ViewModel.TeacherViewModel();
            teacherViewModelObject.LoadTeachers();
            TeacherViewControl.DataContext = teacherViewModelObject;
        }


    }
}
