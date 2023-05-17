using Algorithm.Model;
using Algorithm.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace Algorithm.ViewModel
{
    public class DataManageCourses
    {
        private ObservableCollection<Model.Courses> _courses = new ObservableCollection<Model.Courses>(DataWorker.GetAllCourses());
        private RelayCommand _clickBuy;

        public ObservableCollection<Model.Courses> Courses { get { return _courses; } }

        public RelayCommand ClickBuy 
        {
            get
            {
                return _clickBuy ?? new RelayCommand(obj =>
                {
                    try
                    {
                        FormBuy window = obj as FormBuy;
                        if (window != null)
                        {
                            if (!Regex.IsMatch(window.CardNumber.Text, "^^(4[0-9]{12}(?:[0-9]{3})?|5[1-5][0-9]{14})$"))
                            {
                                throw new Exception("Несуществущий номер карты!");
                            }

                            if (!Regex.IsMatch(window.YearCard.Text, "^2[2-9]$|^30$\r\n"))
                            {
                                throw new Exception("Неверно указан год действия карты!");
                            }

                            if (!Regex.IsMatch(window.MonthCard.Text, "^(0[1-9]|1[0-2])$"))
                            {
                                throw new Exception("Неверно указан месяц действия карты!");
                            }

                            if (!Regex.IsMatch(window.CVVCard.Text, @"^\d{3}$"))
                            {
                                throw new Exception("Неверно указан CVV карты!");
                            }

                            if (!Regex.IsMatch(window.NameCard.Text, "^[a-zA-Z]{6,}$"))
                            {
                                throw new Exception("Неверно указан владелец карты!");
                            }

                            DataWorker.AddUserCourses(AppSettings.localUser.ID_USER, window.course_id);
                            MessageBox.Show("Покупка совершена успешно!", "Purchace Done", MessageBoxButton.OK);
                            window.Close();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Purchace Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                });
            }  
        } 
        
    }
}
