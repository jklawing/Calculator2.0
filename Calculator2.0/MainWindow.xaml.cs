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

namespace Calculator2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        // Permanent Members
        string output = "";
        string operation = "";
        double temp = 0;

        public MainWindow()
        {
            InitializeComponent();

            // Button symbols
            ButtonDivide.Content = "\u00F7";
            ButtonSquared.Content = "x" + "\u00B2";
            ButtonSquareRoot.Content = "\u221A";
            ButtonPosNeg.Content = "\u00B1";
        }

        // Number Button Click Event
        private void ButtonNumber_Click(object sender, RoutedEventArgs e)
        {
            // Whichever button was clicked
            string name = ((Button)sender).Name;

            // Converts to output
            switch(name)
            {
                case "Button0":
                    output += "0";
                    OutputTextBlock.Text = output;
                    break;

                case "Button1":
                    output += "1";
                    OutputTextBlock.Text = output;
                    break;

                case "Button2":
                    output += "2";
                    OutputTextBlock.Text = output;
                    break;

                case "Button3":
                    output += "3";
                    OutputTextBlock.Text = output;
                    break;

                case "Button4":
                    output += "4";
                    OutputTextBlock.Text = output;
                    break;

                case "Button5":
                    output += "5";
                    OutputTextBlock.Text = output;
                    break;

                case "Button6":
                    output += "6";
                    OutputTextBlock.Text = output;
                    break;

                case "Button7":
                    output += "7";
                    OutputTextBlock.Text = output;
                    break;

                case "Button8":
                    output += "8";
                    OutputTextBlock.Text = output;
                    break;

                case "Button9":
                    output += "9";
                    OutputTextBlock.Text = output;
                    break;

                case "ButtonDecimal":
                    if (!output.Contains("."))
                    {
                        output += ".";
                        OutputTextBlock.Text = output;
                    }
                    break;
            }
        }

        #region Operation Button Click Events
        // Subtract
        private void ButtonSubtract_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
                operation = "subtract";
            }
        }

        // Add
        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
                operation = "add";
            }
        }

        // Multiply
        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
                operation = "multiply";
            }
        }

        // Divide
        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
                operation = "divide";
            }
        }

        // Equals
        private void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {
            double outputTemp;

            switch (operation)
            {
                case "subtract":
                    outputTemp = temp - double.Parse(output);
                    output = outputTemp.ToString();
                    OutputTextBlock.Text = output;
                    break;

                case "add":
                    outputTemp = temp + double.Parse(output);
                    output = outputTemp.ToString();
                    OutputTextBlock.Text = output;
                    break;

                case "multiply":
                    outputTemp = temp * double.Parse(output);
                    output = outputTemp.ToString();
                    OutputTextBlock.Text = output;
                    break;

                case "divide":
                    if (double.Parse(output) != 0)
                    {
                        outputTemp = temp / double.Parse(output);
                        output = outputTemp.ToString();
                        OutputTextBlock.Text = output;
                        break;
                    }
                    break;
            }
        }

        // Squared
        private void ButtonSquared_Click(object sender, RoutedEventArgs e)
        {
            double square = double.Parse(output);
            output = (square * square).ToString();
            OutputTextBlock.Text = output;
        }

        // Clear
        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            output = "";
            OutputTextBlock.Text = output;
        }

        // Square Root
        private void ButtonSquareRoot_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                double squareRoot = double.Parse(output);
                output = Math.Sqrt(squareRoot).ToString();
                OutputTextBlock.Text = output;
            }
        }

        // Positive/Negative
        private void ButtonPosNeg_Click(object sender, RoutedEventArgs e)
        {
            double posNegTemp;
            if (output != "")
            {
                posNegTemp = double.Parse(output) * -1;
                output = (posNegTemp).ToString();
                OutputTextBlock.Text = output;
            }
        }
        #endregion
    }
}
