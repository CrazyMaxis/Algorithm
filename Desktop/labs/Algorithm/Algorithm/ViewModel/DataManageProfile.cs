using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.Model;
using Microsoft.Identity.Client;
using Microsoft.Win32;

namespace Algorithm.ViewModel
{
    public class DataManageProfile : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private User _user = AppSettings.localUser;
        private RelayCommand _changeImage;
        private void NotifyPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public User User { get { return _user; } }
        public RelayCommand ChangeImage { get {  return _changeImage ?? new RelayCommand(obj => {
            ChangeImageMethod();
            NotifyPropertyChange("User");
        }); } }

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
    }
}
