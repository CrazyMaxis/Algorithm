using Algorithm.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.View.admin;
using System.Diagnostics;
using System.ComponentModel;
using System.Windows.Media.Imaging;
using Path = System.IO.Path;
using System.IO;
using Microsoft.Win32;

namespace Algorithm.ViewModel.admin
{
    public class DataManageTestsAdmin : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public Algorithm.Model.Test Element;
        private ObservableCollection<Model.Test> _tests = new ObservableCollection<Model.Test>(DataWorker.GetAllTests());
        private RelayCommand _clickTest;
        private RelayCommand _deleteTest;
        private RelayCommand _changeTest;
        private RelayCommand _changeImage;
        private RelayCommand _addTest;

        public ObservableCollection<Model.Test> Tests { get { return _tests; } }

        private void NotifyPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public RelayCommand ClickTest
        {
            get
            {
                return _clickTest ?? new RelayCommand(obj =>
                {
                    TestsAdmin page = obj as TestsAdmin;
                    if (page != null)
                    {
                        Algorithm.Model.Test test = page.TestsList.SelectedItem as Algorithm.Model.Test;
                        if (test != null)
                        {
                            Element = test;
                            ChangeTest form = new ChangeTest(page.DataContext as DataManageTestsAdmin, Element);
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

        public RelayCommand ChangeTest
        {
            get
            {
                return _changeTest ?? new RelayCommand(obj =>
                {
                    ChangeTest form = obj as ChangeTest;
                    if (form != null)
                    {
                        Element.NAME = form.ElementName.Text;
                        DataWorker.ChangeTest(Element);
                        form.Close();
                        Refresh();
                    }
                });
            }
        }

        public RelayCommand DeleteTest
        {
            get
            {
                return _deleteTest ?? new RelayCommand(obj =>
                {
                    ChangeTest form = obj as ChangeTest;
                    if (form != null)
                    {
                        DataWorker.DeleteTest(Element.ID_TEST);
                        form.Close();
                        Refresh();
                    }
                });
            }
        }

        public RelayCommand AddTest
        {
            get
            {
                return _addTest ?? new RelayCommand(obj =>
                {
                    AddTest form = obj as AddTest;
                    if (form != null)
                    {
                        DataWorker.AddTest(new Algorithm.Model.Test() { NAME = form.ElementName.Text, LEVEL = Convert.ToInt32(form.ElementLevel.Text), IMAGE_SOURCE = form.ElementImage.Source.ToString(), SOURCE = form.ElementSource.Text });
                        form.Close();
                        Refresh();
                    }
                });
            }
        }

        private void Refresh()
        {
            _tests = new ObservableCollection<Model.Test>(DataWorker.GetAllTests());
            NotifyPropertyChange("Tests");
        }
    }
}
