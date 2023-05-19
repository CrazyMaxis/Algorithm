using Algorithm.Model;
using Algorithm.View;
using Algorithm.View.admin;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Path = System.IO.Path;
using System.IO;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
using System.Drawing;
using System.Windows.Media.Imaging;
using System.Printing;
using System.ComponentModel;

namespace Algorithm.ViewModel.admin
{
    public class DataManageCatalogAdmin : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public Algorithm.Model.Algorithm Element;
        private ObservableCollection<Model.Algorithm> _levelZero = new ObservableCollection<Model.Algorithm>(DataWorker.GetAllAlgorithms().Where(el => el.LEVEL == 0));
        private ObservableCollection<Model.Algorithm> _levelOne = new ObservableCollection<Model.Algorithm>(DataWorker.GetAllAlgorithms().Where(el => el.LEVEL == 1));
        private ObservableCollection<Model.Algorithm> _levelTwo = new ObservableCollection<Model.Algorithm>(DataWorker.GetAllAlgorithms().Where(el => el.LEVEL == 2));
        private RelayCommand _clickAlgorithmLevel0;
        private RelayCommand _clickAlgorithmLevel1;
        private RelayCommand _clickAlgorithmLevel2;
        private RelayCommand _changeImage;
        private RelayCommand _changePresentation;
        private RelayCommand _changeElement;
        private RelayCommand _deleteElement;
        private RelayCommand _addElement;
        public ObservableCollection<Model.Algorithm> LevelZero { get { return _levelZero; } }
        public ObservableCollection<Model.Algorithm> LevelOne { get { return _levelOne; } }
        public ObservableCollection<Model.Algorithm> LevelTwo { get { return _levelTwo; } }

        private void NotifyPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public RelayCommand ClickAlgorithmLevel0
        {
            get
            {
                return _clickAlgorithmLevel0 ?? new RelayCommand(obj =>
                {
                    CatalogAdmin page = obj as CatalogAdmin;
                    if (page != null)
                    {
                        Algorithm.Model.Algorithm algorithm = page.Level0.SelectedItem as Algorithm.Model.Algorithm;
                        if (algorithm != null)
                        {
                            Element = algorithm;
                            ChangeAlgorithm form = new ChangeAlgorithm(page.DataContext as DataManageCatalogAdmin, Element);
                            form.Show();
                        }
                    }
                });
            }
        }
        public RelayCommand ClickAlgorithmLevel1
        {
            get
            {
                return _clickAlgorithmLevel1 ?? new RelayCommand(obj =>
                {
                    Catalog page = obj as Catalog;
                    if (page != null)
                    {
                        Algorithm.Model.Algorithm algorithm = page.Level1.SelectedItem as Algorithm.Model.Algorithm;
                        if (algorithm != null)
                        {
                            Element = algorithm;
                            ChangeAlgorithm form = new ChangeAlgorithm(page.DataContext as DataManageCatalogAdmin, Element);
                            form.Show();
                        }
                    }
                });
            }
        }
        public RelayCommand ClickAlgorithmLevel2
        {
            get
            {
                return _clickAlgorithmLevel2 ?? new RelayCommand(obj =>
                {
                    Catalog page = obj as Catalog;
                    if (page != null)
                    {
                        Algorithm.Model.Algorithm algorithm = page.Level2.SelectedItem as Algorithm.Model.Algorithm;
                        if (algorithm != null)
                        {
                            Element = algorithm;
                            ChangeAlgorithm form = new ChangeAlgorithm(page.DataContext as DataManageCatalogAdmin, Element);
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

        public RelayCommand ChangePresentation
        {
            get
            {
                return _changePresentation ?? new RelayCommand(obj =>
                {
                    System.Windows.Controls.TextBlock textBlock = obj as System.Windows.Controls.TextBlock;
                    if (textBlock != null)
                    {
                        OpenFileDialog dialog = new OpenFileDialog();
                        dialog.Filter = "All files (*.*)|*.*";
                        if (dialog.ShowDialog() == true)
                        {
                            if (Element != null)
                            {
                                Element.PATH_TO_PRESENTATION = dialog.FileName;
                            }
                            textBlock.Text = dialog.FileName;
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
                    ChangeAlgorithm form = obj as ChangeAlgorithm;
                    if (form != null)
                    {
                        Element.NAME = form.ElementName.Text;
                        Element.LEVEL = Convert.ToInt32(form.ElementLevel.Text);
                        DataWorker.ChangeAlgorithm(Element);
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
                    ChangeAlgorithm form = obj as ChangeAlgorithm;
                    if (form != null)
                    {
                        DataWorker.DeleteAlgorithm(Element.ID_ALGORITHM);
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
                    AddAlgorithm form = obj as AddAlgorithm;
                    if (form != null)
                    {
                        DataWorker.AddAlgorithm(new Algorithm.Model.Algorithm() { NAME = form.ElementName.Text, LEVEL = Convert.ToInt32(form.ElementLevel.Text), IMAGE_SOURCE = form.ElementImage.Source.ToString(), PATH_TO_PRESENTATION = form.ElementPresentation.Text});
                        form.Close();
                        Refresh();
                    }
                });
            }
        }

        private void Refresh()
        {
            _levelZero = new ObservableCollection<Model.Algorithm>(DataWorker.GetAllAlgorithms().Where(el => el.LEVEL == 0));
            _levelOne = new ObservableCollection<Model.Algorithm>(DataWorker.GetAllAlgorithms().Where(el => el.LEVEL == 1));
            _levelTwo = new ObservableCollection<Model.Algorithm>(DataWorker.GetAllAlgorithms().Where(el => el.LEVEL == 2));
            NotifyPropertyChange("LevelZero");
            NotifyPropertyChange("LevelOne");
            NotifyPropertyChange("LevelTwo");
        }
    }
}
