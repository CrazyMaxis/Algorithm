using Algorithm.Model;
using Algorithm.View;
using Algorithm.View.admin;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Algorithm.ViewModel.admin
{
    public class DataManageQuestionAdmin : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        Algorithm.Model.Question Element;
        private ObservableCollection<Model.Question> _questions = new ObservableCollection<Model.Question>(DataWorker.GetAllQuestions());
        private RelayCommand _clickQuestion;
        private RelayCommand _clickAnswer;

        public ObservableCollection<Model.Question> Questions { get { return _questions; } }

        private void NotifyPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public RelayCommand ClickQuestion
        {
            get
            {
                return _clickQuestion ?? new RelayCommand(obj =>
                {
                    QuestionsAdmin page = obj as QuestionsAdmin;
                    if (page != null)
                    {
                        Algorithm.Model.Question question = page.QuestionsList.SelectedItem as Algorithm.Model.Question;
                        if (question != null)
                        {
                            Element = question;
                            AnswerAdmin form = new AnswerAdmin(page.DataContext as DataManageQuestionAdmin);
                            form.Show();
                        }
                    }
                });
            }
        }

        public RelayCommand ClickAnswer
        {
            get
            {
                return _clickAnswer ?? new RelayCommand(obj =>
                {
                    try
                    {
                        AnswerAdmin form = obj as AnswerAdmin;
                        if (form != null)
                        {
                            if (string.IsNullOrEmpty(form.Answer.Text))
                            {
                                throw new Exception("Ответ не может быть пустой");
                            }

                            var mail = AppSettings.CreateMail("Algorithm Adventure", "algorithmkursach@gmail.com", DataWorker.FindUser(Element.ID_USER).EMAIL, "Ответ на ваш вопрос", "Ваш вопрос: " + Element.QUESTION + "\n\nОтвет: " + form.Answer.Text);
                            AppSettings.SendMail("smtp.gmail.com", 587, "algorithmkursach@gmail.com", "bjjltjvrhgvxgkak", mail);
                            DataWorker.DeleteQuestion(Element.ID_QUESTION);
                            form.Close();
                            Refresh();
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка ответа!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                });
            }
        }

        private void Refresh()
        {
            _questions = new ObservableCollection<Model.Question>(DataWorker.GetAllQuestions());
            NotifyPropertyChange("Questions");
        }
    }
}
