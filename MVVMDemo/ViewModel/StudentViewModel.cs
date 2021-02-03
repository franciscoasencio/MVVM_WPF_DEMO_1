﻿using MVVMDemo.Model;
using System.Collections.ObjectModel;
namespace MVVMDemo.ViewModel
{
    public class StudentViewModel
    {

        public StudentViewModel()
        {
            LoadStudents();
        }

        public ObservableCollection<Student> Students
        {
            get;
            set;
        }

        public void LoadStudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>();

            students.Add(new Student { FirstName = "Mark", LastName = "Allain" });
            students.Add(new Student { FirstName = "Allen", LastName = "Brown" });
            students.Add(new Student { FirstName = "Linda", LastName = "Hamerski" });
            students.Add(new Student { FirstName = "Francisco", LastName = "Asencio" });
                        
            Students = students;
        }
    }
}