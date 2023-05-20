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
using System.Linq.Expressions;
using System.Windows;

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
                    try
                    {
                        ChangeTest form = obj as ChangeTest;
                        if (form != null)
                        {
                            if (string.IsNullOrWhiteSpace(form.ElementName.Text))
                            {
                                throw new Exception("Название не может быть пустым!");
                            }

                            if (string.IsNullOrWhiteSpace(form.ElementLevel.Text))
                            {
                                throw new Exception("Уровень не может быть пустым!");
                            }

                            if (string.IsNullOrWhiteSpace(form.ElementImage.Source.ToString()))
                            {
                                throw new Exception("Нужно выбрать картинку!");
                            }

                            if (string.IsNullOrWhiteSpace(form.ElementSource.Text))
                            {
                                throw new Exception("Нужно ссылку на тесту!");
                            }

                            Element.NAME = form.ElementName.Text;
                            DataWorker.ChangeTest(Element);
                            form.Close();
                            Refresh();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка изменения!", MessageBoxButton.OK, MessageBoxImage.Error);
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
                    try
                    {
                        AddTest form = obj as AddTest;
                        if (form != null)
                        {
                            if (string.IsNullOrWhiteSpace(form.ElementName.Text))
                            {
                                throw new Exception("Название не может быть пустым!");
                            }

                            if (string.IsNullOrWhiteSpace(form.ElementLevel.Text))
                            {
                                throw new Exception("Уровень не может быть пустым!");
                            }

                            if (string.IsNullOrWhiteSpace(form.ElementImage.Source.ToString()))
                            {
                                throw new Exception("Нужно выбрать картинку!");
                            }

                            if (string.IsNullOrWhiteSpace(form.ElementSource.Text))
                            {
                                throw new Exception("Нужно ссылку на тесту!");
                            }

                            DataWorker.AddTest(new Algorithm.Model.Test() { NAME = form.ElementName.Text, LEVEL = Convert.ToInt32(form.ElementLevel.Text), IMAGE_SOURCE = form.ElementImage.Source.ToString(), SOURCE = form.ElementSource.Text });
                            form.Close();
                            Refresh();
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка добавление", MessageBoxButton.OK, MessageBoxImage.Error);
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
