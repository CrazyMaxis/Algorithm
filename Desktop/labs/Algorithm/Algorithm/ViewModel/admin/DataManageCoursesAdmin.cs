using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using Algorithm.Model;
using Algorithm.View;
using Algorithm.View.admin;
using Path = System.IO.Path;
using System.IO;
using Microsoft.Win32;
using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Media.Imaging;

namespace Algorithm.ViewModel.admin
{
    public class DataManageCoursesAdmin : INotifyPropertyChanged
    {
        public Algorithm.Model.Courses Element;
        public event PropertyChangedEventHandler? PropertyChanged;
        private ObservableCollection<Model.Courses> _courses = new ObservableCollection<Model.Courses>(DataWorker.GetAllCourses());
        private RelayCommand _clickCourse;
        private RelayCommand _changeImage;
        private RelayCommand _changeElement;
        private RelayCommand _deleteElement;
        private RelayCommand _addElement;

        public ObservableCollection<Model.Courses> Courses { get { return _courses; } }

        private void NotifyPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public RelayCommand ClickCourse
        {
            get
            {
                return _clickCourse ?? new RelayCommand(obj =>
                {
                    CoursesAdmin page = obj as CoursesAdmin;
                    if (page != null)
                    {
                        Algorithm.Model.Courses course = page.CoursesList.SelectedItem as Algorithm.Model.Courses;
                        if (course != null)
                        {
                            Element = course;
                            ChangeCourse form = new ChangeCourse(page.DataContext as DataManageCoursesAdmin, Element);
                            form.Show();
                        }
                    }
                });
            }
        }

        public RelayCommand ChangeImage
        {
            get
            {
                return _changeImage ?? new RelayCommand(obj =>
                {
                    System.Windows.Controls.Image image = obj as System.Windows.Controls.Image;
                    if (image != null)
                    {
                        OpenFileDialog dialog = new OpenFileDialog();
                        dialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All files (*.*)|*.*";
                        if (dialog.ShowDialog() == true)
                        {
                            if (Element != null)
                            {
                                Element.IMAGE_SOURCE = dialog.FileName;
                            }
                            image.Source = new BitmapImage(new Uri(dialog.FileName));
                        }
                    }
                });
            }
        }

        public RelayCommand ChangeElement
        {
            get
            {
                return _changeElement ?? new RelayCommand(obj =>
                {
                    ChangeCourse form = obj as ChangeCourse;
                    if (form != null)
                    {
                        Element.NAME = form.ElementName.Text;
                        Element.PRICE = Convert.ToDouble(form.ElementPrice.Text);
                        Element.DESCRIPTION = form.ElementDescription.Text;
                        DataWorker.ChangeCourse(Element);
                        form.Close();
                        Refresh();
                    }
                });
            }
        }

        public RelayCommand DeleteElement
        {
            get
            {
                return _deleteElement ?? new RelayCommand(obj =>
                {
                    ChangeCourse form = obj as ChangeCourse;
                    if (form != null)
                    {
                        DataWorker.DeleteCourse(Element.ID_COURSE);
                        form.Close();
                        Refresh();
                    }
                });
            }
        }

        public RelayCommand AddElement
        {
            get
            {
                return _addElement ?? new RelayCommand(obj =>
                {
                    AddCourse form = obj as AddCourse;
                    if (form != null)
                    {
                        DataWorker.AddCourse(new Algorithm.Model.Courses() { NAME = form.ElementName.Text, PRICE = Convert.ToDouble(form.ElementPrice.Text), IMAGE_SOURCE = form.ElementImage.Source.ToString(), DESCRIPTION = form.ElementDescription.Text });
                        form.Close();
                        Refresh();
                    }
                });
            }
        }

        private void Refresh()
        {
           _courses = new ObservableCollection<Model.Courses>(DataWorker.GetAllCourses());
            NotifyPropertyChange("Courses");
        }
    }
}
