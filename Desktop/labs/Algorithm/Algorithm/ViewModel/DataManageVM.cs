using Algorithm.Model;
using Algorithm.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                            if (!Regex.IsMatch(Page.LoginForRegister.Text, "^(?=.*[a-zA-Z]).{6,}$"))
                            {
                                throw new Exception("Логин не соответствует требованиям:\n1) Содержит хотя бы одну букву от a до z (в верхнем или нижнем регистре);\n2) Имеют длину не менее 6 символов.");
                                
                            }

                            if (!Regex.IsMatch(Page.EmailForRegister.Text, "^([a-z0-9_-]+\\.)*[a-z0-9_-]+@[a-z0-9_-]+(\\.[a-z0-9_-]+)*\\.[a-z]{2,6}$"))
                            {
                                throw new Exception("Неверно указан email!");

                            }

                            if (!Regex.IsMatch(Page.PasswordForRegister.Password, "^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])[0-9a-zA-Z]{6,}$"))
                            {
                                throw new Exception("Пароль не соответствует требованиям:\nМинимум шесть символов, которые должны включать хотя бы одну цифру, одну строчную латинскую букву и одну заглавную латинскую букву.");

                            }

                            DataWorker.CreateUser(Page.LoginForRegister.Text, Page.EmailForRegister.Text, Page.PasswordForRegister.Password);
                            MessageBox.Show("Регистрация прошла успешно.", "Register", MessageBoxButton.OK);
                        }
                    }
                    catch(Exception ex)
                    { 
                        MessageBox.Show(ex.Message, "Error Register", MessageBoxButton.OK, MessageBoxImage.Error);
                    }

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
                        if (Page != null)
                        {
                            if (DataWorker.CheckUser(Page.LoginForLogin.Text, Page.PasswordForLogin.Password))
                            {
                                Main main = new Main();
                                main.Show();
                                Page.mainW.Close();
                            }
                            else
                            {
                                throw new Exception("Неверно указаны данные!");
                            }
                        }
                    }
                    catch(Exception ex) 
                    {
                        MessageBox.Show(ex.Message, "Error Login in", MessageBoxButton.OK, MessageBoxImage.Error);
                    }

                });
            }
        }
    }
}
