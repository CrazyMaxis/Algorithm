using Algorithm.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.ViewModel
{
    public class DataManageCourses
    {
        private ObservableCollection<Model.Courses> _courses = new ObservableCollection<Model.Courses>(DataWorker.GetAllCourses());
        public ObservableCollection<Model.Courses> Courses { get { return _courses; } }
    }
}
