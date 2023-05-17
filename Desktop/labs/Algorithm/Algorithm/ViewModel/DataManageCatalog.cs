using Algorithm.Model;
using Algorithm.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Path = System.IO.Path;
using System.IO;

namespace Algorithm.ViewModel
{
    public class DataManageCatalog
    {
        private ObservableCollection<Model.Algorithm> _levelZero = new ObservableCollection<Model.Algorithm>(DataWorker.GetAllAlgorithms().Where(el => el.LEVEL == 0));
        private ObservableCollection<Model.Algorithm> _levelOne = new ObservableCollection<Model.Algorithm>(DataWorker.GetAllAlgorithms().Where(el => el.LEVEL == 1));
        private ObservableCollection<Model.Algorithm> _levelTwo = new ObservableCollection<Model.Algorithm>(DataWorker.GetAllAlgorithms().Where(el => el.LEVEL == 2));
        private RelayCommand _clickAlgorithmLevel0;
        private RelayCommand _clickAlgorithmLevel1;
        private RelayCommand _clickAlgorithmLevel2;
        public ObservableCollection<Model.Algorithm>  LevelZero { get { return _levelZero; } }
        public ObservableCollection<Model.Algorithm> LevelOne { get { return _levelOne; } }
        public ObservableCollection<Model.Algorithm> LevelTwo { get { return _levelTwo; } }
        public RelayCommand ClickAlgorithmLevel0
        {
            get 
            {
                return _clickAlgorithmLevel0 ?? new RelayCommand(obj =>
                {
                    Catalog page = obj as Catalog;
                    if (page != null)
                    {
                        Algorithm.Model.Algorithm algorithm = page.Level0.SelectedItem as Algorithm.Model.Algorithm;
                        if (algorithm != null)
                        {
                            FolderBrowserDialog folder = new FolderBrowserDialog();
                            if (folder.ShowDialog() == DialogResult.OK)
                            {
                                string path = folder.SelectedPath + "\\";
                                string fullpath = Path.Combine(path, Path.GetFileName(algorithm.PATH_TO_PRESENTATION));
                                File.Copy(algorithm.PATH_TO_PRESENTATION, fullpath, true);
                                if (!DataWorker.CheckUserActivity(AppSettings.localUser.ID_USER, algorithm.ID_ALGORITHM))
                                {
                                    DataWorker.AddUserActivity(AppSettings.localUser.ID_USER, algorithm.ID_ALGORITHM);
                                }
                            }
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
                            FolderBrowserDialog folder = new FolderBrowserDialog();
                            if (folder.ShowDialog() == DialogResult.OK)
                            {
                                string path = folder.SelectedPath + "\\";
                                string fullpath = Path.Combine(path, Path.GetFileName(algorithm.PATH_TO_PRESENTATION));
                                File.Copy(algorithm.PATH_TO_PRESENTATION, fullpath, true);
                                if (!DataWorker.CheckUserActivity(AppSettings.localUser.ID_USER, algorithm.ID_ALGORITHM))
                                {
                                    DataWorker.AddUserActivity(AppSettings.localUser.ID_USER, algorithm.ID_ALGORITHM);
                                }
                            }
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
                            FolderBrowserDialog folder = new FolderBrowserDialog();
                            if (folder.ShowDialog() == DialogResult.OK)
                            {
                                string path = folder.SelectedPath + "\\";
                                string fullpath = Path.Combine(path, Path.GetFileName(algorithm.PATH_TO_PRESENTATION));
                                File.Copy(algorithm.PATH_TO_PRESENTATION, fullpath, true);
                                if (!DataWorker.CheckUserActivity(AppSettings.localUser.ID_USER, algorithm.ID_ALGORITHM))
                                {
                                    DataWorker.AddUserActivity(AppSettings.localUser.ID_USER, algorithm.ID_ALGORITHM);
                                }
                            }
                        }
                    }
                });
            }
        }
    }
}
