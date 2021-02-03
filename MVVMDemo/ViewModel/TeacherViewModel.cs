using MVVMDemo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDemo.ViewModel
{
    public class TeacherViewModel
    {

        public ObservableCollection<Teacher> Teachers
        {   
            get;
            set;
        }

        public void LoadTeachers()
        {

            ObservableCollection<Teacher> teachers = new ObservableCollection<Teacher>();
            teachers.Add(new Teacher { FirstName = "Carlos", LastName = "Arados" });
            teachers.Add(new Teacher { FirstName = "Carmen", LastName = "Luz" }); 
            teachers.Add(new Teacher { FirstName = "Pamela", LastName = "Neira" });

            Teachers = teachers;

        }



    }
}
