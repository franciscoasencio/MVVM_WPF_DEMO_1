﻿using MVVMDemo.ViewModel;
using System.Windows.Controls;

namespace MVVMDemo.Views
{
    /// <summary>
    /// Interaction logic for StudentView.xaml
    /// </summary>
    public partial class StudentView : UserControl
    {
        public StudentView()
        {
            InitializeComponent();
            this.DataContext = new StudentViewModel();
        }
    }
}
