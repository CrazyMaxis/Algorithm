using Algorithm.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.ViewModel
{
    public class DataManageCatalog
    {
        private ObservableCollection<Model.Algorithm> _levelZero = new ObservableCollection<Model.Algorithm>(DataWorker.GetAllAlgorithms().Where(el => el.LEVEL == 0));
        private ObservableCollection<Model.Algorithm> _levelOne = new ObservableCollection<Model.Algorithm>(DataWorker.GetAllAlgorithms().Where(el => el.LEVEL == 1));
        private ObservableCollection<Model.Algorithm> _levelTwo = new ObservableCollection<Model.Algorithm>(DataWorker.GetAllAlgorithms().Where(el => el.LEVEL == 2));
        public ObservableCollection<Model.Algorithm>  LevelZero { get { return _levelZero; } }
        public ObservableCollection<Model.Algorithm> LevelOne { get { return _levelOne; } }
        public ObservableCollection<Model.Algorithm> LevelTwo { get { return _levelTwo; } }
    }
}
