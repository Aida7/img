﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Image_data
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void open_Clik(object sender, RoutedEventArgs e)
        {
           

            FileStream op = File.Open("z:/1.jpg", FileMode.Open);
            BitmapDecoder decoder = JpegBitmapDecoder.Create(op, BitmapCreateOptions.IgnoreColorProfile, BitmapCacheOption.Default);
            BitmapMetadata metadata = (BitmapMetadata)decoder.Frames[0].Metadata;
   
         name.Content = metadata.Title;
        }
    }
}
