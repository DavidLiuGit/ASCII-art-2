﻿#region references
using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
#endregion

namespace ASCII_Art_mk_2 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {

        }


        /// <summary>
        /// Load an image using file explorer
        /// </summary>
        void LoadImage() {
            
            
        }

        /// <summary>
        /// Opens the file dialog for user to select an image file
        /// </summary>
        /// <returns>string of path to image file</returns>
        string FileDialogImagePath() {
            return "bitch";
        }

    }
}

