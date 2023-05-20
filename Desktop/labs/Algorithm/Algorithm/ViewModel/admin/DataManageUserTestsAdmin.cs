using Algorithm.Model;
using Algorithm.View;
using Algorithm.View.admin;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm.ViewModel.admin
{
    public class DataManageUserTestsAdmin : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        Algorithm.Model.User_Test Element;
        private ObservableCollection<Model.User_Test> _user_tests = new ObservableCollection<Model.User_Test>(DataWorker.GetAllUserTests());
        private RelayCommand _clickUserTest;
        private RelayCommand _showTest;
        private RelayCommand _lvlUp;
        private RelayCommand _notlvlup;

        public ObservableCollection<Model.User_Test> UserTests { get { return _user_tests; } }

        private void NotifyPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public RelayCommand ClickUserTest
        {
            get
            {
                return _clickUserTest ?? new RelayCommand(obj =>
                {
                    UsersAndTestsAdmin page = obj as UsersAndTestsAdmin;
                    if (page != null)
                    {
                        Algorithm.Model.User_Test user_Test = page.UserTestsList.SelectedItem as Algorithm.Model.User_Test;
                        if (user_Test != null)
                        {
                            Element = user_Test;
                            LvlUpFormAdmin form = new LvlUpFormAdmin(page.DataContext as DataManageUserTestsAdmin, Element);
                            form.Show();
                        }
                    }
                });
            }
        }

        public RelayCommand ShowTest
        {
            get
            {
                return _showTest ?? new RelayCommand(obj =>
                {
                    Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome", DataWorker.GetTestSource(Element.ID_TEST));
                });
            }
        }

        public RelayCommand LvlUp
        {
            get
            {
                return _lvlUp ?? new RelayCommand(obj =>
                {
                    LvlUpFormAdmin form = obj as LvlUpFormAdmin;
                    if (form != null)
                    {
                        DataWorker.UserLvlUp(Element.ID_USER);
                        DataWorker.DeleteUserTestAdmin(Element.ID_USER_TEST);
                        form.Close();
                        Refresh();
                    }
                });
            }
        }

        public RelayCommand NotLvlUp
        {
            get
            {
                return _notlvlup ?? new RelayCommand(obj =>
                {
                    LvlUpFormAdmin form = obj as LvlUpFormAdmin;
                    if (form != null)
                    {
                        DataWorker.DeleteUserTestAdmin(Element.ID_USER_TEST);
                        form.Close();
                        Refresh();
                    }
                });
            }
        }

        private void Refresh()
        {
            _user_tests = new ObservableCollection<Model.User_Test>(DataWorker.GetAllUserTests());
            NotifyPropertyChange("UserTests");
        }
    }
}
