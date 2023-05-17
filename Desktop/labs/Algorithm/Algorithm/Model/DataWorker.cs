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
            using (ApplicationContext db = new ApplicationContext())
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
            using (ApplicationContext db = new ApplicationContext())
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

        public static ObservableCollection<Test> GetAllTests()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return new ObservableCollection<Test>(db.TESTS.ToList<Test>());
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

        public static void AddUserActivity(int user_id, int algorithm_id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                User_Activity user_activity = new User_Activity()
                {
                    ID_ALGORITHM = algorithm_id,
                    ID_USER = user_id
                };
                db.USER_ACTIVITY.Add(user_activity);
                db.SaveChanges();
            }
        }

        public static bool CheckUserActivity(int user_id, int algorithm_id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.USER_ACTIVITY.Any(el => el.ID_USER == user_id && el.ID_ALGORITHM == algorithm_id);
            }
        }

        public static int GetCountUserActivity(int user_id)
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                return context.USER_ACTIVITY.Count(el => el.ID_USER == user_id);
            }
        }

        public static void AddUserCourses(int user_id, int course_id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                User_Courses user_course = new User_Courses()
                {
                    ID_COURSE = course_id,
                    ID_USER = user_id
                };
                db.USER_COURSES.Add(user_course);
                db.SaveChanges();
            }
        }

        public static bool CheckUserCourses(int user_id, int course_id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.USER_COURSES.Any(el => el.ID_USER == user_id && el.ID_COURSE == course_id);
            }
        }

        public static int GetCountUserCourses(int user_id)
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                return context.USER_COURSES.Count(el => el.ID_USER == user_id);
            }
        }

        public static void AddQuestion(int user_id, string text)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Question question = new Question()
                {
                    ID_USER = user_id,
                    QUESTION = text
                };
                db.QUESTIONS.Add(question);
                db.SaveChanges();
            }
        }

        public static void AddUserTest(int user_id, int test_id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                User_Test uset_test = new User_Test()
                {
                    ID_USER = user_id,
                    ID_TEST = test_id
                };
                db.USER_TESTS.Add(uset_test);
                db.SaveChanges();
            }
            
        }
    }
}
