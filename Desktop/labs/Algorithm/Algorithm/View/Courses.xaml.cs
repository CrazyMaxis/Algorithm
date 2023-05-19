using Algorithm.Model;
using Algorithm.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
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

namespace Algorithm.View
{
    public partial class Courses : Page
    {
        public Courses()
        {
            InitializeComponent();
            this.DataContext = new DataManageCourses();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Algorithm.Model.Courses course;
                Button button = (Button)sender;
                DependencyObject parent = VisualTreeHelper.GetParent(button);

                // Ищем родительский элемент, пока не достигнем нужного типа или не достигнем корневого элемента
                while (parent != null && !(parent is ListBoxItem))
                {
                    parent = VisualTreeHelper.GetParent(parent);
                }

                if (parent is ListViewItem listItem)
                {
                    course = (Algorithm.Model.Courses)listItem.DataContext;
                    FormBuy form = new FormBuy(course.ID_COURSE);
                    if (DataWorker.CheckUserCourses(AppSettings.localUser.ID_USER, course.ID_COURSE))
                    {
                        throw new Exception("У вас уже куплен данный курс!");
                    }
                    form.Show();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Purchace Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
