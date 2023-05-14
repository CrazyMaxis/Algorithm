using Algorithm.Model;
using Algorithm.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Algorithm.ViewModel
{
    public class DataManageVM
    {
        private RelayCommand _registerCommand;
        private RelayCommand _loginCommand;
        public RelayCommand RegisterCommand
        {
            get
            {
                return _registerCommand ?? new RelayCommand(obj =>
                {
                    try
                    {
                        Register Page = obj as Register;
                        if (Page != null)
                        {
                            DataWorker.CreateUser(Page.LoginForRegister.Text, Page.EmailForRegister.Text, Page.PasswordForRegister.Password);
                        }
                    }
                    catch { }

                });
            }
        }

        public RelayCommand LoginCommand
        {
            get
            {
                return _loginCommand ?? new RelayCommand(obj =>
                {
                    try
                    {
                        Login Page = obj as Login;
                        if (DataWorker.CheckUser(Page.LoginForLogin.Text, Page.PasswordForLogin.Password))
                        {
                            Main main = new Main();
                            main.Show();
                            Page.mainW.Close();
                        }
                        else
                        {
                            MessageBox.Show("Неверно указаны данные!", "Error Login in", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    catch { }

                });
            }
        }
    }
}
