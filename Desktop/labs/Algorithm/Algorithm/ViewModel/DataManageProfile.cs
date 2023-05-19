using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Algorithm.Model;
using Algorithm.View;
using Microsoft.Identity.Client;
using Microsoft.Win32;

namespace Algorithm.ViewModel
{
    public class DataManageProfile : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private User _user = AppSettings.localUser;
        private RelayCommand _changeImage;
        private RelayCommand _addQuestion;
        private int _countAlgorithms = DataWorker.GetCountUserActivity(AppSettings.localUser.ID_USER);
        private int _countCourses = DataWorker.GetCountUserCourses(AppSettings.localUser.ID_USER);

        public int CountAlgorithms { get { return _countAlgorithms; } }
        public int CountCourses { get {  return _countCourses; } }

        private void NotifyPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public User User { get { return _user; } }
        public RelayCommand ChangeImage 
        { 
            get 
            {  
                return _changeImage ?? new RelayCommand(obj => 
                {
                    ChangeImageMethod();
                    NotifyPropertyChange("User");
                }); 
            } 
        }

        public RelayCommand AddQuestion
        {
            get
            {
                return _addQuestion ?? new RelayCommand(obj =>
                {
                    Profile page = obj as Profile;
                    if (page != null)
                    {
                        DataWorker.AddQuestion(AppSettings.localUser.ID_USER, page.Question.Text);
                        page.Question.Text = "";
                        MessageBox.Show("Ожидайте, вам скоро ответят на почту.", "Вопрос", MessageBoxButton.OK);
                    }
                });
            }
        }

        public void ChangeImageMethod ()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All files (*.*)|*.*";
            if (dialog.ShowDialog() == true)
            {
                DataWorker.ChangeImage(dialog.FileName);
                _user.IMAGE_SOURCE = dialog.FileName;
            }
        }

        public void Refresh()
        {
            _countAlgorithms = DataWorker.GetCountUserActivity(AppSettings.localUser.ID_USER);
            _countCourses = DataWorker.GetCountUserCourses(AppSettings.localUser.ID_USER);
            NotifyPropertyChange("CountAlgorithms");
            NotifyPropertyChange("CountCourses");
        }
    }
}
