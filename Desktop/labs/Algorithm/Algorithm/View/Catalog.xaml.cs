﻿using Algorithm.ViewModel;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Algorithm.Model;
using System.IO;
using Path = System.IO.Path;

namespace Algorithm.View
{
    public partial class Catalog : Page
    {
        public Catalog()
        {
            InitializeComponent();
            this.DataContext = new DataManageCatalog();
        }

        private void ListViewItem_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Algorithm.Model.Algorithm algorithm = this.Level0.SelectedItem as Algorithm.Model.Algorithm;
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                string path = folder.SelectedPath + "\\";
                string fullpath = Path.Combine(path, Path.GetFileName(algorithm.PATH_TO_PRESENTATION));
                File.Copy(algorithm.PATH_TO_PRESENTATION, fullpath, true);
            }
        }
    }
}