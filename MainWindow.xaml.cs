#region references
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
using System.IO;
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
            LoadImage();
        }


        /// <summary>
        /// Load an image using file explorer
        /// </summary>
        void LoadImage() {
            string imgPath = FileDialogImagePath();
            if (imgPath != null) {
                // open file
                mainLabel.Content = "Loading image from " + imgPath + '.';
            } else {
                mainLabelAccess.Text = "Please try loading another image.";
            }
            
        }

        /// <summary>
        /// Opens the file dialog for user to select an image file
        /// </summary>
        /// <returns>string of path to image file</returns>
        string FileDialogImagePath() {
            OpenFileDialog diag = new OpenFileDialog();
            diag.Title = "Select image from file";
            diag.InitialDirectory = Directory.GetCurrentDirectory();
            diag.Multiselect = false;           // do not allow user to select multiple images
            diag.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

            diag.ShowDialog();

            if (DialogResult.HasValue && DialogResult.Value == true) {
                return diag.FileName;
            } else {
                return null;                // if the file dialog doesn't properly get a file
            }
        }

    }
}

