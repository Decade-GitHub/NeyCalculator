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

namespace NeyCalcGUI
{
    public partial class MainWindow : Window
    {
        
        const string ErrorMessage = "Tu é burro, irmão?";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int UserUnit = InputDropBox.SelectedIndex;
            if (!ValidateUserValueInput())
            {
                ResultBox.Text = ErrorMessage;
                return;
            }
            try
            {
                float UserValue = TransformUserValue();
                float Result = Master.Calculate(UserValue, UserUnit);
                ResultBox.Text = Result.ToString();

                string ResultType = ReturnTypeExpression();
                ResultTypeBox.Text = ResultType;
            }
            catch (Exception ex)
            {
                ResultBox.Text = ex.Message;
            }
        }
        private bool ValidateUserValueInput()
        {
            if (string.IsNullOrEmpty(InputTextBox.Text))
            {
                return false;
            }
            else if (!float.TryParse(InputTextBox.Text, out _))
            {
                return false;
            }
            return true;
        }
        private float TransformUserValue()
        {
            _ = float.TryParse(InputTextBox.Text, out float UserValue);
            return UserValue;
        }
        private string ReturnTypeExpression()
        {
            int UserUnit = InputDropBox.SelectedIndex;

            return UserUnit switch
            {
                0 => "Neymeters",
                1 => "Neykilos",
                2 => "Neyliters",
                3 => "Neykilobytes",
                4 => "Neykilometers per hour",
                5 => "Neycelsius",
                _ => throw new ArgumentOutOfRangeException("What the fuck")
            };
        }
    }
}
