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

namespace WpfApp1
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

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            
            myInkCanvas.Strokes.Clear();
        }

        
        private void cboBrushSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboBrushSize.Items.Count > 0 && ((ComboBoxItem)cboBrushSize.SelectedItem).Content != null)
            {
               
                myInkCanvas.DefaultDrawingAttributes.Width = Convert.ToDouble(((ComboBoxItem)cboBrushSize.SelectedItem).Content);
                myInkCanvas.DefaultDrawingAttributes.Height = Convert.ToDouble(((ComboBoxItem)cboBrushSize.SelectedItem).Content);
            }
        }

        private void cboColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboColor.Items.Count > 0 && ((ComboBoxItem)cboColor.SelectedItem).Content != null)
            {
              
                if (((ComboBoxItem)cboColor.SelectedItem).Content.ToString() == "Black")
            myInkCanvas.DefaultDrawingAttributes.Color = Colors.Black;
        else if (((ComboBoxItem)cboColor.SelectedItem).Content.ToString() == "Blue")
            myInkCanvas.DefaultDrawingAttributes.Color = Colors.Blue;
        else if (((ComboBoxItem)cboColor.SelectedItem).Content.ToString() == "Green")
            myInkCanvas.DefaultDrawingAttributes.Color = Colors.Green;
        else if (((ComboBoxItem)cboColor.SelectedItem).Content.ToString() == "Red")
            myInkCanvas.DefaultDrawingAttributes.Color = Colors.Red;
        else if (((ComboBoxItem)cboColor.SelectedItem).Content.ToString() == "Yellow")
            myInkCanvas.DefaultDrawingAttributes.Color = Colors.Yellow;
            }
        }

        private void RadMode_Checked(object sender, RoutedEventArgs e)
        {
          
            if (radDrawingMode.IsChecked.Value == true)
                myInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            else if (radSelectMode.IsChecked.Value == true)
                myInkCanvas.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }
    }
}
