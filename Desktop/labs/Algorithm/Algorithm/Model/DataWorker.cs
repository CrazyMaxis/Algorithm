using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.Model.Data;

namespace Algorithm.Model
{
    public static class DataWorker
    {
        public static void CreateUser(string login, string email, string password)
        {
            using(ApplicationContext db = new ApplicationContext())
            {
                if (!db.USERS.Any(el => el.LOGIN == login))
                {
                    User newUser = new User { LOGIN = login, EMAIL = email, PASSWORD = password, LEVEL = 0 };
                    db.USERS.Add(newUser);
                    db.SaveChanges();
                }
            }
        }

        public static bool CheckUser(string login, string password) 
        {
            using( ApplicationContext db = new ApplicationContext())
            {
                AppSettings.localUser = db.USERS.FirstOrDefault(el => el.LOGIN == login && el.PASSWORD == password);
                return AppSettings.localUser == null ? false : true;
            }
        }

        public static ObservableCollection<Algorithm> GetAllAlgorithms()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return new ObservableCollection<Algorithm>(db.ALGORITHMS.ToList<Algorithm>());
            }
        }

        public static ObservableCollection<Courses> GetAllCourses()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return new ObservableCollection<Courses>(db.COURSES.ToList<Courses>());
            }
        }

        public static void ChangeImage(string path)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                User user = db.USERS.FirstOrDefault(el => el.LOGIN == AppSettings.localUser.LOGIN);
                user.IMAGE_SOURCE = path;
                db.SaveChanges();
            }
        }
    }
}
