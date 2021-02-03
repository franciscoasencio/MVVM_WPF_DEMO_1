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

        // as in chapter 4 , this is the "Loaded" instruction executed
        // In chapter 5 This Method is not used. "Load" in constructor, Data Context in Viewmodel Code
        //private void StudentViewControl_Loaded(object sender, RoutedEventArgs e)
        //{
        //    ViewModel.StudentViewModel studentViewModelObject = new ViewModel.StudentViewModel();
        //    //studentViewModelObject.LoadStudents();
        //    //StudentViewControl.DataContext = studentViewModelObject;
        //}
        ////=================================================================

    }
}
