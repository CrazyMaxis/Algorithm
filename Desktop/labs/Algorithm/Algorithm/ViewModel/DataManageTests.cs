using Algorithm.Model;
using Algorithm.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm.ViewModel
{
    public class DataManageTests
    {
        private ObservableCollection<Model.Test> _tests = new ObservableCollection<Model.Test>(DataWorker.GetAllTests());
        private RelayCommand _clickTest;

        public ObservableCollection<Model.Test> Tests { get { return _tests; } }

        public RelayCommand ClickTest 
        {
            get
            {
                return _clickTest ?? new RelayCommand(obj =>
                {
                    Tests page = obj as Tests;
                    if (page != null)
                    {
                        Algorithm.Model.Test test = page.TestsList.SelectedItem as Algorithm.Model.Test;
                        if (test.LEVEL > AppSettings.localUser.LEVEL)
                        {
                            MessageBox.Show("Ты не достоин!", "Нельзя", MessageBoxButtons.OK);
                            return;
                        }
                        if (test != null)
                        {
                            Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome", test.SOURCE);
                            DataWorker.AddUserTest(AppSettings.localUser.ID_USER, test.ID_TEST);
                        }
                    }
                });
            } 
        }
    }
}
