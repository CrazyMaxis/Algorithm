﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;
using Algorithm.Model;
using Algorithm.ViewModel.admin;

namespace Algorithm.View.admin
{
    public partial class ChangeCourse : Window
    {
        public ChangeCourse(DataManageCoursesAdmin context, Algorithm.Model.Courses element)
        {
            InitializeComponent();
            this.DataContext = context;
            ElementName.Text = element.NAME;
            ElementPrice.Text = Convert.ToString(element.PRICE);
            ElementImage.Source = new BitmapImage(new Uri(element.IMAGE_SOURCE));
            ElementDescription.Text = element.DESCRIPTION;
        }

        private void ElementPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ElementPrice.Text.Length > 0)
            {
                ElementPricePlug.Visibility = Visibility.Hidden;
            }
            else
            {
                ElementPricePlug.Visibility = Visibility.Visible;
            }
        }

        private void ElementDescription_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ElementDescription.Text.Length > 0)
            {
                ElementDescriptionPlug.Visibility = Visibility.Hidden;
            }
            else
            {
                ElementDescriptionPlug.Visibility = Visibility.Visible;
            }
        }

        private void ElementName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ElementName.Text.Length > 0)
            {
                ElementNamePlug.Visibility = Visibility.Hidden;
            }
            else
            {
                ElementNamePlug.Visibility = Visibility.Visible;
            }
        }
    }
}
