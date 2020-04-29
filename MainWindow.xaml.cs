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
using System.Globalization;

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


        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)

          {

             Double val;
            if (!Double.TryParse(e.Text, out val)
              && (e.Text != "," || slope.Text.IndexOf(',') != -1)
              && (e.Text != "." || slope.Text.IndexOf('.') != -1)
              )

            {

                e.Handled = true;
          
            }


           //int sl = int.Parse(slope.Text);
         
           //double vsl = Double.Parse(slope.Text);


            verticSlope.Text = slope.Text;
            horizSlope.Text = slope.Text;



        }     
                 
        
       private void TextBox_PreviewKeyDown (object sender, KeyEventArgs e)

        {
           if (e.Key == Key.Space)

                {
                    e.Handled = true; 
                }
        }

        






    }
}
