using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Media.Imaging;
using Algorithm.Model.Data;
using Algorithm.View;
using Microsoft.VisualBasic.Logging;

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
                    User newUser = new User { LOGIN = login, EMAIL = email, PASSWORD = password, LEVEL = 0, IMAGE_SOURCE = "C:\\Users\\USER\\Desktop\\labs\\Algorithm\\Img\\UserLogo.png", ROLE = "user" };
                    db.USERS.Add(newUser);
                    db.SaveChanges();
                }
            }
        }

        public static bool CheckUserLogin(string login)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                AppSettings._possibleLogin = login;
                return db.USERS.FirstOrDefault(el => el.LOGIN == login) == null ? false : true;
            }
        }

        public static User FindUser(int user_id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.USERS.First(el => el.ID_USER  == user_id);
            }
        }

        public static void UserLvlUp(int user_id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                User user = db.USERS.First(el => el.ID_USER == user_id);
                if (user.LEVEL != 2)
                {
                    user.LEVEL = user.LEVEL + 1;
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Пользователь и так максимального уровня", "LvlUp" ,MessageBoxButton.OK);
                }
            }
        }

        public static bool CheckUserPassword(string password)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                AppSettings.localUser = db.USERS.FirstOrDefault(el => el.LOGIN == AppSettings._possibleLogin && el.PASSWORD == password);
                return AppSettings.localUser == null ? false : true;
            }
        }

        public static bool CheckUserEmail(string email)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.USERS.FirstOrDefault(el => el.EMAIL == email) == null ? false : true;
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

        public static ObservableCollection<Question> GetAllQuestions()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return new ObservableCollection<Question>(db.QUESTIONS.ToList<Question>());
            }
        }

        public static ObservableCollection<User_Test> GetAllUserTests()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return new ObservableCollection<User_Test>(db.USER_TESTS.ToList<User_Test>());
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

        public static void ChangeAlgorithm(Algorithm element)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Algorithm algorithm = db.ALGORITHMS.First(el => el.ID_ALGORITHM == element.ID_ALGORITHM);
                algorithm.NAME = element.NAME;
                algorithm.LEVEL = element.LEVEL;
                algorithm.IMAGE_SOURCE = element.IMAGE_SOURCE;
                algorithm.PATH_TO_PRESENTATION = element.PATH_TO_PRESENTATION;
                db.SaveChanges();
            }
        }

        public static void DeleteUserActivity(int algorithm_id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.USER_ACTIVITY.RemoveRange(db.USER_ACTIVITY.Where(el => el.ID_ALGORITHM == algorithm_id));
                db.SaveChanges();
            }
        }

        public static void DeleteAlgorithm(int algorithm_id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Algorithm algorithm = db.ALGORITHMS.First(el => el.ID_ALGORITHM == algorithm_id);
                DataWorker.DeleteUserActivity(algorithm_id);
                db.ALGORITHMS.Remove(algorithm);
                db.SaveChanges();
            }
        }

        public static void AddAlgorithm(Algorithm element)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                element.DESCRIPTION = "1";
                db.ALGORITHMS.Add(element);
                db.SaveChanges();
            }
        }

        public static void ChangeTest(Test element)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Test test= db.TESTS.First(el => el.ID_TEST == element.ID_TEST);
                test.NAME = element.NAME;
                test.LEVEL = element.LEVEL;
                test.IMAGE_SOURCE = element.IMAGE_SOURCE;
                test.SOURCE = element.SOURCE;
                db.SaveChanges();
            }
        }

        public static void DeleteUserTest(int test_id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.USER_TESTS.RemoveRange(db.USER_TESTS.Where(el => el.ID_TEST== test_id));
                db.SaveChanges();
            }
        }

        

        public static void DeleteTest(int test_id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Test test = db.TESTS.First(el => el.ID_TEST == test_id);
                DataWorker.DeleteUserTest(test_id);
                db.TESTS.Remove(test);
                db.SaveChanges();
            }
        }

        public static void AddTest(Test element)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.TESTS.Add(element);
                db.SaveChanges();
            }
        }

        public static void ChangeCourse(Courses element)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Courses course = db.COURSES.First(el => el.ID_COURSE == element.ID_COURSE);
                course.NAME = element.NAME;
                course.PRICE = element.PRICE;
                course.IMAGE_SOURCE = element.IMAGE_SOURCE;
                course.DESCRIPTION = element.DESCRIPTION;
                db.SaveChanges();
            }
        }

        public static void DeleteUserCourses(int course_id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.USER_COURSES.RemoveRange(db.USER_COURSES.Where(el => el.ID_COURSE == course_id));
                db.SaveChanges();
            }
        }

        public static void DeleteCourse(int course_id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Courses course = db.COURSES.First(el => el.ID_COURSE == course_id);
                DataWorker.DeleteCourse(course_id);
                db.COURSES.Remove(course);
                db.SaveChanges();
            }
        }

        public static void AddCourse(Courses element)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.COURSES.Add(element);
                db.SaveChanges();
            }
        }

        public static void DeleteQuestion(int question_id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Question question = db.QUESTIONS.First(el => el.ID_QUESTION == question_id);
                db.QUESTIONS.Remove(question);
                db.SaveChanges();
            }
        }

        public static void DeleteUserTestAdmin(int usertest_id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                User_Test user_Test = db.USER_TESTS.First(el => el.ID_USER_TEST == usertest_id);
                db.USER_TESTS.Remove(user_Test);
                db.SaveChanges();
            }
        }

        public static string GetTestSource(int test_id)
        {
            using (ApplicationContext db = new ApplicationContext ())
            {
                Test test = db.TESTS.First(el => el.ID_TEST == test_id);
                return test.SOURCE;
            }
        }
    }
}
