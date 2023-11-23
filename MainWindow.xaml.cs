using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
            int PlayerValue = PlayerDropBox.SelectedIndex;
            if (!ValidateUserValueInput())
            {
                ResultBox.Text = ErrorMessage;
                return;
            }
            try
            {
                float UserValue = TransformUserValue();
                PlayerResult Result = Master.Calculate(UserValue, UserUnit, PlayerValue);
                ResultBox.Text = Result.ResultValue.ToString();

                PlayerResult ResultType = Master.FetchResultType(UserUnit, PlayerValue);
                ResultTypeBox.Text = ResultType.ResultType;
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
    }
}
